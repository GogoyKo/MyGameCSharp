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
    public partial class Form7 : Form
    {
        bool jump;
        int Force;
        int Force2;
        int Force3;
        int Force4;
        int Force5;
        int Force6;
        int Force7;
        int Force8;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
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
                Force6 -= 2;
            }

            pi7.Top -= Force7;
            if (jump == false)
            {
                Force7 -= 2;
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
                pictureBox2.Visible = false;


            }
            if (pi2.Top <= pi2.Height)
            {
                pi2.Top = pi2.Height - pi2.Height;
                Force2 = +0;
                pictureBox1.Visible = false;
            }
            if (pi3.Top <= pi3.Height)
            {
                pi3.Top = pi3.Height - pi3.Height;
                Force3 = +0;
                pictureBox3.Visible = false;
            }
            if (pi4.Top <= pi4.Height)
            {
                pi4.Top = pi4.Height - pi4.Height;
                Force4 = +0;
                pictureBox4.Visible = false;
            }

            if (pi5.Top <= pi5.Height)
            {
                pi5.Top = pi5.Height - pi5.Height;
                Force5 = +0;
                pictureBox5.Visible = false;
            }
            if (pi6.Top <= pi6.Height)
            {
                pi6.Top = pi6.Height - pi6.Height;
                Force6 = +0;
                pictureBox6.Visible = false;
            }

            if (pi7.Top <= pi7.Height)
            {
                pi7.Top = pi7.Height - pi7.Height;
                Force7 = +0;
                pictureBox7.Visible = false;
            }
            if (pi8.Top <= pi8.Height)
            {
                pi8.Top = pi8.Height - pi8.Height;
                Force8 = +0;
                pictureBox8.Visible = false;
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

            if (pi.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }


            if (pi2.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }
            if (pi3.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }

            if (pi4.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }


            if (pi5.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }

            if (pi6.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }
            if (pi7.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }
            if (pi8.Location.Y > 500)
            {

                timer1.Stop();

                MessageBox.Show("adad");
            }
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
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
                Force7 = 8;
            }
            if (e.KeyCode == Keys.H)
            {
                pi8.Top -= Force8;
                Force8 = 8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form f8 = new Form8();
            f8.Show();
            this.Hide();
        }

       
    }
}
