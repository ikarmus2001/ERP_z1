using System;
using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    internal abstract class DatabaseOperations
    {
        //static void ExecuteQuery(string sqlString, connec)  // czy wyrzucanie sql do osobnej klasy ma sens?

        // establish connection
        public static SqlConnection? EstablishingConnection(string[] args)
        {
            SqlConnection cnxn;

            if (args.Length > 0)
            {
                // TODO: args serialization
                string connectionString = args[0];
                cnxn = new SqlConnection(connectionString);
                cnxn.Open();
                if (cnxn.State != ConnectionState.Open)
                {
                    // probably throwing error at this point would be more convenient
                    //throw new Exception("ConnectionError: Invalid connection string or db unavailable");
                    return null;
                }
                cnxn.Close();
                return cnxn;

            }
            else
            {
                using (DbConnectionForm connectionForm = new DbConnectionForm())
                {
                    DialogResult result = connectionForm.ShowDialog();  
                    
                    // probably ifcheck might be simplified
                    if (result == DialogResult.OK)
                    {
                        cnxn = connectionForm.DbConnection;
                        cnxn.Close();
                        return cnxn;
                    }
                    else { return null; }  // Not sure what might happen without that
                }
            }
        }
    }
}
