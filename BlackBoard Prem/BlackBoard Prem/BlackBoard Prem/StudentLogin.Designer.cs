
namespace BlackBoard_Prem
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            this.LoginButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.InstructorLoginButton = new System.Windows.Forms.Button();
            this.StudentLoginText = new System.Windows.Forms.TextBox();
            this.StudentPasswordLabel = new System.Windows.Forms.Label();
            this.StudentUsernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(294, 259);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(183, 40);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Username.Location = new System.Drawing.Point(312, 155);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(152, 32);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Password.Location = new System.Drawing.Point(312, 202);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(152, 32);
            this.Password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Brown;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(0, -2);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(806, 43);
            this.Title.TabIndex = 4;
            this.Title.Text = "Blackboard+ Sign-in";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // InstructorLoginButton
            // 
            this.InstructorLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InstructorLoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorLoginButton.Location = new System.Drawing.Point(294, 383);
            this.InstructorLoginButton.Name = "InstructorLoginButton";
            this.InstructorLoginButton.Size = new System.Drawing.Size(183, 37);
            this.InstructorLoginButton.TabIndex = 5;
            this.InstructorLoginButton.Text = "Instructor Login";
            this.InstructorLoginButton.UseVisualStyleBackColor = false;
            this.InstructorLoginButton.Click += new System.EventHandler(this.InstructorLoginButton_Click);
            // 
            // StudentLoginText
            // 
            this.StudentLoginText.BackColor = System.Drawing.SystemColors.Menu;
            this.StudentLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentLoginText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginText.Location = new System.Drawing.Point(294, 110);
            this.StudentLoginText.Name = "StudentLoginText";
            this.StudentLoginText.Size = new System.Drawing.Size(183, 39);
            this.StudentLoginText.TabIndex = 6;
            this.StudentLoginText.Text = "Student Login";
            this.StudentLoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentPasswordLabel
            // 
            this.StudentPasswordLabel.AutoSize = true;
            this.StudentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPasswordLabel.Location = new System.Drawing.Point(146, 189);
            this.StudentPasswordLabel.Name = "StudentPasswordLabel";
            this.StudentPasswordLabel.Size = new System.Drawing.Size(160, 45);
            this.StudentPasswordLabel.TabIndex = 16;
            this.StudentPasswordLabel.Text = "Password:";
            // 
            // StudentUsernameLabel
            // 
            this.StudentUsernameLabel.AutoSize = true;
            this.StudentUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentUsernameLabel.Location = new System.Drawing.Point(136, 142);
            this.StudentUsernameLabel.Name = "StudentUsernameLabel";
            this.StudentUsernameLabel.Size = new System.Drawing.Size(170, 45);
            this.StudentUsernameLabel.TabIndex = 15;
            this.StudentUsernameLabel.Text = "Username:";
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentPasswordLabel);
            this.Controls.Add(this.StudentUsernameLabel);
            this.Controls.Add(this.StudentLoginText);
            this.Controls.Add(this.InstructorLoginButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginButton);
            this.Name = "StudentLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button InstructorLoginButton;
        private System.Windows.Forms.TextBox StudentLoginText;
        private System.Windows.Forms.Label StudentPasswordLabel;
        private System.Windows.Forms.Label StudentUsernameLabel;
    }
}

