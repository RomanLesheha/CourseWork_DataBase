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
    public partial class AddStudentsForm : Form
    {
        public AddStudentsForm()
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
        private void Change_btn_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                return;
            }
            try
            {
                int Specialty = Convert.ToInt32(Specialty_comboBox.SelectedItem);
                Students students = new Students(textBox1.Text, textBox2.Text, Specialty, textBox3.Text, Convert.ToDouble(textBox4.Text), textBox5.Text);
                Students.UpdateStudents(Students.key, students);
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox())
            {
                return;
            }
            try
            {
                int Specialty = Convert.ToInt32(Specialty_comboBox.SelectedItem);
                Students students = new Students(textBox1.Text.Trim(), textBox2.Text.Trim(), Specialty, textBox3.Text.Trim(), Convert.ToDouble(textBox4.Text), textBox5.Text.Trim());
                Students.AddStudents(students);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string str = textBox4.Text;
            if (str.Contains("."))
            {
                string s = str.Replace(".", ",");
                textBox4.Clear();
                textBox4.AppendText(str.Replace(".", ","));

            }
        }
    }
}
