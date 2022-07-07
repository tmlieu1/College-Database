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
    public partial class InstructorCourseRegistrationBuilding : Form
    {
        /*
         * NOTE: ICR stands for InstructorCourseRegistration
         * This form was created by Alex Cream
         * 
         * This form is the form where the user selects the building, then using all the information sent from previous screens (all the InstructorCourseRegistration* forms), creates the course/section
         * datab - Database class object that holds the connection string
         * semester - the chosen semester
         * year - the chosen year (from ICRSemester)
         * courseName - the chosen course to teach (from ICRSelection)
         * timeslot - the chosen timeslotID for the course (from ICRBasicInfo)              --- E.g. Monday-Wednesday-Friday = timeslot 1
         * maxStudents - the chosen maximum students for a course (from ICRBasicInfo)
         * startTime - the chosen start time of the course (ICRBasicInfo)
         * endTime - same as startTime
         * credits - the credits of the course (ICRSelection)
         * courseID - the chosen courseID of the course (ICRSelection)
         */
        database datab;
        string semester;
        int year;
        string courseName;
        int timeslot;
        int maxStudents;
        string startTime;
        string endTime;
        double credits;
        string courseID;
        InstructorDetails instructor;
        public InstructorCourseRegistrationBuilding()
        {
            InitializeComponent();
        }

        public InstructorCourseRegistrationBuilding(database db, string semester, int year, int timeslot, string startTime, string endTime)
        {
            this.datab = db;
            this.semester = semester;
            this.year = year;
            this.timeslot = timeslot;
            this.startTime = startTime;
            this.endTime = endTime;
            InitializeComponent();
        }
        public InstructorCourseRegistrationBuilding(database db, string semester, int year, string courseName, int timeslot, int maximumSeats, string startTime, string endTime, double credits, InstructorDetails instructor, string courseID)
        {
            this.datab = db;
            this.semester = semester;
            this.year = year;
            this.courseName = courseName;
            this.timeslot = timeslot;
            this.maxStudents = maximumSeats;
            this.startTime = startTime;
            this.endTime = endTime;
            this.credits = credits;
            this.instructor = instructor;
            this.courseID = courseID;
            InitializeComponent();
            // do stuff here
            getAvailableBuildings();
        }

        private void getAvailableBuildings()
        {
            datab.myConnection.Open();
            string classroomStoredProcedure = @"dbo.[GetAvailableClassrooms]";
            datab.AddParameter("@Semester", semester);
            datab.AddParameter("@Year", year);
            //need to convert time
            datab.AddParameter("@TimeslotID", timeslot);
            try
            {

                TimeSpan Start = TimeSpan.Parse(startTime);
                TimeSpan End = TimeSpan.Parse(endTime);
                datab.AddParameter("@StartTime", startTime);
                datab.AddParameter("@EndTime", endTime);
                datab.executeSP(classroomStoredProcedure);
                while (datab.myReader.Read())
                {
                    buildingComboBox.Items.Add(datab.myReader["Location"].ToString());
                }
                if (buildingComboBox.Items.Count == 0 )
                {
                    MessageBox.Show("ERROR: No available buildings/rooms for desired time and days. Please select another time or day schedule", "NO AVAILABLE ROOMS");
                    this.Close();
                }
                //hello
                datab.myConnection.Close();
                datab.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BuildingInfo_Click(object sender, EventArgs e)
        {


        }

        private string generateSectionID()
        {
            Random RandNum = new Random();
            int prefix = RandNum.Next(1, 99);
            string prefixString = prefix.ToString();
            prefixString = prefixString.PadLeft(2, '0');
            int suffix = RandNum.Next(1000, 9999999);
            string suffixString = suffix.ToString();
            suffixString = suffixString.PadLeft(7, '0');
            string sectionID = prefixString + "-" + suffixString;
            return sectionID;
            
        }

        /*
         * Verify's if the newly generated sectionID exists
         */
        private int verifySectionID(database db, string sectionID)
        {
            string sectionExistSP = @"dbo.[SectionExists]";
            if (db.myConnection.State == System.Data.ConnectionState.Closed)
            {
                db.myConnection.Open();
            }
            //db.myConnection.Open();
            db.AddParameter("@SectionID", sectionID);
            //db.executeSP(sectionExistSP);
            db.myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            db.myCommand.CommandText = sectionExistSP;
            int uniqueCount = (int)db.myCommand.ExecuteScalar();
            db.myCommand.Parameters.Clear();
            return uniqueCount;
        }

        /*
         * Generates a section name for the section the instructor is teaching. Due to the design choices, an instructor can only teach one instance of a course per semester per year.
         */
        private string generateSectionName(database db)
        {
            string prefix = "AS";
            // generate suffix number
            Random RandNum = new Random();
            int suffix = RandNum.Next(1,10);
            string suffixString = suffix.ToString().PadLeft(2, '0');
            string sectionName = prefix + suffixString;
            int unique = verifySectionName(db, sectionName);
            while (unique > 0)
            {
                suffix++;
                sectionName = prefix + suffix.ToString();
                unique = verifySectionName(db, sectionName);
            }
            return sectionName;

        }

        private int verifySectionName(database db, string sectionName)
        {
            if (db.myConnection.State == ConnectionState.Closed)
            {
                db.myConnection.Open();
            }
            db.myCommand.CommandType = CommandType.StoredProcedure;
            db.AddParameter("@SectionName", sectionName);
            db.AddParameter("@CourseID", courseID);
            db.AddParameter("@Semester", semester);
            db.AddParameter("@Year", year);
            db.myCommand.CommandText = @"dbo.[SectionNameExists]";
            int uniqueCount = (int)db.myCommand.ExecuteScalar();
            db.myCommand.Parameters.Clear();
            db.myConnection.Close();
            return uniqueCount;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //send to the database. First check if section ID already exists
            try
            {
                DialogResult dialogResult = MessageBox.Show("Is all your information correct?", "CONFIRMATION", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sectionID = generateSectionID();
                    int uniqueCount = verifySectionID(datab, sectionID);
                    while (uniqueCount > 0)
                    {
                        sectionID = generateSectionID();
                        uniqueCount = verifySectionID(datab, sectionID);


                    }
                    datab.myConnection.Close();

                    string sectionName = generateSectionName(datab);

                    // Grabbing all parameters and executing stored procedure

                    if (buildingComboBox.SelectedIndex <= -1)
                    {
                        MessageBox.Show("ERROR: Please select a building/room for the course to occur", "BUILDING SELECTION MISSING");
                        return;
                    }
                    string selectedBuilding = buildingComboBox.GetItemText(buildingComboBox.SelectedItem);
                    datab.myConnection.Open();
                    string insertCourseSP = @"dbo.[InsertCourse]";
                    datab.AddParameter("@SectionID", sectionID);
                    datab.AddParameter("@InstructorID", instructor.getID());
                    datab.AddParameter("@CourseID", courseID);
                    datab.AddParameter("@timeslotID", timeslot);
                    datab.AddParameter("@Location", selectedBuilding);
                    datab.AddParameter("@SectionName", sectionName);
                    datab.AddParameter("@MaximumStudents", maxStudents);
                    datab.AddParameter("@Semester", semester);
                    datab.AddParameter("@Year", year);
                    datab.AddParameter("@Start_Time", startTime);
                    datab.AddParameter("@End_Time", endTime);
                    datab.myCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //datab.executeSP(insertCourseSP);

                    datab.myCommand.CommandText = insertCourseSP;
                    datab.myCommand.CommandType = CommandType.StoredProcedure;
                    datab.myCommand.ExecuteScalar();

                    int created = Convert.ToInt32(datab.myCommand.Parameters["@Result"].Value);
                    switch (created)
                    {
                        case (2):
                            MessageBox.Show("ERROR: You already instruct this class, cannot create a duplicate course in the same semester and year. Class wasn't created", "DUPLICATE CLASS");
                            datab.myConnection.Close();
                            datab.myCommand.Parameters.Clear();
                            return;
                        case (3):
                            MessageBox.Show("ERROR: Time Conflict created with one of the courses you already teach. Cannot Create Class.", "ERROR");
                            datab.myConnection.Close();
                            datab.myCommand.Parameters.Clear();
                            break;
                        case (1):
                            MessageBox.Show("Successfully created class. Please go to view courses to view newly created course", "Course Creation Success");
                            datab.myConnection.Close();
                            datab.myCommand.Parameters.Clear();
                            InstructorCourseRegistrationBasicInfo open = (InstructorCourseRegistrationBasicInfo)Application.OpenForms["InstructorCourseRegistrationBasicInfo"];
                            open.Hide();
                            this.Hide();
                            InstructorViewCourses viewCourses = new InstructorViewCourses(datab, instructor);
                            viewCourses.ShowDialog();
                            open.Close();
                            this.Close();
                            break;
                    }
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
