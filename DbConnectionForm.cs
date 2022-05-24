using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace Halaczkiewicz_z1
{
    public partial class DbConnectionForm : Form
    {
        public DbConnectionForm()
        {
            InitializeComponent();
            // nie wiem czy jakos inaczej sie obchodzi takie bledy niz dodaniem nullable
            //#pragma warning disable CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.
            string?[] configs = ConfigurationManager.AppSettings.AllKeys;
            //#pragma warning restore CS8619 // Obsługa wartości null dla typów referencyjnych w wartości jest niezgodna z typem docelowym.

            if (configs != null && configs.Length > 0 && configs.Length % 2 == 0)
            {
                string?[] snames = new string[configs.Length];
                string?[] dbnames = new string[configs.Length];
                int pair = 0;
                for (int i = 0; i < configs.Length; i += 2)
                {
                    // nie wiem czy jakos inaczej sie obchodzi takie bledy niz dodaniem nullable
                    //#pragma warning disable CS8601 // Możliwe przypisanie odwołania o wartości null.
                    snames[pair] = ConfigurationManager.AppSettings.Get(configs[i]);
                    dbnames[pair] = ConfigurationManager.AppSettings.Get(configs[i + 1]);
                    //#pragma warning restore CS8601 // Możliwe przypisanie odwołania o wartości null.
                    pair += 1;
                }
                comboBox_serverName.DataSource = snames;
                comboBox_dbName.DataSource = dbnames;
                comboBox_serverName.Text = snames[0];
                comboBox_dbName.Text = dbnames[0];
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
                cnxn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            cnxn.Close();
            if (cnxn != null)
            {
                DbConnection = cnxn;
                DialogResult = DialogResult.OK;
            }
        }



        private void Button_SignIn_Clickable(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Login.Text) || String.IsNullOrEmpty(textBox_Password.Text) || String.IsNullOrEmpty(comboBox_serverName.Text) || String.IsNullOrEmpty(comboBox_dbName.Text))
            {
                button_SignIn.Enabled = false;
                return;
            }
            button_SignIn.Enabled = true;
        }

        private void Textbox_Credentials_TextChanged(object sender, EventArgs e)
        {
            Button_SignIn_Clickable(sender, e);
        }

        private void Button_SignIn_Clicked(object sender, EventArgs e)
        {
            Button_SignIn_Clickable(sender, e);
            if (button_SignIn.Enabled == true)  // Idk if that's necessary check
            {
                EstablishDbConnection();
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
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
