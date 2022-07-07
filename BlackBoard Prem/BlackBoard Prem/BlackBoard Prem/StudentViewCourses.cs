using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BlackBoard_Prem
{
    /// <summary>
    /// StudentViewCourses simply is the form that displays the current courses a student is taking.
    /// 
    /// Author: Rozario (Ross) Beaudin (RB)
    /// 
    /// Private Variables
    /// SqlConnection myConnection      The connection string of the database
    /// SqlCommand    sqlCmd            Sql command we want to perform.
    /// string        storedP           The stored procedure to get all of the student courses.
    /// string        userID            Id of the students
    /// int           selectedRow       The amount of rows selected.
    /// BindingSource courseListBind    Data bind for the datagridview.
    /// </summary>
    public partial class StudentViewCourses : Form
    {
        //@"dbo.[GetAllStudentCourses]"
        private SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-IUI50AL;Initial Catalog='BlackBoard Premium';Integrated Security=True");
        private SqlCommand sqlCmd;
        private string storedP = @"dbo.[GetStudentCourses]";
        private string sqlCommand = "SELECT * FROM dbo.CourseList;";
        private string sqlSPDrop = @"dbo.[StudentDropCourse]";
        private string userID;
        private int selectedRow;
        private BindingSource courseListBind = new BindingSource();
        //private database datab;

        /// <summary>
        /// Simple init for the StudentViewCourses
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="userID">The students user ID.</param>
        public StudentViewCourses(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            //datab = new database(username);
            InitDataGridView();
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
                
                courseViewTable.AutoGenerateColumns = true;
                courseViewTable.DataSource = courseListBind;
                
                courseViewTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                courseViewTable.Columns["StudentID"].Visible = false;
                courseViewTable.Columns["CourseID"].Visible = false;
                courseViewTable.Columns["SectionID"].Visible = false;
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
        /// <returns name="table">The populated data table.</returns>
        private DataTable InitDataTable()
        {
            
            sqlCmd = new SqlCommand(storedP, myConnection);
            sqlCmd.Parameters.AddWithValue("@StudentID", userID);

            SqlDataAdapter adapt = new SqlDataAdapter();
            DataTable table = new DataTable();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            adapt.SelectCommand = sqlCmd;
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapt.Fill(table);
            return table;
        }

        /// <summary>
        /// When clicking on the sign out button you out of your account.
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
        /// Returns you to the course selection screen.
        /// </summary>
        /// 
        /// 2021-03-14 RB
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void courseSelectionButton_Click(object sender, EventArgs e)
        {
            StudentSemester studentsSemester = new StudentSemester(userID);
            this.Hide();
            studentsSemester.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Searches the datagridview for all possible matches.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (courseViewTable.Rows.Count == 0)
                return;
            string searchText = classSearchBox.Text;
            courseListBind.Filter = "CourseName" + " like '%" + searchText + "%'";
        }

        /// <summary>
        /// Drop courses checks to see if there is nothing selected we return. 
        /// I message box will appear and greet the user with are you sure and 
        /// then will drop the course if the user clicks on yes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropCourseButton_Click(object sender, EventArgs e)
        {
            if (selectedRow == -1)
                return;

            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to DROP '" +
                courseViewTable.SelectedRows[0].Cells["CourseName"].Value.ToString() + "'", "DROP COURSE", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (myConnection.State != ConnectionState.Open)
                        myConnection.Open();
                    sqlCmd.Parameters.Clear();

                    sqlCmd.Parameters.AddWithValue("@StudentID", userID);
                    sqlCmd.Parameters.AddWithValue("@CourseID", courseViewTable.SelectedRows[0].Cells["CourseID"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@SectionID", courseViewTable.SelectedRows[0].Cells["SectionID"].Value.ToString());

                    sqlCmd.CommandText = sqlSPDrop;

                    sqlCmd.ExecuteScalar();
                    MessageBox.Show("Course dropped", "SUCCESS", MessageBoxButtons.OK);
                    InitDataGridView();
                }
                catch
                {
                    MessageBox.Show("Something did not work correctly with the sql code. Verify all related sql codes.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    System.Threading.Thread.CurrentThread.Abort();
                }
            }
        }

        private void courseViewTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                selectedRow = e.RowIndex;
            }
        }
    }
}
