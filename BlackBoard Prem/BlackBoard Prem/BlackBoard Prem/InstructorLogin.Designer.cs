
namespace BlackBoard_Prem
{
    partial class InstructorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorLogin));
            this.StudentLoginButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InstructorPassword = new System.Windows.Forms.TextBox();
            this.InstructorUsername = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InstructorLoginText = new System.Windows.Forms.TextBox();
            this.InstructorUsernameLabel = new System.Windows.Forms.Label();
            this.InstructorPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLoginButton
            // 
            this.StudentLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StudentLoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLoginButton.Location = new System.Drawing.Point(295, 384);
            this.StudentLoginButton.Name = "StudentLoginButton";
            this.StudentLoginButton.Size = new System.Drawing.Size(183, 37);
            this.StudentLoginButton.TabIndex = 11;
            this.StudentLoginButton.Text = "Student Login";
            this.StudentLoginButton.UseVisualStyleBackColor = false;
            this.StudentLoginButton.Click += new System.EventHandler(this.StudentLoginButton_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Brown;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(1, -1);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(806, 43);
            this.Title.TabIndex = 10;
            this.Title.Text = "Blackboard+ Sign-in";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorPassword
            // 
            this.InstructorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.InstructorPassword.Location = new System.Drawing.Point(313, 203);
            this.InstructorPassword.Name = "InstructorPassword";
            this.InstructorPassword.PasswordChar = '*';
            this.InstructorPassword.Size = new System.Drawing.Size(152, 32);
            this.InstructorPassword.TabIndex = 8;
            // 
            // InstructorUsername
            // 
            this.InstructorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.InstructorUsername.Location = new System.Drawing.Point(313, 156);
            this.InstructorUsername.Name = "InstructorUsername";
            this.InstructorUsername.Size = new System.Drawing.Size(152, 32);
            this.InstructorUsername.TabIndex = 7;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(295, 260);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(183, 40);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InstructorLoginText
            // 
            this.InstructorLoginText.BackColor = System.Drawing.SystemColors.Menu;
            this.InstructorLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructorLoginText.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorLoginText.Location = new System.Drawing.Point(285, 111);
            this.InstructorLoginText.Name = "InstructorLoginText";
            this.InstructorLoginText.ReadOnly = true;
            this.InstructorLoginText.Size = new System.Drawing.Size(210, 39);
            this.InstructorLoginText.TabIndex = 12;
            this.InstructorLoginText.Text = "Instructor Login";
            this.InstructorLoginText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InstructorUsernameLabel
            // 
            this.InstructorUsernameLabel.AutoSize = true;
            this.InstructorUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorUsernameLabel.Location = new System.Drawing.Point(116, 153);
            this.InstructorUsernameLabel.Name = "InstructorUsernameLabel";
            this.InstructorUsernameLabel.Size = new System.Drawing.Size(173, 37);
            this.InstructorUsernameLabel.TabIndex = 13;
            this.InstructorUsernameLabel.Text = "Username:";
            // 
            // InstructorPasswordLabel
            // 
            this.InstructorPasswordLabel.AutoSize = true;
            this.InstructorPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorPasswordLabel.Location = new System.Drawing.Point(116, 203);
            this.InstructorPasswordLabel.Name = "InstructorPasswordLabel";
            this.InstructorPasswordLabel.Size = new System.Drawing.Size(167, 37);
            this.InstructorPasswordLabel.TabIndex = 14;
            this.InstructorPasswordLabel.Text = "Password:";
            // 
            // InstructorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstructorPasswordLabel);
            this.Controls.Add(this.InstructorUsernameLabel);
            this.Controls.Add(this.InstructorLoginText);
            this.Controls.Add(this.StudentLoginButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InstructorPassword);
            this.Controls.Add(this.InstructorUsername);
            this.Controls.Add(this.LoginButton);
            this.Name = "InstructorLogin";
            this.Text = "InstructorLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentLoginButton;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox InstructorPassword;
        private System.Windows.Forms.TextBox InstructorUsername;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox InstructorLoginText;
        private System.Windows.Forms.Label InstructorUsernameLabel;
        private System.Windows.Forms.Label InstructorPasswordLabel;
    }
}