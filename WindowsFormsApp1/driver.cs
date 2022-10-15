using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class driver : Form
    {
        string guidValue;
        string surnameValue;
        string nameValue;
        string middlenameValue;
        string pasportValue;
        string registrationAdressValue;
        string realAdressValue;
        string phoneValue;
        string emailValue;
        string photo;
        string companyValue;
        string jobValue;
        string path;
        public driver()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            bd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var length = new FileInfo(path).Length;
            Regex emailReg = new Regex(@"@");
            Regex emailReg2 = new Regex(@".");
            guidValue = guid.Text;
            surnameValue = surname.Text;
            nameValue = name.Text;
            middlenameValue = middlename.Text;
            pasportValue = pasport.Text;
            registrationAdressValue = registrationAdress.Text;
            realAdressValue = realAdress.Text;
            phoneValue = phone.Text;
            emailValue = email.Text;
            companyValue = company.Text;
            jobValue = job.Text;
            if (emailReg.IsMatch(emailValue) == true&emailReg2.IsMatch(emailValue)==true)
            {
                if (length<2000000)
                {
                    string firstPassport = pasportValue.Substring(0, 4);
                    string secondPassport = pasportValue.Substring(5);
                    nameValue += "_" + surnameValue;
                    string connectionString = @"Server=DESKTOP-L4MDOV1\SQLEXPRESS;Database=гбдд;Trusted_Connection=True;";
                    string sql = @"INSERT INTO drivers([id], [name], [middlename], [passport serial], [passport number], [postcode], [address], [company], [jobname], [phone], [email], [photo]) VALUES ('"
    + guidValue + "', '" + nameValue + "', '" + middlenameValue + "', '" + firstPassport + "', '" + secondPassport + "', '" + registrationAdressValue + "', '" + realAdressValue + "', '" + companyValue + "', '" + jobValue + "', '" + phoneValue + "', '" + emailValue + "', '" + photo + "')";
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
                }
                else MessageBox.Show("Размер изображения должен быть не более 2 мегабайт!");
            }
            else MessageBox.Show("Введите корректный email!");
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
    }
}
