using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text.ToString().ToUpper().CompareTo("HELLO WORLD") == 0)
                this.button1.Text = "Hello Dell";
            else
                this.button1.Text = "Hello World";

            MessageBox.Show("Clicked button1!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hello World22222222";
        }
    }
}
