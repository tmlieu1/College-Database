using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlackBoard_Prem
{
    public partial class InstructorCourseRegistrationBasicInfo : Form
    {
        /* <MAINTENANCE>
         *  This form requires maintenance IF the user wants more timeslots that the 3 specified, e.g. Monday-Wednesday-Friday
         * </MAINTENANCE>
         * NOTE: ICR = InstructorCourseRegistration
         * This form was created by Alex Cream
         * 
         * This form obtains the rest of the information (except for the buildings, as the available buildings are determined by the desired time schedule/timeslot, start times and end_times
         * 
         * VARIABLES
         * datab - the database class holding the connection string
         * semester - the chosen semester (ICRSemester)
         * year - the chosen year (ICRSemester)
         * courseID - the chosen course (ICRSelection)
         * department - the chosen department ID of the course (ICRSelection)
         * courseName - the chosen course's name (ICRSelection)
         * credits - the chosen courses credits value (ICRSelection)
         * timeslot - the timeslot obtained from THIS form, based on combobox selection
         */
        public database datab;
        public string semester;
        public int year;
        public string courseID;
        public string department;
        public string courseName;
        public double credits;
        public int timeslot;
        public InstructorDetails instructor;
        // Labels
        public InstructorCourseRegistrationBasicInfo()
        {
            InitializeComponent();
        }

        public InstructorCourseRegistrationBasicInfo(database db, string semester, int year, string courseID, string department, string courseName, double credits, InstructorDetails instructor)
        {
            this.datab = db;
            this.semester = semester;
            this.year = year;
            this.courseID = courseID;
            this.department = department;
            this.courseName = courseName;
            this.credits = credits;
            this.instructor = instructor;
            InitializeComponent();
            try
            {
                initializeLabels();
                //getAllBuildings(datab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void TimeslotIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void initializeLabels()
        {
            SemesterLabel.Text = semester;
            YearLabel.Text = year.ToString();
            CourseNameLabel.Text = courseName;
            CreditsLabel.Text = credits.ToString();

            
        }

        private void CreditHintLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreditsLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = StartTimeComboBox.GetItemText(StartTimeComboBox.SelectedItem);
            //MessageBox.Show(selected);
            setEndTimes(selected);
        }


        /*
         * Based on selected time slots e.g. Monday-Wednesday-Friday 
         */
        private int getTimeslot()
        {
            string timeslotString = TimeslotIDComboBox.SelectedItem.ToString();
            switch (timeslotString)
            {
                case "Monday-Wednesday-Friday":
                    return 1;
                case "Tuesday-Thursday":
                    return 2;
                case "Wednesday-Friday":
                    return 3;
                default:
                    return 0;
            }
        }

        /*
         * Ensures that the end time does not begin before the selected start time.
         */
        public void setEndTimes(string time)
        {
            EndTimeComboBox.Items.Clear();
            switch(time)
            {
                case "8:00:00":
                    EndTimeComboBox.Items.Add("8:50:00");
                    EndTimeComboBox.Items.Add("9:20:00");
                    EndTimeComboBox.Items.Add("9:50:00");
                    break;
                case "8:30:00":
                    EndTimeComboBox.Items.Add("9:20:00");
                    EndTimeComboBox.Items.Add("9:50:00");
                    EndTimeComboBox.Items.Add("10:20:00");
                    EndTimeComboBox.Items.Add("10:50:00");
                    break;
                case "9:00:00":
                    EndTimeComboBox.Items.Add("9:50:00");
                    EndTimeComboBox.Items.Add("10:20:00");
                    EndTimeComboBox.Items.Add("10:50:00");
                    break;
                case "9:30:00":
                    EndTimeComboBox.Items.Add("10:20:00");
                    EndTimeComboBox.Items.Add("10:50:00");
                    break;
                case "10:00:00":
                    EndTimeComboBox.Items.Add("10:50:00");
                    EndTimeComboBox.Items.Add("11:50:00");
                    EndTimeComboBox.Items.Add("12:50:00");
                    break;
                case "10:30:00":
                    EndTimeComboBox.Items.Add("11:20:00");
                    EndTimeComboBox.Items.Add("11:50:00");
                    break;
                case "11:00:00":
                    EndTimeComboBox.Items.Add("11:50:00");
                    EndTimeComboBox.Items.Add("12:50:00");
                    break;
                case "12:00:00":
                    EndTimeComboBox.Items.Add("12:50:00");
                    EndTimeComboBox.Items.Add("13:50:00");
                    break;
                case "13:00:00":
                    EndTimeComboBox.Items.Add("13:50:00");
                    EndTimeComboBox.Items.Add("14:20:00");
                    EndTimeComboBox.Items.Add("14:50:00");
                    break;
                case "13:30:00":
                    EndTimeComboBox.Items.Add("14:20:00");
                    EndTimeComboBox.Items.Add("14:50:00");
                    EndTimeComboBox.Items.Add("15:20:00");
                    break;
                case "14:00:00":
                    EndTimeComboBox.Items.Add("14:50:00");
                    EndTimeComboBox.Items.Add("15:20:00");
                    EndTimeComboBox.Items.Add("15:50:00");
                    break;
                case "14:30:00":
                    EndTimeComboBox.Items.Add("15:20:00");
                    EndTimeComboBox.Items.Add("15:50:00");
                    EndTimeComboBox.Items.Add("16:20:00");
                    break;
                case "15:00:00":
                    EndTimeComboBox.Items.Add("15:50:00");
                    EndTimeComboBox.Items.Add("16:20:00");
                    EndTimeComboBox.Items.Add("16:50:00");
                    break;
                case "15:30:00":
                    EndTimeComboBox.Items.Add("16:20:00");
                    EndTimeComboBox.Items.Add("16:50:00");
                    break;
                case "16:00:00":
                    EndTimeComboBox.Items.Add("16:50:00");
                    EndTimeComboBox.Items.Add("17:50:00");
                    break;
                case "17:00:00":
                    EndTimeComboBox.Items.Add("17:50:00");
                    EndTimeComboBox.Items.Add("18:50:00");
                    break;
            }
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            int maximum = (int) maximumSeatsBox.Value;
            if ( (StartTimeComboBox.SelectedIndex <= -1) || (EndTimeComboBox.SelectedIndex <= -1) )
            {
                MessageBox.Show("Error: Please select a Start Time and an End Time for the course");
                return;
            }
            if (TimeslotIDComboBox.SelectedIndex <= -1)
            {
                MessageBox.Show("ERROR: Please select what day(s) the course will occur on for the weeks", "ERROR");
                return;
            }
            int timeslot = getTimeslot();
            if (timeslot == 0)
            {
                MessageBox.Show("ERROR: Failed to get timeslot");
                return;
            }
            string startTime = StartTimeComboBox.Text.ToString();
            string endTime = EndTimeComboBox.Text.ToString();
            InstructorCourseRegistrationBuilding buildingForm = new InstructorCourseRegistrationBuilding(datab, semester, year, courseName, timeslot, maximum, startTime, endTime, credits, instructor, courseID);
            buildingForm.ShowDialog();
        }

        private void InstructorCourseRegistrationBasicInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void InstructorCourseRegistrationBasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void ICourseRegBasicLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorLogin login = new InstructorLogin();
            login.ShowDialog();
            this.Close();
        }

        private void IViewClassesFinalSelect_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard the entered information?", "Leaving Course Creation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                InstructorViewCourses viewCourses = new InstructorViewCourses(datab, instructor);
                viewCourses.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void ICourseRegButtonFinalSelect_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard the entered information?", "Leaving Course Creation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                InstructorCourseRegistrationSemester registrationSemester = new InstructorCourseRegistrationSemester(datab, instructor);
                registrationSemester.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
