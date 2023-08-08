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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Permutari_Click(object sender, EventArgs e)
        {
            Form21 f2 = new Form21();
            f2.Show();
        }

        private void Matrice_Click(object sender, EventArgs e)
        {
            Form22 f2 = new Form22();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 f2 = new Form23();
            f2.Show();
        }

        private void Permutari_MouseHover(object sender, EventArgs e)
        {
            Permutari.BackColor = Color.Red;
        }

        private void Permutari_MouseLeave(object sender, EventArgs e)
        {
            Permutari.BackColor = Color.OliveDrab;
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
