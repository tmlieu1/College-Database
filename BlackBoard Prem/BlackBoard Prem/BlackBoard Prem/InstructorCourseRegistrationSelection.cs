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
    public partial class InstructorCourseRegistrationSelection : Form
    {
        /*
         * Form Created By Alex Cream
         * InstructorCourseRegistrationSelection is a form that allows the user to select which class they want to create a course for based on which row was selected
         * 
         * 
         * VARIABLES 
         * datab -- Database class that holds the connection string
         * year -- the selected year from InstructorCourseRegistrationSemester
         * semester -- the selected semester from InstructorCourseRegistrationSemester
         */
        public database datab;
        public int year;
        public string semester;
        public InstructorDetails instructor;
        public BindingSource dataBind = new BindingSource();
        public InstructorCourseRegistrationSelection()
        {
            InitializeComponent();
        }

        public InstructorCourseRegistrationSelection(string semester, string year, database db, InstructorDetails instructor)
        {
            this.datab = db;
            this.semester = semester;
            this.instructor = instructor;
            try
            {
                this.year = int.Parse(year);
                InitializeComponent();
                getCourseList(db);
                // TODO: get selected row and pass the input

            }
            catch (FormatException)
            {
                MessageBox.Show("Failed to get Year input", "ERROR");
            }
        }
        private void IViewClassesCRS_Click(object sender, EventArgs e)
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

        /*
         * This gets the total courses information from the Course list so the instructor can choose which course they want to instruct.
         * E.g. Instructor ----- wants to teach a section of course CMPT 391 - Databases
         */
        public void getCourseList(database db)
        {
            try
            {
                string viewCoursesSP = @"dbo.[ViewAllCourses]";
                SqlCommand cmd = new SqlCommand(viewCoursesSP, db.myConnection);
                db.myConnection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(viewCoursesSP, db.myConnection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                dataBind.DataSource = dt;
                ICourseRegCourseList.AutoGenerateColumns = true;
                ICourseRegCourseList.DataSource = dataBind;
                ICourseRegCourseList.Columns["CourseID"].Visible = false;
                ICourseRegCourseList.Columns["DepartmentID"].Visible = false;
                ICourseRegCourseList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                ICourseRegCourseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                db.myConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }

        }

        private void ICourseRegSearchButton_Click(object sender, EventArgs e)
        {
            if ((ICourseRegSearchBox.Text.Equals("Search")) || (ICourseRegSearchBox.Text.Equals("")))
            {
                dataBind.RemoveFilter();
            }
            dataBind.Filter = "[CourseName] like '%" + ICourseRegSearchBox.Text + "%'";
        }

        private void ICourseRegCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ICourseRegCourseList_SelectionChanged(object sender, EventArgs e)
        {
            if (ICourseRegCourseList.SelectedRows.Count > 1)
            {
                for (int i = 1; i < ICourseRegCourseList.SelectedRows.Count; i++)
                {
                    //MessageBox.Show("Total Selected: " + ICourseRegCourseList.SelectedRows.Count, "ROWS");
                    ICourseRegCourseList.SelectedRows[i].Selected = false;
                }
            }
        }

        /*
         * Gets the selected row and enters that row's course information.
         */
        private void ICourseRegCourseList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            try
            {
                string courseID = (string)ICourseRegCourseList.CurrentRow.Cells["CourseID"].Value;
                string courseName = (string) ICourseRegCourseList.CurrentRow.Cells["CourseName"].Value;
                string departmentID = (string)ICourseRegCourseList.CurrentRow.Cells["DepartmentID"].Value;
                double creditDoubleType = (double)ICourseRegCourseList.CurrentRow.Cells["Credits"].Value;
                var confirmResult = MessageBox.Show("Going into Course Creation Form for " + courseName, "Confirm or Cancel!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                   
                    // intialize new form and pass information
                    InstructorCourseRegistrationBasicInfo final = new InstructorCourseRegistrationBasicInfo(datab, semester, year, courseID, departmentID, courseName, creditDoubleType, instructor);
                    this.Hide();
                    final.ShowDialog();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ICourseRegInstructions_Click(object sender, EventArgs e)
        {

        }

        private void InstructorCourseRegistrationSelection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorLogin login = new InstructorLogin();
            login.ShowDialog();
            this.Close();
        }

        private void ICourseRegButtonCRSelect_Click(object sender, EventArgs e)
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
