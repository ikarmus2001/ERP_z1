namespace Halaczkiewicz_z1
{
    partial class AddStudentForm
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
            this.label_StudentIndex = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_birthDate = new System.Windows.Forms.Label();
            this.maskedTextBox_birthDate = new System.Windows.Forms.MaskedTextBox();
            this.textBox_index = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_StudentIndex
            // 
            this.label_StudentIndex.AutoSize = true;
            this.label_StudentIndex.Location = new System.Drawing.Point(12, 15);
            this.label_StudentIndex.Name = "label_StudentIndex";
            this.label_StudentIndex.Size = new System.Drawing.Size(83, 15);
            this.label_StudentIndex.TabIndex = 20;
            this.label_StudentIndex.Text = "Student index:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 239);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(129, 239);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 18;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(12, 69);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(39, 15);
            this.label_Name.TabIndex = 13;
            this.label_Name.Text = "Name";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(12, 142);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(192, 23);
            this.textBox_surname.TabIndex = 24;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(12, 124);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(54, 15);
            this.label_Surname.TabIndex = 25;
            this.label_Surname.Text = "Surname";
            // 
            // label_birthDate
            // 
            this.label_birthDate.AutoSize = true;
            this.label_birthDate.Location = new System.Drawing.Point(11, 178);
            this.label_birthDate.Name = "label_birthDate";
            this.label_birthDate.Size = new System.Drawing.Size(76, 15);
            this.label_birthDate.TabIndex = 27;
            this.label_birthDate.Text = "Date of birth:";
            // 
            // maskedTextBox_birthDate
            // 
            this.maskedTextBox_birthDate.Location = new System.Drawing.Point(12, 196);
            this.maskedTextBox_birthDate.Mask = "00/00/0000";
            this.maskedTextBox_birthDate.Name = "maskedTextBox_birthDate";
            this.maskedTextBox_birthDate.Size = new System.Drawing.Size(192, 23);
            this.maskedTextBox_birthDate.TabIndex = 26;
            this.maskedTextBox_birthDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_index
            // 
            this.textBox_index.Location = new System.Drawing.Point(11, 33);
            this.textBox_index.Name = "textBox_index";
            this.textBox_index.Size = new System.Drawing.Size(192, 23);
            this.textBox_index.TabIndex = 28;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 87);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(192, 23);
            this.textBox_name.TabIndex = 29;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 286);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_index);
            this.Controls.Add(this.label_birthDate);
            this.Controls.Add(this.maskedTextBox_birthDate);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label_StudentIndex);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Name);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_StudentIndex;
        private Button button_Cancel;
        private Button button_Add;
        private Label label_Name;
        private TextBox textBox_surname;
        private Label label_Surname;
        private Label label_birthDate;
        private MaskedTextBox maskedTextBox_birthDate;
        private TextBox textBox_index;
        private TextBox textBox_name;
    }
}