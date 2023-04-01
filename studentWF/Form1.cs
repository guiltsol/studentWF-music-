using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace studentWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            trackBar1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button3.Visible = true;
            trackBar1.Visible = true;
            wmp.URL = "C:/Users/Администратор/source/repos/studentWF/studentWF/stud.mp3";
            wmp.controls.play();
            trackBar1.Value = 0;
            wmp.settings.volume = 0;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 10)
                wmp.settings.volume = 100;
            if (trackBar1.Value == 9)
                wmp.settings.volume = 90;
            if (trackBar1.Value == 8)
                wmp.settings.volume = 80;
            if (trackBar1.Value == 7)
                wmp.settings.volume = 70;
            if (trackBar1.Value == 6)
                wmp.settings.volume = 60;
            if (trackBar1.Value == 5)
                wmp.settings.volume = 50;
            if (trackBar1.Value == 4)
                wmp.settings.volume = 40;
            if (trackBar1.Value == 3)
                wmp.settings.volume = 10;
            if (trackBar1.Value == 2)
                wmp.settings.volume = 6;
            if (trackBar1.Value == 1)
                wmp.settings.volume = 3;
            if (trackBar1.Value == 0)
                wmp.settings.volume = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
        }
    }
}
