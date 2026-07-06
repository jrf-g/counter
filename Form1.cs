using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CounterWinForms
{
    public partial class Form1 : Form
    {
        private uint counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            num.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                num.Text = counter.ToString();
            } else {
                MessageBox.Show("The counter is unable to compute signed integers", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = 0;
            num.Text = counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num_Click(object sender, EventArgs e)
        {

        }
    }
}
