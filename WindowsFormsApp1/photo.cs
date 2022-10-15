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
    public partial class photo : Form
    {
        string flip;
        Bitmap bitmap1;
        string path;
        public photo()
        {
            InitializeComponent();
        }
        private void InitializeBitmap()
        {
            try
            {
                bitmap1 = (Bitmap)Bitmap.FromFile(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = bitmap1;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the bitmap.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            InitializeBitmap();
            switch (flip)
            {
                case "1":
                    if (bitmap1 != null)
                    {
                        bitmap1.RotateFlip(RotateFlipType.Rotate90FlipY);
                        pictureBox1.Image = bitmap1;
                        flip = "2";
                    }
                    break;
                case "2":
                    if (bitmap1 != null)
                    {
                        bitmap1.RotateFlip(RotateFlipType.Rotate180FlipY);
                        pictureBox1.Image = bitmap1;
                        flip = "3";
                    }
                    break;
                case "3":
                    if (bitmap1 != null)
                    {
                        bitmap1.RotateFlip(RotateFlipType.Rotate270FlipXY);
                        pictureBox1.Image = bitmap1;
                        flip = "4";
                    }
                    break;
                case "4":
                    if (bitmap1 != null)
                    {
                        bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        pictureBox1.Image = bitmap1;
                        flip = "1";
                    }
                    break;
            }
            if (bitmap1 != null)
            {
                bitmap1.RotateFlip(RotateFlipType.Rotate90FlipY);
                pictureBox1.Image = bitmap1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historyts historyts = new historyts();
            historyts.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление в базу
                string nameV = surname.Text + "_" + name.Text + "_" + middlename.Text;
                DateTime date = DateTime.Now;
                string vin = label5.Text;
                string photoN = label6.Text;
                string connectionString = @"Data Source=DESKTOP-L4MDOV1\SQLEXPRESS;Initial Catalog=гбдд;Integrated Security=True";
                string querty = @"insert into [dbo].[peredacha_ts]([vin], [name], [date], [photo]) values ('" +
                    vin + "', '" + nameV + "', '" + date + "', '"+ photoN + "')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sql = new SqlDataAdapter(querty, connection);
                    DataSet dataSet = new DataSet();
                    sql.Fill(dataSet);
                }
                MessageBox.Show("Данные добавлены!");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность заполнения полей", "ОШИБКА");
            }
        }

        private void photo_Load(object sender, EventArgs e)
        {
            path = label3.Text;
            flip = "1";
        }
    }
}
