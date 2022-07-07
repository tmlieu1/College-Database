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
    public partial class InstructorViewCourses : Form
    {
        /*
         * This form was created by Alex Cream
         * 
         * This form is the landing page for instructors, which will display the courses the instructor has (the past) and is currently (presently) teaching
         * 
         * VARIABLES
         * db - the database class object that holds the connection string
         * instructorID - the instructor's ID (obtained in this form by query)
         * instructorDetails - instructorDetails class object that holds the instructors details from the database [BlackBoard Premium] instructor table
         * selectedRow - the row that is selected by the user in the datagridview IViewCourseDataGridView.
         */
        public database db;
        public string InstructorID;
        public InstructorDetails instructorDetails;
        public BindingSource dataBind = new BindingSource();
        private int selectedRow;
        public InstructorViewCourses()
        {
            InitializeComponent();
        }
        


        private InstructorDetails grabInstructorDetails(database datab)
        {
            InstructorDetails instructorDetails = new InstructorDetails();
            if (db.myReader.Read())
            {
                instructorDetails.setInstructID(db.myReader.GetString(0));
                instructorDetails.setName(db.myReader.GetString(1));
                instructorDetails.setDepartmentID(db.myReader.GetString(2));
                instructorDetails.setGender(db.myReader.GetString(3));
                instructorDetails.setUsername(db.myReader.GetString(4));
                instructorDetails.setPass(db.myReader.GetString(5));
            }
            // Need to close reader and dispose of commands
            return instructorDetails;
        }
        

        public InstructorViewCourses(database datab, InstructorDetails instructor)
        {
            this.instructorDetails = instructor;
            this.db = datab;
            InitializeComponent();
            // if i'm psasing instructor details i need to do the same thing over again. query for instructor details
            loadInstructorCourseTable(instructorDetails.getID(), db);
        }
        public InstructorViewCourses(database datab)
        {
            InitializeComponent();
            db = datab;
            // LEFT OFF HERE. NEED TO WORK ON QUERYING FOR INSTRUCTOR INFORMATION
            string InstructorDetailsSP = @"dbo.[GetInstructorDetails]";
            db.AddParameter("@Username", db.usr);
            db.AddParameter("@Password", db.pass);
            db.executeSP(InstructorDetailsSP);
           
            this.instructorDetails = grabInstructorDetails(db);
            datab.myConnection.Close();
            // Now I need to populate a datagrid with data.
            loadInstructorCourseTable(instructorDetails.getID(), db);

        }
        

        private void loadInstructorCourseTable(string instructorID, database db)
        {
            try
            {

                string instructorSP = @"dbo.[GetAllTaughtCourses]";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand(instructorSP);
                db.myConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(instructorSP, db.myConnection);
                cmd.Parameters.Add(new SqlParameter("@InstructorID", instructorID));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = db.myConnection;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                dataBind.DataSource = dt; 
                IViewCourseDataGrid.AutoGenerateColumns = true;
                IViewCourseDataGrid.DataSource = dataBind;
                // determine which columns are visible

                IViewCourseDataGrid.Columns["CourseID"].Visible = false;
                IViewCourseDataGrid.Columns["SectionID"].Visible = false;
                IViewCourseDataGrid.Columns["InstructorID"].Visible = false;
                IViewCourseDataGrid.Columns["TimeslotID"].Visible = false;
                db.myConnection.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void InstructorCourseSelectionButton_Click(object sender, EventArgs e)
        {

        }

        private void InstructorWinterRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ILandingCourseCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorCourseRegistrationSemester courseCreation = new InstructorCourseRegistrationSemester(db, instructorDetails);
            courseCreation.ShowDialog();
            this.Close();
        }

        private void GetInstructorDetails()
        {
            
        }

        private void IViewCourseLogoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Succesful", "Logout");
            this.Hide();
            InstructorLogin login = new InstructorLogin();
            login.ShowDialog();
            this.Close();
        }

        private void IViewCourseSearchButton_Click(object sender, EventArgs e)
        {
            if ( (IViewCourseSearchTextBox.Text.Equals("Search")) || (IViewCourseSearchTextBox.Text.Equals("")) )
            {
                dataBind.RemoveFilter();
            }
            dataBind.Filter = "CourseName like '%" + IViewCourseSearchTextBox.Text + "%'";
        }

        private void InstructorDeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
                return;
            selectedRow = IViewCourseDataGrid.CurrentCell.RowIndex;
            string selectedCourseName = IViewCourseDataGrid.Rows[selectedRow].Cells[3].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to DELETE `" +
                selectedCourseName + "`", "DELETE COURSE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    db.myReader.Close();
                    string dropSP = @"dbo.[InstructorDropCourse]";
                    db.AddParameter("@InstructorID", instructorDetails.getID());
                    db.AddParameter("@SectionID", IViewCourseDataGrid.Rows[selectedRow].Cells[0].Value.ToString());

                    db.executeSP(dropSP);
                    MessageBox.Show("Course Deleted/Dropped", "SUCCESS", MessageBoxButtons.OK);
                    db.myConnection.Close();
                    loadInstructorCourseTable(instructorDetails.getID(), db);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    System.Threading.Thread.CurrentThread.Abort();
                }
            }
        }

        private void IViewCourseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedRow = e.RowIndex;
            }
        }
    }
}
