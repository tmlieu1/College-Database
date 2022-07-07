
namespace BlackBoard_Prem
{
    partial class InstructorCourseRegistrationSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorCourseRegistrationSemester));
            this.ICourseRegTitleText = new System.Windows.Forms.TextBox();
            this.BackgroudSideBar = new System.Windows.Forms.PictureBox();
            this.ICourseRegButton = new System.Windows.Forms.Button();
            this.IViewClasses = new System.Windows.Forms.Button();
            this.ICourseCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.ICourseRegSummer = new System.Windows.Forms.RadioButton();
            this.ICourseRegSpring = new System.Windows.Forms.RadioButton();
            this.ICourseRegWinter = new System.Windows.Forms.RadioButton();
            this.ICourseRegFall = new System.Windows.Forms.RadioButton();
            this.ICreationNextButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IViewCourseLogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).BeginInit();
            this.ICourseCreationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ICourseRegTitleText
            // 
            this.ICourseRegTitleText.BackColor = System.Drawing.Color.Brown;
            this.ICourseRegTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ICourseRegTitleText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegTitleText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ICourseRegTitleText.Location = new System.Drawing.Point(-3, 0);
            this.ICourseRegTitleText.Name = "ICourseRegTitleText";
            this.ICourseRegTitleText.ReadOnly = true;
            this.ICourseRegTitleText.Size = new System.Drawing.Size(785, 39);
            this.ICourseRegTitleText.TabIndex = 17;
            this.ICourseRegTitleText.Text = "Blackboard+ Create Course";
            this.ICourseRegTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICourseRegTitleText.TextChanged += new System.EventHandler(this.InstructorTitle_TextChanged);
            // 
            // BackgroudSideBar
            // 
            this.BackgroudSideBar.Image = ((System.Drawing.Image)(resources.GetObject("BackgroudSideBar.Image")));
            this.BackgroudSideBar.Location = new System.Drawing.Point(-3, 35);
            this.BackgroudSideBar.Name = "BackgroudSideBar";
            this.BackgroudSideBar.Size = new System.Drawing.Size(185, 711);
            this.BackgroudSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroudSideBar.TabIndex = 21;
            this.BackgroudSideBar.TabStop = false;
            // 
            // ICourseRegButton
            // 
            this.ICourseRegButton.BackColor = System.Drawing.Color.DarkGray;
            this.ICourseRegButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegButton.Location = new System.Drawing.Point(-3, 118);
            this.ICourseRegButton.Name = "ICourseRegButton";
            this.ICourseRegButton.Size = new System.Drawing.Size(185, 56);
            this.ICourseRegButton.TabIndex = 24;
            this.ICourseRegButton.Text = "Course Creation";
            this.ICourseRegButton.UseVisualStyleBackColor = false;
            this.ICourseRegButton.Click += new System.EventHandler(this.ICourseRegButton_Click);
            // 
            // IViewClasses
            // 
            this.IViewClasses.BackColor = System.Drawing.SystemColors.Menu;
            this.IViewClasses.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IViewClasses.Location = new System.Drawing.Point(-3, 45);
            this.IViewClasses.Name = "IViewClasses";
            this.IViewClasses.Size = new System.Drawing.Size(185, 54);
            this.IViewClasses.TabIndex = 26;
            this.IViewClasses.Text = "View Courses";
            this.IViewClasses.UseVisualStyleBackColor = false;
            this.IViewClasses.Click += new System.EventHandler(this.IViewClasses_Click);
            // 
            // ICourseCreationGroupBox
            // 
            this.ICourseCreationGroupBox.Controls.Add(this.ICourseRegSummer);
            this.ICourseCreationGroupBox.Controls.Add(this.ICourseRegSpring);
            this.ICourseCreationGroupBox.Controls.Add(this.ICourseRegWinter);
            this.ICourseCreationGroupBox.Controls.Add(this.ICourseRegFall);
            this.ICourseCreationGroupBox.Location = new System.Drawing.Point(207, 95);
            this.ICourseCreationGroupBox.Name = "ICourseCreationGroupBox";
            this.ICourseCreationGroupBox.Size = new System.Drawing.Size(550, 246);
            this.ICourseCreationGroupBox.TabIndex = 27;
            this.ICourseCreationGroupBox.TabStop = false;
            // 
            // ICourseRegSummer
            // 
            this.ICourseRegSummer.AutoSize = true;
            this.ICourseRegSummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegSummer.Location = new System.Drawing.Point(18, 167);
            this.ICourseRegSummer.Name = "ICourseRegSummer";
            this.ICourseRegSummer.Size = new System.Drawing.Size(237, 41);
            this.ICourseRegSummer.TabIndex = 3;
            this.ICourseRegSummer.TabStop = true;
            this.ICourseRegSummer.Text = "Summer 2022";
            this.ICourseRegSummer.UseVisualStyleBackColor = true;
            // 
            // ICourseRegSpring
            // 
            this.ICourseRegSpring.AutoSize = true;
            this.ICourseRegSpring.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegSpring.Location = new System.Drawing.Point(18, 120);
            this.ICourseRegSpring.Name = "ICourseRegSpring";
            this.ICourseRegSpring.Size = new System.Drawing.Size(207, 41);
            this.ICourseRegSpring.TabIndex = 2;
            this.ICourseRegSpring.TabStop = true;
            this.ICourseRegSpring.Text = "Spring 2021";
            this.ICourseRegSpring.UseVisualStyleBackColor = true;
            // 
            // ICourseRegWinter
            // 
            this.ICourseRegWinter.AutoSize = true;
            this.ICourseRegWinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegWinter.Location = new System.Drawing.Point(18, 73);
            this.ICourseRegWinter.Name = "ICourseRegWinter";
            this.ICourseRegWinter.Size = new System.Drawing.Size(209, 41);
            this.ICourseRegWinter.TabIndex = 1;
            this.ICourseRegWinter.TabStop = true;
            this.ICourseRegWinter.Text = "Winter 2022";
            this.ICourseRegWinter.UseVisualStyleBackColor = true;
            // 
            // ICourseRegFall
            // 
            this.ICourseRegFall.AutoSize = true;
            this.ICourseRegFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegFall.Location = new System.Drawing.Point(18, 26);
            this.ICourseRegFall.Name = "ICourseRegFall";
            this.ICourseRegFall.Size = new System.Drawing.Size(166, 41);
            this.ICourseRegFall.TabIndex = 0;
            this.ICourseRegFall.TabStop = true;
            this.ICourseRegFall.Text = "Fall 2021";
            this.ICourseRegFall.UseVisualStyleBackColor = true;
            this.ICourseRegFall.CheckedChanged += new System.EventHandler(this.ICourseRegFall_CheckedChanged);
            // 
            // ICreationNextButton
            // 
            this.ICreationNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ICreationNextButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICreationNextButton.Location = new System.Drawing.Point(647, 364);
            this.ICreationNextButton.Name = "ICreationNextButton";
            this.ICreationNextButton.Size = new System.Drawing.Size(110, 36);
            this.ICreationNextButton.TabIndex = 27;
            this.ICreationNextButton.Text = "Next";
            this.ICreationNextButton.UseVisualStyleBackColor = false;
            this.ICreationNextButton.Click += new System.EventHandler(this.ICreationNextButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(188, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(594, 44);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Select Semester";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IViewCourseLogoutButton
            // 
            this.IViewCourseLogoutButton.BackColor = System.Drawing.Color.Brown;
            this.IViewCourseLogoutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IViewCourseLogoutButton.ForeColor = System.Drawing.Color.White;
            this.IViewCourseLogoutButton.Location = new System.Drawing.Point(670, -3);
            this.IViewCourseLogoutButton.Name = "IViewCourseLogoutButton";
            this.IViewCourseLogoutButton.Size = new System.Drawing.Size(87, 42);
            this.IViewCourseLogoutButton.TabIndex = 29;
            this.IViewCourseLogoutButton.Text = "Logout";
            this.IViewCourseLogoutButton.UseVisualStyleBackColor = false;
            this.IViewCourseLogoutButton.Click += new System.EventHandler(this.IViewCourseLogoutButton_Click);
            // 
            // InstructorCourseRegistrationSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 433);
            this.Controls.Add(this.IViewCourseLogoutButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ICreationNextButton);
            this.Controls.Add(this.ICourseCreationGroupBox);
            this.Controls.Add(this.IViewClasses);
            this.Controls.Add(this.ICourseRegButton);
            this.Controls.Add(this.BackgroudSideBar);
            this.Controls.Add(this.ICourseRegTitleText);
            this.Name = "InstructorCourseRegistrationSemester";
            this.Text = "InstructorCourseRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroudSideBar)).EndInit();
            this.ICourseCreationGroupBox.ResumeLayout(false);
            this.ICourseCreationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ICourseRegTitleText;
        private System.Windows.Forms.PictureBox BackgroudSideBar;
        private System.Windows.Forms.Button ICourseRegButton;
        private System.Windows.Forms.Button IViewClasses;
        private System.Windows.Forms.GroupBox ICourseCreationGroupBox;
        private System.Windows.Forms.RadioButton ICourseRegSummer;
        private System.Windows.Forms.RadioButton ICourseRegSpring;
        private System.Windows.Forms.RadioButton ICourseRegWinter;
        private System.Windows.Forms.RadioButton ICourseRegFall;
        private System.Windows.Forms.Button ICreationNextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button IViewCourseLogoutButton;
    }
}