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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class historyts : Form
    {
        public historyts()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string vin = vinname.Text;
            string connectionString = @"Data Source=DESKTOP-L4MDOV1\SQLEXPRESS;Initial Catalog=гбдд;Integrated Security=True";
            string querty = @"select * from [dbo].[peredacha_ts] where [VIN]='" + vin + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(querty, connection);
                // Создаем объект DataSet
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            button3.Visible = true;
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            bd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            photo photo = new photo();
            string path = "";
            string namePhoto = "";
            string photoPath = "";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    namePhoto = openFileDialog1.FileName;
                    path = @"D:\kovalenko_yp\WindowsFormsApp1\bin\";
                    FileInfo file = new FileInfo(namePhoto);
                    photoPath = file.Name;
                    path += photoPath;
                    FileInfo file2 = new FileInfo(path);
                    if (file2.Exists == false)
                    {
                        file.CopyTo(path);
                    }
                    MessageBox.Show("Файл записан!");
                }
                //передача данных в другую форму
                photo.pictureBox1.Image = Image.FromFile(path);
                photo.label3.Text = path;
                photo.label6.Text = photoPath;
                photo.label5.Text = vinname.Text;
                photo.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка, повторите попытку позже");
            }


        }
    }
}
