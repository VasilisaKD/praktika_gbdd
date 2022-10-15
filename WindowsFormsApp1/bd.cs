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

namespace WindowsFormsApp1
{
    public partial class bd : Form
    {
        public bd()
        {
            InitializeComponent();
        }

        private void bd_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
            string sql = "SELECT * FROM drivers";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver driver = new driver();
            driver.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            editvy editvy = new editvy();
            editvy.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showvy showvy = new showvy();
            showvy.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addtransport addtransport = new addtransport();
            addtransport.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            historyts historyts = new historyts();
            historyts.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dtp dtp = new dtp();
            dtp.Show();
            this.Hide();
        }
    }
}
