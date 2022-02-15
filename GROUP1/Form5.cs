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
    public partial class Form5 : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        bool jump;
        int Force;
        int Force2;
        int Force3;
        int Force4;
        int Force5;
        int Force6;
        public Form5()
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
                Force -= 6;
            }

            pi3.Top -= Force3;
            if (jump == false)
            {
                Force3 -= 2;
            }

            pi4.Top -= Force4;
            if (jump == false)
            {
                Force4 -= 2;
            }
            pi5.Top -= Force5;
            if (jump == false)
            {
                Force5 -= 2;
            }
            pi6.Top -= Force6;
            if (jump == false)
            {
                Force6 -= 6;
            }

            if (pi.Top <= pi.Height)
            {
                pi.Top = pi.Height - pi.Height;
                Force = +0;
                pictureBox2.Visible = true;
                pi.Visible = false;

                label1.Visible = false;

            }
            if (pi2.Top <= pi2.Height)
            {
                pi2.Top = pi2.Height - pi2.Height;
                Force2 = +0;
                pictureBox1.Visible = true;
                pi2.Visible = false;

                label2.Visible = false;
            }
            if (pi3.Top <= pi3.Height)
            {
                pi3.Top = pi3.Height - pi3.Height;
                Force3 = +0;
                pictureBox3.Visible = true;
                pi3.Visible = false;

                label3.Visible = false;
            }
            if (pi4.Top <= pi4.Height)
            {
                pi4.Top = pi4.Height - pi4.Height;
                Force4 = +0;
                pictureBox4.Visible = true;
                pi4.Visible = false;

                label4.Visible = false;
            }

            if (pi5.Top <= pi5.Height)
            {
                pi5.Top = pi5.Height - pi5.Height;
                Force5 = +0;
                pictureBox5.Visible = true;
                pi5.Visible = false;

                label5.Visible = false;
            }
            if (pi6.Top <= pi6.Height)
            {
                pi6.Top = pi6.Height - pi6.Height;
                Force6 = +0;
                pictureBox6.Visible = true;
                pi6.Visible = false;

                label6.Visible = false;
            }

            if (pi.Top <= pi.Height)
                if (pi2.Top <= pi2.Height)
                    if (pi3.Top <= pi3.Height)
                        if (pi4.Top <= pi4.Height)
                            if (pi5.Top <= pi5.Height)
                                if (pi6.Top <= pi6.Height)
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
            if (pi3.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }

            if (pi4.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }


            if (pi5.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }

            if (pi6.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }
        
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            panel1.Visible = false;
        }

        private void Form5_KeyDown(object sender, KeyEventArgs e)
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
                Force2 = 5;
            }
            if (e.KeyCode == Keys.A)
            {
                pi3.Top -= Force3;
                Force3 = 5;
            }
            if (e.KeyCode == Keys.V)
            {
                pi4.Top -= Force4;
                Force4 = 8;
            }


            if (e.KeyCode == Keys.Enter)
            {
                pi5.Top -= Force5;
                Force5 = 5;
            }
            if (e.KeyCode == Keys.M)
            {
                pi6.Top -= Force6;
                Force6 = 6;
            }


            if (e.KeyCode == Keys.Escape)
            {
                Form f1 = new Form1();
                f1.Show();
                this.Close();
            }
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            player2.Play();
            Form f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void pi2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            player2.Play();
            Form f4 = new Form4();
            f4.Show();
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
