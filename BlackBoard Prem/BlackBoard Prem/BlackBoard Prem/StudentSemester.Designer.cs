
namespace BlackBoard_Prem
{
    partial class StudentSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSemester));
            this.Title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SemesterTitle = new System.Windows.Forms.RichTextBox();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.fallRadio = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.summerRadio = new System.Windows.Forms.RadioButton();
            this.springRadio = new System.Windows.Forms.RadioButton();
            this.winterRadio = new System.Windows.Forms.RadioButton();
            this.ViewCourseButton = new System.Windows.Forms.Button();
            this.CourseSelectionButton = new System.Windows.Forms.Button();
            this.BackgroudSideBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.radioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Brown;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(-1, -2);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(806, 43);
            this.Title.TabIndex = 6;
            this.Title.TabStop = false;
            this.Title.Text = "Blackboard+ Student Course Registration";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(481, 254);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(110, 36);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SemesterTitle
            // 
            this.SemesterTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SemesterTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SemesterTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterTitle.Location = new System.Drawing.Point(143, 49);
            this.SemesterTitle.Name = "SemesterTitle";
            this.SemesterTitle.ReadOnly = true;
            this.SemesterTitle.Size = new System.Drawing.Size(662, 44);
            this.SemesterTitle.TabIndex = 9;
            this.SemesterTitle.Text = "Semester";
            this.SemesterTitle.TextChanged += new System.EventHandler(this.SemesterTitle_TextChanged);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.Brown;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(718, -2);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(87, 42);
            this.SignOutButton.TabIndex = 10;
            this.SignOutButton.Text = "Logout";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // fallRadio
            // 
            this.fallRadio.AutoSize = true;
            this.fallRadio.BackColor = System.Drawing.SystemColors.Control;
            this.fallRadio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallRadio.Location = new System.Drawing.Point(6, 19);
            this.fallRadio.Name = "fallRadio";
            this.fallRadio.Size = new System.Drawing.Size(103, 29);
            this.fallRadio.TabIndex = 16;
            this.fallRadio.TabStop = true;
            this.fallRadio.Text = "Fall 2020";
            this.fallRadio.UseVisualStyleBackColor = false;
            this.fallRadio.CheckedChanged += new System.EventHandler(this.fallRadio_CheckedChanged);
            // 
            // radioGroup
            // 
            this.radioGroup.BackColor = System.Drawing.SystemColors.Menu;
            this.radioGroup.Controls.Add(this.summerRadio);
            this.radioGroup.Controls.Add(this.springRadio);
            this.radioGroup.Controls.Add(this.winterRadio);
            this.radioGroup.Controls.Add(this.fallRadio);
            this.radioGroup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroup.Location = new System.Drawing.Point(143, 90);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(448, 158);
            this.radioGroup.TabIndex = 17;
            this.radioGroup.TabStop = false;
            // 
            // summerRadio
            // 
            this.summerRadio.AutoSize = true;
            this.summerRadio.BackColor = System.Drawing.SystemColors.Control;
            this.summerRadio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerRadio.Location = new System.Drawing.Point(6, 122);
            this.summerRadio.Name = "summerRadio";
            this.summerRadio.Size = new System.Drawing.Size(145, 29);
            this.summerRadio.TabIndex = 19;
            this.summerRadio.TabStop = true;
            this.summerRadio.Text = "Summer 2021";
            this.summerRadio.UseVisualStyleBackColor = false;
            // 
            // springRadio
            // 
            this.springRadio.AutoSize = true;
            this.springRadio.BackColor = System.Drawing.SystemColors.Control;
            this.springRadio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.springRadio.Location = new System.Drawing.Point(6, 87);
            this.springRadio.Name = "springRadio";
            this.springRadio.Size = new System.Drawing.Size(130, 29);
            this.springRadio.TabIndex = 18;
            this.springRadio.TabStop = true;
            this.springRadio.Text = "Spring 2021";
            this.springRadio.UseVisualStyleBackColor = false;
            // 
            // winterRadio
            // 
            this.winterRadio.AutoSize = true;
            this.winterRadio.BackColor = System.Drawing.SystemColors.Control;
            this.winterRadio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winterRadio.Location = new System.Drawing.Point(6, 52);
            this.winterRadio.Name = "winterRadio";
            this.winterRadio.Size = new System.Drawing.Size(132, 29);
            this.winterRadio.TabIndex = 17;
            this.winterRadio.TabStop = true;
            this.winterRadio.Text = "Winter 2021";
            this.winterRadio.UseVisualStyleBackColor = false;
            // 
            // ViewCourseButton
            // 
            this.ViewCourseButton.BackColor = System.Drawing.SystemColors.Menu;
            this.ViewCourseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCourseButton.Location = new System.Drawing.Point(-1, 107);
            this.ViewCourseButton.Name = "ViewCourseButton";
            this.ViewCourseButton.Size = new System.Drawing.Size(138, 54);
            this.ViewCourseButton.TabIndex = 20;
            this.ViewCourseButton.Text = "View Courses";
            this.ViewCourseButton.UseVisualStyleBackColor = false;
            this.ViewCourseButton.Click += new System.EventHandler(this.ViewCourseButton_Click_1);
            // 
            // CourseSelectionButton
            // 
            this.CourseSelectionButton.BackColor = System.Drawing.Color.DarkGray;
            this.CourseSelectionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseSelectionButton.Location = new System.Drawing.Point(-1, 47);
            this.CourseSelectionButton.Name = "CourseSelectionButton";
            this.CourseSelectionButton.Size = new System.Drawing.Size(138, 54);
            this.CourseSelectionButton.TabIndex = 19;
            this.CourseSelectionButton.Text = "Course Selection";
            this.CourseSelectionButton.UseVisualStyleBackColor = false;
            // 
            // BackgroudSideBar
            // 
            this.BackgroudSideBar.Image = ((System.Drawing.Image)(resources.GetObject("BackgroudSideBar.Image")));
            this.BackgroudSideBar.Location = new System.Drawing.Point(-1, 47);
            this.BackgroudSideBar.Name = "BackgroudSideBar";
            this.BackgroudSideBar.Size = new System.Drawing.Size(138, 408);
            this.BackgroudSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroudSideBar.TabIndex = 18;
            this.BackgroudSideBar.TabStop = false;
            // 
            // StudentSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewCourseButton);
            this.Controls.Add(this.CourseSelectionButton);
            this.Controls.Add(this.BackgroudSideBar);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SemesterTitle);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentSemester";
            this.Text = "StudentSemester";
            this.Load += new System.EventHandler(this.StudentSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.RichTextBox SemesterTitle;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.RadioButton fallRadio;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.RadioButton summerRadio;
        private System.Windows.Forms.RadioButton springRadio;
        private System.Windows.Forms.RadioButton winterRadio;
        private System.Windows.Forms.Button ViewCourseButton;
        private System.Windows.Forms.Button CourseSelectionButton;
        private System.Windows.Forms.PictureBox BackgroudSideBar;
    }
}