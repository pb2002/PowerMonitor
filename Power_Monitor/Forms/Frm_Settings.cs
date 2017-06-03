using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Monitor.Forms
{
    public partial class Frm_Settings : Form
    {
        public Frm_Settings()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value + "ms";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.IOControl.CurrentData.TimerSpeed = trackBar1.Value;
            Close();
        }
    }
}
