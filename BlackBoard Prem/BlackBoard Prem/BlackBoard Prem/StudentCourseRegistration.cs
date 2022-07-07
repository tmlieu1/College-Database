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
    /// <summary>
    /// Student course registration shows the courses you can possible register.
    /// </summary>
    /// 
    /// Author: 2021-03-14 RB
    /// 
    /// Private Variable
    /// SqlConnection       myConnection        connection string 
    /// string              userID              The user ID of user
    /// BindingSource       courseListBind      binding data source of datagridview
    /// string              sqlSP               The stored procedure to get all available courses from a data view.
    /// string              sqlAddCourse        The stored procedure to enroll in a course.
    /// SqlCommand          sqlCmd              The sql command
    /// string              semester            The semester that we want to get
    /// string              year                The year we want to get.
    /// int                 selectedRow         The number of selectedRows.
    /// 
    public partial class StudentCourseRegistration : Form
    {
        private SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-IUI50AL;Initial Catalog='BlackBoard Premium';Integrated Security=True");
        
        private string userID;
        private BindingSource courseListBind = new BindingSource();
        private string sqlSP = @"dbo.[GetCourseSemesterYear]";
        private string sqlAddCourse = @"dbo.[EnrollCourse]";
        private SqlCommand sqlCmd;
        private string semester;
        private string year;
        private int selectedRow;

        /// <summary>
        /// Initializes the studentCourseRegistration form.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="userID">The user ID</param>
        /// <param name="semesterYear">The semester and year we want to filter by.</param>
        public StudentCourseRegistration(string userID, string semesterYear)
        {
            InitializeComponent();
            this.userID = userID;
            sqlCmd = new SqlCommand(sqlSP, myConnection);
            SetSemesterYear(semesterYear);
            InitDataGridView();
        }

        /// <summary>
        /// Initializes the studentCourseRegistration form without the semester year.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="userID">The user ID</param>
        public StudentCourseRegistration(string userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        /// <summary>
        /// SetSemesterYear will split a string of semester and year.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="semesterYear"></param>
        public void SetSemesterYear(string semesterYear)
        {
            string[] semesterYearList = semesterYear.Split();
            semester = semesterYearList[0];
            year = semesterYearList[1];
        }

        /// <summary>
        /// Course based on microsofts documentation 
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.datasource?view=net-5.0
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        private void InitDataGridView()
        {
            try
            {
                courseListBind.DataSource = InitDataTable();

                courseDataGrid.AutoGenerateColumns = true;
                courseDataGrid.DataSource = courseListBind;

                courseDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                courseDataGrid.Columns["SectionID"].Visible = false;
                courseDataGrid.Columns["CourseID"].Visible = false;
                courseDataGrid.Columns["TimeslotID"].Visible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something did not work correctly with the sql code. Verify all related sql codes.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Threading.Thread.CurrentThread.Abort();
            }
        }

        /// <summary>
        /// Course based on microsofts documentation 
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.datasource?view=net-5.0
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        private DataTable InitDataTable()
        {

            sqlCmd.Parameters.AddWithValue("@Year", year);
            sqlCmd.Parameters.AddWithValue("@Semester", semester);

            sqlCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapt = new SqlDataAdapter();
            DataTable table = new DataTable();
            
            adapt.SelectCommand = sqlCmd;
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapt.Fill(table);
            return table;
        }

        /// <summary>
        /// When you click on the sign out button to sign the user out.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Hide();
            StudentLogin stud = new StudentLogin();
            stud.ShowDialog();
            Close();
        }

        /// <summary>
        /// View course button returns the user to the studentViewCourses forms.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewCourseButton_Click(object sender, EventArgs e)
        {
            StudentViewCourses viewCourse = new StudentViewCourses(userID);
            this.Hide();
            viewCourse.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// The course selection button will return the user to the student semesters page.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CourseSelectionButton_Click(object sender, EventArgs e)
        {
            StudentSemester studSemester = new StudentSemester(userID);
            this.Hide();
            studSemester.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Determines, the number rows selected.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                selectedRow = e.RowIndex;
            }
        }

        /// <summary>
        /// register button checks your number of selected rows if you have not selected a row then it will simply return. 
        /// It will ask the user if they are sure they want register in the course they have currently selected. 
        /// If yes this method will run a stored proceedure to enroll the student into that respective course if 
        /// all specific conditions are met.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
                return;

            // TODO be able to add the course NAME
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to register in '" + 
                courseDataGrid.SelectedRows[0].Cells["CourseName"].Value.ToString() + "'", 
                "REGISTRATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Convert.ToInt32(courseDataGrid.SelectedRows[0].Cells["Enrolled"].Value) >= 
                Convert.ToInt32(courseDataGrid.SelectedRows[0].Cells["Capacity"].Value))
            {
                MessageBox.Show("The class is full.", "ERROR");
                return;
            }
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (myConnection.State != ConnectionState.Open)
                        myConnection.Open();
                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@StudentID", userID);
                    sqlCmd.Parameters.AddWithValue("@SectionID", courseDataGrid.SelectedRows[0].Cells["SectionID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@CourseID", courseDataGrid.SelectedRows[0].Cells["CourseID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Semester", courseDataGrid.SelectedRows[0].Cells["Semester"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Year", courseDataGrid.SelectedRows[0].Cells["Year"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@StartTime", courseDataGrid.SelectedRows[0].Cells["Start_Time"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@EndTime", courseDataGrid.SelectedRows[0].Cells["End_Time"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@TimeSlotID", courseDataGrid.SelectedRows[0].Cells["TimeSlotID"].Value.ToString());

                    sqlCmd.Parameters.Add("@Success", SqlDbType.Int).Direction = ParameterDirection.Output;

                    sqlCmd.CommandText = sqlAddCourse;
                    sqlCmd.ExecuteScalar();

                    int added = Convert.ToInt32(sqlCmd.Parameters["@Success"].Value);

                    switch (added)
                    {
                        case (0):
                            MessageBox.Show("Course Added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case (-1):
                            MessageBox.Show("Already Enrolled in class.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case (-2):
                            MessageBox.Show("You do not meet the Prerequisites.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case (-3):
                            MessageBox.Show("Time conflict detected. Cannot enroll.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case (-4):
                            MessageBox.Show("The class is at max capacity. Cannot enroll.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    
                }
                catch
                {
                    //MessageBox.Show(bababooey.ToString());
                    MessageBox.Show("Something did not work correctly with the sql code. Verify all related sql codes.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Threading.Thread.CurrentThread.Abort();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (courseDataGrid.Rows.Count == 0)
                return;
            string searchText = SearchBox.Text;
            courseListBind.Filter = "CourseName" + " like '%" + searchText + "%'";
        }
    }
}
