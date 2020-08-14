using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCqB0MvFA4uKdZHx6sXZeAzg?sub_confirmation=1");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                  MessageBox.Show("Please enter a password!");
            }
            else if (textBox1.Text == "Vadim Blyat!")
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("The password that you provided is wrong blyat!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
              

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
