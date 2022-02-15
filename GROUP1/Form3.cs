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
    public partial class Form3 : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        bool jump;
        int Force;
        int Force2;
        public Form3()
        {
            InitializeComponent();
            player2.SoundLocation = "sniper.wav";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pi2.Top -= Force2;

            if (jump == false)
            {
                Force2 -= 6;
            }


            pi.Top -= Force;
            if (jump == false)
            {
                Force -= 2;
            }

            if (pi.Top <= pi.Height)
            {
                pi.Top = pi.Height - pi.Height;
                Force = +0;
                pi.Visible = false;

                label2.Visible = false;

                pictureBox2.Visible = true;
            }
            if (pi2.Top <= pi2.Height)
            {
                pi2.Top = pi2.Height - pi2.Height;
                Force2 = +0;
                label1.Visible = false;
                pictureBox1.Visible = true;
                pi2.Visible = false;

            }
            if (pi.Top <= pi.Height)
                if (pi2.Top <= pi2.Height)
                {
                    button1.Visible = true;
                   
                      
                          
                              
                          

                }

            if (pi.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }


            if (pi2.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }

        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();

         

            if (e.KeyCode == Keys.Up)
            {
                pi.Top -= Force;

                Force = 8;
            }



          
            if (e.KeyCode == Keys.Space)
            {
                pi2.Top -= Force2;
                Force2 = 8;
            }

            if (e.KeyCode == Keys.Escape)
            {
                Form f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            button1.Visible = false;
            timer1.Stop();
            panel1.Visible = false;
        }

     

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            player2.Play();
            Form f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void pi2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            player2.Play();
            Form f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2.Play();
            Form f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
