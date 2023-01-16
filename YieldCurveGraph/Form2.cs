using System;
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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Diagnostics;

namespace YieldCurveGraph
{
    public partial class Form2 : Form
    {
        double xaxisMin = 5000.0;
        double xaxisMax = 31000.0;
        double yaxisMin = 10.0;
        double yaxisMax = 55.0;
        string appPath = System.Windows.Forms.Application.StartupPath;
        // 指数データを受け取るリストの定義
        List<string[]> lists = new List<string[]>();
        // グラフの表示日数のカウント
        int count = 0;
        // グラフの再生、停止の判定
        bool playjudge = false;
        // グラフの更新スピード
        int speed = 50;

        // ログを記入するメソッド
        private void WriteLog(String text)
        {
            File.AppendAllText("log.txt", text + Environment.NewLine);
        }

        // 入力された日付を正規表現(Regexクラス)を用いて同一の形式に整形するメソッド
        // 例　2000/1/1 →　2000-01-01
        public String daySet(String days)
        {   // デフォルトの日付および日付を構成する年、月、日パーツを格納する配列の定義
            String[] dayParts = { "2000", "01", "01" };
            String day = "2000-01-01";
            int i = 0;
            // 正規表現で4桁数字+区切り文字+1~2桁数字+区切り文字+1~2桁数字に合致するか判定
            if (Regex.IsMatch(days, @"\d{4}.\d{1,2}.\d{1,2}"))
            {   // 合致する場合、数字の部分を抜き出して、日付のパーツ用配列に格納
                MatchCollection matches = Regex.Matches(days, @"\d+");
                foreach (Match match in matches)
                {
                    dayParts[i] = match.Value;
                    i++;
                }
                // 月と日のパーツが一桁で、0が落ちている場合、0を追加して再格納
                for (int j = 1; j < 3; j++)
                {
                    if (dayParts[j].Length == 1)
                    {
                        dayParts[j] = "0" + dayParts[j].ToString();
                    }
                }
                // 日付のパーツを-で連結しyyyy-dd-mmの日付表記に変更し、戻り値として返す
                day = dayParts[0] + "-" + dayParts[1] + "-" + dayParts[2];
                return day;
            }
            else
            {　 // 入力された日付の形式が判別できない場合、文字列noneを返す
                return "none";
            }

        }

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

        //グラフエリアをセットするメソッド
        public void NiVichart()
        {
            // チャートエリアの初期化
            nivi.ChartAreas.Clear();
            nivi.Series.Clear();

            // ｙ軸上限値、下限値設定に利用するリストの定義
            var yieldY = new List<double>();

            // チャートエリアを生成し、Chartコントロールに追加
            ChartArea chartAria = new ChartArea("chartArea");
            nivi.ChartAreas.Add(chartAria);

            // Series(系列)を生成
            Series series = new Series();

            // 系列の種類を散布図に指定
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

            // Seriesにデータを追加
            for (int j = 0; j <= count; j++)
            {
                series.Points.AddXY(double.Parse(lists[j][1]), lists[j][2]);
            }
                
            // x軸の設定
            Axis axisX = nivi.ChartAreas[0].AxisX;
            axisX.Minimum = Math.Round(xaxisMin, 1, MidpointRounding.AwayFromZero);
            axisX.Maximum = Math.Round(xaxisMax, 1, MidpointRounding.AwayFromZero);
            axisX.Interval = 1000.0;

            // y軸の設定
            Axis axisY = nivi.ChartAreas[0].AxisY;
            axisY.Minimum = Math.Round(yaxisMin, 1, MidpointRounding.AwayFromZero);
            axisY.Maximum = Math.Round(yaxisMax, 1, MidpointRounding.AwayFromZero);
            axisY.Interval = 5;

            // 生成・設定した系列をChartコントロールに追加
            nivi.Series.Add(series);

        }

        public Form2()
        {
            InitializeComponent();
            changeVi.Enabled = false;
            string fileName = appPath + "\\DataSet\\sqdata.csv";
            setIndex(fileName);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Encoding Enc = Encoding.GetEncoding("utf-8");
            StreamWriter writer = new StreamWriter(appPath + "\\log.txt", false, Enc);
            writer.WriteLine("Form2 Load");
            writer.Close();
        }

        private void changeYield_Click(object sender, EventArgs e)
        {
            playjudge = false;
            YieldCurveGraph f1 = new YieldCurveGraph();
            f1.Show();
            this.Close();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void Play_Click(object sender, EventArgs e)
        {
            if(count >= lists.Count)
            {
                count = 0;
            }

            Play.Enabled = false;
            changeYield.Enabled = false;
            ViHvChange.Enabled = false;
            xaxisMin = double.Parse(xmin.Text);
            xaxisMax = double.Parse(xmax.Text);
            yaxisMin = double.Parse(ymin.Text);
            yaxisMax = double.Parse(ymax.Text);
            playjudge = true;
            // CSVを読み込んだリストをループ処理
            while (count < lists.Count)
            {
                // speedの値が空欄もしくは0の場合に1000を代入
                if (textBox1.Text == "" || textBox1.Text == "0")
                {
                    speed = 100;
                }

                // 表示スピードを入力された値(int型)に更新
                speed = int.Parse(textBox1.Text);
                // 再生判定がTrueの間、リストの先頭からグラフに表示
                if (playjudge)
                {
                    // グラフの表示
                    NiVichart();
                    // 表示しているデータの日付の表示を更新
                    label1.Text = lists[count][0];
                    count += 1;

                    // 次のグラフの表示までのウェイト処理
                    if (speed >= 100)
                    {
                        speed = 100;
                    }
                    if (speed < 20)
                    {
                        speed = 20;
                    }
                    await Task.Delay(10000 / speed);

                }
                else
                {
                    break;
                }
            }
            
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Play.Enabled = true;
            changeYield.Enabled = true;
            // 再生の一時停止判定
            playjudge = false;
            ViHvChange.Enabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Play.Enabled = true;
            changeYield.Enabled = true;
            // 再生の一時停止判定
            playjudge = false;
            // 表示期間指定を指定した時の処理
            if (startday.Text == "0" || startday.Text == "yyyy-mm-dd" || startday.Text == "")
            {
                count = 0;
            }
            else
            {
                int i = 0;
                String day = daySet(startday.Text);
                // CSVデータの日付カラムから入力された日付周辺のデータのインデックス番号を検索し、countに代入する処理
                while (i < lists.Count)
                {
                    if (day.CompareTo(lists[0][0]) == -1)
                    {
                        count = 0;
                        break;
                    }

                    if (lists[i][0].CompareTo(day) == 1)
                    {
                        count = i - 1;              // countへ代入
                        break;
                    }
                    i++;
                }
            }
        }

        private void DataSet_Click(object sender, EventArgs e)
        {
           playjudge = false;
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void allsq_Click(object sender, EventArgs e)
        {
            Play.Enabled = true;
            // 再生の一時停止判定
            playjudge = false;
            count = 0;
            string fileName = appPath + "\\DataSet\\sqdata.csv";
            lists.Clear();
            setIndex(fileName);
        }

        private void msq_Click(object sender, EventArgs e)
        {
            Play.Enabled = true;
            // 再生の一時停止判定
            playjudge = false;
            count = 0;
            string fileName = appPath + "\\DataSet\\msqdata.csv";
            lists.Clear();
            setIndex(fileName);
        }

        private void ViHv_Click(object sender, EventArgs e)
        {
            playjudge = false;
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
