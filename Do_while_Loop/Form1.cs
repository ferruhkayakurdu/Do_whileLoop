using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_while_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0; //If we enter a number greater than 15 here instead of int i = 0, it will be executed at least once. This is the difference between the while loop and the while loop.
            do
            {
              listBox1.Items.Add("Hello World");
                i++;

            }
            while (i<=15);
        }
    }
}
