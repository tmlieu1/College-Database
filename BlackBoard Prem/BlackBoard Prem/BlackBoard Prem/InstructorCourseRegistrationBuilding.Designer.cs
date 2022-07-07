
namespace BlackBoard_Prem
{
    partial class InstructorCourseRegistrationBuilding
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
            this.ICourseRegFinalTitle = new System.Windows.Forms.TextBox();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.ICourseFinalSubtitle = new System.Windows.Forms.TextBox();
            this.BuildingInfo = new System.Windows.Forms.Label();
            this.BuildingHint = new System.Windows.Forms.Label();
            this.buildingComboBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ICourseRegFinalTitle
            // 
            this.ICourseRegFinalTitle.BackColor = System.Drawing.Color.Brown;
            this.ICourseRegFinalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ICourseRegFinalTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseRegFinalTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ICourseRegFinalTitle.Location = new System.Drawing.Point(-151, 1);
            this.ICourseRegFinalTitle.Name = "ICourseRegFinalTitle";
            this.ICourseRegFinalTitle.ReadOnly = true;
            this.ICourseRegFinalTitle.Size = new System.Drawing.Size(975, 39);
            this.ICourseRegFinalTitle.TabIndex = 32;
            this.ICourseRegFinalTitle.Text = "Blackboard+ Create Course";
            this.ICourseRegFinalTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundBox.Location = new System.Drawing.Point(12, 87);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(812, 196);
            this.BackgroundBox.TabIndex = 54;
            this.BackgroundBox.TabStop = false;
            // 
            // ICourseFinalSubtitle
            // 
            this.ICourseFinalSubtitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ICourseFinalSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICourseFinalSubtitle.Location = new System.Drawing.Point(0, 37);
            this.ICourseFinalSubtitle.Name = "ICourseFinalSubtitle";
            this.ICourseFinalSubtitle.ReadOnly = true;
            this.ICourseFinalSubtitle.Size = new System.Drawing.Size(824, 44);
            this.ICourseFinalSubtitle.TabIndex = 56;
            this.ICourseFinalSubtitle.Text = "Select Building/Location ";
            this.ICourseFinalSubtitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuildingInfo
            // 
            this.BuildingInfo.AutoSize = true;
            this.BuildingInfo.BackColor = System.Drawing.SystemColors.Info;
            this.BuildingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingInfo.Location = new System.Drawing.Point(21, 98);
            this.BuildingInfo.Name = "BuildingInfo";
            this.BuildingInfo.Size = new System.Drawing.Size(790, 31);
            this.BuildingInfo.TabIndex = 57;
            this.BuildingInfo.Text = "Based on Desired Days + Time, these are the available buildings";
            this.BuildingInfo.Click += new System.EventHandler(this.BuildingInfo_Click);
            // 
            // BuildingHint
            // 
            this.BuildingHint.AutoSize = true;
            this.BuildingHint.BackColor = System.Drawing.SystemColors.Info;
            this.BuildingHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingHint.Location = new System.Drawing.Point(21, 156);
            this.BuildingHint.Name = "BuildingHint";
            this.BuildingHint.Size = new System.Drawing.Size(229, 31);
            this.BuildingHint.TabIndex = 58;
            this.BuildingHint.Text = "Building/Location:";
            // 
            // buildingComboBox
            // 
            this.buildingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingComboBox.FormattingEnabled = true;
            this.buildingComboBox.Location = new System.Drawing.Point(267, 156);
            this.buildingComboBox.Name = "buildingComboBox";
            this.buildingComboBox.Size = new System.Drawing.Size(121, 37);
            this.buildingComboBox.TabIndex = 59;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(452, 226);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(359, 47);
            this.ConfirmButton.TabIndex = 60;
            this.ConfirmButton.Text = "Confirm Course Creation";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // InstructorCourseRegistrationBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 278);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.buildingComboBox);
            this.Controls.Add(this.BuildingHint);
            this.Controls.Add(this.BuildingInfo);
            this.Controls.Add(this.ICourseFinalSubtitle);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.ICourseRegFinalTitle);
            this.Name = "InstructorCourseRegistrationBuilding";
            this.Text = "InstructorCourseRegistrationBuilding";
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ICourseRegFinalTitle;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.TextBox ICourseFinalSubtitle;
        private System.Windows.Forms.Label BuildingInfo;
        private System.Windows.Forms.Label BuildingHint;
        private System.Windows.Forms.ComboBox buildingComboBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}