using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms.DataVisualization.Charting;

namespace YieldCurveGraph
{
    public partial class Form4 : Form
    {
        // データを受け取る作業用リストの定義
        List<string[]> lists = new List<string[]>();
        string appPath = System.Windows.Forms.Application.StartupPath;

        // 株価指数のデータを作業用リストにセットするメソッド
        public void setIndex(string fileName)
        {
            // データセット（CSV）の読み込み
            StreamReader sr = new StreamReader(@fileName);
            int i = 0;

            //読み込んだファイルを1行ずつ処理
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (i == 0)
                {
                    //1行目はヘッダーとして別途取得
                    string[] cols = line.Split(',');
                    i += 1;
                    continue;
                }
                //カンマで配列の要素に分割
                string[] values = line.Split(',');
                // 配列からリストに格納
                lists.Add(values);
                /*for (int j = 0; j < values.Length; j++)
                {
                    WriteLog(values[j]);
                }*/
            }
        }

        public void ViHvchart()
        {
            // チャートエリアの初期化
            viHvChart.ChartAreas.Clear();
            viHvChart.Series.Clear();

            // チャートエリアを生成し、Chartコントロールに追加
            ChartArea chartAria1 = new ChartArea("chartArea1");
            viHvChart.ChartAreas.Add(chartAria1);

            // Series(系列)を生成
            Series series1 = new Series();
            Series series2 = new Series();

            // 系列の種類を折れ線グラフに指定
            series1.ChartType = SeriesChartType.Line;
            series2.ChartType = SeriesChartType.Line;

            // 系列の凡例を非表示
            series1.Name = "Vi";
            series2.Name = "Hv";

            // グラフの設定
            series1.Color = ColorTranslator.FromHtml("#dc143c");  //グラフ色の設定
            series1.BorderWidth = 1;                              //ボーダーの幅            
            series2.Color = ColorTranslator.FromHtml("#0000cd ");  //グラフ色の設定
            series2.BorderWidth = 1;                              //ボーダーの幅       

            // 系列の情報をセット
            for (int j = 1; j < lists.Count(); j++)
            {
                // シリーズに終値データを追加
                series1.Points.AddXY(lists[j][0], double.Parse(lists[j][4]));
                series2.Points.AddXY(lists[j][0], double.Parse(lists[j][5]));

            }
            // 生成・設定した系列をChartコントロールに追加
            viHvChart.Series.Add(series1);
            viHvChart.Series.Add(series2);
            ViHvChange.Enabled = false;
        }

        public void Deltachart()
        {
            // チャートエリアの初期化
            viHvChart.ChartAreas.Clear();
            viHvChart.Series.Clear();

            // チャートエリアを生成し、Chartコントロールに追加
            ChartArea chartAria1 = new ChartArea("chartArea1");
            viHvChart.ChartAreas.Add(chartAria1);

            // Series(系列)を生成
            Series series1 = new Series();

            // 系列の種類を折れ線グラフに指定
            series1.ChartType = SeriesChartType.Line;

            // 系列の凡例を非表示
            series1.Name = "Delta(Vi-Hv)";

            // グラフの設定
            series1.Color = ColorTranslator.FromHtml("#008000");  //グラフ色の設定
            series1.BorderWidth = 1;                              //ボーダーの幅              

            // 系列の情報をセット
            for (int j = 1; j < lists.Count(); j++)
            {
                // シリーズに終値データを追加
                series1.Points.AddXY(lists[j][0], double.Parse(lists[j][4]) - double.Parse(lists[j][5]));

            }
            // 生成・設定した系列をChartコントロールに追加
            viHvChart.Series.Add(series1);
            ViHvChange.Enabled = false;
        }


        public Form4()
        {
            InitializeComponent();
            string fileName = appPath + "\\DataSet\\alldata.csv";
            setIndex(fileName);
            ViHvchart();

        }

        private void changeYield_Click(object sender, EventArgs e)
        {
            YieldCurveGraph f1 = new YieldCurveGraph();
            f1.Show();
            this.Close();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeVi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void ViHv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViHvchart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deltachart();
        }
    }
}
