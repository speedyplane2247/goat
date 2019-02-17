using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpVisualGoat
{
    public partial class Form1 : Form
    {
        private int DataYes;
        private string Data;
        private MessageBox MessageBox1;
        public Form1()
        {
            InitializeComponent();
            DataYes = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
             DataYes = 1;
            try
            {
                Data = "This is some cool test data. This file should be 17,408 long!";
            } catch
            {
                MessageBox.Show("Failed to get data!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                label2.Text = Data;
            }
            catch
            {
                MessageBox.Show("Failed to show data! Maybe it doesn't exist?");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This file should be 17,408 long."); // no file size change?? owo; also sammy sux jk ily
        }
    }
}
