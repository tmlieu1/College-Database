using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBoard_Prem
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InstructorLogin : Form
    {
        public database datab;
        private string spName = @"dbo.[InstructorLogin]";
        public InstructorLogin()
        {
            InitializeComponent();
        }

        /*
         * Sha256 hashing function created by user 'Nico DumDum': https://stackoverflow.com/questions/12416249/hashing-a-string-with-sha256 
         */
        static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
             * datab will have all the necessary information for the connction, what it does not handle is user input for either query commands or inserting
             */
            try
            {
                /*
                 * You can also simply just use the commented line instead, difference being constructor that uses username stores it into the database class incase we need to use it again
                 */
                datab = new database(InstructorUsername.Text, sha256(InstructorPassword.Text));
                //datab = new database();
                //MessageBox.Show("Made it beyond connection string stuff", "Stuff");  // If you didn't get this messagebox, you forgot to change the connection string to yours, since database object creation will fail if given incorrect connection string
                datab.AddParameter("@Username", InstructorUsername.Text);
                datab.AddParameter("@Password", sha256(InstructorPassword.Text));
                datab.executeSP(spName);
                if (datab.myReader.HasRows)
                {
                    //MessageBox.Show("Login Successful", "SUCCESS");
                    this.Hide();
                    datab.myConnection.Close();
                    //datab.myReader.Close();
                    InstructorViewCourses landingPageInstructor = new InstructorViewCourses(datab);
                    landingPageInstructor.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Login, Username or Password is incorrect.", "ERROR");
                }
            }
            catch(Exception bababooey)
            {
                MessageBox.Show(bababooey.ToString());
                //MessageBox.Show("A database connection error occured. Please try again", "ERROR");
            }
        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin stud = new StudentLogin();
            stud.ShowDialog();
            this.Close();
        }
    }
}
