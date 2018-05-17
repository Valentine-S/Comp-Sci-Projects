using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGame
{
    static class Program
    {
        public static class Global
        {
            public static int score1 = 0;
            public static int score2 = 0;
            public static bool Player = true;
            public static int test = 0;
            public static int y; //Correct Answer Choice
        }

        public static class Name
        {
            public static string name1;
            public static string name2;
            
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
