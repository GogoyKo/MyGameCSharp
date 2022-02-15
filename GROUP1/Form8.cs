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
    public partial class Form8 : Form
    {
        int second = 5;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form8()
        {
            InitializeComponent();
            player.SoundLocation = "yeah.wav";
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            player.Play();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Start();
            label1.Text = second.ToString();
            second = second - 1;
            if (second == -1)
            {
                this.Close();
                Form f1 = new Form1();
                f1.Show();

                MessageBox.Show("PLAY AGAIN???");
            }
        }
    }
}
