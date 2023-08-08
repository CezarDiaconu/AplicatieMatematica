using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Grila2
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form231 f2 = new Form231();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form232 f2 = new Form232();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form233 f2 = new Form233();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form234 f2 = new Form234();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form235 f2 = new Form235();
            f2.Show();
        }

        private void Matrice_Click(object sender, EventArgs e)
        {
            Form236 f2 = new Form236();
            f2.Show();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.OliveDrab;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.OliveDrab;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.OliveDrab;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.OliveDrab;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.OliveDrab;
        }

        private void Matrice_MouseHover(object sender, EventArgs e)
        {
            Matrice.BackColor = Color.Red;
        }

        private void Matrice_MouseLeave(object sender, EventArgs e)
        {
            Matrice.BackColor = Color.OliveDrab;
        }
    }
}
