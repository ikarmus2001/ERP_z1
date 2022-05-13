/*
    Umo�liwia dodanie do bazy informacji i studentach (Imi�, Nazwisko, Numer indeksu, Data urodzenia)
    Umo�liwia wy�wietlenie informacji o studentach i wyszukanie studenta na podstawie Imienia, Nazwiska, Numeru indeksu, Daty urodzenia
    Umo�liwia edytowanie informacji o studentach
    Umo�liwia usuni�cie studenta
    Umo�liwia dodanie oceny dla studenta, kt�ry ju� zosta� dodany do bazy (obs�uga dodania oceny w nowym oknie)

 

    Prosz� przes�a� kody �r�d�owe, jak r�wnie� kody do tworzenia tabel, procedur sk�adowanych
    Najlepiej �eby to by� MSSQL
    Pod��czenie do bazy danych prosz� umie�ci� w pliku konfiguracyjnym
*/
using System.Data;
using System.Data.SqlClient;

namespace Halaczkiewicz_z1
{
    public partial class MainForm : Form
    {
        SqlConnection cnxn;
        DataSet ds = new();
        public MainForm(SqlConnection passedConnection)
        {
            cnxn = passedConnection;
            //dataGridView1.DataMember = "Studenci";
            InitializeComponent();
            UpdateDataGridView();
        }

        private void Button_AddGrade_Click(object sender, EventArgs e)
        {
            using (var addGradeForm = new AddGradeForm())
            {
                DialogResult result = addGradeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    UpdateDataGridView();
                }
            }
        }

        private void UpdateDataGridView()
        {
            string updateString = "SELECT * FROM Students;";
            //SqlDataAdapter dataAdapter = new(updateString, cnxn);
            if (cnxn.State != ConnectionState.Open) { cnxn.Open(); }
            new SqlDataAdapter(updateString, cnxn).Fill(ds);
            //dataAdapter.Fill(ds);  // Also updates existing rows
            cnxn.Close();
            dataGridView1.DataSource = ds;
        }

        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //DeleteRecursivelyViaID(ds.Tables[dataGridView1.SelectedRows].Select("IDStudent = " + e.ToString);
        }

        private void DeleteRecursivelyViaID(int RowIndex)
        {
            // TODO: Fix sql strings variables names
            //string sql_com = "DELETE FROM Students WHERE IDStudent=" +
                 //ds[RowIndex]["IDStudent"] + ";";
            //SqlCommand command = new(sql_com);
            
            //if (cnxn.State != ConnectionState.Open) { cnxn.Open(); }
            //command.ExecuteNonQuery();
            //cnxn.Close();
            //UpdateDataGridView();
        }
    }
}
