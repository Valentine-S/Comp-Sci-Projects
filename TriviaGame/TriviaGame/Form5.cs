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
    public partial class Form5 : Form
    {

        int timeLeft;
        string PlayerName;


        public Form5()
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
                    QuestionLabel.Text = ("General Motors Was founded in which city?");
                    Choice1Label.Text = ("Flint, MI");//Correct answer
                    Choice2Label.Text = ("Detroit, MI");
                    Choice3Label.Text = ("Tuscon, Arizona");
                    Choice4Label.Text = ("Clevland, Ohio");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 2:
                    QuestionLabel.Text = ("The vehicle manufacturer Volvo was founded in what country?");
                    Choice1Label.Text = ("Sweden");//Correct answer
                    Choice2Label.Text = ("Germany");
                    Choice3Label.Text = ("Italy");
                    Choice4Label.Text = ("USA");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 3:
                    QuestionLabel.Text = ("The first generation of the Chevrolet Corvette was introduced in what year?");
                    Choice1Label.Text = ("1953");//Correct answer
                    Choice2Label.Text = ("1966");
                    Choice3Label.Text = ("1994");
                    Choice4Label.Text = ("1913");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 4:
                    QuestionLabel.Text = ("Porsche is a brand of car that originated in what country?");
                    Choice1Label.Text = ("Germany");//Correct answer
                    Choice2Label.Text = ("Poland");
                    Choice3Label.Text = ("Russia");
                    Choice4Label.Text = ("Sweden");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 5:
                    QuestionLabel.Text = ("In what year was the Chevrolet Chevelle first produced?");
                    Choice1Label.Text = ("1964");//Correct answer
                    Choice2Label.Text = ("1999");
                    Choice3Label.Text = ("2003");
                    Choice4Label.Text = ("1925");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 6:
                    QuestionLabel.Text = ("When found on a vehicle’s speedometer, what do the letters MPH stand for?");
                    Choice1Label.Text = ("Miles Per Hour");//Correct answer
                    Choice2Label.Text = ("Meters Per Hour");
                    Choice3Label.Text = ("Miles Per HorsePower");
                    Choice4Label.Text = ("Minutes Per Horse");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 7:
                    QuestionLabel.Text = ("What do the letters “PT” stand for in the name of Chrysler’s family car, the PT Cruiser?");
                    Choice1Label.Text = ("Personal Transport");//Correct answer
                    Choice2Label.Text = ("Personal Trainer");
                    Choice3Label.Text = ("Physical Training");
                    Choice4Label.Text = ("Properly Tested");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 8:
                    QuestionLabel.Text = ("In most modern vehicles, the carburetor has been replace with what?");
                    Choice1Label.Text = ("Fuel Injection");//Correct answer
                    Choice2Label.Text = ("Air Intake");
                    Choice3Label.Text = ("Brake Pads");
                    Choice4Label.Text = ("Alternator");
                    Program.Global.y = 1;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 9:
                    QuestionLabel.Text = ("What is generally considered to be the first ''pony car''?");
                    Choice1Label.Text = ("Pontiac FireBird");
                    Choice2Label.Text = ("Mercury Cougar");
                    Choice3Label.Text = ("Ford Mustang");//Correct answer
                    Choice4Label.Text = ("Chevy Comaro");
                    Program.Global.y = 3;

                    timeLeft = 30;
                    timerLabel.Text = "30 Seconds";
                    timer1.Start();
                    break;

                case 10:
                    QuestionLabel.Text = ("What was the first Japanese car to be produced in the United States?");
                    Choice1Label.Text = ("Honda Accord");//Correct answer
                    Choice2Label.Text = ("Mazda Miata");
                    Choice3Label.Text = ("Toyota Camry");
                    Choice4Label.Text = ("Nissan Maxima");
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

                Form5 f5 = new Form5();
                f5.ShowDialog();
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
