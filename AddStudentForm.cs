using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halaczkiewicz_z1
{
    public partial class AddStudentForm : Form
    {
        SqlConnection connection;
        public AddStudentForm(DataTable dt, SqlConnection cnxn)
        {
            connection = cnxn;
            InitializeComponent();
            textBox_index.Text = Convert.ToString(Convert.ToInt32(dt.Select("Student_ID=max(Student_ID)")[0][0]) + 1);  // surely it can be simplified
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            DatabaseOperations.CommitStudent(textBox_index.Text, textBox_name.Text, textBox_surname.Text, maskedTextBox_birthDate.Text, connection);
            DialogResult = DialogResult.OK;
        }
    }
}
