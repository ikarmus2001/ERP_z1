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
    public partial class DbConnectionForm : Form
    {
        public DbConnectionForm()
        {
            InitializeComponent();
        }

        public SqlConnection DbConnection {get;set;}
        
        private void EstablishDbConnection()
        {
            // Data Source=LENOVOTHINKPAD-\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;User ID=;Password=*
            SqlConnection cnxn;
            // "DRIVER={ODBC Driver 17 for SQL Server};
            string connectionString = "Data Source=" +
                this.textBox_Server.Text +
                ";Initial Catalog=" +
                this.textBox_DatabaseName.Text +
                ";User Id=" +
                this.textBox_Login.Text +
                ";Password=" +
                this.textBox_Password.Text;

            bool close_flag = false;
            try
            {
                cnxn = new SqlConnection(connectionString);
                cnxn.Open();
                if (cnxn.State != ConnectionState.Open)
                {
                    throw new Exception("Connection failed");
                }
                close_flag = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            if (close_flag)
            {
                this.DbConnection = cnxn;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private void Button_SignIn_Clickable(object sender, EventArgs e)
        {
            // Login + Password are required due to login method to my db
            if (!String.IsNullOrEmpty(this.textBox_Login.Text) && !String.IsNullOrEmpty(this.textBox_Password.Text))
            {
                this.button_SignIn.Enabled = true;
            }
        }

        private void Textbox_Credentials_TextChanged(object sender, EventArgs e)
        {
            Button_SignIn_Clickable(sender, e);
        }

        private void Button_SignIn_Clicked(object sender, EventArgs e)
        {
            if (this.button_SignIn.Enabled == true)  // Idk if that's necessary check
            {
                EstablishDbConnection();
            }
        }

        private void Button_SignIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_SignIn_Clicked(sender, e);
            }
        }
    }
}
