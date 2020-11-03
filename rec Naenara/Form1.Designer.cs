namespace rec_Naenara
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ldlRec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.PictureBox();
            this.btn_record = new System.Windows.Forms.PictureBox();
            this.microphone = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.lblURL2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Analyzer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Recording";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldlRec
            // 
            this.ldlRec.AutoSize = true;
            this.ldlRec.BackColor = System.Drawing.Color.Transparent;
            this.ldlRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ldlRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlRec.ForeColor = System.Drawing.Color.IndianRed;
            this.ldlRec.Location = new System.Drawing.Point(215, 8);
            this.ldlRec.Name = "ldlRec";
            this.ldlRec.Size = new System.Drawing.Size(42, 26);
            this.ldlRec.TabIndex = 7;
            this.ldlRec.Text = "-----";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(12, 8);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(197, 27);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "Duration : 00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stop and Save";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(450, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "CLOSE";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Image = global::rec_Naenara.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(88, 265);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 70);
            this.btn_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_save.TabIndex = 9;
            this.btn_save.TabStop = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_record
            // 
            this.btn_record.Image = global::rec_Naenara.Properties.Resources.Record;
            this.btn_record.Location = new System.Drawing.Point(12, 265);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(70, 70);
            this.btn_record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_record.TabIndex = 1;
            this.btn_record.TabStop = false;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // microphone
            // 
            this.microphone.Image = global::rec_Naenara.Properties.Resources.MicroOff;
            this.microphone.Location = new System.Drawing.Point(12, 46);
            this.microphone.Name = "microphone";
            this.microphone.Size = new System.Drawing.Size(222, 213);
            this.microphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.microphone.TabIndex = 0;
            this.microphone.TabStop = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(369, 8);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 19;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // lblURL
            // 
            this.lblURL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(343, 365);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(297, 31);
            this.lblURL.TabIndex = 12;
            // 
            // lblURL2
            // 
            this.lblURL2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblURL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblURL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL2.Location = new System.Drawing.Point(4, 364);
            this.lblURL2.Name = "lblURL2";
            this.lblURL2.Size = new System.Drawing.Size(329, 32);
            this.lblURL2.TabIndex = 24;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(240, 46);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 289);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // btn_Analyzer
            // 
            this.btn_Analyzer.Location = new System.Drawing.Point(531, 8);
            this.btn_Analyzer.Name = "btn_Analyzer";
            this.btn_Analyzer.Size = new System.Drawing.Size(98, 23);
            this.btn_Analyzer.TabIndex = 27;
            this.btn_Analyzer.Text = "Wave Analizer";
            this.btn_Analyzer.UseVisualStyleBackColor = true;
            this.btn_Analyzer.Click += new System.EventHandler(this.btn_Analyzer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(652, 413);
            this.Controls.Add(this.btn_Analyzer);
            this.Controls.Add(this.lblURL2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.ldlRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.microphone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Naenara Voice Recorder (c)sn.Lionel90";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox microphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ldlRec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox btn_record;
        private System.Windows.Forms.PictureBox btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.LinkLabel lblURL;
        private System.Windows.Forms.Label lblURL2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_Analyzer;
    }
}

