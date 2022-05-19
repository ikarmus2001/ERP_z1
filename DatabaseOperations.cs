﻿using System;
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
                gradeCommit += $"VALUES({studentIndex}, {grade.ToString()} CONVERT(DATE, '{date}', 104), '{comment}'); ";
            }
            gradeCommit += "COMMIT TRANSACTION addGrade;";

            if (connection.State != ConnectionState.Open) { connection.Open(); }
            SqlCommand cmd = new(gradeCommit, connection);
            cmd.ExecuteNonQuery();
            
            connection.Close();
        }

        private static int DeleteStudentsGrades(DataTable dt, SqlConnection connection)
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
