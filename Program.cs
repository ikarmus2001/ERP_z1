using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{

    internal static class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();


            SqlConnection cnxn;

            if (args.Length > 0)
            {
                // TODO: pls fix it, args serialization
                string connectionString = args[0];
                cnxn = new SqlConnection(connectionString);
                if (cnxn.State != ConnectionState.Open)
                {
                    throw new Exception("ConnectionError: Invalid connection string or db unavailable");
                }
            }
            else
            {
                using (var connectionForm = new DbConnectionForm())
                {
                    var result = connectionForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        cnxn = connectionForm.DbConnection;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            Application.Run(new MainForm(cnxn));
            
        }
    }
}