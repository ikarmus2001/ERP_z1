using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halaczkiewicz_z1
{
    public partial class UncommitedChangesForm : Form
    {
        DataTable? allChanges;
        public UncommitedChangesForm(DataTable dataTable)
        {
            DataColumn dc = new DataColumn("Operation", typeof(char));
            allChanges.Rows.Add(dataTable.GetChanges(DataRowState.Added).Columns.Add());
            allChanges.Append(dataTable.GetChanges(DataRowState.Modified));
            allChanges.Append(dataTable.GetChanges(DataRowState.Deleted));

            foreach (DataRowCollection item in collection)
            {

            }
            InitializeComponent();
            unc

        }

        private void UncommitedChangesForm_Load(object sender, EventArgs e)
        {


        }
    }
}
