using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaDataBase
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=students");

        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        static public bool СonfirmedUser = false;

        public static void DeleteDataBase(bool students_db)
        {
            
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            if (students_db)
                command = new MySqlCommand("TRUNCATE `students`", db.GetConnection());
            else
                command = new MySqlCommand("TRUNCATE `teachers`", db.GetConnection());
           
            db.OpenConnection();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("База данних успішно очищена", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.CloseConnection();
            
           
        }
    }
}
