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
    public partial class InstructorCourseRegistrationSemester : Form
    {
        /*
         * <YEARLY MAINTENANCE REQUIRED>
         * This form was created by Alex Cream
         * 
         * This form is the first form the user encounters to create a course. They will select the desired semester/year to teach in. 
         * The year/semester IS OBTAINED RADIO BUTTON ITSELF, as a professor should not be able to create a course in the past, thus will need to be maintained every year
         * 
         * VARIABLES
         * datab - the database class that holds the connection string to the database
         * instructor - a class that holds the instructor details after querying ONCE for the information
         */
        public database datab;
        public InstructorDetails instructor;
        public InstructorCourseRegistrationSemester()
        {
            InitializeComponent();
        }

        public InstructorCourseRegistrationSemester(database db)
        {
            this.datab = db;
            InitializeComponent();
        }
        public InstructorCourseRegistrationSemester(database db, InstructorDetails instructor)
        {
            this.datab = db;
            this.instructor = instructor;
            InitializeComponent();
        }
        public RadioButton GetCheckedRadioButton()
        {
            RadioButton[] CourseRegButtons = new RadioButton[] { ICourseRegFall, ICourseRegWinter, ICourseRegSpring, ICourseRegSummer };
            RadioButton checkedButton = new RadioButton();
            foreach (RadioButton button in CourseRegButtons)
            {
                if (button.Checked)
                {
                    checkedButton = button;
                }
            }
            return checkedButton;
        }
        private void InstructorTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstructorCourseSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void IRegisterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ICreationNextButton_Click(object sender, EventArgs e)
        {
            RadioButton semesterButton = GetCheckedRadioButton();
            string selectedSemesterAndYear = semesterButton.Text;
            string[] semesterYear = selectedSemesterAndYear.Split(' ');
            string semester = semesterYear[0];
            string Year = semesterYear[1];
            //pass semester and year over to the next form

            InstructorCourseRegistrationSelection courseSelection = new InstructorCourseRegistrationSelection(semester, Year, datab, instructor);
            this.Hide();
            courseSelection.ShowDialog();
            this.Close();

        }

        private void IViewClasses_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorViewCourses viewCourses = new InstructorViewCourses(datab, instructor);
            viewCourses.ShowDialog();   
            this.Close();
        }

        private void IViewCourseLogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Sucessful", "LOGOUT");
            this.Hide();
            InstructorLogin instructLogin = new InstructorLogin();
            instructLogin.ShowDialog();
            this.Close();
            
            
        }

        private void ICourseRegFall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ICourseRegButton_Click(object sender, EventArgs e)
        {

        }
    }
}
