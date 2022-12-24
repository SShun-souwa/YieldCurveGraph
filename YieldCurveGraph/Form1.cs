﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;


namespace YieldCurveGraph
{
    public partial class Form1 : Form
    {   
        // Form1クラスで利用する変数の定義
        // 金利と指数データを受け取るリストの定義
        List<string[]> lists = new List<string[]>();
        // イールドカーブのX軸を表示するリスト
        string[] yieldX = { "3M", "6M", "1Y", "2Y", "3Y", "5Y", "7Y", "10Y", "20Y", "30Y" };
        // グラフの表示日数のカウント
        int count = 0;
        // 史上最高値日が格納されたリストのインデックス番号を格納
        int highcount = 0;
        // グラフの再生、停止の判定
        bool playjudge = false;
        // グラフの更新スピード
        int speed = 1000;
        // 史上最高値、最高値後の最安値、下落率を格納するリスト
        double[] maxmin = { 1.0, 1.0, 1.0 };
        // 表示する株価指数
        string stind = "DJI";

        // イールドカーブのグラフエリアをセットするメソッド
        public void YieldcurveChart()
        {
            // チャートエリアの初期化
            YieldCurve.ChartAreas.Clear();
            YieldCurve.Series.Clear();

            // ｙ軸上限値、下限値設定に利用するリストの定義
            var yieldY = new List<double>();

            // チャートエリアを生成し、Chartコントロールに追加
            ChartArea chartAria = new ChartArea("chartArea");
            YieldCurve.ChartAreas.Add(chartAria);

            // Series(系列)を生成
            Series series = new Series();

            // 系列の種類を折れ線グラフに指定
            series.ChartType = SeriesChartType.Line;

            // 系列の凡例を非表示
            series.IsVisibleInLegend = false;

            // グラフの設定
            series.Color = ColorTranslator.FromHtml("#32aed4");  //グラフ色
            series.BorderWidth = 3;                              //折れ線の幅
            series.MarkerSize = 10;                              //マーカーのサイズ
            series.MarkerColor = Color.Blue;                     //マーカーの背景色
            series.MarkerBorderColor = Color.Black;              //マーカーの枠の色
            series.MarkerStyle = MarkerStyle.Square;

            // 系列のポイント情報をセット、イールドカーブのデータは10種（CSVファイルの2～10列）
            for (int i = 0; i < 10; i++)
            {   
                // Seriesにデータを追加
                series.Points.AddXY(yieldX[i], lists[count][i + 1]);
                // y軸設定用のリストにもデータを追加
                yieldY.Add(double.Parse(lists[count][i + 1])); ;
            }

            // y軸の設定
            Axis axisY = new Axis();
            // y軸の上端を10%、下端は20%の幅で表示
            axisY.Minimum = Math.Round(0.8 * yieldY.Min(), 1, MidpointRounding.AwayFromZero);
            axisY.Maximum = Math.Round(1.1 * yieldY.Max(), 1, MidpointRounding.AwayFromZero);
            YieldCurve.ChartAreas[0].AxisY = axisY;

            // 生成・設定した系列をChartコントロールに追加
            YieldCurve.Series.Add(series);

        }

        // 株価指数のグラフエリアをセットするメソッド
        public void StockIndChart()
        {
            // チャートエリアの初期化
            StockInd.ChartAreas.Clear();
            StockInd.Series.Clear();

            // チャートエリアを生成し、Chartコントロールに追加
            ChartArea chartAria1 = new ChartArea("chartArea1");
            StockInd.ChartAreas.Add(chartAria1);

            // Series(系列)を生成
            Series series1 = new Series();

            // 系列の種類を折れ線グラフに指定
            series1.ChartType = SeriesChartType.Line;

            // 系列の凡例を非表示
            series1.IsVisibleInLegend = false;

            // グラフの設定
            series1.Color = ColorTranslator.FromHtml("#dc143c");  //グラフ色の設定
            series1.BorderWidth = 3;                              //ボーダーの幅            

            // 系列のポイント情報をセット、イールドカーブのデータは10種（CSVファイルの11列）
            for (int j = 1; j < count; j++)
            {   
                // シリーズに終値データを追加
                series1.Points.AddXY(lists[j][0], lists[j][11]);

                // 史上最高値を撮った場合と、最高値をとった後の最安値までの下落率を計算し、リストに格納
                if (maxmin[0] < double.Parse(lists[j][11]))
                {
                    maxmin[0] = double.Parse(lists[j][11]);
                    maxmin[1] = double.Parse(lists[j][11]);
                    highest.Text = maxmin[0].ToString();
                    highcount = count;

                }
                else if (maxmin[1] > double.Parse(lists[j][11]) & j > highcount)
                {
                    maxmin[1] = double.Parse(lists[j][11]);
                    maxmin[2] = Math.Round((1 - maxmin[1] / maxmin[0]) * 100, 2, MidpointRounding.AwayFromZero);
                    fall.Text = maxmin[2].ToString() + "%";
                }
            }
            // 生成・設定した系列をChartコントロールに追加
            StockInd.Series.Add(series1);
        }

        // 史上最高値、最高値後の安値、下落率の値をリセットするメソッド
        public void resetMaxmin()
        {
            for(int i=0; i < maxmin.Length; i++)
                {
                maxmin[i] = 1.0;
                }
        }

        public void setIndex()
        {
            // データセット（CSV）の読み込み
            string fileName = "I:\\HandMadePrograms\\YieldCurveGraph\\YieldCurveGraph\\DataSet\\" + stind + "data.csv";
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
            }
        }

        public Form1()
        {
            InitializeComponent();
            setIndex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 再生ボタンを押下した時の処理（非同期宣言）
        private async void play_Click(object sender, EventArgs e)
        {
            // 現在表示している株価指数名の表示
            IndName.Text = stind;
            // 日付のエラー文の初期化
            dateerror.Text = "";
            playjudge = true;
            // CSVを読み込んだリストをループ処理
            while (count < lists.Count)
            {
                // speedの値が空欄もしくは0の場合に1000を代入
                if(textBox1.Text == ""　|| textBox1.Text == "0")
                {
                    speed = 1000;
                }

                // 表示スピードを入力された値(int型)に更新
                speed = int.Parse(textBox1.Text);
                // 再生判定がTrueの間、リストの先頭からグラフに表示
                if (playjudge)
                {
                    // グラフの表示
                    YieldcurveChart();
                    StockIndChart();

                    // 表示しているデータの日付の表示を更新
                    labeldate.Text = lists[count][0];
                    count += 1;

                    // 次のグラフの表示までのウェイト処理
                    await Task.Delay(10000/speed);
                }
                else
                {
                    break;
                }
            }
        }

        // 再生ストップボタンを押下した時の処理
        private void stop_Click(object sender, EventArgs e)
        {   
            // 再生の一時停止判定
            playjudge = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {   
            // 最高値と下落率の表示のリセット
            highest.Text = "";
            fall.Text = "";
            // 再生の一時停止判定
            playjudge = false;
            // 表示期間指定を指定した時の処理
            if(startday.Text == "0" || startday.Text =="yyyy-mm-dd" || startday.Text == "")
            {
                count = 0;
            }
            else{
                int i = 0;
                bool test = true;
                // CSVデータの日付カラムから入力された日付と同日のインデックス番号を検索し、countに代入する処理
                while(i < lists.Count) 
                {
                    if(startday.Text == lists[i][0]) 
                    {
                        dateerror.Text = "";    // 日付エラーテキストの非表示
                        count = i;              // countへ代入
                        test = false;           // エラー出力の可否をfalseに
                        resetMaxmin();
                        break;
                    }

                    i++;
                }
                // 指定された日付がデータに存在しない場合にエラーの表示
                if (test)
                {
                    dateerror.Text = "指定された日付のデータはありません。日時をずらしてください。";
                }
            }

        }

        // 表示する株価指数の切り替え
        private void button1_Click(object sender, EventArgs e)
        {
            stind = "DJI";
            // データを格納していたリストと、史上最高値、最高値後の最安値の値をリセット
            lists.Clear();
            resetMaxmin();
            // 対応する株価指数のデータを再度CSVから読み込み
            setIndex();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stind = "SP500";
            // データを格納していたリストと、史上最高値、最高値後の最安値の値をリセット
            lists.Clear();
            resetMaxmin();
            // 対応する株価指数のデータを再度CSVから読み込み
            setIndex();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stind = "NDX100";
            // データを格納していたリストと、史上最高値、最高値後の最安値の値をリセット
            lists.Clear();
            resetMaxmin();
            // 対応する株価指数のデータを再度CSVから読み込み
            setIndex();
        }
    }
}