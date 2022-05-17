namespace Halaczkiewicz_z1
{
    partial class UncommitedChangesForm
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
            this.dataGridView_UncommitedChanges = new System.Windows.Forms.DataGridView();
            this.trackBar_UncommitedChanges = new System.Windows.Forms.TrackBar();
            this.label_Added = new System.Windows.Forms.Label();
            this.label_Modified = new System.Windows.Forms.Label();
            this.label_Deleted = new System.Windows.Forms.Label();
            this.label_Records = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_RevertChanges = new System.Windows.Forms.Button();
            this.button_CommitToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UncommitedChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_UncommitedChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_UncommitedChanges
            // 
            this.dataGridView_UncommitedChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UncommitedChanges.Location = new System.Drawing.Point(12, 63);
            this.dataGridView_UncommitedChanges.Name = "dataGridView_UncommitedChanges";
            this.dataGridView_UncommitedChanges.RowTemplate.Height = 25;
            this.dataGridView_UncommitedChanges.Size = new System.Drawing.Size(626, 423);
            this.dataGridView_UncommitedChanges.TabIndex = 0;
            // 
            // trackBar_UncommitedChanges
            // 
            this.trackBar_UncommitedChanges.LargeChange = 1;
            this.trackBar_UncommitedChanges.Location = new System.Drawing.Point(254, 12);
            this.trackBar_UncommitedChanges.Maximum = 2;
            this.trackBar_UncommitedChanges.Name = "trackBar_UncommitedChanges";
            this.trackBar_UncommitedChanges.Size = new System.Drawing.Size(148, 45);
            this.trackBar_UncommitedChanges.TabIndex = 1;
            this.trackBar_UncommitedChanges.Scroll += new System.EventHandler(this.trackBar_UncommitedChanges_Scroll);
            this.trackBar_UncommitedChanges.ValueChanged += new System.EventHandler(this.trackBar_UncommitedChanges_ValueChanged);
            // 
            // label_Added
            // 
            this.label_Added.AutoSize = true;
            this.label_Added.Location = new System.Drawing.Point(247, 45);
            this.label_Added.Name = "label_Added";
            this.label_Added.Size = new System.Drawing.Size(42, 15);
            this.label_Added.TabIndex = 2;
            this.label_Added.Text = "Added";
            // 
            // label_Modified
            // 
            this.label_Modified.AutoSize = true;
            this.label_Modified.Location = new System.Drawing.Point(300, 45);
            this.label_Modified.Name = "label_Modified";
            this.label_Modified.Size = new System.Drawing.Size(55, 15);
            this.label_Modified.TabIndex = 3;
            this.label_Modified.Text = "Modified";
            // 
            // label_Deleted
            // 
            this.label_Deleted.AutoSize = true;
            this.label_Deleted.Location = new System.Drawing.Point(364, 45);
            this.label_Deleted.Name = "label_Deleted";
            this.label_Deleted.Size = new System.Drawing.Size(47, 15);
            this.label_Deleted.TabIndex = 4;
            this.label_Deleted.Text = "Deleted";
            // 
            // label_Records
            // 
            this.label_Records.AutoSize = true;
            this.label_Records.Location = new System.Drawing.Point(184, 45);
            this.label_Records.Name = "label_Records";
            this.label_Records.Size = new System.Drawing.Size(52, 15);
            this.label_Records.TabIndex = 5;
            this.label_Records.Text = "Records:";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(12, 5);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(75, 25);
            this.button_Return.TabIndex = 6;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_RevertChanges
            // 
            this.button_RevertChanges.Location = new System.Drawing.Point(542, 5);
            this.button_RevertChanges.Name = "button_RevertChanges";
            this.button_RevertChanges.Size = new System.Drawing.Size(96, 23);
            this.button_RevertChanges.TabIndex = 7;
            this.button_RevertChanges.Text = "Revert changes";
            this.button_RevertChanges.UseVisualStyleBackColor = true;
            this.button_RevertChanges.Click += new System.EventHandler(this.button_RevertChanges_Click);
            // 
            // button_CommitToDatabase
            // 
            this.button_CommitToDatabase.Location = new System.Drawing.Point(541, 34);
            this.button_CommitToDatabase.Name = "button_CommitToDatabase";
            this.button_CommitToDatabase.Size = new System.Drawing.Size(97, 23);
            this.button_CommitToDatabase.TabIndex = 8;
            this.button_CommitToDatabase.Text = "Commit to db";
            this.button_CommitToDatabase.UseVisualStyleBackColor = true;
            this.button_CommitToDatabase.Click += new System.EventHandler(this.button_CommitToDatabase_Click);
            // 
            // UncommitedChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.button_CommitToDatabase);
            this.Controls.Add(this.button_RevertChanges);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.label_Records);
            this.Controls.Add(this.label_Deleted);
            this.Controls.Add(this.label_Modified);
            this.Controls.Add(this.label_Added);
            this.Controls.Add(this.trackBar_UncommitedChanges);
            this.Controls.Add(this.dataGridView_UncommitedChanges);
            this.Name = "UncommitedChangesForm";
            this.Text = "UncommitedChangesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UncommitedChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_UncommitedChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_UncommitedChanges;
        private TrackBar trackBar_UncommitedChanges;
        private Label label_Added;
        private Label label_Modified;
        private Label label_Deleted;
        private Label label_Records;
        private Button button_Return;
        private Button button_RevertChanges;
        private Button button_CommitToDatabase;
    }
}