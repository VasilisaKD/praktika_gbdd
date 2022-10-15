using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class showvy : Form
    {
        public showvy()
        {
            InitializeComponent();
            string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
            string sql = "SELECT * FROM vy";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект DataSet
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            int[] ageName = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020,2021,2022};
            int[] times = {0, 0, 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] arrayAge = new int[500];
            int st = Convert.ToInt32(comboBox1.Text);
            int end = Convert.ToInt32(comboBox2.Text);
            int buf = dataGridView1.Rows.Count-1;
            for (int i = 1; i < buf; i++)
            {

                string buf2 = dataGridView1[5,i].Value.ToString();
                buf2 = buf2.Substring(6,4);
                int age = Convert.ToInt32(buf2);
                if (st <= age & end >= age)
                {
                    arrayAge[j] = age;
                    j++;
                }
            }

            for (int i = 0; i< arrayAge.Length; i++)
            {
                switch (arrayAge[i])
                {
                    case 2010:
                        times[0]++;
                        break;
                    case 2011:
                        times[1]++;
                        break;
                    case 2012:
                        times[2]++;
                        break;
                    case 2013:
                        times[3]++;
                        break;
                    case 2014:
                        times[4]++;
                        break;
                    case 2015:
                        times[5]++;
                        break;
                    case 2016:
                        times[6]++;
                        break;
                    case 2017:
                        times[7]++;
                        break;
                    case 2018:
                        times[8]++;
                        break;
                    case 2019:
                        times[9]++;
                        break;
                    case 2020:
                        times[10]++;
                        break;
                    case 2021:
                        times[11]++;
                        break;
                    case 2022:
                        times[12]++;
                        break;
                }
            }

            for (int i = 0; i < ageName.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(ageName[i].ToString());

                // Add point.
                series.Points.Add(times[i]);
            }

            string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
            string sql = "SELECT * FROM vy where [licence date]>='"+st+ "' and [expire date]<='"+end+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект DataSet
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            bd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showvy_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 12;
        }
    }
}
