using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        int count_up = 0;
        int count_down = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            l_up.Text = count_up.ToString();
            l_down.Text = count_down.ToString();
        }

        private void b_up_Click(object sender, EventArgs e)
        {
            count_up++;
            l_up.Text = count_up.ToString();
        }
        private void b_down_Click(object sender, EventArgs e)
        {
            count_down++;
            l_down.Text = count_down.ToString();
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int num_r = r.Next(0, 2);
            if(num_r == 1)
            {
                p_this.BackColor = p_green.BackColor;
            }
            else
            {
                p_this.BackColor = p_red.BackColor;
            }

            p_this.Height = r.Next(2, 200);
            p_this.Width = r.Next(2, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count_down = 0;
            count_up = 0;

            l_down.Text = count_down.ToString();
            l_up.Text = count_up.ToString();
        }
    }
}
