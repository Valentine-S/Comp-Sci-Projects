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
    public partial class Form9 : Form
    {
        int timeLeft;
        string PlayerName;

        public Form9()
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
            int rand1 = random.Next(1, 11);

            switch (rand1)
            {
                case 1:
                    QuestionLabel.Text = ("What Chicago Bears running back was known as ''The Galloping Ghost'' ? ");
                    Choice1Label.Text = ("Harold Grange");//Correct answer
                    Choice2Label.Text = ("Jim Brown");
                    Choice3Label.Text = ("Walter Payton");
                    Choice4Label.Text = ("Gale Sayers");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 2:
                    QuestionLabel.Text = ("What pitcher holds the record for most complete games in an MLB career?");
                    Choice1Label.Text = ("Cy Young");//Correct answer
                    Choice2Label.Text = ("Nolan Ryan ");
                    Choice3Label.Text = ("Don Sutton");
                    Choice4Label.Text = ("Roy Halladay");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 3:
                    QuestionLabel.Text = ("What was the biggest margin of victory ever in a Triple Crown race?");
                    Choice1Label.Text = ("31 Lengths");//Correct answer
                    Choice2Label.Text = ("25 Lengths");
                    Choice3Label.Text = ("12 Lengths");
                    Choice4Label.Text = ("18 Lengths");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 4:
                    QuestionLabel.Text = ("What coach came off the bench to play for his team in the Stanley Cup finals?");
                    Choice1Label.Text = ("Wayne Gretzky");
                    Choice2Label.Text = ("Dick Irvin");
                    Choice3Label.Text = ("Toe");
                    Choice4Label.Text = ("Lester Patrik");//Correct answer
                    Program.Global.y = 4;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 5:
                    QuestionLabel.Text = ("What NFL player returned a fumble 66 yards--to the wrong end zone?");
                    Choice1Label.Text = ("Deion Sanders");//Correct answer
                    Choice2Label.Text = ("Deltha O'Neal");
                    Choice3Label.Text = ("Leon Lett");
                    Choice4Label.Text = ("Jim Marshall");//Correct answer
                    Program.Global.y = 4;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 6:
                    QuestionLabel.Text = ("Who was the only person in NBA history to be named Most Valuable Player, Coach of the Year, and Executive of the Year?");
                    Choice1Label.Text = ("Bill Russel");//Correct answer
                    Choice2Label.Text = ("Phil Jackson");
                    Choice3Label.Text = ("Larry Bird");
                    Choice4Label.Text = ("Michael Jordan");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 7:
                    QuestionLabel.Text = ("Who was the only person in NBA history to be named Most Valuable Player, Coach of the Year, and Executive of the Year?");
                    Choice1Label.Text = ("Bill Russel");
                    Choice2Label.Text = ("Phil Jackson");
                    Choice3Label.Text = ("Larry Bird");//Correct answer
                    Choice4Label.Text = ("Michael Jordan");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 8:
                    QuestionLabel.Text = ("What is the PGA record for highest score on a par-4?");
                    Choice1Label.Text = ("10");//Correct answer
                    Choice2Label.Text = ("16");
                    Choice3Label.Text = ("13");
                    Choice4Label.Text = ("7");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 9:
                    QuestionLabel.Text = ("What country won the first World Cup?");
                    Choice1Label.Text = ("Brazil");//Correct answer
                    Choice2Label.Text = ("Uruguay");
                    Choice3Label.Text = ("Argentina");
                    Choice4Label.Text = ("Switzerland");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 10:
                    QuestionLabel.Text = ("Who hit an underhand serve to defeat Ivan Lendl for the 1989 French Open title?");
                    Choice1Label.Text = ("Mats Wilander");//Correct answer
                    Choice2Label.Text = ("Michael Ghang");
                    Choice3Label.Text = ("Jim Courier");
                    Choice4Label.Text = ("Bjorn Borg");
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

                Form9 f9 = new Form9();
                f9.ShowDialog();
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