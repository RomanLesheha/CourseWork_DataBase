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
    public partial class AddTeachersForm : Form
    {
        public AddTeachersForm()
        {
            InitializeComponent();
        }
        private bool CheckTextBox()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox)item).Text == string.Empty)
                    {
                        MessageBox.Show("Ввeдіть усю інформацію");
                        ((TextBox)item).Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                return;
            }

            try
            {
                Teachers teachers = new Teachers(textBox1.Text.Trim(), Department_comboBox.SelectedItem.ToString(), Position_comboBox.SelectedItem.ToString(), richTextBox1.Text, textBox3.Text, textBox2.Text);
                Teachers.AddTeacher(teachers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                return;
            }
            try
            {
                Teachers teachers = new Teachers(textBox1.Text, Department_comboBox.SelectedItem.ToString(), Position_comboBox.SelectedItem.ToString(), richTextBox1.Text, textBox3.Text, textBox2.Text);
                Teachers.UpdateTeacher(Teachers.Key, teachers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }

        private void AddTeachersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
