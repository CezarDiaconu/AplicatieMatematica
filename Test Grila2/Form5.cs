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
    public partial class Form5 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions=16;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                //work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quizul s-a terminat!" + Environment.NewLine +
                    "Ai raspuns corect la " + score + " dintre intrebari" + Environment.NewLine +
                    "Procentajul de intrebari la care ai raspuns corect este " + percentage + "&" + Environment.NewLine +
                    "Apasa OK pentru a juca din nou"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Care este cel de-al 10-lea termen al sirului 1,3,5,7...?";

                    button1.Text = "a) 21";
                    button2.Text = "b) 22";
                    button3.Text = "c) 19";
                    button4.Text = "d) 16";

                    correctAnswer = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Pentru o progresie aritmetica suma primilor n termeni ai ei este Sn=5n^2+6n. Sa se determine primul termen a1 si ratia r";

                    button1.Text = "a) 21";
                    button2.Text = "b) 22";
                    button3.Text = "c) 19";
                    button4.Text = "d) 16";

                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Determinati toate valorile lui x care apartine multimii Z pentru care are loc inegalitatea √(3x-11)-7+√x<0";

                    button1.Text = "a) {1,3,4,5,6,7,8}";
                    button2.Text = "b) {1,2,3,4,5,7,8}";
                    button3.Text = "c) {2,3,4,5,6,7,8}";
                    button4.Text = "d) {4,5,6,7,8}";

                    correctAnswer = 4;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se rezolve ecuatia irationala √(1-x^2 )+x=1";

                    button1.Text = "a) x1=0,x2=1";
                    button2.Text = "b) x1=1,x2=2";
                    button3.Text = "c) x1=1,x2=-1";
                    button4.Text = "d) x1=-2,x2=2";

                    correctAnswer = 1;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se rezolve inecuatia 2+3x+√(5x+4)<0";
                    button1.Text = "a) [-4/5;-2/3)";
                    button2.Text = "b) [-4/5;-2/5]";
                    button3.Text = "c) [-4/5;-7/9)";
                    button4.Text = "d) [-3/5;-1/5]";

                    correctAnswer = 3;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se determine x apartine lui R pentru care √(1+x )-√(1-x)=1 ";

                    button1.Text = "a) x=-1";
                    button2.Text = "b) x=-2";
                    button3.Text = "c) x=√3/2";
                    button4.Text = "d) x=-√3/2";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se determine multimea cu x apartine R astfel incat √(x^2-5x+6 )≥√(3-x)  ";

                    button1.Text = "a) (-∞;-1]";
                    button2.Text = "b) [2;+∞)";
                    button3.Text = "c) [1;+∞)";
                    button4.Text = "d) (-∞;1] ∪ {3}";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Precizati care este multimea solutiilor inecuatiei  √(15+5x )-√(13-2x)<=2 ";

                    button1.Text = "a) A=[-109/49;2]";
                    button2.Text = "b) A=[2;13/2]";
                    button3.Text = "c) A=[-3;109/49]";
                    button4.Text = "d) A=[-3;2]";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se determine valorea expresiei E=∛(20+14√(2 )) +∛(20-14√2)  ";

                    button1.Text = "a) 1";
                    button2.Text = "b) 2";
                    button3.Text = "c) 3";
                    button4.Text = "d) 4";

                    correctAnswer = 4;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se determine valorea expresiei E=(9^n-9^(n-1)) )^(1/2)/(〖27^(n-1)-19*27^(n-2)〗^(1/2)), n apartine Z  ";

                    button1.Text = "a) √72";
                    button2.Text = "b) 2";
                    button3.Text = "c) √2*3";
                    button4.Text = "d) 1";

                    correctAnswer = 3;

                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se rezolve ecuatia 2^x-3^x=√(6^x-9^x )  ";

                    button1.Text = "a) x1=0 este unica solutie";
                    button2.Text = "b) x1=0,x2=1/(1-log_2,⁡3)";
                    button3.Text = "c) x1=0,x2=1+log_2,⁡3";
                    button4.Text = "d) x1=0,x2=4";

                    correctAnswer = 2;

                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "La o reuniune de 12 persoane, fiecare a dat mana cu fiecare dintre ceilalti participanti. Cate strangeri de mana au fost date?  ";

                    button1.Text = "a) 132";
                    button2.Text = "b) 66";
                    button3.Text = "c) 12!";
                    button4.Text = "d) 12";

                    correctAnswer = 2;

                    break;


                case 13:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se calculeze valoarea expresiei E=〖((1+i))/((1-i))〗^1996+〖((1-i))/((1+i))〗^1996  ";

                    button1.Text = "a) i";
                    button2.Text = "b) 2";
                    button3.Text = "c) -i";
                    button4.Text = "d) -2";

                    correctAnswer = 2;

                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se determine toate solutiile reale ale ecuatiei √(x+3-4√(x-1)) +√(x+8-6√(x-1)) =1 ";

                    button1.Text = "a) {2,5,10}";
                    button2.Text = "b) [5,10]";
                    button3.Text = "c) {5,10}";
                    button4.Text = "d) [1,5]";

                    correctAnswer = 2;

                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se rezolve inecuatia (〖1/3)〗^√(x+2)>3^(-x)   ";

                    button1.Text = "a) (2,+∞)";
                    button2.Text = "b) (-1,1)";
                    button3.Text = "c) (-2,-1)";
                    button4.Text = "d) (-∞,2)";

                    correctAnswer = 1;

                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Sa se rezolve ecuatia lgx^2+2lgx=2^3 ";

                    button1.Text = "a) x=10";
                    button2.Text = "b) x=100";
                    button3.Text = "c) x=1000";
                    button4.Text = "d) x=1";

                    correctAnswer = 2;

                    break;
            }
        }
    }

}
