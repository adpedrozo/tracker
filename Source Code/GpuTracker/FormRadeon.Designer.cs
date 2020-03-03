namespace GpuTracker
{
    partial class FormRadeon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRadeon));
            this.panelSeries = new System.Windows.Forms.Panel();
            this.btn5000 = new System.Windows.Forms.RadioButton();
            this.btnVega = new System.Windows.Forms.RadioButton();
            this.btn500 = new System.Windows.Forms.RadioButton();
            this.btn400 = new System.Windows.Forms.RadioButton();
            this.btn300 = new System.Windows.Forms.RadioButton();
            this.btn200 = new System.Windows.Forms.RadioButton();
            this.btnHD8000 = new System.Windows.Forms.RadioButton();
            this.btnHD7000 = new System.Windows.Forms.RadioButton();
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
            this.labelForCoreNew = new System.Windows.Forms.Label();
            this.labelForCoreOld = new System.Windows.Forms.Label();
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
            this.panelSeries.Controls.Add(this.btn5000);
            this.panelSeries.Controls.Add(this.btnVega);
            this.panelSeries.Controls.Add(this.pictureBoxTrans);
            this.panelSeries.Controls.Add(this.btn500);
            this.panelSeries.Controls.Add(this.btn400);
            this.panelSeries.Controls.Add(this.btn300);
            this.panelSeries.Controls.Add(this.btn200);
            this.panelSeries.Controls.Add(this.btnHD8000);
            this.panelSeries.Controls.Add(this.btnHD7000);
            this.panelSeries.Controls.Add(this.pictureBoxCorner);
            this.panelSeries.Location = new System.Drawing.Point(12, 12);
            this.panelSeries.Name = "panelSeries";
            this.panelSeries.Size = new System.Drawing.Size(227, 382);
            this.panelSeries.TabIndex = 0;
            // 
            // btn5000
            // 
            this.btn5000.AutoSize = true;
            this.btn5000.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5000.ForeColor = System.Drawing.Color.White;
            this.btn5000.Location = new System.Drawing.Point(49, 319);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(120, 21);
            this.btn5000.TabIndex = 8;
            this.btn5000.TabStop = true;
            this.btn5000.Text = "RX 5000 Series";
            this.btn5000.UseVisualStyleBackColor = true;
            this.btn5000.CheckedChanged += new System.EventHandler(this.btn5000_CheckedChanged);
            // 
            // btnVega
            // 
            this.btnVega.AutoSize = true;
            this.btnVega.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVega.ForeColor = System.Drawing.Color.White;
            this.btnVega.Location = new System.Drawing.Point(49, 292);
            this.btnVega.Name = "btnVega";
            this.btnVega.Size = new System.Drawing.Size(119, 21);
            this.btnVega.TabIndex = 7;
            this.btnVega.TabStop = true;
            this.btnVega.Text = "RX Vega Series";
            this.btnVega.UseVisualStyleBackColor = true;
            this.btnVega.CheckedChanged += new System.EventHandler(this.btnVega_CheckedChanged);
            // 
            // btn500
            // 
            this.btn500.AutoSize = true;
            this.btn500.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(49, 265);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(112, 21);
            this.btn500.TabIndex = 5;
            this.btn500.TabStop = true;
            this.btn500.Text = "RX 500 Series";
            this.btn500.UseVisualStyleBackColor = true;
            this.btn500.CheckedChanged += new System.EventHandler(this.btn500_CheckedChanged);
            // 
            // btn400
            // 
            this.btn400.AutoSize = true;
            this.btn400.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn400.ForeColor = System.Drawing.Color.White;
            this.btn400.Location = new System.Drawing.Point(49, 238);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(112, 21);
            this.btn400.TabIndex = 4;
            this.btn400.TabStop = true;
            this.btn400.Text = "RX 400 Series";
            this.btn400.UseVisualStyleBackColor = true;
            this.btn400.CheckedChanged += new System.EventHandler(this.btn400_CheckedChanged);
            // 
            // btn300
            // 
            this.btn300.AutoSize = true;
            this.btn300.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn300.ForeColor = System.Drawing.Color.White;
            this.btn300.Location = new System.Drawing.Point(49, 211);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(112, 21);
            this.btn300.TabIndex = 3;
            this.btn300.TabStop = true;
            this.btn300.Text = "RX 300 Series";
            this.btn300.UseVisualStyleBackColor = true;
            this.btn300.CheckedChanged += new System.EventHandler(this.btn300_CheckedChanged);
            // 
            // btn200
            // 
            this.btn200.AutoSize = true;
            this.btn200.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200.ForeColor = System.Drawing.Color.White;
            this.btn200.Location = new System.Drawing.Point(49, 184);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(112, 21);
            this.btn200.TabIndex = 2;
            this.btn200.TabStop = true;
            this.btn200.Text = "RX 200 Series";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.CheckedChanged += new System.EventHandler(this.btn200_CheckedChanged);
            // 
            // btnHD8000
            // 
            this.btnHD8000.AutoSize = true;
            this.btnHD8000.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD8000.ForeColor = System.Drawing.Color.White;
            this.btnHD8000.Location = new System.Drawing.Point(49, 157);
            this.btnHD8000.Name = "btnHD8000";
            this.btnHD8000.Size = new System.Drawing.Size(124, 21);
            this.btnHD8000.TabIndex = 1;
            this.btnHD8000.TabStop = true;
            this.btnHD8000.Text = "HD 8000 Series";
            this.btnHD8000.UseVisualStyleBackColor = true;
            this.btnHD8000.CheckedChanged += new System.EventHandler(this.btnHD8000_CheckedChanged);
            // 
            // btnHD7000
            // 
            this.btnHD7000.AutoSize = true;
            this.btnHD7000.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD7000.ForeColor = System.Drawing.Color.White;
            this.btnHD7000.Location = new System.Drawing.Point(49, 130);
            this.btnHD7000.Name = "btnHD7000";
            this.btnHD7000.Size = new System.Drawing.Size(124, 21);
            this.btnHD7000.TabIndex = 0;
            this.btnHD7000.TabStop = true;
            this.btnHD7000.Text = "HD 7000 Series";
            this.btnHD7000.UseVisualStyleBackColor = true;
            this.btnHD7000.CheckedChanged += new System.EventHandler(this.btnHD7000_CheckedChanged);
            // 
            // comboBoxModels
            // 
            this.comboBoxModels.BackColor = System.Drawing.Color.Black;
            this.comboBoxModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModels.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxModels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
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
            // labelForCoreNew
            // 
            this.labelForCoreNew.AutoSize = true;
            this.labelForCoreNew.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelForCoreNew.ForeColor = System.Drawing.Color.White;
            this.labelForCoreNew.Location = new System.Drawing.Point(496, 151);
            this.labelForCoreNew.Name = "labelForCoreNew";
            this.labelForCoreNew.Size = new System.Drawing.Size(0, 17);
            this.labelForCoreNew.TabIndex = 17;
            // 
            // labelForCoreOld
            // 
            this.labelForCoreOld.AutoSize = true;
            this.labelForCoreOld.Font = new System.Drawing.Font("Malgun Gothic", 9.75F);
            this.labelForCoreOld.ForeColor = System.Drawing.Color.White;
            this.labelForCoreOld.Location = new System.Drawing.Point(476, 151);
            this.labelForCoreOld.Name = "labelForCoreOld";
            this.labelForCoreOld.Size = new System.Drawing.Size(0, 17);
            this.labelForCoreOld.TabIndex = 18;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::GpuTracker.Properties.Resources.info_logo;
            this.pictureBoxInfo.Location = new System.Drawing.Point(604, 159);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfo.TabIndex = 73;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.MouseHover += new System.EventHandler(this.pictureBoxInfo_MouseHover);
            // 
            // pictureBoxBrand
            // 
            this.pictureBoxBrand.Image = global::GpuTracker.Properties.Resources.radeon_amd;
            this.pictureBoxBrand.Location = new System.Drawing.Point(246, 50);
            this.pictureBoxBrand.Name = "pictureBoxBrand";
            this.pictureBoxBrand.Size = new System.Drawing.Size(158, 42);
            this.pictureBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBrand.TabIndex = 7;
            this.pictureBoxBrand.TabStop = false;
            // 
            // pictureBoxTrans
            // 
            this.pictureBoxTrans.Image = global::GpuTracker.Properties.Resources.radeon_logo_trans;
            this.pictureBoxTrans.Location = new System.Drawing.Point(80, 36);
            this.pictureBoxTrans.Name = "pictureBoxTrans";
            this.pictureBoxTrans.Size = new System.Drawing.Size(63, 63);
            this.pictureBoxTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTrans.TabIndex = 6;
            this.pictureBoxTrans.TabStop = false;
            // 
            // pictureBoxCorner
            // 
            this.pictureBoxCorner.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCorner.Image = global::GpuTracker.Properties.Resources.corner_red_solo;
            this.pictureBoxCorner.Location = new System.Drawing.Point(-1, 213);
            this.pictureBoxCorner.Name = "pictureBoxCorner";
            this.pictureBoxCorner.Size = new System.Drawing.Size(185, 167);
            this.pictureBoxCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCorner.TabIndex = 74;
            this.pictureBoxCorner.TabStop = false;
            // 
            // FormRadeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(632, 408);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.labelForCoreOld);
            this.Controls.Add(this.labelForCoreNew);
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
            this.Name = "FormRadeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop GPU Tracker: AMD Radeon";
            this.Move += new System.EventHandler(this.FormRadeon_Move);
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
        private System.Windows.Forms.RadioButton btn500;
        private System.Windows.Forms.RadioButton btn400;
        private System.Windows.Forms.RadioButton btn300;
        private System.Windows.Forms.RadioButton btn200;
        private System.Windows.Forms.RadioButton btnHD8000;
        private System.Windows.Forms.RadioButton btnHD7000;
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
        private System.Windows.Forms.Label labelForCoreNew;
        private System.Windows.Forms.Label labelForCoreOld;
        private System.Windows.Forms.RadioButton btn5000;
        private System.Windows.Forms.RadioButton btnVega;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.PictureBox pictureBoxCorner;
    }
}