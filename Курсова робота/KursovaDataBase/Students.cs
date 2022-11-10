using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaDataBase
{
    class Students
    {
        public string Fullname { get; set; }  //прізвище ім'я по батькові

        public string NumberGradebook { get; set; } // номер залікової книжки 

        public int Specialty { get; set; }  //спеціальність 

        public string Group { get; set; }  // група

        public double GPU { get; set; } // середня оцінка в 5-бальній системі 

        public string Curator { get; set; }  //ПІБ куратора

        public static string key;

        //конструктор для ініціалізації даних
        public Students(string fullname, string numberGradebook, int specialty, string group, double gpu, string curator)
        {
            Fullname = fullname;
            NumberGradebook = numberGradebook;
            Specialty = specialty;
            Group = group;
            GPU = gpu;
            Curator = curator;
        }
        //перевірка залікової книжки
        private static bool CheckNumberGradebook(Students students)
        {
            DataBase db = new DataBase();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `students` WHERE `NumberGradeBook` = @k ", db.GetConnection()); //створення команди
            sqlCommand.Parameters.AddWithValue("@k", students.NumberGradebook);
            db.OpenConnection();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(); //оголошення адаптера для звязку з БД
            sqlDataAdapter.SelectCommand = sqlCommand; //встановлення команди
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table); //заповнення таблиці
            if (table.Rows.Count == 1) //перевірка кількості рядків таблиці
            {
                return false;
            }
            db.CloseConnection();
            return true;
        }  

        public static void AddStudents(Students students)
        {
            DataBase db = new DataBase();

            if (!CheckNumberGradebook(students))
            {
                MessageBox.Show("Користувач із таким номером залікової книжки уже є у базі данних!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                MySqlCommand command = 
                    new MySqlCommand("INSERT INTO `students` (`Fullname`, `NumberGradeBook`, `Specialty`, `Group`, `GPU`, `Curator`) " +
                        "VALUES (@f, @n, @s, @g, @gp, @c)",db.GetConnection());
                command.Parameters.AddWithValue("@f", students.Fullname);
                command.Parameters.AddWithValue("@n", students.NumberGradebook);
                command.Parameters.AddWithValue("@s", students.Specialty);
                command.Parameters.AddWithValue("@g", students.Group);
                command.Parameters.AddWithValue("@gp", students.GPU);
                command.Parameters.AddWithValue("@c", students.Curator);
                db.OpenConnection();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Show(DataGridView dataGridView)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `students`", dataBase.GetConnection());
            dataBase.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView.DataSource = table;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.CloseConnection();
        }

        public static void UpdateStudents(string key, Students students)
        {
            DataBase db = new DataBase();

            try
            {
                MySqlCommand command = 
                    new MySqlCommand("UPDATE `students` SET `Fullname`= @f,`NumberGradeBook`= @n,`Specialty`= @s,`Group`= @g,`GPU`= @gp,`Curator`= @c " +
                        "WHERE `students`.`NumberGradeBook`= @k",db.GetConnection());
                command.Parameters.AddWithValue("@f", students.Fullname);
                command.Parameters.AddWithValue("@n", students.NumberGradebook);
                command.Parameters.AddWithValue("@s", students.Specialty);
                command.Parameters.AddWithValue("@g", students.Group);
                command.Parameters.AddWithValue("@gp", students.GPU);
                command.Parameters.AddWithValue("@c", students.Curator);
                command.Parameters.AddWithValue("@k", key);
                db.OpenConnection();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteStudents(string key)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE  FROM students WHERE `NumberGradeBook` = @k", db.GetConnection());
            command.Parameters.AddWithValue("@k", key);
            db.OpenConnection();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.CloseConnection();
        }

        public static void FindStudents(string key, bool check, DataGridView dataGridView)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            if (!check) //змінна check перевіряє по якому параметру ми шукаємо ,якщо true ,то по ПІБ ,якщо false , то по групі
            {
                command = new MySqlCommand("SELECT * FROM `students` WHERE `Fullname` REGEXP (@k) ", db.GetConnection());
            }
            else
            {
                command = new MySqlCommand("SELECT * FROM `students` WHERE `Group` REGEXP (@k) ", db.GetConnection());

            }
            command.Parameters.AddWithValue("@k", key);
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView.DataSource = table;
            db.CloseConnection();
        }

        public static void SortStudents(int index, DataGridView dataGridView)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();

            switch (index)
            {
                case 0:
                    command = new MySqlCommand("SELECT * FROM `students` ORDER BY `GPU` DESC; ", db.GetConnection());
                    break;
                case 1:
                    command = new MySqlCommand("SELECT * FROM `students` ORDER BY `GPU`; ", db.GetConnection());
                    break;
                case 2:
                    command = new MySqlCommand("SELECT * FROM `students` ORDER BY `Fullname`; ", db.GetConnection());
                    break;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.OpenConnection();
            dataGridView.DataSource = table;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.CloseConnection();
        }

        public static string AvgGpu(string group)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT AVG (`GPU`) FROM `students` WHERE `Group`= @k", db.GetConnection());
            command.Parameters.AddWithValue("@k", group);
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string gpu = table.Rows[0][0].ToString();
            db.CloseConnection();
            return gpu;
        }

        public static string CountStudentsInGroup(string group)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(`GPU`) FROM `students` WHERE `Group`= @k", db.GetConnection());
            command.Parameters.AddWithValue("@k", group);
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string gpu = table.Rows[0][0].ToString();
            db.CloseConnection();
            return gpu;
        }

        public static double[] MinMaxGPU(string group)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            command = new MySqlCommand("SELECT MIN(`GPU`) FROM `students` WHERE `Group`= @k", db.GetConnection());
            command.Parameters.AddWithValue("@k", group);
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string min = table.Rows[0][0].ToString();
            double res1 = Convert.ToDouble(min);
            command = new MySqlCommand("SELECT MAX(`GPU`) FROM `students` WHERE `Group`= @k", db.GetConnection());
            command.Parameters.AddWithValue("@k", group);
            db.OpenConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table2);
            string max = table2.Rows[0][0].ToString();
            double res2 = Convert.ToDouble(max);
            db.CloseConnection();
            return new double[] { res1, res2 };
        }

    }
}
