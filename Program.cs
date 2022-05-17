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
            SqlConnection? cnxn;

            cnxn = DatabaseOperations.EstablishingConnection(args);
            if (cnxn != null)
            {
                Application.Run(new MainForm(cnxn));
            }
            else
            {
                return;
            } 
        }
    }
}