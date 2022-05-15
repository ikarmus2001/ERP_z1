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
        DataTable dt = new();

        string mainViewQuery = @"
            SELECT 
                Students.Student_ID,
	            Student_name        'Imiê',
	            Student_surname     'Nazwisko',
	            Student_birthdate   'Data urodzenia',
	            AVG(Grade)          'Œrednia'
            FROM
                Students FULL JOIN
                    Grades ON Students.Student_ID = Grades.Student_ID
            GROUP BY Students.Student_ID, Student_name, Student_surname, Student_birthdate; ";


        public MainForm(SqlConnection passedConnection)
        {
            cnxn = passedConnection;
            InitializeComponent();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            if (cnxn.State != ConnectionState.Open) { cnxn.Open(); }
            new SqlDataAdapter(mainViewQuery, cnxn).Fill(dt);
            cnxn.Close();
            dataGridView1.DataSource = dt;
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


        private void DataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            //dt.Remove()
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string msg = "Próbujesz usun¹æ wpis studenta, spowoduje to kaskadowe usuniêcie ocen. Kontynuowaæ?";
            DialogResult result = MessageBox.Show("Ostrze¿enie!", msg, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { e.Cancel = true; }
        }

        private void button_uncommitedChanges_Click(object sender, EventArgs e)
        {
            using (var form = new UncommitedChangesForm(dt))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
            

        }
    }
}
