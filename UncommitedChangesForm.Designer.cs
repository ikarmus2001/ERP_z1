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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UncommitedChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_UncommitedChanges
            // 
            this.dataGridView_UncommitedChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UncommitedChanges.Location = new System.Drawing.Point(12, 38);
            this.dataGridView_UncommitedChanges.Name = "dataGridView_UncommitedChanges";
            this.dataGridView_UncommitedChanges.RowTemplate.Height = 25;
            this.dataGridView_UncommitedChanges.Size = new System.Drawing.Size(562, 400);
            this.dataGridView_UncommitedChanges.TabIndex = 0;
            // 
            // UncommitedChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.dataGridView_UncommitedChanges);
            this.Name = "UncommitedChangesForm";
            this.Text = "UncommitedChangesForm";
            this.Load += new System.EventHandler(this.UncommitedChangesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UncommitedChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_UncommitedChanges;
    }
}