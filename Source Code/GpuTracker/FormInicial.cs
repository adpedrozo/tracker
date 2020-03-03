using System;
using System.Windows.Forms;

namespace GpuTracker
{
    public partial class FormInicial : Form
    {
        DatosGPU datosGPU = new DatosGPU();

        public FormInicial()
        {
            InitializeComponent();
        }

        #region Hover Properties
        private void imgNvidia_MouseHover(object sender, EventArgs e)
        {
            imgNvidia.Image = Properties.Resources.nvidia_logo_h2;
        }

        private void imgNvidia_MouseLeave(object sender, EventArgs e)
        {
            imgNvidia.Image = Properties.Resources.nvidia_logo_h;
        }

        private void imgRadeon_MouseHover(object sender, EventArgs e)
        {
            imgRadeon.Image = Properties.Resources.radeon_logo_h2;
        }

        private void imgRadeon_MouseLeave(object sender, EventArgs e)
        {
            imgRadeon.Image = Properties.Resources.radeon_logo_h;
        }

        private void imgVersus_MouseHover(object sender, EventArgs e)
        {
            imgVersus.Image = Properties.Resources.vs_logo_2;
        }

        private void imgVersus_MouseLeave(object sender, EventArgs e)
        {
            imgVersus.Image = Properties.Resources.vs_logo;
        }

        #endregion

        private void imgNvidia_Click(object sender, EventArgs e)
        {
            FormNvidia FNvidia = new FormNvidia();
            FNvidia.Show();
        }

        private void imgRadeon_Click(object sender, EventArgs e)
        {
            FormRadeon FRadeon = new FormRadeon();
            FRadeon.Show();
        }

        private void imgVersus_Click(object sender, EventArgs e)
        {
            FormVersus FVersus = new FormVersus();
            FVersus.Show();
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is free to distribute.\n\n" +
                            "Nvidia & AMD Radeon brands and logos are used for non-commercial and informational purposes.\n\n" +

                            "Developed by Tech. Alejandro Pedrozo ©2019\n" +
                            "Contact: adpedrozo@gmail.com\n\n" +

                            "Database Version: " + datosGPU.DataBaseVersion(),

                            "Desktop GPU Tracker " + datosGPU.AppVersion(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
