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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        PowerStatus pw = SystemInformation.PowerStatus;
        private void Tmr_Update_Tick(object sender, EventArgs e)
        {
            UpdateChanges();
        }
        public void UpdateChanges()
        {
            Lbl_PowerLineTxt.Text = (pw.PowerLineStatus == PowerLineStatus.Online) ?
                "Power Current" : "Battery";
            PicBox_PowerlineInd.BackColor = (pw.PowerLineStatus == PowerLineStatus.Online) ?
                Color.FromArgb(255, 192, 128) : Color.CadetBlue;
            Lbl_PercentageInd.Text =
                Convert.ToInt32(pw.BatteryLifePercent * 100) + "%";
            ProgBar_BatteryLvl.Value = Convert.ToInt32(pw.BatteryLifePercent * 100);
        }

        private void Mstrip_Settings_Click(object sender, EventArgs e)
        {
            new Frm_Settings().ShowDialog(this);
        }
    }
}
