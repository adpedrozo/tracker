using System;
using System.Windows.Forms;

namespace GpuTracker
{
    public partial class FormRadeon : Form
    {
        DatosGPU datosGPU = new DatosGPU();

        public FormRadeon()
        {
            InitializeComponent();

            pictureBoxInfo.Visible = false;
            btn5000.Checked = true;
        }

        private void HideTooltip()
        {
            toolTipCoreConfig.Hide(labelForCoreOld);
            toolTipCoreConfig.Hide(labelForCoreNew);
        }

        private void FormRadeon_Move(object sender, EventArgs e)
        {
            HideTooltip();
        }

        private void btnHD7000_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "HD 7000 Series");
        }

        private void btnHD8000_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "HD 8000 Series");
        }

        private void btn200_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX 200 Series");
        }

        private void btn300_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX 300 Series");
        }

        private void btn400_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX 400 Series");
        }

        private void btn500_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX 500 Series");
        }

        private void btnVega_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX Vega Series");
        }

        private void btn5000_CheckedChanged(object sender, EventArgs e)
        {
            HideTooltip();
            pictureBoxInfo.Visible = false;
            datosGPU.VaciarComboBox(comboBoxModels);
            comboBoxModels.Text = ">>> Select Models >>>";
            datosGPU.VaciarDetalles(labelLaunch, labelCodeName, labelArch, labelCoreConfig, labelClockBase,
                    labelClockBoost, labelMemClock, labelBusW, labelMemType, labelSize, labelBandwidth,
                    labelTDP, labelMSRP);

            datosGPU.MostrarModelos(comboBoxModels, "RX 5000 Series");
        }

        private void comboBoxModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModels.SelectedItem)
            {
                #region HD 7000 Series

                case "Radeon HD 7350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7350 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7450 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7470 GDDR5":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7470 GDDR5", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7510 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7510 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7570", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7670", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7730", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7750":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7750", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7770", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7790":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7790", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7850":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7850", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7870 XT":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870 XT", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7950", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7970", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 7990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7990", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region HD 8000 Series

                case "Radeon HD 8350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8350 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8450 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8470":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8470", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8490":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8490", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8570", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8670", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8730", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8760":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8760", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8770", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8870", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8950", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8970", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon HD 8990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8990", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX 200 Series

                case "Radeon R5 220":
                    datosGPU.MostrarDetallesGPU("Radeon R5 220", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 230":
                    datosGPU.MostrarDetallesGPU("Radeon R5 230", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 235":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 235X":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 240":
                    datosGPU.MostrarDetallesGPU("Radeon R5 240", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 240":
                    datosGPU.MostrarDetallesGPU("Radeon R7 240", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 250":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 250E":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250E", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 250X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 260":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 260X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 265":
                    datosGPU.MostrarDetallesGPU("Radeon R7 265", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 270":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 270X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 280":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 280X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 285":
                    datosGPU.MostrarDetallesGPU("Radeon R9 285", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 290":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 290X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 295":
                    datosGPU.MostrarDetallesGPU("Radeon R9 295", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX 300 Series

                case "Radeon R5 330 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 330 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 340 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R5 340X DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340X DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 340":
                    datosGPU.MostrarDetallesGPU("Radeon R7 340", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 350":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 350X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 360":
                    datosGPU.MostrarDetallesGPU("Radeon R7 360", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R7 370":
                    datosGPU.MostrarDetallesGPU("Radeon R7 370", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 360":
                    datosGPU.MostrarDetallesGPU("Radeon R9 360", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 370":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 370X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 380":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 380X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 390":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 390X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 Fury":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 Fury X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury X", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon R9 Nano":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Nano", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreOld, toolTipCoreConfig);
                    break;
                case "Radeon Pro Duo":
                    datosGPU.MostrarDetallesGPU("Radeon Pro Duo", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX 400 Series

                case "Radeon R5 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 430 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon R5 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 435 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon R7 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 430 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon R7 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 435 DDR3", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon R7 450":
                    datosGPU.MostrarDetallesGPU("Radeon R7 450", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 455":
                    datosGPU.MostrarDetallesGPU("Radeon RX 455", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 460":
                    datosGPU.MostrarDetallesGPU("Radeon RX 460", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 470":
                    datosGPU.MostrarDetallesGPU("Radeon RX 470", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 480":
                    datosGPU.MostrarDetallesGPU("Radeon RX 480", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX 500 Series

                case "Radeon RX 540":
                    datosGPU.MostrarDetallesGPU("Radeon RX 540", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 550":
                    datosGPU.MostrarDetallesGPU("Radeon RX 550", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 560":
                    datosGPU.MostrarDetallesGPU("Radeon RX 560", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 570":
                    datosGPU.MostrarDetallesGPU("Radeon RX 570", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 580":
                    datosGPU.MostrarDetallesGPU("Radeon RX 580", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 590":
                    datosGPU.MostrarDetallesGPU("Radeon RX 590", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX Vega Series

                case "Radeon RX Vega 56":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 56", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX Vega 64":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX Vega 64 Liquid":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64 Liquid", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon VII":
                    datosGPU.MostrarDetallesGPU("Radeon VII", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                #endregion

                #region RX 5000 Series

                case "Radeon RX 5500 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5500 XT", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 5600 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5600 XT", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 5700":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;
                case "Radeon RX 5700 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700 XT", labelLaunch, labelCodeName, labelArch,
                        labelCoreConfig, labelClockBase, labelClockBoost, labelMemClock, labelBusW,
                        labelMemType, labelSize, labelBandwidth, labelTDP, labelMSRP, labelForCoreNew, toolTipCoreConfig);
                    break;

                    #endregion
            }
            pictureBoxInfo.Visible = true;
        }

        private void pictureBoxInfo_MouseHover(object sender, EventArgs e)
        {
            if (btnHD7000.Checked == true || btnHD8000.Checked == true ||
                btn200.Checked == true || btn300.Checked == true)
            {
                datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCoreOld, "Radeon1");
            }
            
            if (btn400.Checked == true || btn500.Checked == true || btnVega.Checked == true || btn5000.Checked == true)
            {
                datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCoreNew, "Radeon2");
            }

            if ((btnHD7000.Checked == true && comboBoxModels.Text == "Radeon HD 7990") ||
                (btnHD8000.Checked == true && comboBoxModels.Text == "Radeon HD 8990") ||
                (btn200.Checked == true && comboBoxModels.Text == "Radeon R9 295") ||
                (btn300.Checked == true && comboBoxModels.Text == "Radeon Pro Duo"))
            {
                datosGPU.MostrarCoreInfo(toolTipCoreConfig, labelForCoreNew, "Radeon1");
            }
        }
    }
}
