using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YieldCurveGraph
{
    public partial class Form3 : Form
    {
        string appPath = System.Windows.Forms.Application.StartupPath;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataPath = appPath + "\\DataSet\\";
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("java",
            "-jar I:\\HandMadePrograms\\YieldCurveGraph\\YieldCurveGraph\\YieldCurveGraph\\JAVA\\viset.jar " + dataPath);
            p.StartInfo.CreateNoWindow = true;
            p.WaitForExit();
            this.Close();
        }
    }
}
