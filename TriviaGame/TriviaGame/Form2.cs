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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                Program.Name.name1 = textBox1.Text;
                
                this.Hide();
                var form = new Form();
                form.Closed += (s, args) => this.Close();

                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }
    }
}
