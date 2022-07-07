
namespace BlackBoard_Prem
{
    partial class StudentViewCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentViewCourses));
            this.searchButton = new System.Windows.Forms.Button();
            this.classSearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.viewCourseButton = new System.Windows.Forms.Button();
            this.courseSelectionButton = new System.Windows.Forms.Button();
            this.BackgroudSideBar = new System.Windows.Forms.PictureBox();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SemesterTitle = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseViewTable = new System.Windows.Forms.DataGridView();
            this.dropCourseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(147, 145);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 36);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // classSearchBox
            // 
            this.classSearchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSearchBox.Location = new System.Drawing.Point(147, 106);
            this.classSearchBox.Name = "classSearchBox";
            this.classSearchBox.Size = new System.Drawing.Size(130, 33);
            this.classSearchBox.TabIndex = 31;
            this.classSearchBox.Text = "Search";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 358);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // viewCourseButton
            // 
            this.viewCourseButton.BackColor = System.Drawing.Color.DarkGray;
            this.viewCourseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCourseButton.Location = new System.Drawing.Point(-2, 106);
            this.viewCourseButton.Name = "viewCourseButton";
            this.viewCourseButton.Size = new System.Drawing.Size(135, 54);
            this.viewCourseButton.TabIndex = 29;
            this.viewCourseButton.Text = "View Courses";
            this.viewCourseButton.UseVisualStyleBackColor = false;
            // 
            // courseSelectionButton
            // 
            this.courseSelectionButton.BackColor = System.Drawing.SystemColors.Menu;
            this.courseSelectionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSelectionButton.Location = new System.Drawing.Point(-2, 46);
            this.courseSelectionButton.Name = "courseSelectionButton";
            this.courseSelectionButton.Size = new System.Drawing.Size(135, 54);
            this.courseSelectionButton.TabIndex = 28;
            this.courseSelectionButton.Text = "Course Selection";
            this.courseSelectionButton.UseVisualStyleBackColor = false;
            this.courseSelectionButton.Click += new System.EventHandler(this.courseSelectionButton_Click);
            // 
            // BackgroudSideBar
            // 
            this.BackgroudSideBar.Image = ((System.Drawing.Image)(resources.GetObject("BackgroudSideBar.Image")));
            this.BackgroudSideBar.Location = new System.Drawing.Point(-2, 46);
            this.BackgroudSideBar.Name = "BackgroudSideBar";
            this.BackgroudSideBar.Size = new System.Drawing.Size(135, 408);
            this.BackgroudSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroudSideBar.TabIndex = 27;
            this.BackgroudSideBar.TabStop = false;
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.Brown;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(717, -3);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(87, 42);
            this.SignOutButton.TabIndex = 26;
            this.SignOutButton.Text = "Logout";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SemesterTitle
            // 
            this.SemesterTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SemesterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SemesterTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterTitle.Location = new System.Drawing.Point(139, 46);
            this.SemesterTitle.Name = "SemesterTitle";
            this.SemesterTitle.ReadOnly = true;
            this.SemesterTitle.Size = new System.Drawing.Size(674, 44);
            this.SemesterTitle.TabIndex = 25;
            this.SemesterTitle.Text = "View Courses";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Brown;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(-2, -3);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(806, 43);
            this.Title.TabIndex = 24;
            this.Title.TabStop = false;
            this.Title.Text = "Blackboard+ View Courses";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // courseViewTable
            // 
            this.courseViewTable.AllowUserToDeleteRows = false;
            this.courseViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseViewTable.Location = new System.Drawing.Point(283, 96);
            this.courseViewTable.MultiSelect = false;
            this.courseViewTable.Name = "courseViewTable";
            this.courseViewTable.ReadOnly = true;
            this.courseViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseViewTable.Size = new System.Drawing.Size(521, 358);
            this.courseViewTable.TabIndex = 34;
            this.courseViewTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseViewTable_CellContentClick);
            // 
            // dropCourseButton
            // 
            this.dropCourseButton.BackColor = System.Drawing.Color.Red;
            this.dropCourseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropCourseButton.Location = new System.Drawing.Point(147, 394);
            this.dropCourseButton.Name = "dropCourseButton";
            this.dropCourseButton.Size = new System.Drawing.Size(130, 44);
            this.dropCourseButton.TabIndex = 35;
            this.dropCourseButton.Text = "Drop Course";
            this.dropCourseButton.UseVisualStyleBackColor = false;
            this.dropCourseButton.Click += new System.EventHandler(this.dropCourseButton_Click);
            // 
            // StudentViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dropCourseButton);
            this.Controls.Add(this.courseViewTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.classSearchBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.viewCourseButton);
            this.Controls.Add(this.courseSelectionButton);
            this.Controls.Add(this.BackgroudSideBar);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SemesterTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentViewCourses";
            this.Text = "StudentViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox classSearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button viewCourseButton;
        private System.Windows.Forms.Button courseSelectionButton;
        private System.Windows.Forms.PictureBox BackgroudSideBar;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.RichTextBox SemesterTitle;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView courseViewTable;
        private System.Windows.Forms.Button dropCourseButton;
    }
}