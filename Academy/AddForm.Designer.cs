namespace Academy
{
    partial class AddForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tbStudentLastName = new System.Windows.Forms.TextBox();
            this.tbStudentFirstName = new System.Windows.Forms.TextBox();
            this.tbStudentMiddleName = new System.Windows.Forms.TextBox();
            this.dtpStudentBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.tbStudentPhone = new System.Windows.Forms.TextBox();
            this.cbStudentGroups = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageTeachers);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(362, 319);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.cbStudentGroups);
            this.tabPageStudents.Controls.Add(this.tbStudentPhone);
            this.tabPageStudents.Controls.Add(this.tbStudentEmail);
            this.tabPageStudents.Controls.Add(this.dtpStudentBirthDate);
            this.tabPageStudents.Controls.Add(this.tbStudentMiddleName);
            this.tabPageStudents.Controls.Add(this.tbStudentFirstName);
            this.tabPageStudents.Controls.Add(this.tbStudentLastName);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(354, 293);
            this.tabPageStudents.TabIndex = 1;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(335, 382);
            this.tabPageTeachers.TabIndex = 2;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // tbStudentLastName
            // 
            this.tbStudentLastName.Location = new System.Drawing.Point(6, 6);
            this.tbStudentLastName.Name = "tbStudentLastName";
            this.tbStudentLastName.Size = new System.Drawing.Size(191, 20);
            this.tbStudentLastName.TabIndex = 1;
            // 
            // tbStudentFirstName
            // 
            this.tbStudentFirstName.Location = new System.Drawing.Point(6, 32);
            this.tbStudentFirstName.Name = "tbStudentFirstName";
            this.tbStudentFirstName.Size = new System.Drawing.Size(191, 20);
            this.tbStudentFirstName.TabIndex = 2;
            // 
            // tbStudentMiddleName
            // 
            this.tbStudentMiddleName.Location = new System.Drawing.Point(6, 58);
            this.tbStudentMiddleName.Name = "tbStudentMiddleName";
            this.tbStudentMiddleName.Size = new System.Drawing.Size(191, 20);
            this.tbStudentMiddleName.TabIndex = 3;
            // 
            // dtpStudentBirthDate
            // 
            this.dtpStudentBirthDate.Location = new System.Drawing.Point(6, 84);
            this.dtpStudentBirthDate.Name = "dtpStudentBirthDate";
            this.dtpStudentBirthDate.Size = new System.Drawing.Size(191, 20);
            this.dtpStudentBirthDate.TabIndex = 4;
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Location = new System.Drawing.Point(6, 110);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(191, 20);
            this.tbStudentEmail.TabIndex = 5;
            // 
            // tbStudentPhone
            // 
            this.tbStudentPhone.Location = new System.Drawing.Point(6, 136);
            this.tbStudentPhone.Name = "tbStudentPhone";
            this.tbStudentPhone.Size = new System.Drawing.Size(191, 20);
            this.tbStudentPhone.TabIndex = 6;
            // 
            // cbStudentGroups
            // 
            this.cbStudentGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentGroups.FormattingEnabled = true;
            this.cbStudentGroups.Location = new System.Drawing.Point(6, 162);
            this.cbStudentGroups.Name = "cbStudentGroups";
            this.cbStudentGroups.Size = new System.Drawing.Size(191, 21);
            this.cbStudentGroups.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(380, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(380, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.ComboBox cbStudentGroups;
        private System.Windows.Forms.TextBox tbStudentPhone;
        private System.Windows.Forms.TextBox tbStudentEmail;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthDate;
        private System.Windows.Forms.TextBox tbStudentMiddleName;
        private System.Windows.Forms.TextBox tbStudentFirstName;
        private System.Windows.Forms.TextBox tbStudentLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}