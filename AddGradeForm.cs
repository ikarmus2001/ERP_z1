using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    public partial class AddGradeForm : Form
    {

        public AddGradeForm(DataTable dt)
        {
            InitializeComponent();

            // Populating comboboxes
            comboBox_StudentIndex.DataSource = dt.Columns["Student_ID"];
            comboBox_Grade.DataSource = new List<string>{"1", "2", "3", "4", "5", "6"};

            DateTime dateTime = DateTime.UtcNow.Date;
            maskedTextBox_Date.Text = dateTime.Date.ToString();  // check if date is correct
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
