namespace GpuTracker
{
    partial class FormNvidia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNvidia));
            this.panelSeries = new System.Windows.Forms.Panel();
            this.btn20 = new System.Windows.Forms.RadioButton();
            this.btn16 = new System.Windows.Forms.RadioButton();
            this.btn10 = new System.Windows.Forms.RadioButton();
            this.btn900 = new System.Windows.Forms.RadioButton();
            this.btn700 = new System.Windows.Forms.RadioButton();
            this.btn600 = new System.Windows.Forms.RadioButton();
            this.comboBoxModels = new System.Windows.Forms.ComboBox();
            this.labelTitulos = new System.Windows.Forms.Label();
            this.labelLaunch = new System.Windows.Forms.Label();
            this.labelCodeName = new System.Windows.Forms.Label();
            this.labelArch = new System.Windows.Forms.Label();
            this.labelCoreConfig = new System.Windows.Forms.Label();
            this.labelClockBoost = new System.Windows.Forms.Label();
            this.labelClockBase = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelMemType = new System.Windows.Forms.Label();
            this.labelBusW = new System.Windows.Forms.Label();
            this.labelMemClock = new System.Windows.Forms.Label();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.labelMSRP = new System.Windows.Forms.Label();
            this.labelTDP = new System.Windows.Forms.Label();
            this.toolTipCoreConfig = new System.Windows.Forms.ToolTip(this.components);
            this.labelForCore20 = new System.Windows.Forms.Label();
            this.labelForCore16 = new System.Windows.Forms.Label();
            this.labelForCoreStandard = new System.Windows.Forms.Label();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrand = new System.Windows.Forms.PictureBox();
            this.pictureBoxTrans = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorner = new System.Windows.Forms.PictureBox();
            this.panelSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorner)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSeries
            // 
            this.panelSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeries.Controls.Add(this.pictureBoxTrans);
            this.panelSeries.Controls.Add(this.btn20);
            this.panelSeries.Controls.Add(this.btn16);
            this.panelSeries.Controls.Add(this.btn10);
            this.panelSeries.Controls.Add(this.btn900);
            this.panelSeries.Controls.Add(this.btn700);
            this.panelSeries.Controls.Add(this.btn600);
            this.panelSeries.Controls.Add(this.pictureBoxCorner);
            this.panelSeries.Location = new System.Drawing.Point(12, 12);
            this.panelSeries.Name = "panelSeries";
            this.panelSeries.Size = new System.Drawing.Size(227, 382);
            this.panelSeries.TabIndex = 0;
            // 
            // btn20
            // 
            this.btn20.AutoSize = true;
            this.btn20.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.ForeColor = System.Drawing.Color.White;
            this.btn20.Location = new System.Drawing.Point(40, 270);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(137, 21);
            this.btn20.TabIndex = 5;
            this.btn20.TabStop = true;
            this.btn20.Text = "GeForce 20 Series";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.CheckedChanged += new System.EventHandler(this.btn20_CheckedChanged);
            // 
            // btn16
            // 
            this.btn16.AutoSize = true;
            this.btn16.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16.ForeColor = System.Drawing.Color.White;
            this.btn16.Location = new System.Drawing.Point(40, 243);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(137, 21);
            this.btn16.TabIndex = 4;
            this.btn16.TabStop = true;
            this.btn16.Text = "GeForce 16 Series";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.CheckedChanged += new System.EventHandler(this.btn16_CheckedChanged);
            // 
            // btn10
            // 
            this.btn10.AutoSize = true;
            this.btn10.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.ForeColor = System.Drawing.Color.White;
            this.btn10.Location = new System.Drawing.Point(40, 216);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(137, 21);
            this.btn10.TabIndex = 3;
            this.btn10.TabStop = true;
            this.btn10.Text = "GeForce 10 Series";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.CheckedChanged += new System.EventHandler(this.btn10_CheckedChanged);
            // 
            // btn900
            // 
            this.btn900.AutoSize = true;
            this.btn900.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn900.ForeColor = System.Drawing.Color.White;
            this.btn900.Location = new System.Drawing.Point(40, 189);
            this.btn900.Name = "btn900";
            this.btn900.Size = new System.Drawing.Size(145, 21);
            this.btn900.TabIndex = 2;
            this.btn900.TabStop = true;
            this.btn900.Text = "GeForce 900 Series";
            this.btn900.UseVisualStyleBackColor = true;
            this.btn900.CheckedChanged += new System.EventHandler(this.btn900_CheckedChanged);
            // 
            // btn700
            // 
            this.btn700.AutoSize = true;
            this.btn700.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn700.ForeColor = System.Drawing.Color.White;
            this.btn700.Location = new System.Drawing.Point(40, 162);
            this.btn700.Name = "btn700";
            this.btn700.Size = new System.Drawing.Size(145, 21);
            this.btn700.TabIndex = 1;
            this.btn700.TabStop = true;
            this.btn700.Text = "GeForce 700 Series";
            this.btn700.UseVisualStyleBackColor = true;
            this.btn700.CheckedChanged += new System.EventHandler(this.btn700_CheckedChanged);
            // 
            // btn600
            // 
            this.btn600.AutoSize = true;
            this.btn600.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn600.ForeColor = System.Drawing.Color.White;
            this.btn600.Location = new System.Drawing.Point(40, 135);
            this.btn600.Name = "btn600";
            this.btn600.Size = new System.Drawing.Size(145, 21);
            this.btn600.TabIndex = 0;
            this.btn600.TabStop = true;
            this.btn600.Text = "GeForce 600 Series";
            this.btn600.UseVisualStyleBackColor = true;
            this.btn600.CheckedChanged += new System.EventHandler(this.btn600_CheckedChanged);
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.BackColor = System.Drawing.Color.Black;
            this.comboBoxModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModels.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxModels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxModels.FormattingEnabled = true;
            this.comboBoxModels.Location = new System.Drawing.Point(251, 12);
            this.comboBoxModels.Name = "comboBoxModels";
            this.comboBoxModels.Size = new System.Drawing.Size(370, 25);
            this.comboBoxModels.TabIndex = 1;
            this.comboBoxModels.Tag = "";
            this.comboBoxModels.SelectedIndexChanged += new System.EventHandler(this.comboBoxModels_SelectedIndexChanged);
            // 
            // labelTitulos
            // 
            this.labelTitulos.AutoSize = true;
            this.labelTitulos.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTitulos.ForeColor = System.Drawing.Color.White;
            this.labelTitulos.Location = new System.Drawing.Point(249, 105);
            this.labelTitulos.Name = "labelTitulos";
            this.labelTitulos.Size = new System.Drawing.Size(194, 289);
            this.labelTitulos.TabIndex = 2;
            this.labelTitulos.Text = resources.GetString("labelTitulos.Text");
            // 
            // labelLaunch
            // 
            this.labelLaunch.AutoSize = true;
            this.labelLaunch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelLaunch.ForeColor = System.Drawing.Color.White;
            this.labelLaunch.Location = new System.Drawing.Point(339, 105);
            this.labelLaunch.Name = "labelLaunch";
            this.labelLaunch.Size = new System.Drawing.Size(0, 17);
            this.labelLaunch.TabIndex = 3;
            // 
            // labelCodeName
            // 
            this.labelCodeName.AutoSize = true;
            this.labelCodeName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelCodeName.ForeColor = System.Drawing.Color.White;
            this.labelCodeName.Location = new System.Drawing.Point(333, 122);
            this.labelCodeName.Name = "labelCodeName";
            this.labelCodeName.Size = new System.Drawing.Size(0, 17);
            this.labelCodeName.TabIndex = 4;
            // 
            // labelArch
            // 
            this.labelArch.AutoSize = true;
            this.labelArch.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelArch.ForeColor = System.Drawing.Color.White;
            this.labelArch.Location = new System.Drawing.Point(344, 139);
            this.labelArch.Name = "labelArch";
            this.labelArch.Size = new System.Drawing.Size(0, 17);
            this.labelArch.TabIndex = 5;
            // 
            // labelCoreConfig
            // 
            this.labelCoreConfig.AutoSize = true;
            this.labelCoreConfig.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelCoreConfig.ForeColor = System.Drawing.Color.White;
            this.labelCoreConfig.Location = new System.Drawing.Point(380, 156);
            this.labelCoreConfig.Name = "labelCoreConfig";
            this.labelCoreConfig.Size = new System.Drawing.Size(0, 17);
            this.labelCoreConfig.TabIndex = 6;
            // 
            // labelClockBoost
            // 
            this.labelClockBoost.AutoSize = true;
            this.labelClockBoost.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelClockBoost.ForeColor = System.Drawing.Color.White;
            this.labelClockBoost.Location = new System.Drawing.Point(377, 207);
            this.labelClockBoost.Name = "labelClockBoost";
            this.labelClockBoost.Size = new System.Drawing.Size(0, 17);
            this.labelClockBoost.TabIndex = 8;
            // 
            // labelClockBase
            // 
            this.labelClockBase.AutoSize = true;
            this.labelClockBase.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelClockBase.ForeColor = System.Drawing.Color.White;
            this.labelClockBase.Location = new System.Drawing.Point(370, 190);
            this.labelClockBase.Name = "labelClockBase";
            this.labelClockBase.Size = new System.Drawing.Size(0, 17);
            this.labelClockBase.TabIndex = 7;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelSize.ForeColor = System.Drawing.Color.White;
            this.labelSize.Location = new System.Drawing.Point(285, 292);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(0, 17);
            this.labelSize.TabIndex = 12;
            // 
            // labelMemType
            // 
            this.labelMemType.AutoSize = true;
            this.labelMemType.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelMemType.ForeColor = System.Drawing.Color.White;
            this.labelMemType.Location = new System.Drawing.Point(348, 258);
            this.labelMemType.Name = "labelMemType";
            this.labelMemType.Size = new System.Drawing.Size(0, 17);
            this.labelMemType.TabIndex = 11;
            // 
            // labelBusW
            // 
            this.labelBusW.AutoSize = true;
            this.labelBusW.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelBusW.ForeColor = System.Drawing.Color.White;
            this.labelBusW.Location = new System.Drawing.Point(326, 275);
            this.labelBusW.Name = "labelBusW";
            this.labelBusW.Size = new System.Drawing.Size(0, 17);
            this.labelBusW.TabIndex = 10;
            // 
            // labelMemClock
            // 
            this.labelMemClock.AutoSize = true;
            this.labelMemClock.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelMemClock.ForeColor = System.Drawing.Color.White;
            this.labelMemClock.Location = new System.Drawing.Point(351, 241);
            this.labelMemClock.Name = "labelMemClock";
            this.labelMemClock.Size = new System.Drawing.Size(0, 17);
            this.labelMemClock.TabIndex = 9;
            // 
            // labelBandwidth
            // 
            this.labelBandwidth.AutoSize = true;
            this.labelBandwidth.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelBandwidth.ForeColor = System.Drawing.Color.White;
            this.labelBandwidth.Location = new System.Drawing.Point(326, 326);
            this.labelBandwidth.Name = "labelBandwidth";
            this.labelBandwidth.Size = new System.Drawing.Size(0, 17);
            this.labelBandwidth.TabIndex = 13;
            // 
            // labelMSRP
            // 
            this.labelMSRP.AutoSize = true;
            this.labelMSRP.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelMSRP.ForeColor = System.Drawing.Color.White;
            this.labelMSRP.Location = new System.Drawing.Point(391, 377);
            this.labelMSRP.Name = "labelMSRP";
            this.labelMSRP.Size = new System.Drawing.Size(0, 17);
            this.labelMSRP.TabIndex = 15;
            // 
            // labelTDP
            // 
            this.labelTDP.AutoSize = true;
            this.labelTDP.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelTDP.ForeColor = System.Drawing.Color.White;
            this.labelTDP.Location = new System.Drawing.Point(444, 360);
            this.labelTDP.Name = "labelTDP";
            this.labelTDP.Size = new System.Drawing.Size(0, 17);
            this.labelTDP.TabIndex = 14;
            // 
            // toolTipCoreConfig
            // 
            this.toolTipCoreConfig.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCoreConfig.ToolTipTitle = "Core Configuration Details";
            // 
            // labelForCore20
            // 
            this.labelForCore20.AutoSize = true;
            this.labelForCore20.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelForCore20.ForeColor = System.Drawing.Color.White;
            this.labelForCore20.Location = new System.Drawing.Point(525, 151);
            this.labelForCore20.Name = "labelForCore20";
            this.labelForCore20.Size = new System.Drawing.Size(0, 17);
            this.labelForCore20.TabIndex = 16;
            // 
            // labelForCore16
            // 
            this.labelForCore16.AutoSize = true;
            this.labelForCore16.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelForCore16.ForeColor = System.Drawing.Color.White;
            this.labelForCore16.Location = new System.Drawing.Point(496, 151);
            this.labelForCore16.Name = "labelForCore16";
            this.labelForCore16.Size = new System.Drawing.Size(0, 17);
            this.labelForCore16.TabIndex = 17;
            // 
            // labelForCoreStandard
            // 
            this.labelForCoreStandard.AutoSize = true;
            this.labelForCoreStandard.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelForCoreStandard.ForeColor = System.Drawing.Color.White;
            this.labelForCoreStandard.Location = new System.Drawing.Point(476, 151);
            this.labelForCoreStandard.Name = "labelForCoreStandard";
            this.labelForCoreStandard.Size = new System.Drawing.Size(0, 17);
            this.labelForCoreStandard.TabIndex = 18;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::GpuTracker.Properties.Resources.info_logo;
            this.pictureBoxInfo.Location = new System.Drawing.Point(604, 159);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 72;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.MouseHover += new System.EventHandler(this.pictureBoxInfo_MouseHover);
            // 
            // pictureBoxBrand
            // 
            this.pictureBoxBrand.Image = global::GpuTracker.Properties.Resources.nvidia_20;
            this.pictureBoxBrand.Location = new System.Drawing.Point(251, 46);
            this.pictureBoxBrand.Name = "pictureBoxBrand";
            this.pictureBoxBrand.Size = new System.Drawing.Size(243, 50);
            this.pictureBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBrand.TabIndex = 7;
            this.pictureBoxBrand.TabStop = false;
            // 
            // pictureBoxTrans
            // 
            this.pictureBoxTrans.Image = global::GpuTracker.Properties.Resources.nvidia_logo_trans;
            this.pictureBoxTrans.Location = new System.Drawing.Point(82, 41);
            this.pictureBoxTrans.Name = "pictureBoxTrans";
            this.pictureBoxTrans.Size = new System.Drawing.Size(63, 63);
            this.pictureBoxTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrans.TabIndex = 6;
            this.pictureBoxTrans.TabStop = false;
            // 
            // pictureBoxCorner
            // 
            this.pictureBoxCorner.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCorner.Image = global::GpuTracker.Properties.Resources.corner_green_solo;
            this.pictureBoxCorner.Location = new System.Drawing.Point(-1, 213);
            this.pictureBoxCorner.Name = "pictureBoxCorner";
            this.pictureBoxCorner.Size = new System.Drawing.Size(185, 167);
            this.pictureBoxCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCorner.TabIndex = 75;
            this.pictureBoxCorner.TabStop = false;
            // 
            // FormNvidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(632, 408);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelForCoreStandard);
            this.Controls.Add(this.labelForCore16);
            this.Controls.Add(this.labelForCore20);
            this.Controls.Add(this.pictureBoxBrand);
            this.Controls.Add(this.labelMSRP);
            this.Controls.Add(this.labelTDP);
            this.Controls.Add(this.labelBandwidth);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelMemType);
            this.Controls.Add(this.labelBusW);
            this.Controls.Add(this.labelMemClock);
            this.Controls.Add(this.labelClockBoost);
            this.Controls.Add(this.labelClockBase);
            this.Controls.Add(this.labelCoreConfig);
            this.Controls.Add(this.labelArch);
            this.Controls.Add(this.labelCodeName);
            this.Controls.Add(this.labelLaunch);
            this.Controls.Add(this.comboBoxModels);
            this.Controls.Add(this.panelSeries);
            this.Controls.Add(this.labelTitulos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNvidia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop GPU Tracker: Nvidia";
            this.Move += new System.EventHandler(this.FormNvidia_Move);
            this.panelSeries.ResumeLayout(false);
            this.panelSeries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSeries;
        private System.Windows.Forms.RadioButton btn20;
        private System.Windows.Forms.RadioButton btn16;
        private System.Windows.Forms.RadioButton btn10;
        private System.Windows.Forms.RadioButton btn900;
        private System.Windows.Forms.RadioButton btn700;
        private System.Windows.Forms.RadioButton btn600;
        private System.Windows.Forms.ComboBox comboBoxModels;
        private System.Windows.Forms.Label labelTitulos;
        private System.Windows.Forms.Label labelLaunch;
        private System.Windows.Forms.Label labelCodeName;
        private System.Windows.Forms.Label labelArch;
        private System.Windows.Forms.Label labelCoreConfig;
        private System.Windows.Forms.PictureBox pictureBoxBrand;
        private System.Windows.Forms.Label labelClockBoost;
        private System.Windows.Forms.Label labelClockBase;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelMemType;
        private System.Windows.Forms.Label labelBusW;
        private System.Windows.Forms.Label labelMemClock;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.Label labelMSRP;
        private System.Windows.Forms.Label labelTDP;
        private System.Windows.Forms.PictureBox pictureBoxTrans;
        private System.Windows.Forms.ToolTip toolTipCoreConfig;
        private System.Windows.Forms.Label labelForCore20;
        private System.Windows.Forms.Label labelForCore16;
        private System.Windows.Forms.Label labelForCoreStandard;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxCorner;
    }
}