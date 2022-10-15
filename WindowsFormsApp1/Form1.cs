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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string login;
        string password;
        int times;
        int timertick;
        public Form1()
        {
            InitializeComponent();
            login = "inspector";
            password = "inspector";
            string file = @"D:\kovalenko_yp\WindowsFormsApp1\bin\check.txt";
            string timesChek = File.ReadAllText(file);
            times = Convert.ToInt32(timesChek);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bd bd = new bd();
            string loginCheck = textBox1.Text;
            string passwordCheck = textBox2.Text;
            string file = @"D:\kovalenko_yp\WindowsFormsApp1\bin\check.txt";

            if (login == loginCheck & password == passwordCheck)
            {
                bd.Show();
                this.Hide();
            }
            else
            {
                times--;
                MessageBox.Show($"ОШИБКА!\nПроверьте правильность написания логина/пароля\nУ Вас осталось {times} попытки");

            }
            if (times == 0)
            {
                MessageBox.Show("Вы ввели логин/пароль неправильно 3 раза, подождите 1 минуту");
                timer1.Start();
                timertick = 0;
                File.WriteAllText(file, times.ToString());
            }
            if (timer1.Enabled == true)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                button1.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string file = @"D:\kovalenko_yp\WindowsFormsApp1\bin\check.txt";
            timertick++;
            if (timertick == 60)
            {
                timer1.Stop();
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                button1.Visible = true;
                times = 4;
                File.WriteAllText(file, times.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file = @"D:\kovalenko_yp\WindowsFormsApp1\bin\check.txt";
            if (times == 0)
            {
                MessageBox.Show("Вы ввели логин/пароль неправильно 3 раза, подождите 1 минуту");
                timer1.Start();
                timertick = 0;
                File.WriteAllText(file, times.ToString());
            }
            if (timer1.Enabled == true)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                button1.Visible = false;
            }
        }
    }
}
