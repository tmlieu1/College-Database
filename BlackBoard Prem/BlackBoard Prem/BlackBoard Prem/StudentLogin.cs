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
    public partial class StudentLogin : Form
    {
        // code from instructorLogin
        public database datab;
        private string spName = @"dbo.[StudentLogin]";
        // username for test case: mcboostR
        // password for test case: shasha123
        public StudentLogin()
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

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

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
                 * TODO:
                 *      - link to InstructorLandingPage
                 */
                datab = new database(Username.Text);
                //datab = new database();
                //MessageBox.Show("Made it beyond connection string stuff", "Stuff");  // If you didn't get this messagebox, you forgot to change the connection string to yours,
                                                                                     // since database object creation will fail if given incorrect connection string
                datab.AddParameter("@Username", Username.Text);
                datab.AddParameter("@Password", sha256(Password.Text));
                //MessageBox.Show(sha256(InstructorPassword.Text));
                datab.executeSP(spName);
                if (datab.myReader.HasRows && datab.myReader.Read())
                {
                    //string cmdStr = "select StudentID from Students where Username = @usern;";
                    //datab.AddParameter("@usern", Username.Text);
                    
                    string userId = datab.myReader.GetValue(datab.myReader.GetOrdinal("StudentID")).ToString();
                    datab.myReader.Close();
                    //MessageBox.Show(userId, "SUCCESS");
                    datab.myConnection.Close();
                    this.Hide();
                    StudentSemester student = new StudentSemester(userId);
                    student.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Login, Username or Password is incorrect.", "ERROR");
                }
            }
            catch(Exception baba)
            {
                MessageBox.Show(baba.ToString());
                MessageBox.Show("A database connection error occured. Please try again", "ERROR");
            }
            //StudentSemester student = new StudentSemester();
            //student.ShowDialog();
            //this.Close();
        }

        private void InstructorLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorLogin inst = new InstructorLogin();
            inst.ShowDialog();
            this.Close();
        }
    }
}
