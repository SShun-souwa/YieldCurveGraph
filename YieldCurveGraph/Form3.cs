using System;
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
            string argment = "-jar " + appPath + "\\viset.jar " + dataPath;
            System.Diagnostics.Process.Start("java", argment);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
