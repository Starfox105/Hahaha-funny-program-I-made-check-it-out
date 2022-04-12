using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using System.Media;

namespace WindowsFormsApp3
{
    public partial class Pussy : Form
    {
        public Pussy()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = ("/c start chrome.exe https://www.thisworldthesedays.com/relaxorg.html");
            Process.Start(ps);
            System.Threading.Thread.Sleep(400);
            SendKeys.Send("{F11}");
            System.Threading.Thread.Sleep(2000);
            ps.Arguments = ("/c start chrome.exe https://matias.ma/nsfw/");
            Process.Start(ps);
            System.Threading.Thread.Sleep(2000);
            ps.Arguments = ("/c start chrome.exe https://pranx.com/fake-virus/");
            Process.Start(ps);
            //System.Threading.Thread.Sleep(200);
            System.IO.Stream direc = (AUUUUUAGH.Properties.Resources.fuckyou);
            SoundPlayer splay = new SoundPlayer(direc);
            splay.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
