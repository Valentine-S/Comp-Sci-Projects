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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();

            Player1.Text = Program.Name.name1;
            Player2.Text = Program.Name.name2;
            S1.Text = Program.Global.score1.ToString();
            S2.Text = Program.Global.score2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
