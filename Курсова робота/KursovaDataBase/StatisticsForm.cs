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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        List<string> groups_name = new List<string>();
        List<double> groups_gpu = new List<double>();

        List<string> students = new List<string>();
        List<double> studets_gpu = new List<double>();

        private void ParseDataGroups()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `students`", db.GetConnection()); //знаходимо усіх студентів
            db.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table); //заповнюємо таблицю
            for (int i = 0; i < table.Rows.Count; i++) //проходимось по усій таблиці і шукаємо рядок з групою студента
            {
                if (groups_name.Contains(table.Rows[i][3])) //якщо група уже знаходиться в домогіжному лісті продовжуємо
                    continue;
                else
                    groups_name.Add(table.Rows[i][3].ToString()); //якщо ні ,то добаляємо групу
            }
            //в результаті маємо заповнений ліст з усіма групами які є у таблиці студентів
            db.CloseConnection();
        }
        private void ParseDataStudents_GPU(string group)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command = new MySqlCommand("SELECT * FROM `students` WHERE `Group` REGEXP (@k) ", db.GetConnection());
            command.Parameters.AddWithValue("@k", group);
            db.OpenConnection();
            adapter = new MySqlDataAdapter();
            table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                students.Add(table.Rows[i][0].ToString()); //заповнення ліста студентів групи
                studets_gpu.Add(Convert.ToDouble(table.Rows[i][4])); //заповнення ліста оцінок студента
            }
            db.CloseConnection();  
        }
        private void BuildStatictics() 
        {
            ParseDataGroups();
            foreach (var i in groups_name)
            {
                var AvgGpu = Students.AvgGpu(i);
                groups_gpu.Add(Convert.ToDouble(AvgGpu));
            }
            for (int i = 0; i < groups_gpu.Count; i++)
            {
                chart1.Series[0].Points.AddXY(groups_name[i], groups_gpu[i]);
            }
            groups_name.Clear();
            groups_gpu.Clear();
        }


        private void Statictics_btn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
           
            if (radioButton1.Checked)
            {
                BuildStatictics();
            }
            if (radioButton2.Checked)
            {
                string key = textBox1.Text;
                string temp = Students.AvgGpu(key);
                if (temp == string.Empty)
                {
                    MessageBox.Show("Немає інформації про дану групу!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ParseDataStudents_GPU(key);
                gpu_label.Text = temp;
                double[] min_max = Students.MinMaxGPU(key);
                min_mark_label.Text = min_max[0].ToString();
                max_mark_label.Text = min_max[1].ToString();
                countstudent.Text = Students.CountStudentsInGroup(key);
                for (int i = 0; i < students.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(students[i], studets_gpu[i]);
                }
                students.Clear();
                studets_gpu.Clear();
            }
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            BuildStatictics();
        }
    }
}
