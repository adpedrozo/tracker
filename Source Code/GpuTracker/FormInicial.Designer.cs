namespace GpuTracker
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.buttonCredits = new System.Windows.Forms.Button();
            this.imgVersus = new System.Windows.Forms.PictureBox();
            this.imgRadeon = new System.Windows.Forms.PictureBox();
            this.imgNvidia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVersus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRadeon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNvidia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Black;
            this.buttonCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredits.ForeColor = System.Drawing.Color.White;
            this.buttonCredits.Location = new System.Drawing.Point(179, 251);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(20, 20);
            this.buttonCredits.TabIndex = 3;
            this.buttonCredits.Text = "?";
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // imgVersus
            // 
            this.imgVersus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgVersus.Image = global::GpuTracker.Properties.Resources.vs_logo;
            this.imgVersus.Location = new System.Drawing.Point(67, 173);
            this.imgVersus.Name = "imgVersus";
            this.imgVersus.Size = new System.Drawing.Size(245, 50);
            this.imgVersus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVersus.TabIndex = 2;
            this.imgVersus.TabStop = false;
            this.imgVersus.Click += new System.EventHandler(this.imgVersus_Click);
            this.imgVersus.MouseLeave += new System.EventHandler(this.imgVersus_MouseLeave);
            this.imgVersus.MouseHover += new System.EventHandler(this.imgVersus_MouseHover);
            // 
            // imgRadeon
            // 
            this.imgRadeon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgRadeon.Image = global::GpuTracker.Properties.Resources.radeon_logo_h;
            this.imgRadeon.Location = new System.Drawing.Point(67, 87);
            this.imgRadeon.Name = "imgRadeon";
            this.imgRadeon.Size = new System.Drawing.Size(245, 38);
            this.imgRadeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRadeon.TabIndex = 1;
            this.imgRadeon.TabStop = false;
            this.imgRadeon.Click += new System.EventHandler(this.imgRadeon_Click);
            this.imgRadeon.MouseLeave += new System.EventHandler(this.imgRadeon_MouseLeave);
            this.imgRadeon.MouseHover += new System.EventHandler(this.imgRadeon_MouseHover);
            // 
            // imgNvidia
            // 
            this.imgNvidia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgNvidia.Image = global::GpuTracker.Properties.Resources.nvidia_logo_h;
            this.imgNvidia.Location = new System.Drawing.Point(67, 40);
            this.imgNvidia.Name = "imgNvidia";
            this.imgNvidia.Size = new System.Drawing.Size(245, 37);
            this.imgNvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNvidia.TabIndex = 0;
            this.imgNvidia.TabStop = false;
            this.imgNvidia.Click += new System.EventHandler(this.imgNvidia_Click);
            this.imgNvidia.MouseLeave += new System.EventHandler(this.imgNvidia_MouseLeave);
            this.imgNvidia.MouseHover += new System.EventHandler(this.imgNvidia_MouseHover);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(379, 291);
            this.Controls.Add(this.buttonCredits);
            this.Controls.Add(this.imgVersus);
            this.Controls.Add(this.imgRadeon);
            this.Controls.Add(this.imgNvidia);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop GPU Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.imgVersus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRadeon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNvidia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNvidia;
        private System.Windows.Forms.PictureBox imgRadeon;
        private System.Windows.Forms.PictureBox imgVersus;
        private System.Windows.Forms.Button buttonCredits;
    }
}

