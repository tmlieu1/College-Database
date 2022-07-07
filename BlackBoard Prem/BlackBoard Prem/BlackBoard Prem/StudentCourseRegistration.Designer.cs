
namespace BlackBoard_Prem
{
    partial class StudentCourseRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCourseRegistration));
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SemesterTitle = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewCourseButton = new System.Windows.Forms.Button();
            this.CourseSelectionButton = new System.Windows.Forms.Button();
            this.BackgroudSideBar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.courseDataGrid = new System.Windows.Forms.DataGridView();
            this.registerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.Brown;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(713, -4);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(87, 42);
            this.SignOutButton.TabIndex = 14;
            this.SignOutButton.Text = "Logout";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SemesterTitle
            // 
            this.SemesterTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SemesterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SemesterTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterTitle.Location = new System.Drawing.Point(138, 45);
            this.SemesterTitle.Name = "SemesterTitle";
            this.SemesterTitle.ReadOnly = true;
            this.SemesterTitle.Size = new System.Drawing.Size(671, 44);
            this.SemesterTitle.TabIndex = 13;
            this.SemesterTitle.Text = "Registration";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Brown;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(-6, -4);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(806, 43);
            this.Title.TabIndex = 12;
            this.Title.TabStop = false;
            this.Title.Text = "Blackboard+ Student Course Registration";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ViewCourseButton
            // 
            this.ViewCourseButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ViewCourseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCourseButton.Location = new System.Drawing.Point(-6, 105);
            this.ViewCourseButton.Name = "ViewCourseButton";
            this.ViewCourseButton.Size = new System.Drawing.Size(138, 54);
            this.ViewCourseButton.TabIndex = 17;
            this.ViewCourseButton.Text = "View Courses";
            this.ViewCourseButton.UseVisualStyleBackColor = false;
            this.ViewCourseButton.Click += new System.EventHandler(this.ViewCourseButton_Click);
            // 
            // CourseSelectionButton
            // 
            this.CourseSelectionButton.BackColor = System.Drawing.Color.DarkGray;
            this.CourseSelectionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseSelectionButton.Location = new System.Drawing.Point(-6, 45);
            this.CourseSelectionButton.Name = "CourseSelectionButton";
            this.CourseSelectionButton.Size = new System.Drawing.Size(138, 54);
            this.CourseSelectionButton.TabIndex = 16;
            this.CourseSelectionButton.Text = "Course Selection";
            this.CourseSelectionButton.UseVisualStyleBackColor = false;
            this.CourseSelectionButton.Click += new System.EventHandler(this.CourseSelectionButton_Click);
            // 
            // BackgroudSideBar
            // 
            this.BackgroudSideBar.Image = ((System.Drawing.Image)(resources.GetObject("BackgroudSideBar.Image")));
            this.BackgroudSideBar.Location = new System.Drawing.Point(-6, 45);
            this.BackgroudSideBar.Name = "BackgroudSideBar";
            this.BackgroudSideBar.Size = new System.Drawing.Size(138, 408);
            this.BackgroudSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroudSideBar.TabIndex = 15;
            this.BackgroudSideBar.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(146, 105);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(130, 33);
            this.SearchBox.TabIndex = 20;
            this.SearchBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(146, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 36);
            this.searchButton.TabIndex = 22;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // courseDataGrid
            // 
            this.courseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGrid.Location = new System.Drawing.Point(283, 95);
            this.courseDataGrid.MultiSelect = false;
            this.courseDataGrid.Name = "courseDataGrid";
            this.courseDataGrid.ReadOnly = true;
            this.courseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGrid.Size = new System.Drawing.Size(517, 358);
            this.courseDataGrid.TabIndex = 23;
            this.courseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGrid_CellContentClick_1);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(146, 402);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(130, 36);
            this.registerButton.TabIndex = 24;
            this.registerButton.Text = "Register Course";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // StudentCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.courseDataGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ViewCourseButton);
            this.Controls.Add(this.CourseSelectionButton);
            this.Controls.Add(this.BackgroudSideBar);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SemesterTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentCourseRegistration";
            this.Text = "StudentCourseRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.RichTextBox SemesterTitle;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ViewCourseButton;
        private System.Windows.Forms.Button CourseSelectionButton;
        private System.Windows.Forms.PictureBox BackgroudSideBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView courseDataGrid;
        private System.Windows.Forms.Button registerButton;
    }
}