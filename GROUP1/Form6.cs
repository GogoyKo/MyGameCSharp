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
    public partial class Form6 : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        bool jump;
        int Force;
        int Force2;
        int Force3;
        int Force4;
        int Force5;
        int Force6;
        int Force7;
        int Force8;
        public Form6()
        {
            InitializeComponent();
            player2.SoundLocation = "sniper.wav";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pi2.Top -= Force2;

            if (jump == false)
            {
                Force2 -= 2;
            }


            pi.Top -= Force;
            if (jump == false)
            {
                Force -= 2;
            }

            pi3.Top -= Force3;
            if (jump == false)
            {
                Force3 -= 6;
            }

            pi4.Top -= Force;
            if (jump == false)
            {
                Force4 -= 6;
            }
            pi5.Top -= Force4;
            if (jump == false)
            {
                Force5 -= 2;
            }
            pi6.Top -= Force6;
            if (jump == false)
            {
                Force6 -= 6;
            }

            pi7.Top -= Force7;
            if (jump == false)
            {
                Force7 -= 6;
            }

            pi8.Top -= Force8;
            if (jump == false)
            {
                Force8 -= 2;
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

            if (pi7.Top <= pi7.Height)
            {
                pi7.Top = pi7.Height - pi7.Height;
                Force7 = +0;
                pi8.Visible = false;
                pi7.Visible = false;

                label7.Visible = false;
            }
            if (pi8.Top <= pi8.Height)
            {
                pi8.Top = pi8.Height - pi8.Height;
                Force8 = +0;
                pictureBox8.Visible = false;
                pi8.Visible = false;

                label8.Visible = false;
            }


            if (pi.Top <= pi.Height)
                if (pi2.Top <= pi2.Height)
                    if (pi3.Top <= pi3.Height)
                        if (pi4.Top <= pi4.Height)
                            if (pi5.Top <= pi5.Height)
                                if (pi6.Top <= pi6.Height)
                                    if (pi7.Top <= pi7.Height)
                                        if (pi8.Top <= pi8.Height)
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
            if (pi7.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }
            if (pi8.Location.Y > 2000)
            {

                timer1.Stop();

                MessageBox.Show("GAME OVER!!!!");
                panel1.Visible = true;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            panel1.Visible = false;
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.A)
            {
                pi3.Top -= Force3;
                Force3 = 8;
            }
            if (e.KeyCode == Keys.V)
            {
                pi4.Top -= Force4;
                Force4 = 8;
            }


            if (e.KeyCode == Keys.Enter)
            {
                pi5.Top -= Force5;
                Force5 = 8;
            }
            if (e.KeyCode == Keys.M)
            {
                pi6.Top -= Force6;
                Force6 = 8;
            }


            if (e.KeyCode == Keys.Y)
            {
                pi7.Top -= Force7;
                Force7 = 6;
            }
            if (e.KeyCode == Keys.H)
            {
                pi8.Top -= Force8;
                Force8 = 6;
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
            Form f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            player2.Play();
            Form f5 = new Form5();
            f5.Show();
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
