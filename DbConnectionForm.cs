using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Configuration.dll;

namespace Halaczkiewicz_z1
{
    public partial class DbConnectionForm : Form
    {
        public DbConnectionForm()
        {
            InitializeComponent();
#pragma warning disable CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.
            string[] configs = ConfigurationManager.AppSettings.AllKeys;
#pragma warning restore CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.
            if (configs.Length > 0)
            {
                string[] snames = new string[configs.Length];
                string[] dbnames = new string[configs.Length];
                for (int i=0; i < configs.Length; i++)
                {
                    //snames[i] = configs[i][0];
                    //dbnames[i] = configs[i][1];
                }
                comboBox_serverName.DataSource = snames;
                comboBox_dbName.DataSource = dbnames;
            }


        }

        public SqlConnection DbConnection {get;set;}
        
        private void EstablishDbConnection()
        {
            SqlConnection cnxn;

            string connectionString = $"Data Source={comboBox_serverName.Text}; Initial Catalog={comboBox_dbName.Text}" +
                $"; User Id={textBox_Login.Text}; Password={textBox_Password.Text}";

            try
            {
                cnxn = new SqlConnection(connectionString);
                // Not sure if that's necessary
                cnxn.Open();
                if (cnxn.State != ConnectionState.Open)
                {
                    throw new Exception("Connection failed");
                }
                //
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            if (cnxn != null)
            {
                DbConnection = cnxn;
                DialogResult = DialogResult.OK;
            }
        }



        private void Button_SignIn_Clickable(object sender, EventArgs e)
        {
            // Login + Password are required due to login method to my db
            // TODO LATER: tho i should play sound when some field is empty, not disable button
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
