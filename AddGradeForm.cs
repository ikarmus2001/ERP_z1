using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    public partial class AddGradeForm : Form
    {
        SqlConnection connection;

        public AddGradeForm(DataTable dt, SqlConnection connection)
        {
            InitializeComponent();

            // Populating comboboxes
            List<int> ids = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                ids.Add( (int) row[0]);
            }
            comboBox_StudentIndex.DataSource = ids;
            comboBox_Grade.DataSource = new List<string> { "1", "2", "3", "4", "5", "6" };

            DateTime dateTime = DateTime.UtcNow.Date;
            maskedTextBox_Date.Text = dateTime.Date.ToString();  // check if date is correct
            this.connection = connection;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            DatabaseOperations.CommitGrade(comboBox_StudentIndex.Text, maskedTextBox_Date.Text, comboBox_Grade.Text, textBox_Comment.Text, connection);
            DialogResult = DialogResult.OK;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
