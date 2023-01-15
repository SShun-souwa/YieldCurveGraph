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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ViHv = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.changeVi = new System.Windows.Forms.Button();
            this.changeYield = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViHv
            // 
            this.ViHv.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.ViHv.Location = new System.Drawing.Point(425, 10);
            this.ViHv.Name = "ViHv";
            this.ViHv.Size = new System.Drawing.Size(175, 75);
            this.ViHv.TabIndex = 47;
            this.ViHv.Text = "VI-HV";
            this.ViHv.UseVisualStyleBackColor = true;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 100);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1500, 750);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ViHv);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.changeVi);
            this.Controls.Add(this.changeYield);
            this.Name = "Form4";
            this.Text = "VI-HV";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViHv;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button changeVi;
        private System.Windows.Forms.Button changeYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}