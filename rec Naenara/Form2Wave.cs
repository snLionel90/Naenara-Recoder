using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rec_Naenara
{
    public partial class Form2Wave : Form
    {
        public Form2Wave()
        {
            InitializeComponent();     
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            waveViewer1.SamplesPerPixel = 450;
            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);

            chart1.Series.Add("wave");
            chart1.Series["wave"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chart1.Series["wave"].ChartArea = "ChartArea1";

            NAudio.Wave.WaveChannel32 wave = new NAudio.Wave.WaveChannel32(new NAudio.Wave.WaveFileReader(open.FileName));

            byte[] buffer = new byte[16384];
            int read = 0;

            while (wave.Position < wave.Length)
            {
                read = wave.Read(buffer, 0, 16384);

                for (int i = 0; i < read / 4; i++)
                {
                    chart1.Series["wave"].Points.Add(BitConverter.ToSingle(buffer, i * 4));
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wave Analyzer is parto of Naenara Voice Recorder (c) sn.Lionel90");  
        }

        private void btn_play_Click(object sender, EventArgs e)
        {

        }

    }
}
