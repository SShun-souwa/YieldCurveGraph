namespace YieldCurveGraph
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ViHvChange = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.changeVi = new System.Windows.Forms.Button();
            this.changeYield = new System.Windows.Forms.Button();
            this.viHvChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viHvChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ViHvChange
            // 
            this.ViHvChange.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.ViHvChange.Location = new System.Drawing.Point(425, 10);
            this.ViHvChange.Name = "ViHvChange";
            this.ViHvChange.Size = new System.Drawing.Size(175, 75);
            this.ViHvChange.TabIndex = 47;
            this.ViHvChange.Text = "VI-HV";
            this.ViHvChange.UseVisualStyleBackColor = true;
            this.ViHvChange.Click += new System.EventHandler(this.ViHv_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.SystemColors.Control;
            this.EXIT.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.EXIT.ForeColor = System.Drawing.Color.OrangeRed;
            this.EXIT.Location = new System.Drawing.Point(625, 10);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(175, 75);
            this.EXIT.TabIndex = 46;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // changeVi
            // 
            this.changeVi.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeVi.Location = new System.Drawing.Point(225, 10);
            this.changeVi.Name = "changeVi";
            this.changeVi.Size = new System.Drawing.Size(175, 75);
            this.changeVi.TabIndex = 45;
            this.changeVi.Text = "changeVi";
            this.changeVi.UseVisualStyleBackColor = true;
            this.changeVi.Click += new System.EventHandler(this.changeVi_Click);
            // 
            // changeYield
            // 
            this.changeYield.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeYield.Location = new System.Drawing.Point(25, 10);
            this.changeYield.Name = "changeYield";
            this.changeYield.Size = new System.Drawing.Size(175, 75);
            this.changeYield.TabIndex = 44;
            this.changeYield.Text = "changeYield";
            this.changeYield.UseVisualStyleBackColor = true;
            this.changeYield.Click += new System.EventHandler(this.changeYield_Click);
            // 
            // viHvChart
            // 
            chartArea3.Name = "ChartArea1";
            this.viHvChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.viHvChart.Legends.Add(legend3);
            this.viHvChart.Location = new System.Drawing.Point(25, 100);
            this.viHvChart.Name = "viHvChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.viHvChart.Series.Add(series3);
            this.viHvChart.Size = new System.Drawing.Size(1400, 750);
            this.viHvChart.TabIndex = 48;
            this.viHvChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1460, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 49;
            this.button1.Text = "Vi-Hv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1460, 725);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 50;
            this.button2.Text = "Delta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viHvChart);
            this.Controls.Add(this.ViHvChange);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.changeVi);
            this.Controls.Add(this.changeYield);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VI-HV";
            ((System.ComponentModel.ISupportInitialize)(this.viHvChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViHvChange;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button changeVi;
        private System.Windows.Forms.Button changeYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart viHvChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}