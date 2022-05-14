using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    public partial class AddGradeForm : Form
    {
        public AddGradeForm()
        {

            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
