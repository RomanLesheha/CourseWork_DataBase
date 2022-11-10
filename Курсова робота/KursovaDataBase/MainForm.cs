using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaDataBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        AddStudentsForm studentsForm = new AddStudentsForm();
        AddTeachersForm teacherForm = new AddTeachersForm();
        AuthorizationForm authorizationForm = new AuthorizationForm();
        StatisticsForm statisticsForm = new StatisticsForm();

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (DataBase.СonfirmedUser)
            {
                Authorization_btn.Visible = false;
            }
            Students.Show(students_dataGridView);
            Teachers.Show(teachers_DataGridView);
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (DataBase.СonfirmedUser)
            {
                if (students_check.Checked)
                {
                    if (studentsForm == null || studentsForm.IsDisposed)
                        studentsForm = new AddStudentsForm();
                    studentsForm.Show();
                }
                if (teachers_check.Checked)
                {
                    if (teacherForm == null || teacherForm.IsDisposed)
                        teacherForm = new AddTeachersForm();
                    teacherForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Авторизуйтесь спочатку!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (search_field.Text == string.Empty)
            {
                MessageBox.Show("Ви не ввели жодного символа!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                search_field.Focus();
                return;
            }
            string key = search_field.Text;
            if (key.Any(Char.IsDigit))
            {
                Students.FindStudents(key, true, students_dataGridView);
                Teachers.FindTeacher(key, true, teachers_DataGridView);
                return;
            }
            if (students_check.Checked)
            {
                Students.FindStudents(key, false, students_dataGridView);
                if (students_dataGridView.Rows.Count == 0)
                {
                    MessageBox.Show($"Вибачте ,але ми не змогли знайти {key}", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            if (teachers_check.Checked)
            {
                Teachers.FindTeacher(key, false, teachers_DataGridView);
                if (teachers_DataGridView.Rows.Count == 0)
                {
                    MessageBox.Show($"Вибачте ,але ми не змогли знайти {key}", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            

            
                
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Students.Show(students_dataGridView);
            Teachers.Show(teachers_DataGridView);
        }

        private void DeteleDB_btn_Click(object sender, EventArgs e)
        {
            if (students_check.Checked)
            {
                if (MessageBox.Show("Ви впевнені ,що хочете видалити базу данних студентів?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    DataBase.DeleteDataBase(true);
                }
            }
            else
            {
                if (MessageBox.Show("Ви впевнені ,що хочете видалити базу данних викладачів ?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    DataBase.DeleteDataBase(false);
                }
            }
            
        }

        private void Authorization_btn_Click(object sender, EventArgs e)
        {
            if (authorizationForm == null || authorizationForm.IsDisposed)
                authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void Statictics_btn_Click(object sender, EventArgs e)
        {
            if (statisticsForm == null || statisticsForm.IsDisposed)
                statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void students_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBase.СonfirmedUser)
            {
                if (e.ColumnIndex == 0)
                {
                    if (studentsForm == null || studentsForm.IsDisposed)
                        studentsForm = new AddStudentsForm();
                    studentsForm.Show();
                    studentsForm.textBox1.Text = students_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    studentsForm.textBox2.Text = students_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    studentsForm.Specialty_comboBox.SelectedItem = students_dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    studentsForm.textBox3.Text = students_dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    studentsForm.textBox4.Text = students_dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    studentsForm.textBox5.Text = students_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    studentsForm.Change_btn.Visible = true;
                    studentsForm.textBox2.ReadOnly = true;
                    Students.key = students_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    return;
                }
                if (e.ColumnIndex == 1)
                {
                    Students.key = students_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Students.DeleteStudents(Students.key);
                    Students.Show(students_dataGridView);
                    return;
                }
            }
        }

        private void students_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string key = students_dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            Teachers.FindTeacher(key, teachers_DataGridView);
            if (teachers_DataGridView.Rows.Count == 0)
            {
                Teachers.Show(teachers_DataGridView);
                MessageBox.Show("Куратор відсутній у базі данних", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void teachers_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataBase.СonfirmedUser)
            {
                if (e.ColumnIndex == 0)
                {
                    if (teacherForm == null || teacherForm.IsDisposed)
                        teacherForm = new AddTeachersForm();
                    teacherForm.Show();
                    teacherForm.Change_btn.Visible = true;
                    teacherForm.textBox1.Text = teachers_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    teacherForm.richTextBox1.Text = teachers_DataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                    teacherForm.textBox2.Text = teachers_DataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                    teacherForm.textBox3.Text = teachers_DataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                    teacherForm.Position_comboBox.SelectedItem = teachers_DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                    teacherForm.Department_comboBox.SelectedItem = teachers_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Teachers.Key = teachers_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    return;
                }
                if (e.ColumnIndex == 1)
                {
                    Teachers.Key = teachers_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    Teachers.DeleteTeacher(Teachers.Key);
                    Teachers.Show(teachers_DataGridView);
                    return;
                }
            }
        }

        private void search_field_Enter(object sender, EventArgs e)
        {
            search_field.Text = "";
        }

        private void students_check_CheckedChanged(object sender, EventArgs e)
        {
            teachers_comboBox.Visible = false;
        }

        private void teachers_check_CheckedChanged(object sender, EventArgs e)
        {
            teachers_comboBox.Visible = true;
        }

        private void teachers_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = teachers_comboBox.SelectedIndex;
            Teachers.SortTeacher(index, teachers_DataGridView);
        }

        private void students_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = students_comboBox.SelectedIndex;
            Students.SortStudents(index, students_dataGridView);
        }
    }
}
