using System;
using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    internal abstract class DatabaseOperations
    {
        //public static ? ExecuteQuery(string sqlString, connec)
        //{

        //}
        public void CommitGrade(int studentIndex, string date, int grade, string? comment, SqlConnection connection)
        {
        // CREATE TABLE Grades(
        //  Student_ID int NOT NULL REFERENCES Students(Student_ID),
        //  Grade tinyint NOT NULL,
        //  Grade_date date,
        //  Grade_comment VARCHAR(100)
        // );

            string gradeCommit = "INSERT INTO Grades VALUES (" + studentIndex + ", " + grade.ToString() + ",  CONVERT(DATE, '" + date + "', 104));";

            if (connection.State != ConnectionState.Open) { connection.Open(); }
            SqlCommand cmd = new(gradeCommit, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void CommitChanges(DataTable dt, SqlConnection connection)
        {
            CommitDelete(dt, connection);
            CommitAdd(dt, connection);
            CommitUpdate(dt, connection);
        }

        #region Commits

        #region Updates
        private void CommitUpdate(DataTable dt, SqlConnection connection)
        {
            UpdateStudents(dt, connection);
        }

        private void UpdateStudents(DataTable dt, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Adds
        private void CommitAdd(DataTable dt, SqlConnection connection)
        {
            AddStudents(dt, connection);
        }

        private void AddStudents(DataTable dt, SqlConnection connection)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Deletes
        private void CommitDelete(DataTable dt, SqlConnection connection)
        {
            DeleteStudentsGrades(dt, connection);
            DeleteStudents(dt, connection);
        }

        private void DeleteStudents(DataTable dt, SqlConnection connection)
        {
            throw new NotImplementedException();
        }

        private int DeleteStudentsGrades(DataTable dt, SqlConnection connection)
        {
            // TODO Test method

            int rowsAffected = 0;
            DataTable? deletedStudents = dt.GetChanges(DataRowState.Deleted);
            if (deletedStudents != null)
            {
                DataRowCollection dsRows = deletedStudents.Rows;
                string delete_string = "DELETE FROM Grades WHERE Student_ID = " + dsRows[0].ToString();

                if (deletedStudents.Rows.Count > 1)
                {
                    dsRows.RemoveAt(0);
                    foreach (int Student_ID in dsRows)
                    {
                        delete_string += " || " + Student_ID.ToString();
                    }
                }
                delete_string += ';';

                if (connection.State != ConnectionState.Open) { connection.Open(); }
                SqlCommand cmd = new(delete_string, connection);
                rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return rowsAffected;
        }
        #endregion

        #endregion
        public static SqlConnection? EstablishingConnection(string[] args)
        {
            // overloading method would be better idea
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
