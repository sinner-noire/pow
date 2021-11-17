using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using static Memory;
using static Spammer;

namespace Pow
{
    public partial class Main : Form
    {
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys ArrowKeys);
        public void checkThread()
        {
            while (true)
            {
                if (!sethandle("ClassiCube"))
                {
                    Environment.Exit(0);
                }
            }
        }
        public void psThread()
        {
            while (true)
            {
                if (psFlag)
                {
                    svpacketspam();
                }
            }
        }    
        public void flThread()
        {
            while (true)
            {
                if (flFlag)
                {
                    Random randomizer = new Random();
                    int i = randomizer.Next(1, 50);
                    if (i == 4)
                    {
                        write<float>((int)ccAdd + fPosX, flpos.x--);
                        write<float>((int)ccAdd + fPosX, flpos.x++);
                    }
                    else if (i == 25)
                    {
                        write<float>((int)ccAdd + fPosZ, flpos.z--);
                        write<float>((int)ccAdd + fPosZ, flpos.z++);
                    }
                }
                Thread.Sleep(25);
            }
        }
        public void fl2Thread()
        {
            while (true)
            {
                flpos = PlayerPos;
                Thread.Sleep(1000);
            }
        }
       
        public static IntPtr ccAdd = (IntPtr)0;
        public static bool psFlag = false;
        public static bool flFlag = false;
        public static Vec3 flpos;

        public Main()
        {
            InitializeComponent();
            try
            {
                sethandle("ClassiCube");
                Console.WriteLine("Process: 0x" + prochandle);
                setmodule("ClassiCube", "ClassiCube.exe", out ccAdd);
                if (ccAdd != (IntPtr)0)
                {
                    Thread checkThread_ = new Thread(checkThread);
                    Thread psThread_ = new Thread(psThread);
                    Thread flThread_ = new Thread(flThread);
                    Thread fl2Thread_ = new Thread(fl2Thread);
                    Console.WriteLine("CC: 0x" + ccAdd);
                    timerOpac.Start();
                    checkThread_.Start();
                    flThread_.Start();
                    fl2Thread_.Start();
                    psThread_.Start();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void EMouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void EMouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void EMouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void checkBoxReach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReach.Checked)
            {
                write<float>((int)ccAdd + 0x25CCE8, 35f);
            }
            else
            {
                write<float>((int)ccAdd + 0x25CCE8, 5f);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Self destruct
            write<float>((int)ccAdd + 0x25CCE8, 5f);
            write<bool>((int)ccAdd + 0x25CD13, false);
            write<bool>((int)ccAdd + 0x25CD12, false);
            psFlag = false;
            Environment.Exit(0);
        }

        private void checkBoxFly_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFly.Checked)
            {
                write<bool>((int)ccAdd + 0x25CD13, true);
            }
            else
            {
                write<bool>((int)ccAdd + 0x25CD13, false);
            }
        }

        private void checkBoxNoclip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoclip.Checked)
            {
                write<bool>((int)ccAdd + 0x25CD12, true);
            }
            else
            {
                write<bool>((int)ccAdd + 0x25CD12, false);
            }
        }

        private void checkBoxFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFPS.Checked)
            {
                write<int>((int)ccAdd + 0x9FCF4, 6);
            }
            else
            {
                write<int>((int)ccAdd + 0x9FCF4, 64);
            }
        }

        private void checkBoxCrash_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrash.Checked)
            {
                pos = PlayerPos;
                pos2 = ViewPos;
                psFlag = true;
            }
            else
            {
                psFlag = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerOpac_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timerOpac.Stop();
            }
            else
            {
                Opacity += 0.01;
            }
        }

        private void checkBoxFakelag_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFakelag.Checked)
            {
                flFlag = true;
            }
            else
            {
                flFlag = false;
            }
        }
    }
}
