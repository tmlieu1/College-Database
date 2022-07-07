
namespace BlackBoard_Prem
{
    partial class InstructorViewCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorViewCourses));
            this.ILandingViewCourses = new System.Windows.Forms.Button();
            this.BackgroudSideBar = new System.Windows.Forms.PictureBox();
            this.IViewCourseLogoutButton = new System.Windows.Forms.Button();
            this.InstructorSemesterTitle = new System.Windows.Forms.RichTextBox();
            this.InstructorDeleteButton = new System.Windows.Forms.Button();
            this.IViewCourseTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ILandingCourseCreation = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.IViewCourseSearchTextBox = new System.Windows.Forms.TextBox();
            this.IViewCourseSearchButton = new System.Windows.Forms.Button();
            this.IViewCourseDataGrid = new System.Windows.Forms.DataGridView();
            this.DeleteHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IViewCourseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ILandingViewCourses
            // 
            this.ILandingViewCourses.BackColor = System.Drawing.Color.DarkGray;
            this.ILandingViewCourses.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILandingViewCourses.Location = new System.Drawing.Point(-2, 46);
            this.ILandingViewCourses.Name = "ILandingViewCourses";
            this.ILandingViewCourses.Size = new System.Drawing.Size(185, 51);
            this.ILandingViewCourses.TabIndex = 21;
            this.ILandingViewCourses.Text = "View Courses";
            this.ILandingViewCourses.UseVisualStyleBackColor = false;
            this.ILandingViewCourses.Click += new System.EventHandler(this.InstructorCourseSelectionButton_Click);
            // 
            // BackgroudSideBar
            // 
            this.BackgroudSideBar.Image = ((System.Drawing.Image)(resources.GetObject("BackgroudSideBar.Image")));
            this.BackgroudSideBar.Location = new System.Drawing.Point(-2, 46);
            this.BackgroudSideBar.Name = "BackgroudSideBar";
            this.BackgroudSideBar.Size = new System.Drawing.Size(185, 665);
            this.BackgroudSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroudSideBar.TabIndex = 20;
            this.BackgroudSideBar.TabStop = false;
            // 
            // IViewCourseLogoutButton
            // 
            this.IViewCourseLogoutButton.BackColor = System.Drawing.Color.Brown;
            this.IViewCourseLogoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IViewCourseLogoutButton.ForeColor = System.Drawing.Color.White;
            this.IViewCourseLogoutButton.Location = new System.Drawing.Point(1301, 3);
            this.IViewCourseLogoutButton.Name = "IViewCourseLogoutButton";
            this.IViewCourseLogoutButton.Size = new System.Drawing.Size(87, 42);
            this.IViewCourseLogoutButton.TabIndex = 19;
            this.IViewCourseLogoutButton.Text = "Logout";
            this.IViewCourseLogoutButton.UseVisualStyleBackColor = false;
            this.IViewCourseLogoutButton.Click += new System.EventHandler(this.IViewCourseLogoutButton_Click);
            // 
            // InstructorSemesterTitle
            // 
            this.InstructorSemesterTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InstructorSemesterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructorSemesterTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorSemesterTitle.Location = new System.Drawing.Point(189, 46);
            this.InstructorSemesterTitle.Name = "InstructorSemesterTitle";
            this.InstructorSemesterTitle.ReadOnly = true;
            this.InstructorSemesterTitle.Size = new System.Drawing.Size(1209, 44);
            this.InstructorSemesterTitle.TabIndex = 18;
            this.InstructorSemesterTitle.Text = "View Courses";
            // 
            // InstructorDeleteButton
            // 
            this.InstructorDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InstructorDeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorDeleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstructorDeleteButton.Location = new System.Drawing.Point(201, 609);
            this.InstructorDeleteButton.Name = "InstructorDeleteButton";
            this.InstructorDeleteButton.Size = new System.Drawing.Size(205, 71);
            this.InstructorDeleteButton.TabIndex = 17;
            this.InstructorDeleteButton.Text = "Delete Course";
            this.InstructorDeleteButton.UseVisualStyleBackColor = false;
            this.InstructorDeleteButton.Click += new System.EventHandler(this.InstructorDeleteButton_Click);
            // 
            // IViewCourseTitle
            // 
            this.IViewCourseTitle.BackColor = System.Drawing.Color.Brown;
            this.IViewCourseTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IViewCourseTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.IViewCourseTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IViewCourseTitle.Location = new System.Drawing.Point(-2, -3);
            this.IViewCourseTitle.Name = "IViewCourseTitle";
            this.IViewCourseTitle.ReadOnly = true;
            this.IViewCourseTitle.Size = new System.Drawing.Size(1400, 43);
            this.IViewCourseTitle.TabIndex = 16;
            this.IViewCourseTitle.Text = "Blackboard+ View Courses Taught";
            this.IViewCourseTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1411, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ILandingCourseCreation
            // 
            this.ILandingCourseCreation.BackColor = System.Drawing.SystemColors.Menu;
            this.ILandingCourseCreation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILandingCourseCreation.Location = new System.Drawing.Point(-2, 103);
            this.ILandingCourseCreation.Name = "ILandingCourseCreation";
            this.ILandingCourseCreation.Size = new System.Drawing.Size(185, 54);
            this.ILandingCourseCreation.TabIndex = 23;
            this.ILandingCourseCreation.Text = "Course Creation";
            this.ILandingCourseCreation.UseVisualStyleBackColor = false;
            this.ILandingCourseCreation.Click += new System.EventHandler(this.ILandingCourseCreation_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(189, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 608);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // IViewCourseSearchTextBox
            // 
            this.IViewCourseSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IViewCourseSearchTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IViewCourseSearchTextBox.Location = new System.Drawing.Point(201, 113);
            this.IViewCourseSearchTextBox.Name = "IViewCourseSearchTextBox";
            this.IViewCourseSearchTextBox.Size = new System.Drawing.Size(205, 44);
            this.IViewCourseSearchTextBox.TabIndex = 26;
            this.IViewCourseSearchTextBox.Text = "Search";
            // 
            // IViewCourseSearchButton
            // 
            this.IViewCourseSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IViewCourseSearchButton.Location = new System.Drawing.Point(201, 175);
            this.IViewCourseSearchButton.Name = "IViewCourseSearchButton";
            this.IViewCourseSearchButton.Size = new System.Drawing.Size(205, 56);
            this.IViewCourseSearchButton.TabIndex = 27;
            this.IViewCourseSearchButton.Text = "Search";
            this.IViewCourseSearchButton.UseVisualStyleBackColor = true;
            this.IViewCourseSearchButton.Click += new System.EventHandler(this.IViewCourseSearchButton_Click);
            // 
            // IViewCourseDataGrid
            // 
            this.IViewCourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IViewCourseDataGrid.Location = new System.Drawing.Point(446, 103);
            this.IViewCourseDataGrid.MultiSelect = false;
            this.IViewCourseDataGrid.Name = "IViewCourseDataGrid";
            this.IViewCourseDataGrid.ReadOnly = true;
            this.IViewCourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IViewCourseDataGrid.Size = new System.Drawing.Size(921, 608);
            this.IViewCourseDataGrid.TabIndex = 28;
            this.IViewCourseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IViewCourseDataGrid_CellContentClick);
            // 
            // DeleteHint
            // 
            this.DeleteHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHint.ForeColor = System.Drawing.Color.Red;
            this.DeleteHint.Location = new System.Drawing.Point(492, 735);
            this.DeleteHint.Name = "DeleteHint";
            this.DeleteHint.Size = new System.Drawing.Size(855, 75);
            this.DeleteHint.TabIndex = 29;
            this.DeleteHint.Text = "Select/Highlight Course Name, then click delete to delete a course";
            // 
            // InstructorViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 819);
            this.Controls.Add(this.DeleteHint);
            this.Controls.Add(this.InstructorDeleteButton);
            this.Controls.Add(this.IViewCourseDataGrid);
            this.Controls.Add(this.IViewCourseSearchButton);
            this.Controls.Add(this.IViewCourseSearchTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ILandingCourseCreation);
            this.Controls.Add(this.ILandingViewCourses);
            this.Controls.Add(this.BackgroudSideBar);
            this.Controls.Add(this.IViewCourseLogoutButton);
            this.Controls.Add(this.InstructorSemesterTitle);
            this.Controls.Add(this.IViewCourseTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InstructorViewCourses";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IViewCourseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ILandingViewCourses;
        private System.Windows.Forms.PictureBox BackgroudSideBar;
        private System.Windows.Forms.Button IViewCourseLogoutButton;
        private System.Windows.Forms.RichTextBox InstructorSemesterTitle;
        private System.Windows.Forms.Button InstructorDeleteButton;
        private System.Windows.Forms.TextBox IViewCourseTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ILandingCourseCreation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox IViewCourseSearchTextBox;
        private System.Windows.Forms.Button IViewCourseSearchButton;
        private System.Windows.Forms.DataGridView IViewCourseDataGrid;
        private System.Windows.Forms.Label DeleteHint;
    }
}