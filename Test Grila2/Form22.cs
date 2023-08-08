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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Matrice_Click(object sender, EventArgs e)
        {
            Form221 f2 = new Form221();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form222 f2 = new Form222();
            f2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form223 f2 = new Form223();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form224 f2 = new Form224();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form225 f2 = new Form225();
            f2.Show();
        }

        private void Matrice_MouseHover(object sender, EventArgs e)
        {
            Matrice.BackColor = Color.Red;
        }

        private void Matrice_MouseLeave(object sender, EventArgs e)
        {
            Matrice.BackColor = Color.OliveDrab;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.OliveDrab;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.OliveDrab;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.OliveDrab;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.OliveDrab;
        }
    }
}
