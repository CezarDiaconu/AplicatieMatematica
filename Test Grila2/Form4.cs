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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            methodX();
        }


        int cal = 0;

        public void methodX()
        {
            Random rand = new Random();
            int first_value = rand.Next(100, 500);
            int second_value = rand.Next(100, 500);

            int calculate = first_value + second_value;

            cal = calculate;
            label1.Text = first_value + " + " + second_value + " = ?"  ; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (Int32.Parse(x).Equals(cal))
            {
                MessageBox.Show("Raspunsul tau este corect!");
                methodX();
            }
            else
            {
                MessageBox.Show("Raspunsul tau este gresit!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
