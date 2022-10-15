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
    public partial class editvy : Form
    {
        string nameValue;
        string surnameValue;
        string middlenameValue;
        DateTime dateBirth;
        string photo;
        string path;
        string classValue;
        DateTime dateSt;
        DateTime dateE;
        string num;
        string phone;
        string email;
        string firstNum;
        string secondNum;
        public editvy()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            bd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {    try
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
            catch
            {
                MessageBox.Show("Возникла ошибка, повторите попытку позже");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameValue = name.Text;
            surnameValue = surname.Text;
            middlenameValue = middlename.Text;
            dateBirth = datebrth.Value;
            num = address.Text;
            dateE = dateEnd.Value;
            dateSt = dateStart.Value;
            classValue = comboBox1.Text; 
            string nV= nameValue + "_" + surnameValue;
            try
            { 
                string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
                string sqlDriver = @"select [phone], [email] from drivers where [name]='" + nV + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlDriver, connection);
                    // Создаем объект DataSet
                    DataSet ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                if (dataGridView1[0, 0].Value == null & dataGridView1[1, 0].Value == null)
                {
                    DialogResult result = MessageBox.Show("Такой водитель не создан, хотите перейти к созданию водителя?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        driver driver = new driver();
                        driver.Show();
                        this.Hide();
                    }
                }
                else
                {
                    phone = dataGridView1[0, 0].Value.ToString();
                    email = dataGridView1[1, 0].Value.ToString();
                    firstNum = num.Substring(0, 2);
                    firstNum += " " + num.Substring(2, 2);
                    secondNum = num.Substring(4);
                    string sql = @"INSERT INTO vy ([phone], [email], [photo], [licence date], [expire date], [categories], [licence series], [licence number]) VALUES ('"
    + phone + "', '" + email + "', '" + photo + "', '" + dateSt + "', '" + dateE + "', '" + classValue + "', '" + firstNum + "', '" + secondNum + "')";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Создаем объект DataAdapter
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        // Создаем объект DataSet
                        DataSet ds = new DataSet();
                        // Заполняем Dataset
                        adapter.Fill(ds);
                    }
                    MessageBox.Show("Данные успешно записаны!");
                    button5.Visible = true;
                }
            }
            catch 
            {
                MessageBox.Show("Возникла ошибка, проверьте все вводимые данные и попробуйте снова");
            }
            

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
            string sql = "SELECT [address] FROM drivers where [phone]='" + phone + "'";
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
            string a = dataGridView1[0, 0].Value.ToString();

            print print = new print();
            print.surname.Text = surnameValue;
            print.name.Text = nameValue + " " + middlenameValue;
            print.date.Text = dateBirth.Date.ToString();
            print.dateStart.Text = dateSt.Date.ToString();
            print.number.Text = num;
            print.realAdress.Text = "f";
            print.avtoClass.Text = comboBox1.Text;
            print.pictureBox2.Image = Image.FromFile(path);
            print.Show();
            this.Hide();
        }
    }
}
