using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    public partial class UncommitedChangesForm : Form
    {
        List<DataTable?> allChanges;
        DataTable dt;
        SqlConnection connection;
        public UncommitedChangesForm(DataTable dataTable, SqlConnection sqlConnection)
        {
            allChanges.Add(dataTable.GetChanges(DataRowState.Added));
            allChanges.Add(dataTable.GetChanges(DataRowState.Modified));
            allChanges.Add(dataTable.GetChanges(DataRowState.Deleted));

            connection = sqlConnection;
            dt = dataTable;

            InitializeComponent();
            dataGridView_UncommitedChanges.DataSource = allChanges[0];  // Added records first
        }

        //not sure which will work
        private void trackBar_UncommitedChanges_ValueChanged(object sender, EventArgs e)
        {
            dataGridView_UncommitedChanges.DataSource = allChanges[trackBar_UncommitedChanges.Value];
        }

        private void trackBar_UncommitedChanges_Scroll(object sender, EventArgs e)
        {
            dataGridView_UncommitedChanges.DataSource = allChanges[trackBar_UncommitedChanges.Value];
            dataGridView_UncommitedChanges.Update();
        }
        // 
        private void button_CommitToDatabase_Click(object sender, EventArgs e)
        {
            DatabaseOperations.CommitChanges(dt, connection);
            DialogResult = DialogResult.OK;
        }

        private void button_RevertChanges_Click(object sender, EventArgs e)
        {
            dt.RejectChanges();
            DialogResult = DialogResult.Cancel;
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }


    }
    
}
