﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace rec_Naenara
{
    public partial class Form1 : Form
    {
        private Thread cpuThread;
        private Double cpuArray;
        public Form1()
        {
            InitializeComponent();
            lblURL.Text = "https://github.com/snLionel90/";
        }
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetrno, int MciRetrnoLeng, IntPtr Callback);
        string record = "";

        private void btn_record_Click(object sender, EventArgs e)
        {
            //Recording at PCM Line 16bits 44.1Khz 1536kbps
            mciSendString("open new type waveaudio alias Som", null, 0, IntPtr.Zero);
            mciSendString("record Som", null, 0, IntPtr.Zero);
            ldlRec.Text = "Recording at PCM Line 16bits 44.1Khz 1536kbps";
            ldlRec.ForeColor = System.Drawing.Color.Red;
            microphone.Image = Properties.Resources.Micro;
            btn_record.Image = Properties.Resources.Recordoff;
            timer1.Start();
            cd.Start();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (record == "")
            {
                btn_play.Image = Properties.Resources.noplay;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "wave |*.wav";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    record = ofd.FileName;
                }
                mciSendString("play " + record, null, 0, IntPtr.Zero);
                ldlRec.Text = "Playing";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            mciSendString("stop Som", null, 0, IntPtr.Zero);
            ldlRec.Text = "Recorded";
            microphone.Image = Properties.Resources.MicroOff;
            btn_record.Image = Properties.Resources.Record;
            timer1.Stop();
            cd.Stop();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "wave |*.wav";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mciSendString("save Som" + sfd.FileName, null, 0, IntPtr.Zero);
                mciSendString("close Som", null, 0, IntPtr.Zero);
                ldlRec.Text = "Saved";
            }

        }
        System.Diagnostics.Stopwatch cd = new System.Diagnostics.Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = cd.Elapsed;
            label_time.Text = "Duration : " + string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours),
                elapsed.TotalMinutes, elapsed.TotalSeconds);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
