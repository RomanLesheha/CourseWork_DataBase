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
    class Teachers
    {
        public string FullName { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        public string Disciplines { get; set; }

        public string Degree { get; set; }

        public string Groups { get; set; }

        public static string Key { get; set; }

        public Teachers(string fullName, string department, string position, string disciplines, string degree, string groups)
        {
            FullName = fullName;
            Department = department;
            Position = position;
            Disciplines = disciplines;
            Degree = degree;
            Groups = groups;
        }
        private static bool CheckTeacher(Teachers teachers)
        {
            DataBase db = new DataBase();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `teachers` WHERE `Fullname` = @f ", db.GetConnection());
            sqlCommand.Parameters.AddWithValue("@f", teachers.FullName);
            db.OpenConnection();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                return false;
            }
            db.CloseConnection();
            return true;
        }

        public static void AddTeacher(Teachers teachers)
        {
            if (!CheckTeacher(teachers))
            {
                MessageBox.Show("Такий викладач уже є у базі данних!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `teachers` (`FullName`, `Department`, `Position`, `Disciplines`, `Degree`, `Groups`) VALUES (@f, @d , @p , @di, @de ,@g)", db.GetConnection());
            command.Parameters.AddWithValue("@f", teachers.FullName);
            command.Parameters.AddWithValue("@d", teachers.Department);
            command.Parameters.AddWithValue("@p", teachers.Position);
            command.Parameters.AddWithValue("@di", teachers.Disciplines);
            command.Parameters.AddWithValue("@de", teachers.Degree);
            command.Parameters.AddWithValue("@g", teachers.Groups);
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

        public static void Show(DataGridView dataGridView)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teachers`", dataBase.GetConnection());
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

        public static void UpdateTeacher(string Key, Teachers teachers)
        {
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("UPDATE `teachers` SET `FullName` = @f, `Department` = @d, `Position` = @p, `Disciplines` = @di, `Degree` = @de , `Groups` = @g WHERE `teachers`.`Fullname` = @k;", db.GetConnection());
            command.Parameters.AddWithValue("@f", teachers.FullName);
            command.Parameters.AddWithValue("@d", teachers.Department);
            command.Parameters.AddWithValue("@p", teachers.Position);
            command.Parameters.AddWithValue("@di", teachers.Disciplines);
            command.Parameters.AddWithValue("@de", teachers.Degree);
            command.Parameters.AddWithValue("@g", teachers.Groups);
            command.Parameters.AddWithValue("@k", Key);

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

        public static void DeleteTeacher(string key)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("DELETE FROM teachers WHERE `teachers`.`FullName` = @k", db.GetConnection());
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

        public static void FindTeacher(string key, bool check, DataGridView dataGridView)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            if (!check)
            {
                command = new MySqlCommand("SELECT * FROM `teachers` WHERE `FullName` REGEXP (@k) ", db.GetConnection());
            }
            else
            {
                command = new MySqlCommand("SELECT * FROM `teachers` WHERE `Groups` REGEXP (@k) ", db.GetConnection());

            }
            command.Parameters.AddWithValue("@k", key);
            db.OpenConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView.DataSource = table;
            db.CloseConnection();
        }

        public static void FindTeacher(string key , DataGridView dataGridView)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            command = new MySqlCommand("SELECT * FROM `teachers` WHERE `FullName` REGEXP (@k) ", db.GetConnection());
            command.Parameters.AddWithValue("@k", key);
            db.OpenConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView.DataSource = table;
            db.CloseConnection();
        }

        public static void SortTeacher(int index, DataGridView dataGridView)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();

            switch (index)
            {
                case 0:
                    command = new MySqlCommand("SELECT * FROM `teachers` ORDER BY `FullName`; ", db.GetConnection());
                    break;
                case 1:
                    command = new MySqlCommand("SELECT * FROM `teachers` ORDER BY `Department`; ", db.GetConnection());
                    break;
                case 2:
                    command = new MySqlCommand("SELECT * FROM `teachers` ORDER BY `Position`; ", db.GetConnection());
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
    }
}
