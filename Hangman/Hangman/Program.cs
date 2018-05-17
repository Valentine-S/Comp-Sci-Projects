using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        public class Global
        {
            public static string Word;
            public static char Guess;
        }
        static void Main(string[] args)
        {
            Start();
            Rand();
            Console.ReadLine();
        }

        static void Start()
        {
            Console.WriteLine("Welcome to Val's Hangman Game");
            Console.WriteLine("Please Press Enter to Begin");
            Console.ReadLine();
        }

        static void Rand()
        {
            int numcorrect = 0;
            int count = 0;
            bool Test = false;
            bool Loop = false;
            Random random = new Random();
            int Rand = random.Next(0, 7);

            string[] words = { "STOP", "TEST", "RUN", "Orange", "HIPPO", "BANANA", "BABOON" }; //This is the list of words, they can easily be changed to what ever is required.
            Global.Word = words[Rand];
            Global.Word = Global.Word.ToUpper();

            Base();

            int NumLetters = Global.Word.Count();
            EmptyLetters(NumLetters);

            char[] PickedWord = Global.Word.ToCharArray();

            for (int j = 0; j < 20; j++)
            {
                int i;
                Test = false;

                if (Loop == true)
                {
                    break;
                }

                Guess();

                for (i = 0; i < Global.Word.Count(); i++)
                {
                    if (Global.Guess == PickedWord[i])
                    {
                        Console.SetCursorPosition((i + 1), 18);
                        Console.Write(Global.Guess);
                        Test = true;
                        numcorrect++;
                    }

                    if (numcorrect == Global.Word.Count())
                    {
                        Win();
                        Loop = true;
                        break;
                    }
                }

                if (Test == false)
                {
                    count++;
                    Console.SetCursorPosition((22 + count), 10);
                    Console.Write(Global.Guess);
                    if (count == 1)
                    {
                        Head();
                        Console.SetCursorPosition(1, (23));
                    }

                    if (count == 2)
                    {
                        Body();
                        Console.SetCursorPosition(1, (23));
                    }

                    if (count == 3)
                    {
                        LeftArm();
                        Console.SetCursorPosition(1, (23));
                    }

                    if (count == 4)
                    {
                        RightArm();
                        Console.SetCursorPosition(1, (23));
                    }

                    if (count == 5)
                    {
                        LeftLeg();
                        Console.SetCursorPosition(1, (23));
                    }
                    if (count == 6)
                    {
                        RightLeg();
                        Console.SetCursorPosition(1, (23));
                        EndGame();
                    }
                }
            }
        }

        static void Guess()
        {
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("Please Input your Guess letter");
            Global.Guess = (char.Parse(Console.ReadLine()));
            Global.Guess = char.ToUpper(Global.Guess);
        }

        static void Base()
        {
            Console.Clear();
            Console.Write("                 Val's Hangman Game");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write(" ");
            Console.Write("|");
            for (int i = 0; i < 14; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");
            for (int j = 0; j < 2; j++)
            {
                Console.Write(" |");
                for (int i = 0; i < 14; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" |");
            }

            for (int i = 0; i < 14; i++)
            {
                Console.Write("-");
            }

        }

        static void EmptyLetters(int Num)
        {
            Console.SetCursorPosition(1, 18);
            while (Num > 0)
            {
                Console.Write("-");
                Num--;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Head()
        {
            Console.SetCursorPosition(15, 6);
            Console.Write("( )");
        }

        static void Body()
        {
            Console.SetCursorPosition(16, 7);
            Console.Write("|");
            Console.SetCursorPosition(16, 8);
            Console.Write("|");
            Console.SetCursorPosition(16, 9);
            Console.Write("|");
            Console.SetCursorPosition(16, 10);
            Console.Write("|");
        }

        static void LeftArm()
        {
            Console.SetCursorPosition(14, 8);
            Console.Write("/ |");
            Console.SetCursorPosition(13, 9);
            Console.Write("/  |");
        }

        static void RightArm()
        {
            Console.SetCursorPosition(17, 8);
            Console.Write(" \\");
            Console.SetCursorPosition(18, 9);
            Console.Write(" \\");
        }

        static void LeftLeg()
        {
            Console.SetCursorPosition(15, 11);
            Console.Write("/");
            Console.SetCursorPosition(14, 12);
            Console.Write("/");
        }

        static void RightLeg()
        {
            Console.SetCursorPosition(17, 11);
            Console.Write("\\");
            Console.SetCursorPosition(18, 12);
            Console.Write("\\");
        }

        static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("You Lost!");
            Console.WriteLine("The Word was " + Global.Word);
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void Win()
        {
            Console.Clear();
            Console.WriteLine("You Won!");
            Console.WriteLine("The Word was " + Global.Word);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}

