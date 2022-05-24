using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    internal abstract class DatabaseOperations
    {
        // TODO: Refactor class using DataAdapters

        //public static ? ExecuteQuery(string sqlString, connec)
        //{

        //}
        public static void CommitGrade(string studentIndex, string date, string grade, string? comment, SqlConnection connection)
        {
            string gradeCommit = "BEGIN TRANSACTION addGrade; INSERT INTO Grades ";
            if (comment == null || comment.Length == 0)
            {
                gradeCommit += $"(Student_ID, Grade, Grade_date) VALUES ({studentIndex}, {grade.ToString()}, CONVERT(DATE, '{date}', 104));";
            }
            else
            {
                gradeCommit += $"VALUES({studentIndex}, {grade.ToString()}, CONVERT(DATE, '{date}', 104), '{comment}'); ";
            }
            gradeCommit += "COMMIT TRANSACTION addGrade;";

            if (connection.State != ConnectionState.Open) { connection.Open(); }
            SqlCommand cmd = new(gradeCommit, connection);
            cmd.ExecuteNonQuery();
            
            connection.Close();
        }

        public static void CommitStudent(string studentIndex, string name, string surname, string birthdate, SqlConnection connection)
        {
            string studentCommit = @$"
                BEGIN TRANSACTION addStudent; 
                INSERT INTO Students (Student_ID, Student_name, Student_surname, Student_birthdate)
                VALUES({studentIndex}, '{name}', '{surname}', CONVERT(DATE, '{birthdate}', 104));
                COMMIT TRANSACTION addGrade;";
            
            if (connection.State != ConnectionState.Open) { connection.Open(); }
            SqlCommand cmd = new(studentCommit, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static int DeleteStudentsGrades(DataTable dt, SqlConnection connection)
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

        internal static int DeleteStudent(string studentIndex, SqlDataAdapter da)
        {
            string dcmd = $"DELETE FROM Students WHERE Student_ID = {studentIndex}";
            da.DeleteCommand = new SqlCommand(dcmd);
            return da.DeleteCommand.ExecuteNonQuery();
        }

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
                    
                    if (result == DialogResult.OK)
                    {
                        cnxn = connectionForm.DbConnection;
                        cnxn.Close();
                        return cnxn;
                    }
                    else { return null; }  // Not sure if that's necessary
                }
            }
        }

        internal static int UpdateStudent(DataGridViewCell cell, SqlDataAdapter da, SqlConnection connection)
        {
            string updateString = @$"
                        UPDATE Students 
                        SET {cell.OwningColumn.Name} = '{cell.Value}'
                        WHERE Student_ID = {cell.OwningRow.Cells[0].Value};";
            connection.Open();
            da.UpdateCommand = new SqlCommand(updateString, connection);
            int result =  da.UpdateCommand.ExecuteNonQuery();
            return result;
        }
    }
}
