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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.nivi)).BeginInit();
            this.SuspendLayout();
            // 
            // changeYield
            // 
            this.changeYield.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.changeYield.Location = new System.Drawing.Point(75, 10);
            this.changeYield.Name = "changeYield";
            this.changeYield.Size = new System.Drawing.Size(200, 75);
            this.changeYield.TabIndex = 22;
            this.changeYield.Text = "changeYield";
            this.changeYield.UseVisualStyleBackColor = true;
            this.changeYield.Click += new System.EventHandler(this.changeYield_Click);
            // 
            // changeVi
            // 
            this.changeVi.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.changeVi.Location = new System.Drawing.Point(305, 10);
            this.changeVi.Name = "changeVi";
            this.changeVi.Size = new System.Drawing.Size(200, 75);
            this.changeVi.TabIndex = 23;
            this.changeVi.Text = "changeVi";
            this.changeVi.UseVisualStyleBackColor = true;
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("MS UI Gothic", 50F);
            this.EXIT.ForeColor = System.Drawing.Color.OrangeRed;
            this.EXIT.Location = new System.Drawing.Point(535, 10);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(200, 75);
            this.EXIT.TabIndex = 24;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // nivi
            // 
            chartArea2.Name = "ChartArea1";
            this.nivi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.nivi.Legends.Add(legend2);
            this.nivi.Location = new System.Drawing.Point(25, 120);
            this.nivi.Name = "nivi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.nivi.Series.Add(series2);
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
            this.Stop.Location = new System.Drawing.Point(1360, 300);
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
            this.Reset.Location = new System.Drawing.Point(1360, 450);
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
            this.DataSet.Location = new System.Drawing.Point(1360, 600);
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
            this.textBox1.Location = new System.Drawing.Point(1399, 763);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 19);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(1357, 736);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 32;
            this.label2.Text = "表示スピード";
            // 
            // allsq
            // 
            this.allsq.Location = new System.Drawing.Point(1471, 750);
            this.allsq.Name = "allsq";
            this.allsq.Size = new System.Drawing.Size(75, 23);
            this.allsq.TabIndex = 33;
            this.allsq.Text = "AllSQ";
            this.allsq.UseVisualStyleBackColor = true;
            this.allsq.Click += new System.EventHandler(this.allsq_Click);
            // 
            // msq
            // 
            this.msq.Location = new System.Drawing.Point(1471, 800);
            this.msq.Name = "msq";
            this.msq.Size = new System.Drawing.Size(75, 23);
            this.msq.TabIndex = 34;
            this.msq.Text = "MSQ";
            this.msq.UseVisualStyleBackColor = true;
            this.msq.Click += new System.EventHandler(this.msq_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
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
    }
}