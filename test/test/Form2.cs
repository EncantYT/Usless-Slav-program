using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\xenca\Music\Cheeki breeki.wav");
            soundPlayer.Play();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/PlLQsUGefdo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We got you western spy!!!");
            MessageBox.Show("System is shutting down in 3 seconds!");
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            this.Close();
            Form1 F1 = new Form1();
            F1.Close();
            Application.Exit();
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\xenca\Music\Cheeki breeki.wav");
            soundPlayer.Stop();
        }
    }
}
