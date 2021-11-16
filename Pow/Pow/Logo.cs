using System;
using System.Windows.Forms;

namespace Pow
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
            timerOpac.Start();
        }

        private void timerOpac_Tick(object sender, System.EventArgs e)
        {
            if (Opacity == 1)
            {
                timer.Start();
                timerOpac.Stop();
            }
            else
            {
                Opacity += 0.01;
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
            timer.Stop();
        }
    }
}
