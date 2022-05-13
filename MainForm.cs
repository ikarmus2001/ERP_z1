/*
    Umo¿liwia dodanie do bazy informacji i studentach (Imiê, Nazwisko, Numer indeksu, Data urodzenia)
    Umo¿liwia wyœwietlenie informacji o studentach i wyszukanie studenta na podstawie Imienia, Nazwiska, Numeru indeksu, Daty urodzenia
    Umo¿liwia edytowanie informacji o studentach
    Umo¿liwia usuniêcie studenta
    Umo¿liwia dodanie oceny dla studenta, który ju¿ zosta³ dodany do bazy (obs³uga dodania oceny w nowym oknie)

 

    Proszê przes³aæ kody Ÿród³owe, jak równie¿ kody do tworzenia tabel, procedur sk³adowanych
    Najlepiej ¿eby to by³ MSSQL
    Pod³¹czenie do bazy danych proszê umieœciæ w pliku konfiguracyjnym
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
