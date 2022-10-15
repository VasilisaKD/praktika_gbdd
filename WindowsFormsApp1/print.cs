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
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showvy vy = new showvy();
            vy.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Bitmap printscreen = new Bitmap(990, 637);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen( this.Left+31, this.Top+42, 0, 0, printscreen.Size);
            printscreen.Save(@"D:\kovalenko_yp\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void print_Load(object sender, EventArgs e)
        {
            editvy editvy = new editvy();


          
        }
    }
}
