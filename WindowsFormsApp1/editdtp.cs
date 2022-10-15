using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class editdtp : Form
    {
        string path;
        string photo;
        public editdtp()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string namePhoto = openFileDialog1.FileName;
                path = @"D:\kovalenko_yp\WindowsFormsApp1\bin\";
                FileInfo file = new FileInfo(namePhoto);
                photo = file.Name;
                path += photo;
                FileInfo file2 = new FileInfo(path);
                if (file2.Exists == false)
                {
                    file.CopyTo(path);
                }
                MessageBox.Show("Файл записан!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtp dtp = new dtp();
            dtp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classif = comboBox1.Text;
            string fio = textBox1.Text;
            string vy = textBox2.Text;
            string mesto = textBox3.Text;
            string nomer = textBox4.Text;
            string info = textBox5.Text;
            string gertv = textBox6.Text;
            string date = datebrth.Value.ToShortDateString();
            try
            {
                string connectionString = @"Data Source=DESKTOP-L4MDOV1\SQLEXPRESS;Initial Catalog=гбдд;Integrated Security=True";
                string querty = @"insert into [dbo].[дтп] ([классификация], [фио], [ву], [место проишествия], [номера], [другие объекты], [кол-во жертв], [дата], [фото]) values ('" +
                    classif + "', '" + fio + "', '" + vy + "', '" + mesto + "', '" + nomer + "', '" + info + "', '" + gertv + "', '" + date + "', '" + photo + "')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sql = new SqlDataAdapter(querty, connection);
                    DataSet ds = new DataSet();
                    sql.Fill(ds);
                }
                MessageBox.Show("Данные успешно загруженны!");
            }
            catch
            {
                MessageBox.Show("Проверьте, заполнены ли все поля");
            }
            

        }
    }
}
