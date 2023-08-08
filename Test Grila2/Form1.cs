using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Test_Grila2
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        public Form1()
        {
            InitializeComponent();
            player.URL = "musicmp3.mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Show();
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

        private void Algebra_MouseHover(object sender, EventArgs e)
        {
            Algebra.BackColor = Color.Red;
        }

        private void Algebra_MouseLeave(object sender, EventArgs e)
        {
            Algebra.BackColor = Color.OliveDrab;
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
    }
}
