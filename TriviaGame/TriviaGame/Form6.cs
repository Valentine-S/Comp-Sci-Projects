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
    public partial class Form6 : Form
    {
        int timeLeft;
        string PlayerName;

        public Form6()
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
                    QuestionLabel.Text = ("What company invented floppy disc?");
                    Choice1Label.Text = ("Apple");
                    Choice2Label.Text = ("Microsoft");
                    Choice3Label.Text = ("IBM");//Correct answer answer
                    Choice4Label.Text = ("Nvidia");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 2:
                    QuestionLabel.Text = ("What is the first domain name ever registered?");
                    Choice1Label.Text = ("WorldWideWeb.com");
                    Choice2Label.Text = ("Symboloc.com");//Correct answer answer
                    Choice3Label.Text = ("Me.com");
                    Choice4Label.Text = ("Google.com");
                    Program.Global.y = 2;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 3:
                    QuestionLabel.Text = ("In what year was the Chevrolet Chevelle first produced?");
                    Choice1Label.Text = ("1964");//Correct answer answer
                    Choice2Label.Text = ("1999");
                    Choice3Label.Text = ("2003");
                    Choice4Label.Text = ("1925");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 4:
                    QuestionLabel.Text = ("Which company is the largest producer of software for PC?");
                    Choice1Label.Text = ("Microsoft");//Correct answer answer
                    Choice2Label.Text = ("Apple");
                    Choice3Label.Text = ("IBM");
                    Choice4Label.Text = ("Linux");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 5:
                    QuestionLabel.Text = ("What is CPU?");
                    Choice1Label.Text = ("Computer Programming Unit");
                    Choice2Label.Text = ("Central Processing Unit");//Correct answer answer
                    Choice3Label.Text = ("Central Placement Unit");
                    Choice4Label.Text = ("Computer Processing Unit");
                    Program.Global.y = 2;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 6:
                    QuestionLabel.Text = ("What is RAM?");
                    Choice1Label.Text = ("Random Access Memory");//Correct answer answer
                    Choice2Label.Text = ("Routing Automatic Memory");
                    Choice3Label.Text = ("Recycled Automated Memory");
                    Choice4Label.Text = ("Rad Auto Memory");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 7:
                    QuestionLabel.Text = ("The first computer mouse was constructed in 1964 with what material?");
                    Choice1Label.Text = ("Metal");
                    Choice2Label.Text = ("Rubber ");
                    Choice3Label.Text = ("Wood ");//Correct answer answer
                    Choice4Label.Text = ("Plastic");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 8:
                    QuestionLabel.Text = ("What company invented floppy disc?");
                    Choice1Label.Text = ("Apple");
                    Choice2Label.Text = ("Microsoft");
                    Choice3Label.Text = ("IBM");//Correct answer answer
                    Choice4Label.Text = ("Nvidia");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 9:
                    QuestionLabel.Text = ("Approximately how many domain names are registered every month? (2014)");
                    Choice1Label.Text = ("200000");
                    Choice2Label.Text = ("600000");
                    Choice3Label.Text = ("1 Million");//Correct answer answer
                    Choice4Label.Text = ("200 Million");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 10:
                    QuestionLabel.Text = ("Approximately how many web pages are on the internet today? ( As of 2014)");
                    Choice1Label.Text = ("1 Billion");
                    Choice2Label.Text = ("5 Billion");
                    Choice3Label.Text = ("10 Billion");
                    Choice4Label.Text = ("20 Billion");//Correct answer answer
                    Program.Global.y = 4;

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

                Form6 f6 = new Form6();
                f6.ShowDialog();
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


/*
 * 
 * 
 * public partial class Form5 : Form
    {

        int timeLeft;
        string PlayerName;


        public Form5()
        {
            InitializeComponent();
            StartTheQuiz();
        }

        public void StartTheQuiz()
        {
            
            player1Name.Text = Program.Name.name1;
            player2Name.Text = Program.Name.name2;
            Program.Global.score1 = "0";
            Program.Global.score2 = "0";
            player1Score.Text = Program.Global.score1;
            player2Score.Text = Program.Global.score2;
            Program.Global.Player = "1";

            if (Program.Global.Player == "1")
            {
                PlayerName = Program.Name.name1;
            }
            if (Program.Global.Player == "2")
            {
                PlayerName = Program.Name.name2;
            }

                currentPlayer.Text = PlayerName;


                timeLeft = 30;
                timerLabel.Text = "30 Seconds";
                timer1.Start();
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timerLabel.Text = timeLeft + " seconds";
        }
    }
}
 * 
 * 
 * 
 */
