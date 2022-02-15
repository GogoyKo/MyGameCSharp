using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GROUP1
{
    public partial class Form9 : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        public Form9()
        {
            InitializeComponent();
            player2.SoundLocation = "sniper.wav";
        }

     

    

        private void Form9_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Form9_MouseEnter(object sender, EventArgs e)
        {
           
          
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            label1.BringToFront();
            button1.BringToFront();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            label2.BringToFront();
            button1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
            player2.Play();
        }

        private void Form9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }

        
    }
}
