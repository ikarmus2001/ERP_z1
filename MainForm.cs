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
        DataTable dt = new();
        SqlDataAdapter da = new();
        
        

        public MainForm(SqlConnection passedConnection)
        {
            cnxn = passedConnection;
            InitializeComponent();
            SetupDataAdapter();
            UpdateDataGridView();
        }

        private void SetupDataAdapter()
        {
            string mainViewQuery = @"
            SELECT 
                Students.Student_ID,
	            Student_name                        ,
	            Student_surname                     ,
	            Student_birthdate                   ,
	            ROUND(AVG(Cast(Grade as Float)), 2) 'Average score'
            FROM
                Students FULL JOIN
                    Grades ON Students.Student_ID = Grades.Student_ID
            GROUP BY Students.Student_ID, Student_name, Student_surname, Student_birthdate; ";
            da.SelectCommand = new SqlCommand(mainViewQuery, cnxn);

            

            // todo
            //da.UpdateCommand = new SqlCommand(, cnxn);


            //da.DeleteCommand = new SqlCommand(, cnxn);
        }

        private void UpdateDataGridView()
        {
            dt = new();

            if (cnxn.State != ConnectionState.Open) { cnxn.Open(); }
            da.Fill(dt);
            cnxn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Update();
        }

        private void Button_AddGrade_Click(object sender, EventArgs e)
        {
            using (var addGradeForm = new AddGradeForm(dt, cnxn))
            {
                DialogResult result = addGradeForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Grade commited
                    UpdateDataGridView();
                }
            }
        }

        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string msg = "Pr�bujesz usun�� wpis studenta, spowoduje to kaskadowe usuni�cie ocen. Kontynuowa�?";
            DialogResult result = MessageBox.Show(msg, "Ostrze�enie!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { e.Cancel = true; }
            else
            {
                string? deletedStudentIndex = e.Row.Cells[0].Value.ToString();
                if (deletedStudentIndex != null && deletedStudentIndex.Length > 0)
                {
                    DatabaseOperations.DeleteStudentsGrades(dt, cnxn);
                    DatabaseOperations.DeleteStudent(deletedStudentIndex, da);
                }
            }
        }

        
        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        //private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    MessageBox.Show(e.ToString(), "es", MessageBoxButtons.OK);
        //    //foreach (var item in collection)
        //    //{
        //    //    string insertCommand = $"""
        //    //    INSERT INTO Students VALUES (
        //    //        {Student_ID},
        //    //     {Student_name},
        //    //     {Student_surname},
        //    //     {Student_birthdate});
        //    //    """;
        //    //    da.InsertCommand = new SqlCommand(insertCommand, cnxn);
        //    //}
        //}

        private void button_addStudent_Click(object sender, EventArgs e)
        {
            
            using (var addStudentForm = new AddStudentForm(dt, cnxn))
            {
                DialogResult result = addStudentForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Student commited
                    UpdateDataGridView();
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell? currentCell = dataGridView1.CurrentCell;
            // todo ograniczenia edycji? np indexy, typy zmiennych
            if (currentCell.OwningColumn.Name == "Student_ID")
            {
                MessageBox.Show("Nie można wprowadzać zmian w ID");
                UpdateDataGridView();
            }
            else if (currentCell.OwningColumn.Name == "Average score")
            {
                MessageBox.Show("Nie można wprowadzać zmian w średniej");
                UpdateDataGridView();
            }
            else
            {
                try
                {
                    DatabaseOperations.UpdateStudent(currentCell, da, cnxn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Nie wprowadzono zmian, proszę wprowadzić poprawne dane");
                    UpdateDataGridView();
                }
            }
        }
    }
}
