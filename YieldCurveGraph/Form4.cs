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
    public partial class Form4 : Form
    {
        public Form4()
        {
            ViHv.Enabled = false;

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
    }
}
