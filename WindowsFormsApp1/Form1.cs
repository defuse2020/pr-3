using ClassLibrary1;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        AccClass acc;
        class Denga
        {

        }
        public Form1()
        {
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccClass acc = new AccClass(Convert.ToInt32(textBox2.Text), textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc.Add(Convert.ToInt32(textBox3.Text));
            listBox1.Items.Add(acc);
        }
    }
}
