using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Start();
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
