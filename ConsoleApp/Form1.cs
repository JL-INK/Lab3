using System;
using System.Windows.Forms;

namespace ConsoleHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
