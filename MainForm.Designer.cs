namespace Halaczkiewicz_z1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_AddGrade = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Update = new System.Windows.Forms.Button();
            this.button_addStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddGrade
            // 
            this.button_AddGrade.Location = new System.Drawing.Point(500, 9);
            this.button_AddGrade.Name = "button_AddGrade";
            this.button_AddGrade.Size = new System.Drawing.Size(100, 30);
            this.button_AddGrade.TabIndex = 0;
            this.button_AddGrade.Text = "Add grade";
            this.button_AddGrade.UseVisualStyleBackColor = true;
            this.button_AddGrade.Click += new System.EventHandler(this.Button_AddGrade_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 384);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView_UserDeletingRow);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(Halaczkiewicz_z1.MainForm);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(12, 9);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(94, 30);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_addStudent
            // 
            this.button_addStudent.Location = new System.Drawing.Point(606, 9);
            this.button_addStudent.Name = "button_addStudent";
            this.button_addStudent.Size = new System.Drawing.Size(94, 30);
            this.button_addStudent.TabIndex = 6;
            this.button_addStudent.Text = "Add student";
            this.button_addStudent.UseVisualStyleBackColor = true;
            this.button_addStudent.Click += new System.EventHandler(this.button_addStudent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 441);
            this.Controls.Add(this.button_addStudent);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_AddGrade);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Database view";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_AddGrade;
        private DataGridView dataGridView1;
        private BindingSource mainFormBindingSource;
        private Button button_Update;
        private Button button_addStudent;
    }
}