namespace rec_Naenara
{
    partial class Form2Wave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Wave";
            // 
            // waveViewer1
            // 
            this.waveViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.waveViewer1.Location = new System.Drawing.Point(295, 69);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(278, 164);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 29;
            this.waveViewer1.WaveStream = null;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 69);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(263, 166);
            this.chart1.TabIndex = 28;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = "Spectrum";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(153, 12);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 34;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(249, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 33;
            this.buttonExit.Text = "CLOSE";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(348, 12);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(84, 22);
            this.Open.TabIndex = 35;
            this.Open.Text = "Open File";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(57, 11);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(77, 23);
            this.btn_play.TabIndex = 36;
            this.btn_play.Text = "button1";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // Form2Wave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 253);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Name = "Form2Wave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wave Analyzer (naenara Project) Sn.Lionel90";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button btn_play;
    }
}