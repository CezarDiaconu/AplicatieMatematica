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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form381 f2 = new Form381();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form382 f2 = new Form382();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form383 f2 = new Form383();
            f2.Show();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.OliveDrab;
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
    }
}
