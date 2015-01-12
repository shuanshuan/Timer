using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class WA : Form
    {
        public WA()
        {
            InitializeComponent();
        }

        private void WA_Load(object sender, EventArgs e)
        {
            nuHour.Maximum = 12;
            nuHour.Value = 0;

            nuMinute.Maximum = 59;
            nuMinute.Value = 40;

            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.ShowDialog();

            this.ShowInTaskbar = true;
            this.Show();
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.lbMsg.Text = "";
            
            decimal time =1;
            if (rbRange.Checked) {
               time = nuMinute.Value * 60000 + nuHour.Value * 3600000 ;
            }
            else 
            {
                
                double current = DateTime.Now.TimeOfDay.TotalMilliseconds;
                double f = timePicker.Value.TimeOfDay.TotalMilliseconds;
                time = (decimal)(f - current);   
            }

            if (time > 0)
            {

                timer1.Interval = (int)time;

                timer1.Start();

                this.ShowInTaskbar = false;
                this.Hide();
            }
            else if (rbRange.Checked)
            {
                this.lbMsg.Text = "Time gap is less than 1 second!";
            }
            else {
                this.lbMsg.Text = "Time is not a future time!";
            }
      
        }

    

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            
            this.Show();
        }

        private void WA_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) {

                this.ShowInTaskbar = false;
                this.Hide();          
            }


        }

        private void lbMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
