using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Queue_Management_Ortega
{
    public partial class VIewForm : Form
    {
        

        public VIewForm()
        {
            InitializeComponent();
            
        }
        bool blink_on = false;
        private void VIewForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            timer1.Start();

            SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\paone\source\repos\Queue Management_Ortega\annc.wav");
            player.Play();



        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData==(Keys.Escape))
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (blink_on)
            {
                lblNowServing.ForeColor = Color.Orange;
                lblNowServing.ForeColor = Color.White;
            }
            else
            {
                lblNowServing.ForeColor = Color.White;
                lblNowServing.ForeColor = Color.Orange;
            }
            blink_on = !blink_on;
            
        }
    }
}
