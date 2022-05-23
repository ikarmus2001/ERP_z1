namespace Halaczkiewicz_z1
{
    partial class AddGradeForm
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
            this.comboBox_Student = new System.Windows.Forms.ComboBox();
            this.label_Student = new System.Windows.Forms.Label();
            this.maskedTextBox_Date = new System.Windows.Forms.MaskedTextBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label_Comment = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_StudentIndex = new System.Windows.Forms.Label();
            this.comboBox_StudentIndex = new System.Windows.Forms.ComboBox();
            this.comboBox_Grade = new System.Windows.Forms.ComboBox();
            this.label_Grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Student
            // 
            this.comboBox_Student.FormattingEnabled = true;
            this.comboBox_Student.Location = new System.Drawing.Point(12, 34);
            this.comboBox_Student.Name = "comboBox_Student";
            this.comboBox_Student.Size = new System.Drawing.Size(192, 23);
            this.comboBox_Student.TabIndex = 0;
            // 
            // label_Student
            // 
            this.label_Student.AutoSize = true;
            this.label_Student.Location = new System.Drawing.Point(12, 16);
            this.label_Student.Name = "label_Student";
            this.label_Student.Size = new System.Drawing.Size(51, 15);
            this.label_Student.TabIndex = 1;
            this.label_Student.Text = "Student:";
            // 
            // maskedTextBox_Date
            // 
            this.maskedTextBox_Date.Location = new System.Drawing.Point(12, 143);
            this.maskedTextBox_Date.Mask = "00/00/0000";
            this.maskedTextBox_Date.Name = "maskedTextBox_Date";
            this.maskedTextBox_Date.Size = new System.Drawing.Size(192, 23);
            this.maskedTextBox_Date.TabIndex = 2;
            this.maskedTextBox_Date.ValidatingType = typeof(System.DateTime);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(12, 125);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(34, 15);
            this.label_Date.TabIndex = 3;
            this.label_Date.Text = "Date:";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(12, 251);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(192, 23);
            this.textBox_Comment.TabIndex = 4;
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(12, 233);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(119, 15);
            this.label_Comment.TabIndex = 5;
            this.label_Comment.Text = "Comment (optional):";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(129, 291);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 291);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // label_StudentIndex
            // 
            this.label_StudentIndex.AutoSize = true;
            this.label_StudentIndex.Location = new System.Drawing.Point(12, 70);
            this.label_StudentIndex.Name = "label_StudentIndex";
            this.label_StudentIndex.Size = new System.Drawing.Size(83, 15);
            this.label_StudentIndex.TabIndex = 8;
            this.label_StudentIndex.Text = "Student index:";
            // 
            // comboBox_StudentIndex
            // 
            this.comboBox_StudentIndex.FormattingEnabled = true;
            this.comboBox_StudentIndex.Location = new System.Drawing.Point(12, 88);
            this.comboBox_StudentIndex.Name = "comboBox_StudentIndex";
            this.comboBox_StudentIndex.Size = new System.Drawing.Size(192, 23);
            this.comboBox_StudentIndex.TabIndex = 9;
            // 
            // comboBox_Grade
            // 
            this.comboBox_Grade.FormattingEnabled = true;
            this.comboBox_Grade.Location = new System.Drawing.Point(12, 196);
            this.comboBox_Grade.MaxDropDownItems = 6;
            this.comboBox_Grade.MaxLength = 1;
            this.comboBox_Grade.Name = "comboBox_Grade";
            this.comboBox_Grade.Size = new System.Drawing.Size(192, 23);
            this.comboBox_Grade.Sorted = true;
            this.comboBox_Grade.TabIndex = 10;
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(12, 178);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(41, 15);
            this.label_Grade.TabIndex = 11;
            this.label_Grade.Text = "Grade:";
            // 
            // AddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 339);
            this.Controls.Add(this.label_Grade);
            this.Controls.Add(this.comboBox_Grade);
            this.Controls.Add(this.comboBox_StudentIndex);
            this.Controls.Add(this.label_StudentIndex);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Comment);
            this.Controls.Add(this.textBox_Comment);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.maskedTextBox_Date);
            this.Controls.Add(this.label_Student);
            this.Controls.Add(this.comboBox_Student);
            this.Name = "AddGradeForm";
            this.Text = "AddGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_Student;
        private Label label_Student;
        private MaskedTextBox maskedTextBox_Date;
        private Label label_Date;
        private TextBox textBox_Comment;
        private Label label_Comment;
        private Button button_Add;
        private Button button_Cancel;
        private Label label_StudentIndex;
        private ComboBox comboBox_StudentIndex;
        private ComboBox comboBox_Grade;
        private Label label_Grade;
    }
}