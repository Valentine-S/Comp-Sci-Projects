using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGame
{
    public partial class Form8 : Form
    {
        int timeLeft;
        string PlayerName;

        public Form8()
        {
            InitializeComponent();
            Quiz();
        }

        public void Quiz()
        {

            player1Name.Text = Program.Name.name1;
            player2Name.Text = Program.Name.name2;

            player1Score.Text = Program.Global.score1.ToString();
            player2Score.Text = Program.Global.score2.ToString();


            if (Program.Global.Player == true)
            {
                PlayerName = Program.Name.name1;
            }
            if (Program.Global.Player == false)
            {
                PlayerName = Program.Name.name2;
            }

            currentPlayer.Text = PlayerName;


            Random random = new Random();
            int rand1 = random.Next(1, 1);

            switch (rand1)
            {
                case 1:
                    QuestionLabel.Text = ("Question 1 Topic 2.");
                    Choice1Label.Text = ("A");//Corect answer
                    Choice2Label.Text = ("B");
                    Choice3Label.Text = ("C");
                    Choice4Label.Text = ("D");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;



                default:
                    this.Hide();
                    var form = new Form();
                    form.Closed += (s, args) => this.Close();

                    Form4 f4 = new Form4();
                    f4.ShowDialog(); // Shows Form4;
                    break;

            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left 
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft + " seconds";
            }
            else
            {
                if (Program.Global.Player == true)
                {
                    Program.Global.Player = false;

                    timer1.Stop();

                    timerLabel.Text = "Times's up!";
                    MessageBox.Show("You Didn't Finish in Time!");

                    this.Hide();
                    var form = new Form();
                    form.Closed += (s, args) => this.Close();

                    Form4 f4 = new Form4();
                    f4.ShowDialog(); // Shows Form4;
                }

                if (Program.Global.Player == false)
                {
                    Program.Global.Player = true;

                    timer1.Stop();

                    timerLabel.Text = "Times's up!";
                    MessageBox.Show("You Didn't Finish in Time!");

                    this.Hide();
                    var form = new Form();
                    form.Closed += (s, args) => this.Close();

                    Form4 f4 = new Form4();
                    f4.ShowDialog(); // Shows Form4;
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            {
                Program.Global.test = 1;
                string temp = Program.Global.test.ToString();
            }
            if (numericUpDown1.Value == 2)
            {
                Program.Global.test = 2;
                string temp = Program.Global.test.ToString();
            }
            if (numericUpDown1.Value == 3)
            {
                Program.Global.test = 3;
                string temp = Program.Global.test.ToString();
            }
            if (numericUpDown1.Value == 4)
            {
                Program.Global.test = 4;
                string temp = Program.Global.test.ToString();
            }

            if (Program.Global.test == Program.Global.y)
            {
                if (Program.Global.Player == true)
                {
                    Program.Global.score1++;
                }
                else
                {
                    Program.Global.score2++;
                }

                timer1.Stop();

                this.Hide();
                var form = new Form();
                form.Closed += (s, args) => this.Close();

                Form8 f8 = new Form8();
                f8.ShowDialog();
            }
            else
            {
                if (Program.Global.Player == true)
                {
                    Program.Global.Player = false;

                    timer1.Stop();

                    this.Hide();
                    var form = new Form();
                    form.Closed += (s, args) => this.Close();

                    Form4 f4 = new Form4();
                    f4.ShowDialog(); // Shows Form4;

                }
                else
                {
                    Program.Global.Player = true;

                    timer1.Stop();

                    this.Hide();
                    var form = new Form();
                    form.Closed += (s, args) => this.Close();

                    Form4 f4 = new Form4();
                    f4.ShowDialog(); // Shows Form4;
                }
            }

        }
    }
}
