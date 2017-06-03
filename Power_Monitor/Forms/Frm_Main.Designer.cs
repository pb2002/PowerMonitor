namespace Power_Monitor.Forms
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.ProgBar_BatteryLvl = new System.Windows.Forms.ProgressBar();
            this.Lbl_PercentageInd = new System.Windows.Forms.Label();
            this.PicBox_PowerlineInd = new System.Windows.Forms.PictureBox();
            this.Lbl_PowerLineTxt = new System.Windows.Forms.Label();
            this.Mstrip_MenuBar = new System.Windows.Forms.MenuStrip();
            this.Mstrip_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_Start_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Mstrip_Help_Htu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmr_Update = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_PowerlineInd)).BeginInit();
            this.Mstrip_MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgBar_BatteryLvl
            // 
            this.ProgBar_BatteryLvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgBar_BatteryLvl.BackColor = System.Drawing.SystemColors.Control;
            this.ProgBar_BatteryLvl.Location = new System.Drawing.Point(13, 226);
            this.ProgBar_BatteryLvl.Name = "ProgBar_BatteryLvl";
            this.ProgBar_BatteryLvl.Size = new System.Drawing.Size(251, 23);
            this.ProgBar_BatteryLvl.TabIndex = 0;
            // 
            // Lbl_PercentageInd
            // 
            this.Lbl_PercentageInd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PercentageInd.AutoSize = true;
            this.Lbl_PercentageInd.Font = new System.Drawing.Font("LCD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PercentageInd.Location = new System.Drawing.Point(270, 226);
            this.Lbl_PercentageInd.Name = "Lbl_PercentageInd";
            this.Lbl_PercentageInd.Size = new System.Drawing.Size(52, 23);
            this.Lbl_PercentageInd.TabIndex = 1;
            this.Lbl_PercentageInd.Text = "000%";
            this.Lbl_PercentageInd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBox_PowerlineInd
            // 
            this.PicBox_PowerlineInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PicBox_PowerlineInd.Image = global::Power_Monitor.Properties.Resources.glass2;
            this.PicBox_PowerlineInd.Location = new System.Drawing.Point(13, 27);
            this.PicBox_PowerlineInd.Name = "PicBox_PowerlineInd";
            this.PicBox_PowerlineInd.Size = new System.Drawing.Size(64, 64);
            this.PicBox_PowerlineInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_PowerlineInd.TabIndex = 2;
            this.PicBox_PowerlineInd.TabStop = false;
            // 
            // Lbl_PowerLineTxt
            // 
            this.Lbl_PowerLineTxt.AutoSize = true;
            this.Lbl_PowerLineTxt.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PowerLineTxt.Location = new System.Drawing.Point(83, 27);
            this.Lbl_PowerLineTxt.Name = "Lbl_PowerLineTxt";
            this.Lbl_PowerLineTxt.Size = new System.Drawing.Size(143, 27);
            this.Lbl_PowerLineTxt.TabIndex = 3;
            this.Lbl_PowerLineTxt.Text = "Initializing...";
            // 
            // Mstrip_MenuBar
            // 
            this.Mstrip_MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mstrip_Start,
            this.Mstrip_Settings,
            this.Mstrip_Help});
            this.Mstrip_MenuBar.Location = new System.Drawing.Point(0, 0);
            this.Mstrip_MenuBar.Name = "Mstrip_MenuBar";
            this.Mstrip_MenuBar.Size = new System.Drawing.Size(334, 24);
            this.Mstrip_MenuBar.TabIndex = 4;
            this.Mstrip_MenuBar.Text = "Mstrip_MenuBar";
            // 
            // Mstrip_Start
            // 
            this.Mstrip_Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mstrip_Start_Exit});
            this.Mstrip_Start.Name = "Mstrip_Start";
            this.Mstrip_Start.Size = new System.Drawing.Size(43, 20);
            this.Mstrip_Start.Text = "Start";
            // 
            // Mstrip_Start_Exit
            // 
            this.Mstrip_Start_Exit.Name = "Mstrip_Start_Exit";
            this.Mstrip_Start_Exit.Size = new System.Drawing.Size(152, 22);
            this.Mstrip_Start_Exit.Text = "Exit";
            // 
            // Mstrip_Settings
            // 
            this.Mstrip_Settings.Name = "Mstrip_Settings";
            this.Mstrip_Settings.Size = new System.Drawing.Size(70, 20);
            this.Mstrip_Settings.Text = "Settings...";
            this.Mstrip_Settings.Click += new System.EventHandler(this.Mstrip_Settings_Click);
            // 
            // Mstrip_Help
            // 
            this.Mstrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mstrip_Help_About,
            this.Mstrip_Help_Htu});
            this.Mstrip_Help.Name = "Mstrip_Help";
            this.Mstrip_Help.Size = new System.Drawing.Size(44, 20);
            this.Mstrip_Help.Text = "Help";
            // 
            // Mstrip_Help_About
            // 
            this.Mstrip_Help_About.Name = "Mstrip_Help_About";
            this.Mstrip_Help_About.Size = new System.Drawing.Size(135, 22);
            this.Mstrip_Help_About.Text = "About";
            // 
            // Mstrip_Help_Htu
            // 
            this.Mstrip_Help_Htu.Name = "Mstrip_Help_Htu";
            this.Mstrip_Help_Htu.Size = new System.Drawing.Size(135, 22);
            this.Mstrip_Help_Htu.Text = "How to Use";
            // 
            // Tmr_Update
            // 
            this.Tmr_Update.Enabled = true;
            this.Tmr_Update.Interval = 500;
            this.Tmr_Update.Tick += new System.EventHandler(this.Tmr_Update_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.Lbl_PowerLineTxt);
            this.Controls.Add(this.PicBox_PowerlineInd);
            this.Controls.Add(this.Lbl_PercentageInd);
            this.Controls.Add(this.ProgBar_BatteryLvl);
            this.Controls.Add(this.Mstrip_MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mstrip_MenuBar;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Frm_Main";
            this.Text = "Power Monitor";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_PowerlineInd)).EndInit();
            this.Mstrip_MenuBar.ResumeLayout(false);
            this.Mstrip_MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgBar_BatteryLvl;
        private System.Windows.Forms.Label Lbl_PercentageInd;
        private System.Windows.Forms.PictureBox PicBox_PowerlineInd;
        private System.Windows.Forms.Label Lbl_PowerLineTxt;
        private System.Windows.Forms.MenuStrip Mstrip_MenuBar;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Start;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Settings;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Help;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Help_About;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Help_Htu;
        private System.Windows.Forms.Timer Tmr_Update;
        private System.Windows.Forms.ToolStripMenuItem Mstrip_Start_Exit;
    }
}