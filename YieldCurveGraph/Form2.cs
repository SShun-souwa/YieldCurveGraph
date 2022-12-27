using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YieldCurveGraph
{
    public partial class Form2 : Form
    {
        string appPath = System.Windows.Forms.Application.StartupPath;
        public Form2()
        {
            InitializeComponent();
            changeVi.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void changeYield_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void DataSet_Click(object sender, EventArgs e)
        {
            Dim p As System.Diagnostics.Process =
            System.Diagnostics.Process.Start()
                                         
        }
    }
}
