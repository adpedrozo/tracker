using System;
using System.Windows.Forms;

namespace GpuTracker
{
    public partial class FormNvidia : Form
    {
        DatosGPU datosGPU = new DatosGPU();

        public FormNvidia()
        {
            InitializeComponent();

            pictureBoxInfo.Visible = false;
            btn20.Checked = true;
        }

        private void HideTooltip()
        {
            toolTipCoreConfig.Hide(labelForCoreStandard);
            toolTipCoreConfig.Hide(labelForCore16);
            toolTipCoreConfig.Hide(labelForCore20);
        }

        private void FormNvidia_Move(object sender, EventArgs e)
        {
            HideTooltip();
        }

        private void btn600_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_600;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels,"GeForce 600 Series");
        }

        private void btn700_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_700;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "GeForce 700 Series");
        }

        private void btn900_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_900;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "GeForce 900 Series");
        }

        private void btn10_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_10;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "GeForce 10 Series");
        }

        private void btn16_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_16;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "GeForce 16 Series");
        }

        private void btn20_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            pictureBoxBrand.Image = Properties.Resources.nvidia_20;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "GeForce 20 Series");
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModels.SelectedItem)
            {
                #region 600 Series

                case "GeForce GT 610 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 610 DDR3", labelLaunch, labelCodeName, labelArch,
                       labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                       labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 620 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 620 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 630 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 630 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 640 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 640 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 650 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 670":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 670", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 680":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 680", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 690":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 690", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;

                #endregion

                #region 700 Series

                case "GeForce GT 720 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 720 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 730 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 730 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 740 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 740 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 750":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 750 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 760":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 760 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 770":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 770", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 780":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 780 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX Titan":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX Titan Black":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Black", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX Titan Z":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Z", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;

                #endregion

                #region 900 Series

                case "GeForce GTX 950":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 950", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 960":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 960", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 970":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 970", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 980":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 980 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX Titan X":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;

                #endregion

                #region 10 Series

                case "GeForce GT 1030 DDR4":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 DDR4", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GT 1030 GDDR5":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 GDDR5", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1050 2GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 2GB", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1050 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 3GB", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1050 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1060 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 3GB", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1060 6GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 6GB", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1070":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1070 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1080":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "Nvidia Titan X":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;
                case "Nvidia Titan XP":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan XP", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreStandard, toolTipCoreConfig);
                    break;

                #endregion

                #region 16 Series

                case "GeForce GTX 1650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1650 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650 Super", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1660 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Super", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;
                case "GeForce GTX 1660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore16, toolTipCoreConfig);
                    break;

                #endregion

                #region 20 Series

                case "GeForce RTX 2060":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2060 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060 Super", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2070":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2070 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070 Super", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2080":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2080 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Super", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "GeForce RTX 2080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Ti", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;
                case "Nvidia Titan RTX":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan RTX", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCore20, toolTipCoreConfig);
                    break;

                    #endregion
            }
            pictureBoxInfo.Visible = true;
        }

        private void pictureBoxInfo_MouseHover(object sender, EventArgs e)
        {
            if (btn600.Checked == true || btn700.Checked == true || btn900.Checked == true || btn10.Checked == true)
            {
                datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCoreStandard, "Nvidia1");
            }
            if (btn16.Checked == true) { datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCore16, "Nvidia2"); }
            if (btn20.Checked == true) { datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCore20, "Nvidia3"); }

            if ( (btn600.Checked == true && comboBoxModels.Text == "GeForce GTX 690") ||
                 (btn700.Checked == true && comboBoxModels.Text == "GeForce GTX Titan Z") )
            {
                datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCore16, "Nvidia1");
            }
        }
    }
}
