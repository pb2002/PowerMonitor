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
    public partial class Frm_SplashScreen : Form
    {
        public Frm_SplashScreen()
        {
            InitializeComponent();
        }

        private void Frm_SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            new Frm_Main().Show();
            timer1.Enabled = false;
            Hide();
        }
    }
}
