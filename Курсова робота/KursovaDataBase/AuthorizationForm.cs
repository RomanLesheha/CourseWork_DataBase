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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private int Count = 3;
        private void Login_btn_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Password = textBox2.Text;
            var diametr = Password.Length / 2;
            if (Password.Length == 0)
            {
                diametr = 5;
            }
            var encryptedMessageByPass = ScytaleCipher.Encrypt(Password, diametr);
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            command = new MySqlCommand("SELECT * FROM `staff` WHERE `Password` LIKE @p AND `Name` LIKE @l ", db.GetConnection());
            command.Parameters.AddWithValue("@p", encryptedMessageByPass);
            command.Parameters.AddWithValue("@l", Login);
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            if (Count <= 1)
            {
                MessageBox.Show("Забагато спроб", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (dataTable.Rows.Count == 0)
            {
                Count--;
                label4.Text = Count.ToString();
                MessageBox.Show("Ви ввели неправильний пароль чи логін", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataBase.СonfirmedUser = true;
                MessageBox.Show("Вас авторизовано , тепер ви маєте доступ до всього функціоналу!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            db.CloseConnection();
        }

        private void AddNewStaff()
        {
            string Login = textBox1.Text;
            string Password = textBox2.Text;
            var diametr = Password.Length / 2;
            var encryptedMessageByPass = ScytaleCipher.Encrypt(Password, diametr);
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `staff` (`Password`, `Name`) VALUES (@rt, @qw);", db.GetConnection());
            command.Parameters.AddWithValue("@rt", encryptedMessageByPass);
            command.Parameters.AddWithValue("@qw", Login);

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

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                if (textBox2.UseSystemPasswordChar)
                {
                    textBox2.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox2.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
