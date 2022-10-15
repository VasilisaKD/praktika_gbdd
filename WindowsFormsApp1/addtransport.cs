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
using VIN_LIB;
namespace WindowsFormsApp1
{
    public partial class addtransport : Form
    {
        int times;
        string file;
        int id;
        string fileId;
        public addtransport()
        {
            InitializeComponent();
            file = @"D:\kovalenko_yp\WindowsFormsApp1\bin\colorid.txt";
            string timesChek = File.ReadAllText(file);
            fileId = @"D:\kovalenko_yp\WindowsFormsApp1\bin\id.txt";
            string idCheck = File.ReadAllText(fileId);
            id = Convert.ToInt32(idCheck);
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
        {
           colorDialog1.ShowDialog();
           color.Text = colorDialog1.Color.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vinnameValue = vinname.Text;
            string manufactValue = Manufacturer.Text;
            string modelV = model.Text;
            string typeTrV = type_of_transport.Text;
            string categoriesV = categories.Text;
            string yearV = year.Text;
            string colorV = color.Text;
            string weightV = weight.Text;
            string typeDrV = type_of_drive.Text;
            string engineV = (Engine_type.SelectedIndex+1).ToString();
            string nameValue = name.Text + "_" + surname.Text;
            string querty;
            string connectionString = @"Data Source=DESKTOP-L4MDOV1\SQLEXPRESS;Initial Catalog=гбдд;Integrated Security=True";
            try
            {
                //проверка водителя
                querty = @"select [id] from [dbo].[drivers] where [name]='" + nameValue + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(querty, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                if (dataGridView1[0, 0].Value == null)
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
                    string idV = dataGridView1[0, 0].Value.ToString();
                }

                //проверка цвета и добаление его в таблицу
                querty = @"select [Color num] from [dbo].[car-colors] where [Color code]='" + "#" + colorV + "' or [Color name] ='" + colorV + "' or [Name] ='" + colorV + "'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(querty, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                if (dataGridView1[0, 0].Value == null)
                {
                    querty = @"insert into [dbo].[car-colors] ([Color num], [Color code], [Name]) values ('" + times + "', '" + colorV + "', 'Пользовательский цвет')";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(querty, connection);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    times++;
                    File.WriteAllText(file, times.ToString());
                }
                string idColorV = dataGridView1[0, 0].Value.ToString();

                //проверка номера и запись в таблицу
                VIN vinBib = new VIN();
                bool check = vinBib.CheckVIN(vinnameValue);
                if (check == false) MessageBox.Show("Проверьте правильность написания VIN номера");
                else
                {
                    querty = @"select * from [dbo].[transport] where [VIN]='" + vinnameValue + "'";
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
                    if (dataGridView1[0, 0].Value != null)
                    {
                        DialogResult result = MessageBox.Show("Такой VIN номер уже создан, хотите получить о нём информацию?", "", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show(dataGridView1[0, 0].Value.ToString() + " " + dataGridView1[1, 0].Value.ToString() + " " + dataGridView1[3, 0].Value.ToString() + " "
                                + dataGridView1[4, 0].Value.ToString() + " " + dataGridView1[5, 0].Value.ToString() + " " + dataGridView1[6, 0].Value.ToString() + " " + dataGridView1[7, 0].Value.ToString() + " " +
                                dataGridView1[8, 0].Value.ToString() + " " + dataGridView1[9, 0].Value.ToString() + " " + dataGridView1[10, 0].Value.ToString() + " " + dataGridView1[11, 0].Value.ToString() + " " + dataGridView1[12, 0].Value.ToString());
                        }
                    }
                    else
                    {
                        querty = @"insert into [dbo].[transport] ([id], [VIN], [Manufacturer], [Model], [Year], [Weight], [Color], [Engine Type], [type of drive], [categories], [type of transport]) values ('" +
                            id + "', '" + vinnameValue + "', '" + manufactValue + "', '" + modelV + "', '" + yearV + "', '" + weightV + "', '" + idColorV + "', '" + engineV + "', '" +
                            typeDrV + "', '" + categoriesV + "', '" + typeTrV + "')";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Создаем объект DataAdapter
                            SqlDataAdapter adapter = new SqlDataAdapter(querty, connection);
                            // Создаем объект DataSet
                            DataSet ds = new DataSet();
                            // Заполняем Dataset
                            adapter.Fill(ds);
                        }
                        MessageBox.Show("Транспортное средство записано!");
                        id++;
                        File.WriteAllText(fileId, id.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте, заполнены ли все поля на форме.", "ОШИБКА");
            }
           
        }
    }
}
