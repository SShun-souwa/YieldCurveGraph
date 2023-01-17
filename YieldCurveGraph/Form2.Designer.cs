using System.Windows.Forms;

namespace YieldCurveGraph
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.changeYield = new System.Windows.Forms.Button();
            this.changeVi = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.nivi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.DataSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allsq = new System.Windows.Forms.Button();
            this.msq = new System.Windows.Forms.Button();
            this.xmax = new System.Windows.Forms.TextBox();
            this.xmin = new System.Windows.Forms.TextBox();
            this.ymax = new System.Windows.Forms.TextBox();
            this.ymin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ViHvChange = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.startday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nivi)).BeginInit();
            this.SuspendLayout();
            // 
            // changeYield
            // 
            this.changeYield.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeYield.Location = new System.Drawing.Point(25, 10);
            this.changeYield.Name = "changeYield";
            this.changeYield.Size = new System.Drawing.Size(175, 75);
            this.changeYield.TabIndex = 22;
            this.changeYield.Text = "changeYield";
            this.changeYield.UseVisualStyleBackColor = true;
            this.changeYield.Click += new System.EventHandler(this.changeYield_Click);
            // 
            // changeVi
            // 
            this.changeVi.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeVi.Location = new System.Drawing.Point(225, 10);
            this.changeVi.Name = "changeVi";
            this.changeVi.Size = new System.Drawing.Size(175, 75);
            this.changeVi.TabIndex = 23;
            this.changeVi.Text = "changeVi";
            this.changeVi.UseVisualStyleBackColor = true;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.SystemColors.Control;
            this.EXIT.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.EXIT.ForeColor = System.Drawing.Color.OrangeRed;
            this.EXIT.Location = new System.Drawing.Point(625, 10);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(175, 75);
            this.EXIT.TabIndex = 24;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // nivi
            // 
            chartArea1.Name = "ChartArea1";
            this.nivi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.nivi.Legends.Add(legend1);
            this.nivi.Location = new System.Drawing.Point(25, 120);
            this.nivi.Name = "nivi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.nivi.Series.Add(series1);
            this.nivi.Size = new System.Drawing.Size(1296, 723);
            this.nivi.TabIndex = 25;
            this.nivi.Text = "chart1";
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Play.Location = new System.Drawing.Point(1360, 150);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(200, 100);
            this.Play.TabIndex = 26;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Stop.Location = new System.Drawing.Point(1360, 270);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(200, 100);
            this.Stop.TabIndex = 27;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Reset.Location = new System.Drawing.Point(1360, 390);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(200, 100);
            this.Reset.TabIndex = 28;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // DataSet
            // 
            this.DataSet.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.DataSet.Location = new System.Drawing.Point(1360, 510);
            this.DataSet.Name = "DataSet";
            this.DataSet.Size = new System.Drawing.Size(200, 100);
            this.DataSet.TabIndex = 29;
            this.DataSet.Text = "DataSet";
            this.DataSet.UseVisualStyleBackColor = true;
            this.DataSet.Click += new System.EventHandler(this.DataSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 80F);
            this.label1.Location = new System.Drawing.Point(850, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 107);
            this.label1.TabIndex = 30;
            this.label1.Text = "yyyy-mm-dd";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1470, 680);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 19);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(1380, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "表示スピード";
            // 
            // allsq
            // 
            this.allsq.Location = new System.Drawing.Point(1380, 720);
            this.allsq.Name = "allsq";
            this.allsq.Size = new System.Drawing.Size(75, 23);
            this.allsq.TabIndex = 33;
            this.allsq.Text = "AllSQ";
            this.allsq.UseVisualStyleBackColor = true;
            this.allsq.Click += new System.EventHandler(this.allsq_Click);
            // 
            // msq
            // 
            this.msq.Location = new System.Drawing.Point(1470, 720);
            this.msq.Name = "msq";
            this.msq.Size = new System.Drawing.Size(75, 23);
            this.msq.TabIndex = 34;
            this.msq.Text = "MSQ";
            this.msq.UseVisualStyleBackColor = true;
            this.msq.Click += new System.EventHandler(this.msq_Click);
            // 
            // xmax
            // 
            this.xmax.Location = new System.Drawing.Point(1380, 770);
            this.xmax.Name = "xmax";
            this.xmax.Size = new System.Drawing.Size(61, 19);
            this.xmax.TabIndex = 35;
            this.xmax.Text = "31000";
            // 
            // xmin
            // 
            this.xmin.Location = new System.Drawing.Point(1380, 810);
            this.xmin.Name = "xmin";
            this.xmin.Size = new System.Drawing.Size(61, 19);
            this.xmin.TabIndex = 36;
            this.xmin.Text = "5000";
            // 
            // ymax
            // 
            this.ymax.Location = new System.Drawing.Point(1510, 770);
            this.ymax.Name = "ymax";
            this.ymax.Size = new System.Drawing.Size(61, 19);
            this.ymax.TabIndex = 37;
            this.ymax.Text = "55";
            // 
            // ymin
            // 
            this.ymin.Location = new System.Drawing.Point(1510, 810);
            this.ymin.Name = "ymin";
            this.ymin.Size = new System.Drawing.Size(61, 19);
            this.ymin.TabIndex = 38;
            this.ymin.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1330, 770);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "x-Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1330, 810);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "x-Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1460, 770);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "y-Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1460, 810);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "y-Min";
            // 
            // ViHvChange
            // 
            this.ViHvChange.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.ViHvChange.Location = new System.Drawing.Point(425, 10);
            this.ViHvChange.Name = "ViHvChange";
            this.ViHvChange.Size = new System.Drawing.Size(175, 75);
            this.ViHvChange.TabIndex = 43;
            this.ViHvChange.Text = "VI-HV";
            this.ViHvChange.UseVisualStyleBackColor = true;
            this.ViHvChange.Click += new System.EventHandler(this.ViHv_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(1335, 650);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 44;
            this.label7.Text = "途中の日時から表示";
            // 
            // startday
            // 
            this.startday.Location = new System.Drawing.Point(1470, 650);
            this.startday.Name = "startday";
            this.startday.Size = new System.Drawing.Size(100, 19);
            this.startday.TabIndex = 45;
            this.startday.Text = "yyyy-mm-dd";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.startday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViHvChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ymin);
            this.Controls.Add(this.ymax);
            this.Controls.Add(this.xmin);
            this.Controls.Add(this.xmax);
            this.Controls.Add(this.msq);
            this.Controls.Add(this.allsq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataSet);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.nivi);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.changeVi);
            this.Controls.Add(this.changeYield);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolatilityMap";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeYield;
        private System.Windows.Forms.Button changeVi;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.DataVisualization.Charting.Chart nivi;
        private Button Play;
        private Button Stop;
        private Button Reset;
        private Button DataSet;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button allsq;
        private Button msq;
        private TextBox xmax;
        private TextBox xmin;
        private TextBox ymax;
        private TextBox ymin;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ViHvChange;
        private Label label7;
        private TextBox startday;
    }
}