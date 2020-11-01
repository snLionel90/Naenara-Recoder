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
            this.label2 = new System.Windows.Forms.Label();
            this.ldlRec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.LinkLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_save = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.btn_record = new System.Windows.Forms.PictureBox();
            this.microphone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Recording";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Play";
            // 
            // ldlRec
            // 
            this.ldlRec.AutoSize = true;
            this.ldlRec.Location = new System.Drawing.Point(15, 19);
            this.ldlRec.Name = "ldlRec";
            this.ldlRec.Size = new System.Drawing.Size(13, 13);
            this.ldlRec.TabIndex = 7;
            this.ldlRec.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(15, 44);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(127, 18);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "Recording: 00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stop and Save";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(242, 268);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "CLOSE";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblURL
            // 
            this.lblURL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(242, 221);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(267, 31);
            this.lblURL.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(164, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(345, 194);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // btn_save
            // 
            this.btn_save.Image = global::rec_Naenara.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(88, 221);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 70);
            this.btn_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_save.TabIndex = 9;
            this.btn_save.TabStop = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_play
            // 
            this.btn_play.Image = global::rec_Naenara.Properties.Resources.play;
            this.btn_play.Location = new System.Drawing.Point(164, 221);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(70, 70);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_play.TabIndex = 2;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_record
            // 
            this.btn_record.Image = global::rec_Naenara.Properties.Resources.Record;
            this.btn_record.Location = new System.Drawing.Point(12, 221);
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
            this.microphone.Location = new System.Drawing.Point(12, 69);
            this.microphone.Name = "microphone";
            this.microphone.Size = new System.Drawing.Size(146, 146);
            this.microphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.microphone.TabIndex = 0;
            this.microphone.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 321);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.ldlRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.microphone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recorder";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microphone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox microphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ldlRec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox btn_record;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel lblURL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

