using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TImer_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;
            timer1.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            int guess = Convert.ToInt16(txtguessnumber.Text);
            int result = Convert.ToInt16(lblresult.Text);
            if (result == guess)
            {
                lblMessage.Text = "Sl tea oun mnak !";
            }
            else
            {
                lblMessage.Text = "Som meta muy !";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //get value form Random
            Random rnd = new Random();
            int num = rnd.Next(0,100);
            lblresult.Text = num.ToString();
        }
    }
}
