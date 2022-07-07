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
    public partial class StudentSemester : Form
    {
        private string userID;
        public StudentSemester(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            SemesterTitle.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void SemesterTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StudentSemester_Load(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            StudentLogin stud =  new StudentLogin();
            stud.ShowDialog();
            Close();
        }

        private void BackgroundSemester_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //var theButton = this.Controls.OfType<RadioButton>().FirstOrDefault(i => i.Checked);
            RadioButton [] theRadButtons = new RadioButton[] {fallRadio, winterRadio, springRadio, summerRadio};
            RadioButton checkedButton = new RadioButton();
            foreach (RadioButton button in theRadButtons){
                if (button.Checked)
                    checkedButton = button;
            }

            //StudentCourseRegistration stuCourRegi = new StudentCourseRegistration(userID);
            StudentCourseRegistration stuCourRegi = new StudentCourseRegistration(userID);
            // when the buttons will be updated we will take the radio buttons name and then split it to get the semester and year.
            string currentyear = checkedButton.Text;
            switch (checkedButton.Name)
            {
                case ("fallRadio"):
                    // add fall semester query for current year here
                    stuCourRegi = new StudentCourseRegistration(userID, "Fall 2020");
                    //stuCourRegi.SetSemesterYear("Fall 2020");
                    this.Hide();
                    stuCourRegi.ShowDialog();
                    this.Close();
                    break;
                case ("winterRadio"):
                    // add fall semester query for current year here
                    stuCourRegi = new StudentCourseRegistration(userID, "Winter 2021");
                    //stuCourRegi.SetSemesterYear("Winter 2021");
                    this.Hide();
                    stuCourRegi.ShowDialog();
                    this.Close();
                    break;
                case ("springRadio"):
                    // add fall semester query for current year here
                    stuCourRegi = new StudentCourseRegistration(userID, "Spring 2021");
                    //stuCourRegi.SetSemesterYear("Spring 2021");
                    this.Hide();
                    stuCourRegi.ShowDialog();
                    this.Close();
                    break;
                case ("summerRadio"):
                    // add fall semester query for current year here
                    stuCourRegi = new StudentCourseRegistration(userID, "Summer 2021");
                    //stuCourRegi.SetSemesterYear("Summer 2021");
                    this.Hide();
                    stuCourRegi.ShowDialog();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("No semester selected!", "ERROR");
                    break;
            }

        }

        private void ViewCourseButton_Click_1(object sender, EventArgs e)
        {
            StudentViewCourses viewCourse = new StudentViewCourses(userID);
            this.Hide();
            viewCourse.ShowDialog();
            this.Close();
        }

        private void fallRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
