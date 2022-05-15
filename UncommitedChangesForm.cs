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
        List<DataTable?> allChanges;
        public UncommitedChangesForm(DataTable dataTable)
        {
            allChanges.Add(dataTable.GetChanges(DataRowState.Added));
            allChanges.Add(dataTable.GetChanges(DataRowState.Modified));
            allChanges.Add(dataTable.GetChanges(DataRowState.Deleted));
            
            InitializeComponent();
            dataGridView_UncommitedChanges.DataSource = allChanges[0];  // Added records first
        }
    }
}
