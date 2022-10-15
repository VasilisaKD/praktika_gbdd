using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tabledtp : Form
    {
        public tabledtp()
        {
            InitializeComponent();
        }

        private void tabledtp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гбддDataSet.дтп". При необходимости она может быть перемещена или удалена.
            this.дтпTableAdapter.Fill(this.гбддDataSet.дтп);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtp dtp = new dtp();
            dtp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
