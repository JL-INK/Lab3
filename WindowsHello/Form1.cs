using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp;
            temp = textBox1.Text;
            if (temp == "")
                textBox2.Text = "Здравствуй, мир!";
            else
                textBox2.Text = "Здравствуй, " + temp + " !";

        }
    }
}
