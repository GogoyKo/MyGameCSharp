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
    public partial class Form2 : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer();
        int second = 1;
        bool right, left;
        bool jump;
        int G = 65;
        int Force;
        public Form2()
        {
            InitializeComponent();
            player2.SoundLocation = "sniper.wav";
            player3.SoundLocation = "tada......wav";
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; } // controller
            if (e.KeyCode == Keys.Left) { left = true; }// controller
            if (e.KeyCode == Keys.Escape)
            {
                Form f1 = new Form1();
                f1.Show();
                this.Close();
            }


            if (jump != true) // para dli maka double jump or pila ka jump sa taas.. XD
            {
                if (e.KeyCode == Keys.Space)
                {

                    jump = true;
                    Force = G;
                }

            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; } // connectado sa JUMP na timer
            if (e.KeyCode == Keys.Left) { left = false; }// connectado sa JUMP na timer
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) { pi.Left += 10; } // para sa Form1_KeyUp
            if (left == true) { pi.Left -= 10; } // para sa Form1_KeyUp



            if (jump == true) // para sa amback
            {
                pi.Top -= Force;
                Force -= 13;
            }

            if (pi.Top >= screen.Height) // para mag pundo and player sa bottom sa screen
            {
                pi.Top = screen.Height + 25;
                jump = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
          
        }

        

        private void timer1_Tick_1(object sender, EventArgs e) //para sa pa move////////////////
        {
            if (right == true) { pi.Left += 10; } // para sa Form1_KeyUp
            if (left == true) { pi.Left -= 10; } // para sa Form1_KeyUp



            if (jump == true) // para sa amback
            {
                pi.Top -= Force;
                Force -= 13;
            }

            if (pi.Top >= screen.Height) // para mag pundo and player sa bottom sa screen
            {
                pi.Top = screen.Height + 25;
                jump = false;
            }

            if (second == 50){ timer2.Interval = +120;}//////
            if (second == 100){ timer2.Interval = +115;}/////
            if (second == 300){timer2.Interval = +110;}/////////
            if (second == 500){timer2.Interval = +100;}///////////
            if (second == 700){timer2.Interval = +95;}////////////////// pakusog sa  dagan// 
            if (second == 900){timer2.Interval = +85;}//////////
            if (second == 100){timer2.Interval = +70;}///////
            if (second == 2000){timer2.Interval = +60;}/////
            if (second == 3000){timer2.Interval = +50;}////

            if (pi.Location.X < -1){ pi.Location = new Point(0, 270);} // para dli mulapas ang player sa right//
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

            pictureBox1.Left -= 8;
            Random md = new Random();

            int s = md.Next(1, 4);
            if (pictureBox1.Location.X < -60 && s == 1)
            {
                pictureBox1.Location = new Point(700, 260);

            }
            if (pictureBox1.Location.X < -60 && s == 2)
            {
                pictureBox1.Location = new Point(700, 235);

            }
            if (pictureBox1.Location.X < -60 && s == 3)
            {
                pictureBox1.Location = new Point(700, 250);

            }

            pictureBox2.Left -= 8;
            Random me = new Random();

            int a = md.Next(1, 4);
            if (pictureBox2.Location.X < -60 && a == 1)
            {
                pictureBox2.Location = new Point(900, 210);

            }
            if (pictureBox2.Location.X < -60 && a == 2)
            {
                pictureBox2.Location = new Point(900, 260);

            }
            if (pictureBox2.Location.X < -60 && a == 3)
            {
                pictureBox2.Location = new Point(900, 206);

            }


            pictureBox3.Left -= 8;
            Random mq = new Random();

            int z = md.Next(1, 4);
            if (pictureBox3.Location.X < -60 && z == 1)
            {
                pictureBox3.Location = new Point(1000 ,206);

            }
            if (pictureBox3.Location.X < -60 && z == 2)
            {
                pictureBox3.Location = new Point(1000, 235);

            }
            if (pictureBox3.Location.X < -60 && z == 3)
            {
                pictureBox3.Location = new Point(1000, 206);

            }

            pictureBox4.Left -= 8;
            Random mc = new Random();

            int x = md.Next(1, 4);
            if (pictureBox4.Location.X < -60 && x == 1)
            {
                pictureBox4.Location = new Point(1200, 225);

            }
            if (pictureBox4.Location.X < -60 && x == 2)
            {
                pictureBox4.Location = new Point(1200, 211);

            }
            if (pictureBox4.Location.X < -60 && x == 3)
            {
                pictureBox4.Location = new Point(1200, 213);

            }





            if (pictureBox18.Left >= -50)
            {
                pictureBox18.Left = pictureBox18.Left - 10;

            }
            else
            {
                pictureBox18.Left = 0;
            }

         


         
          
          
        }

        private void timer3_Tick_1(object sender, EventArgs e) // para sa banga///////////////////
        {
            if (pi.Right > pictureBox1.Left && pi.Left < pictureBox1.Right && pi.Bottom > pictureBox1.Top)
            {
                timer1.Stop();
                timer3.Stop();
                timer2.Stop();
                label4.Text = label5.Text;
                label5.Hide();
                panel1.Show();
                label4.Show();
                panel1.Show();
                player3.Play();
            }

            if (pi.Right > pictureBox2.Left && pi.Left < pictureBox2.Right && pi.Bottom > pictureBox2.Top)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                label4.Text = label5.Text;
                label5.Hide();
                panel1.Show();
                label4.Show();
                panel1.Show();
                player3.Play();
            }


            if (pi.Right > pictureBox3.Left && pi.Left < pictureBox3.Right && pi.Bottom > pictureBox3.Top)
            {
                timer1.Stop();
                timer2.Stop();
                 timer3.Stop();
                 label5.Hide();
                label4.Text = label5.Text;

                panel1.Show();
                label4.Show();
                panel1.Show();
                player3.Play();
            }
            if (pi.Right > pictureBox4.Left && pi.Left < pictureBox4.Right && pi.Bottom > pictureBox4.Top)
            {
                timer1.Stop();
                timer2.Stop();
                 timer3.Stop();
                label4.Text = label5.Text;
                label5.Hide();
                panel1.Show();
                label4.Show();
                panel1.Show();
                player3.Play();
            }


         
            }
            private void pictureBox5_Click(object sender, EventArgs e)
            {timer3.Stop();}

            private void label2_Enter(object sender, EventArgs e)
            {
                Form f2 = new Form2();
                f2.Show();
                this.Close();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                player2.Play();
                Form f2 = new Form2();
                f2.Show();
                this.Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                player2.Play();
                Form f1 = new Form1();
                f1.Show();
                this.Close();
            }

            private void button1_Enter(object sender, EventArgs e)
            {
                
            }

            private void timer4_Tick(object sender, EventArgs e)
            {
                label5.Text = second.ToString();
                second = second + 1;
           
            }

            private void label4_Click(object sender, EventArgs e)
            {
                player2.Play();

               
            }

            private void label3_Click(object sender, EventArgs e)
            {
                player2.Play();
            }

            
    }
}
