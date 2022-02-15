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
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "spongebob.wav";
            player2.SoundLocation = "sniper.wav";
        }

      


        private void timer1_Tick(object sender, EventArgs e)
        {

            button1.Top += 2;
            button2.Top += 2;
            button4.Top += 2;
            button8.Top += 2;
            button9.Top += 2;         
            button5.Top += 2;
            button12.Top += 2;
            button6.Top += 2;
            button10.Top += 2;
            button11.Top += 2;
            button7.Top += 2;

            if (button4.Location.Y > 183) { timer1.Stop(); button3.Visible = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            }

            if (button5.Location.Y < 183) { button5.Left -= 3; }
          

            if (button6.Location.Y < 183) { button6.Left += 3; }


            if (button7.Location.Y < 333) { button7.Top += 2; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            player.Play();
            timer1.Stop();
            timer2.Stop();
           
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            player2.Play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random mw = new Random();
            button7.Location = new Point(button7.Location.X, button7.Location.Y + 11);
            int a = mw.Next(1, 4);
            if (button7.Location.Y > 300 && a == 1)
            {
                button7.Location = new Point(422, -18);
            }
            if (button7.Location.Y > 300 && a == 2)
            {
                button7.Location = new Point(227, -18);
            }
            if (button7.Location.Y > 300 && a == 3)
            {
                button7.Location = new Point(192, 0);
            }
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(258, 201);
            button2.Location = new Point(258, 201);
            button10.Location = new Point(258, 201);
            button11.Location = new Point(258, 201);
            button12.Location = new Point(258, 201);


            button8.Location = new Point(247, 240);
            button9.Location = new Point(247, 284);
           
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {

          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(258, 201);
            button2.Location = new Point(258, 201);
            button8.Location = new Point(258, 201);
            button9.Location = new Point(258, 201);
            button12.Location = new Point(258, 201);



            button10.Location = new Point(454, 240);
            button11.Location = new Point(454, 285);
             button1.Location = new Point(454, 330);
             button2.Location = new Point(454, 375);
           
        
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button12.Location = new Point(40, 242);




            button1.Location = new Point(258, 201);
            button2.Location = new Point(258, 201);
            button8.Location = new Point(258, 201);
            button9.Location = new Point(258, 201);
            button10.Location = new Point(258, 201);
            button11.Location = new Point(258, 201);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(258, 201);
            button2.Location = new Point(258, 201);
            button8.Location = new Point(258, 201);
            button9.Location = new Point(258, 201);       
            button10.Location = new Point(258, 201);
            button11.Location = new Point(258, 201);
            button12.Location = new Point(258, 201);

            button7.Location = new Point(3, 3);
            timer2.Start();



           
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button7_MouseCaptureChanged(object sender, EventArgs e)
        {
          
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player2.Play(); 
            this.Close();
        }

      

     

    
        private void button8_Click(object sender, EventArgs e)
        {
            player2.Play();
            Form f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            player2.Play(); 
            Form f2 = new Form2();
            f2.Show();
            this.Hide();


       

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
          
            Form f9 = new Form9();
            f9.Show();
            this.Hide();
            player2.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

     

     

       

       

   

      

       
    }
}
