using System.Windows.Forms;

namespace YieldCurveGraph
{
    partial class YieldCurveGraph
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.YieldCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockInd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.highest = new System.Windows.Forms.Label();
            this.fall = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateerror = new System.Windows.Forms.Label();
            this.DJIbutton = new System.Windows.Forms.Button();
            this.SP500button = new System.Windows.Forms.Button();
            this.NDX100button = new System.Windows.Forms.Button();
            this.IndName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.changeYield = new System.Windows.Forms.Button();
            this.changeVi = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.ViHvChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YieldCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInd)).BeginInit();
            this.SuspendLayout();
            // 
            // YieldCurve
            // 
            chartArea1.Name = "ChartArea1";
            this.YieldCurve.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.YieldCurve.Legends.Add(legend1);
            this.YieldCurve.Location = new System.Drawing.Point(25, 350);
            this.YieldCurve.Name = "YieldCurve";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.YieldCurve.Series.Add(series1);
            this.YieldCurve.Size = new System.Drawing.Size(750, 500);
            this.YieldCurve.TabIndex = 0;
            this.YieldCurve.Text = "chart1";
            // 
            // StockInd
            // 
            chartArea2.Name = "ChartArea1";
            this.StockInd.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StockInd.Legends.Add(legend2);
            this.StockInd.Location = new System.Drawing.Point(800, 350);
            this.StockInd.Name = "StockInd";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StockInd.Series.Add(series2);
            this.StockInd.Size = new System.Drawing.Size(750, 500);
            this.StockInd.TabIndex = 1;
            this.StockInd.Text = "chart2";
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.play.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.play.Location = new System.Drawing.Point(835, 90);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(200, 100);
            this.play.TabIndex = 2;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.stop.Location = new System.Drawing.Point(1075, 90);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(200, 100);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.reset.Location = new System.Drawing.Point(1325, 90);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(200, 100);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(955, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(840, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "表示スピード";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("MS UI Gothic", 100F);
            this.labeldate.Location = new System.Drawing.Point(25, 185);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(775, 134);
            this.labeldate.TabIndex = 7;
            this.labeldate.Text = "yyyy-mm-dd";
            // 
            // DateTime
            // 
            this.DateTime.AutoSize = true;
            this.DateTime.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.DateTime.Location = new System.Drawing.Point(25, 140);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(240, 54);
            this.DateTime.TabIndex = 8;
            this.DateTime.Text = "DateTime";
            // 
            // highest
            // 
            this.highest.AutoSize = true;
            this.highest.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.highest.Location = new System.Drawing.Point(1125, 275);
            this.highest.Name = "highest";
            this.highest.Size = new System.Drawing.Size(104, 40);
            this.highest.TabIndex = 9;
            this.highest.Text = "Point";
            // 
            // fall
            // 
            this.fall.AutoSize = true;
            this.fall.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.fall.Location = new System.Drawing.Point(1375, 275);
            this.fall.Name = "fall";
            this.fall.Size = new System.Drawing.Size(150, 40);
            this.fall.TabIndex = 10;
            this.fall.Text = "Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(1100, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "史上最高値";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(1300, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "史上最高値後の最大下落率";
            // 
            // startday
            // 
            this.startday.Location = new System.Drawing.Point(955, 40);
            this.startday.Name = "startday";
            this.startday.Size = new System.Drawing.Size(100, 19);
            this.startday.TabIndex = 13;
            this.startday.Text = "yyyy-mm-dd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(820, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "途中の日時から表示";
            // 
            // dateerror
            // 
            this.dateerror.AutoSize = true;
            this.dateerror.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.dateerror.ForeColor = System.Drawing.Color.Red;
            this.dateerror.Location = new System.Drawing.Point(800, 65);
            this.dateerror.Name = "dateerror";
            this.dateerror.Size = new System.Drawing.Size(0, 14);
            this.dateerror.TabIndex = 15;
            // 
            // DJIbutton
            // 
            this.DJIbutton.Location = new System.Drawing.Point(1140, 10);
            this.DJIbutton.Name = "DJIbutton";
            this.DJIbutton.Size = new System.Drawing.Size(113, 56);
            this.DJIbutton.TabIndex = 16;
            this.DJIbutton.Text = "DJI";
            this.DJIbutton.UseVisualStyleBackColor = true;
            this.DJIbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SP500button
            // 
            this.SP500button.Location = new System.Drawing.Point(1280, 10);
            this.SP500button.Name = "SP500button";
            this.SP500button.Size = new System.Drawing.Size(113, 56);
            this.SP500button.TabIndex = 17;
            this.SP500button.Text = "SP500";
            this.SP500button.UseVisualStyleBackColor = true;
            this.SP500button.Click += new System.EventHandler(this.button2_Click);
            // 
            // NDX100button
            // 
            this.NDX100button.Location = new System.Drawing.Point(1420, 10);
            this.NDX100button.Name = "NDX100button";
            this.NDX100button.Size = new System.Drawing.Size(113, 56);
            this.NDX100button.TabIndex = 18;
            this.NDX100button.Text = "NDX100";
            this.NDX100button.UseVisualStyleBackColor = true;
            this.NDX100button.Click += new System.EventHandler(this.button3_Click);
            // 
            // IndName
            // 
            this.IndName.AutoSize = true;
            this.IndName.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.IndName.Location = new System.Drawing.Point(900, 275);
            this.IndName.Name = "IndName";
            this.IndName.Size = new System.Drawing.Size(75, 40);
            this.IndName.TabIndex = 19;
            this.IndName.Text = "DJI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(845, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "現在表示中の株価指数";
            // 
            // changeYield
            // 
            this.changeYield.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeYield.Location = new System.Drawing.Point(25, 10);
            this.changeYield.Name = "changeYield";
            this.changeYield.Size = new System.Drawing.Size(175, 75);
            this.changeYield.TabIndex = 21;
            this.changeYield.Text = "changeYield";
            this.changeYield.UseVisualStyleBackColor = true;
            // 
            // changeVi
            // 
            this.changeVi.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.changeVi.Location = new System.Drawing.Point(225, 10);
            this.changeVi.Name = "changeVi";
            this.changeVi.Size = new System.Drawing.Size(175, 75);
            this.changeVi.TabIndex = 22;
            this.changeVi.Text = "changeVi";
            this.changeVi.UseVisualStyleBackColor = true;
            this.changeVi.Click += new System.EventHandler(this.changeVi_Click);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("MS UI Gothic", 40F);
            this.EXIT.ForeColor = System.Drawing.Color.OrangeRed;
            this.EXIT.Location = new System.Drawing.Point(625, 10);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(175, 75);
            this.EXIT.TabIndex = 23;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // ViHvChange
            // 
            this.ViHvChange.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.ViHvChange.Location = new System.Drawing.Point(425, 10);
            this.ViHvChange.Name = "ViHvChange";
            this.ViHvChange.Size = new System.Drawing.Size(175, 75);
            this.ViHvChange.TabIndex = 24;
            this.ViHvChange.Text = "VI-HV";
            this.ViHvChange.UseVisualStyleBackColor = true;
            this.ViHvChange.Click += new System.EventHandler(this.ViHv_Click);
            // 
            // YieldCurveGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.ControlBox = false;
            this.Controls.Add(this.ViHvChange);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.changeVi);
            this.Controls.Add(this.changeYield);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndName);
            this.Controls.Add(this.NDX100button);
            this.Controls.Add(this.SP500button);
            this.Controls.Add(this.DJIbutton);
            this.Controls.Add(this.dateerror);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fall);
            this.Controls.Add(this.highest);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.StockInd);
            this.Controls.Add(this.YieldCurve);
            this.Name = "YieldCurveGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YieldCurveGraph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YieldCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart YieldCurve;
        private System.Windows.Forms.DataVisualization.Charting.Chart StockInd;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label highest;
        private System.Windows.Forms.Label fall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dateerror;
        private System.Windows.Forms.Button DJIbutton;
        private System.Windows.Forms.Button SP500button;
        private System.Windows.Forms.Button NDX100button;
        private System.Windows.Forms.Label IndName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changeYield;
        private System.Windows.Forms.Button changeVi;
        private System.Windows.Forms.Button EXIT;
        private Button ViHvChange;
    }
}

