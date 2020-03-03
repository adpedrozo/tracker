using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GpuTracker
{
    public partial class FormVersus : Form
    {
        DatosGPU datosGPU = new DatosGPU();
     
        public FormVersus()
        {
            InitializeComponent();
            labelCreditos.Text = "Desktop GPU Tracker " + datosGPU.AppVersion();

            buttonInvisible.Visible = false;
            labelCreditos.Visible = false;
            pictureBoxInfo1.Visible = false;
            pictureBoxInfo2.Visible = false;

            comboBoxBrand1.TabIndex = 0;
            comboBoxFamily1.TabIndex = 1;
            comboBoxModels1.TabIndex = 2;
            comboBoxBrand2.TabIndex = 3;
            comboBoxFamily2.TabIndex = 4;
            comboBoxModels2.TabIndex = 5;

            buttonInvisible.Select();
            comboBoxBrand1.SelectedItem = "AMD Radeon";
            comboBoxBrand2.SelectedItem = "Nvidia";
        }

        private void CambioDeMarcaNvidia(ComboBox cbBrand, ComboBox cbFamily, ComboBox cbModels, PictureBox pb)
        {
            cbBrand.ForeColor = Color.FromArgb(118, 185, 0);
            cbFamily.ForeColor = Color.FromArgb(118, 185, 0);
            cbModels.ForeColor = Color.FromArgb(118, 185, 0);
            if ( pb.Name == "pictureBox1" )
            {
                pb.Image = Properties.Resources.corner_green1;
            }
            else
            {
                pb.Image = Properties.Resources.corner_green2;
            }

            cbFamily.Items.Clear();
            datosGPU.MostrarFamilias(cbFamily, "Nvidia");
            cbFamily.Text = "<<< Select Family <<<";

            cbModels.Items.Clear();
            cbModels.Items.AddRange(new object[] { "" });
            cbModels.Text = "<<< Select Model <<<";
        }

        private void CambioDeMarcaRadeon(ComboBox cbBrand, ComboBox cbFamily, ComboBox cbModels, PictureBox pb)
        {
            cbBrand.ForeColor = Color.FromArgb(222, 0, 50);
            cbFamily.ForeColor = Color.FromArgb(222, 0, 50);
            cbModels.ForeColor = Color.FromArgb(222, 0, 50);
            if (pb.Name == "pictureBox1")
            {
                pb.Image = Properties.Resources.corner_red1;
            }
            else
            {
                pb.Image = Properties.Resources.corner_red2;
            }

            cbFamily.Items.Clear();
            datosGPU.MostrarFamilias(cbFamily, "AMD Radeon");
            cbFamily.Text = "<<< Select Family <<<";

            cbModels.Items.Clear();
            cbModels.Items.AddRange(new object[] { "" });
            cbModels.Text = "<<< Select Model <<<";
        }

        private void FormVersus_Move(object sender, EventArgs e)
        {
            toolTipCoreConfig1.Hide(pictureBoxInfo1);
            toolTipCoreConfig2.Hide(pictureBoxInfo2);
        }

        private void VaciarDetalles(byte lado)
        {
            switch (lado)
            {
                case 1:
                    datosGPU.VaciarDetalles(labelLaunch1, labelCodeName1, labelArch1, labelCoreConfig1, labelClockBase1,
                    labelClockBoost1, labelMemClock1, labelBusW1, labelMemType1, labelSize1, labelBandwidth1,
                    labelTDP1, labelMSRP1);
                    pictureBoxInfo1.Visible = false;
                    toolTipCoreConfig1.Hide(labelForInfo1);
                    break;
                case 2:
                    datosGPU.VaciarDetalles(labelLaunch2, labelCodeName2, labelArch2, labelCoreConfig2, labelClockBase2,
                    labelClockBoost2, labelMemClock2, labelBusW2, labelMemType2, labelSize2, labelBandwidth2,
                    labelTDP2, labelMSRP2);
                    pictureBoxInfo2.Visible = false;
                    toolTipCoreConfig2.Hide(labelForInfo2);
                    break;
            }
        }

        private void comboBoxBrand1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( comboBoxBrand1.SelectedItem.ToString() == "Nvidia" )
            {
                CambioDeMarcaNvidia(comboBoxBrand1, comboBoxFamily1, comboBoxModels1, pictureBox1);
            }
            if ( comboBoxBrand1.SelectedItem.ToString() == "AMD Radeon" )
            {
                CambioDeMarcaRadeon(comboBoxBrand1, comboBoxFamily1, comboBoxModels1, pictureBox1);
            }

            VaciarDetalles(1);
        }

        private void comboBoxBrand2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBrand2.SelectedItem.ToString() == "Nvidia")
            {
                CambioDeMarcaNvidia(comboBoxBrand2, comboBoxFamily2, comboBoxModels2, pictureBox2);
            }
            if (comboBoxBrand2.SelectedItem.ToString() == "AMD Radeon")
            {
                CambioDeMarcaRadeon(comboBoxBrand2, comboBoxFamily2, comboBoxModels2, pictureBox2);
            }

            VaciarDetalles(2);
        }

        private void comboBoxFamily1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFamily1.SelectedItem)
            {
                case "GeForce 600 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 600 Series");
                    break;
                case "GeForce 700 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 700 Series");
                    break;
                case "GeForce 900 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 900 Series");
                    break;
                case "GeForce 10 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 10 Series");
                    break;
                case "GeForce 16 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 16 Series");
                    break;
                case "GeForce 20 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "GeForce 20 Series");
                    break;

                case "HD 7000 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "HD 7000 Series");
                    break;
                case "HD 8000 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "HD 8000 Series");
                    break;
                case "RX 200 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX 200 Series");
                    break;
                case "RX 300 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX 300 Series");
                    break;
                case "RX 400 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX 400 Series");
                    break;
                case "RX 500 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX 500 Series");
                    break;
                case "RX Vega Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX Vega Series");
                    break;
                case "RX 5000 Series":
                    datosGPU.MostrarModelos(comboBoxModels1, "RX 5000 Series");
                    break;

                default:
                    datosGPU.VaciarComboBox(comboBoxModels1);
                    break;
            }
            comboBoxModels1.Text = "<<< Select Model <<<";
            VaciarDetalles(1);
        }

        private void comboBoxFamily2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFamily2.SelectedItem)
            {
                case "GeForce 600 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 600 Series");
                    break;
                case "GeForce 700 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 700 Series");
                    break;
                case "GeForce 900 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 900 Series");
                    break;
                case "GeForce 10 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 10 Series");
                    break;
                case "GeForce 16 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 16 Series");
                    break;
                case "GeForce 20 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "GeForce 20 Series");
                    break;

                case "HD 7000 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "HD 7000 Series");
                    break;
                case "HD 8000 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "HD 8000 Series");
                    break;
                case "RX 200 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX 200 Series");
                    break;
                case "RX 300 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX 300 Series");
                    break;
                case "RX 400 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX 400 Series");
                    break;
                case "RX 500 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX 500 Series");
                    break;
                case "RX Vega Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX Vega Series");
                    break;
                case "RX 5000 Series":
                    datosGPU.MostrarModelos(comboBoxModels2, "RX 5000 Series");
                    break;

                default:
                    datosGPU.VaciarComboBox(comboBoxModels2);
                    break;
            }
            comboBoxModels2.Text = "<<< Select Model <<<";
            VaciarDetalles(2);
        }

        private void pictureBoxInfo1_MouseHover(object sender, EventArgs e)
        {
            datosGPU.MostrarCoreInfoHover(comboBoxFamily1, toolTipCoreConfig1, labelForInfo1);
        }

        private void pictureBoxInfo2_MouseHover(object sender, EventArgs e)
        {
            datosGPU.MostrarCoreInfoHover(comboBoxFamily2, toolTipCoreConfig2, labelForInfo2);
        }

        private void comboBoxModels1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModels1.SelectedItem)
            {
                #region 600 Series

                case "GeForce GT 610 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 610 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                       labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                       labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 620 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 620 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 630 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 630 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 640 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 640 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 650 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 670":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 670", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 680":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 680", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 690":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 690", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region 700 Series

                case "GeForce GT 720 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 720 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 730 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 730 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 740 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 740 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 750":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 750 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 760":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 760 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 770":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 770", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 780":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 780 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX Titan":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX Titan Black":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Black", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX Titan Z":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Z", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region 900 Series

                case "GeForce GTX 950":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 950", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 960":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 960", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 970":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 970", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 980":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 980 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX Titan X":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region 10 Series

                case "GeForce GT 1030 DDR4":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 DDR4", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GT 1030 GDDR5":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 GDDR5", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1050 2GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 2GB", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1050 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 3GB", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1050 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1060 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 3GB", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1060 6GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 6GB", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1070":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1070 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1080":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Nvidia Titan X":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Nvidia Titan XP":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan XP", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region 16 Series

                case "GeForce GTX 1650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1650 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650 Super", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1660 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Super", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce GTX 1660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region 20 Series

                case "GeForce RTX 2060":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2060 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060 Super", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2070":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2070 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070 Super", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2080":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2080 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Super", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "GeForce RTX 2080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Ti", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Nvidia Titan RTX":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan RTX", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion


                #region HD 7000 Series

                case "Radeon HD 7350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7350 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7450 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7470 GDDR5":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7470 GDDR5", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7510 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7510 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7570", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7670", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7730", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7750":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7750", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7770", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7790":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7790", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7850":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7850", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7870 XT":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870 XT", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7950", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7970", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 7990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7990", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region HD 8000 Series

                case "Radeon HD 8350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8350 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8450 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8470":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8470", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8490":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8490", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8570", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8670", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8730", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8760":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8760", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8770", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8870", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8950", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8970", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon HD 8990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8990", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX 200 Series

                case "Radeon R5 220":
                    datosGPU.MostrarDetallesGPU("Radeon R5 220", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 230":
                    datosGPU.MostrarDetallesGPU("Radeon R5 230", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 235":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 235X":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 240":
                    datosGPU.MostrarDetallesGPU("Radeon R5 240", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 240":
                    datosGPU.MostrarDetallesGPU("Radeon R7 240", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 250":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 250E":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250E", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 250X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 260":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 260X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 265":
                    datosGPU.MostrarDetallesGPU("Radeon R7 265", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 270":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 270X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 280":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 280X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 285":
                    datosGPU.MostrarDetallesGPU("Radeon R9 285", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 290":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 290X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 295":
                    datosGPU.MostrarDetallesGPU("Radeon R9 295", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX 300 Series

                case "Radeon R5 330 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 330 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 340 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 340X DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340X DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 340":
                    datosGPU.MostrarDetallesGPU("Radeon R7 340", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 350":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 350X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 360":
                    datosGPU.MostrarDetallesGPU("Radeon R7 360", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 370":
                    datosGPU.MostrarDetallesGPU("Radeon R7 370", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 360":
                    datosGPU.MostrarDetallesGPU("Radeon R9 360", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 370":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 370X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 380":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 380X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 390":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 390X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 Fury":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 Fury X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury X", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R9 Nano":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Nano", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon Pro Duo":
                    datosGPU.MostrarDetallesGPU("Radeon Pro Duo", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX 400 Series

                case "Radeon R5 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 430 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R5 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 435 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 430 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 435 DDR3", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon R7 450":
                    datosGPU.MostrarDetallesGPU("Radeon R7 450", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 455":
                    datosGPU.MostrarDetallesGPU("Radeon RX 455", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 460":
                    datosGPU.MostrarDetallesGPU("Radeon RX 460", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 470":
                    datosGPU.MostrarDetallesGPU("Radeon RX 470", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 480":
                    datosGPU.MostrarDetallesGPU("Radeon RX 480", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX 500 Series

                case "Radeon RX 540":
                    datosGPU.MostrarDetallesGPU("Radeon RX 540", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 550":
                    datosGPU.MostrarDetallesGPU("Radeon RX 550", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 560":
                    datosGPU.MostrarDetallesGPU("Radeon RX 560", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 570":
                    datosGPU.MostrarDetallesGPU("Radeon RX 570", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 580":
                    datosGPU.MostrarDetallesGPU("Radeon RX 580", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 590":
                    datosGPU.MostrarDetallesGPU("Radeon RX 590", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX Vega Series

                case "Radeon RX Vega 56":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 56", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX Vega 64":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX Vega 64 Liquid":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64 Liquid", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon VII":
                    datosGPU.MostrarDetallesGPU("Radeon VII", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                #endregion

                #region RX 5000 Series

                case "Radeon RX 5500 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5500 XT", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 5600 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5600 XT", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 5700":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;
                case "Radeon RX 5700 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700 XT", labelLaunch1, labelCodeName1, labelArch1,
                        labelCoreConfig1, labelClockBase1, labelClockBoost1, labelMemClock1, labelBusW1,
                        labelMemType1, labelSize1, labelBandwidth1, labelTDP1, labelMSRP1, labelForInfo1, toolTipCoreConfig1);
                    break;

                    #endregion
            }
            if ( comboBoxModels1.SelectedItem.ToString() != "" )
            {
                pictureBoxInfo1.Visible = true;
            }
        }

        private void comboBoxModels2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModels2.SelectedItem)
            {
                #region 600 Series

                case "GeForce GT 610 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 610 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                       labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                       labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 620 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 620 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 630 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 630 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 640 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 640 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 650 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 650 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 660 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 670":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 670", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 680":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 680", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 690":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 690", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region 700 Series

                case "GeForce GT 720 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 720 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 730 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 730 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 740 DDR3":
                    datosGPU.MostrarDetallesGPU("GeForce GT 740 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 750":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 750 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 750 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 760":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 760 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 760 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 770":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 770", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 780":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 780 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 780 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX Titan":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX Titan Black":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Black", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX Titan Z":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan Z", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region 900 Series

                case "GeForce GTX 950":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 950", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 960":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 960", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 970":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 970", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 980":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 980 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 980 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX Titan X":
                    datosGPU.MostrarDetallesGPU("GeForce GTX Titan X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region 10 Series

                case "GeForce GT 1030 DDR4":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 DDR4", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GT 1030 GDDR5":
                    datosGPU.MostrarDetallesGPU("GeForce GT 1030 GDDR5", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1050 2GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 2GB", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1050 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 3GB", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1050 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1050 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1060 3GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 3GB", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1060 6GB":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1060 6GB", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1070":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1070 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1070 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1080":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1080 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Nvidia Titan X":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Nvidia Titan XP":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan XP", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region 16 Series

                case "GeForce GTX 1650":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1650 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1650 Super", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1660":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1660 Super":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Super", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce GTX 1660 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce GTX 1660 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region 20 Series

                case "GeForce RTX 2060":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2060 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2060 Super", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2070":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2070 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2070 Super", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2080":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2080 Super":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Super", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "GeForce RTX 2080 Ti":
                    datosGPU.MostrarDetallesGPU("GeForce RTX 2080 Ti", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Nvidia Titan RTX":
                    datosGPU.MostrarDetallesGPU("Nvidia Titan RTX", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion


                #region HD 7000 Series

                case "Radeon HD 7350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7350 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7450 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7470 GDDR5":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7470 GDDR5", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7510 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7510 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7570", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7670", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7730", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7750":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7750", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7770", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7790":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7790", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7850":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7850", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7870 XT":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7870 XT", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7950", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7970", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 7990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 7990", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region HD 8000 Series

                case "Radeon HD 8350 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8350 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8450 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8450 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8470":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8470", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8490":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8490", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8570":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8570", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8670":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8670", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8730":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8730", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8760":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8760", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8770":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8770", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8870":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8870", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8950":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8950", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8970":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8970", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon HD 8990":
                    datosGPU.MostrarDetallesGPU("Radeon HD 8990", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX 200 Series

                case "Radeon R5 220":
                    datosGPU.MostrarDetallesGPU("Radeon R5 220", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 230":
                    datosGPU.MostrarDetallesGPU("Radeon R5 230", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 235":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 235X":
                    datosGPU.MostrarDetallesGPU("Radeon R5 235X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 240":
                    datosGPU.MostrarDetallesGPU("Radeon R5 240", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 240":
                    datosGPU.MostrarDetallesGPU("Radeon R7 240", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 250":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 250E":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250E", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 250X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 250X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 260":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 260X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 260X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 265":
                    datosGPU.MostrarDetallesGPU("Radeon R7 265", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 270":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 270X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 270X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 280":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 280X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 280X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 285":
                    datosGPU.MostrarDetallesGPU("Radeon R9 285", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 290":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 290X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 290X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 295":
                    datosGPU.MostrarDetallesGPU("Radeon R9 295", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX 300 Series

                case "Radeon R5 330 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 330 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 340 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 340X DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 340X DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 340":
                    datosGPU.MostrarDetallesGPU("Radeon R7 340", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 350":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 350X":
                    datosGPU.MostrarDetallesGPU("Radeon R7 350X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 360":
                    datosGPU.MostrarDetallesGPU("Radeon R7 360", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 370":
                    datosGPU.MostrarDetallesGPU("Radeon R7 370", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 360":
                    datosGPU.MostrarDetallesGPU("Radeon R9 360", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 370":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 370X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 370X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 380":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 380X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 380X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 390":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 390X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 390X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 Fury":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 Fury X":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Fury X", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R9 Nano":
                    datosGPU.MostrarDetallesGPU("Radeon R9 Nano", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon Pro Duo":
                    datosGPU.MostrarDetallesGPU("Radeon Pro Duo", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX 400 Series

                case "Radeon R5 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 430 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R5 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R5 435 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 430 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 430 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 435 DDR3":
                    datosGPU.MostrarDetallesGPU("Radeon R7 435 DDR3", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon R7 450":
                    datosGPU.MostrarDetallesGPU("Radeon R7 450", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 455":
                    datosGPU.MostrarDetallesGPU("Radeon RX 455", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 460":
                    datosGPU.MostrarDetallesGPU("Radeon RX 460", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 470":
                    datosGPU.MostrarDetallesGPU("Radeon RX 470", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 480":
                    datosGPU.MostrarDetallesGPU("Radeon RX 480", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX 500 Series

                case "Radeon RX 540":
                    datosGPU.MostrarDetallesGPU("Radeon RX 540", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 550":
                    datosGPU.MostrarDetallesGPU("Radeon RX 550", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 560":
                    datosGPU.MostrarDetallesGPU("Radeon RX 560", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 570":
                    datosGPU.MostrarDetallesGPU("Radeon RX 570", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 580":
                    datosGPU.MostrarDetallesGPU("Radeon RX 580", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 590":
                    datosGPU.MostrarDetallesGPU("Radeon RX 590", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX Vega Series

                case "Radeon RX Vega 56":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 56", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX Vega 64":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX Vega 64 Liquid":
                    datosGPU.MostrarDetallesGPU("Radeon RX Vega 64 Liquid", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon VII":
                    datosGPU.MostrarDetallesGPU("Radeon VII", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                #endregion

                #region RX 5000 Series

                case "Radeon RX 5500 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5500 XT", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 5600 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5600 XT", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 5700":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;
                case "Radeon RX 5700 XT":
                    datosGPU.MostrarDetallesGPU("Radeon RX 5700 XT", labelLaunch2, labelCodeName2, labelArch2,
                        labelCoreConfig2, labelClockBase2, labelClockBoost2, labelMemClock2, labelBusW2,
                        labelMemType2, labelSize2, labelBandwidth2, labelTDP2, labelMSRP2, labelForInfo2, toolTipCoreConfig2);
                    break;

                    #endregion
            }
            if (comboBoxModels2.SelectedItem.ToString() != "")
            {
                pictureBoxInfo2.Visible = true;
            }
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveDialog.ShowDialog())
            {
                buttonInvisible.Select();
                pictureBoxSave.Image = Properties.Resources.gpu_logo;
                string nombreArchivo = saveDialog.FileName;
                this.FormBorderStyle = FormBorderStyle.None;
                labelCreditos.Visible = true;
                pictureBoxInfo1.Visible = false;
                pictureBoxInfo2.Visible = false;

                using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
                    bitmap.Save(nombreArchivo, ImageFormat.Png);
                }

                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                pictureBoxSave.Image = Properties.Resources.save_logo;
                labelCreditos.Visible = false;
                pictureBoxInfo1.Visible = false;
                pictureBoxInfo2.Visible = false;

                if (MessageBox.Show("*** Comparison Properly Saved ***\nDo you want to open the location of the saved file?",
                    "Successful Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string pathAux = Path.GetDirectoryName(saveDialog.FileName);

                    ProcessStartInfo abrirExplorer = new ProcessStartInfo
                    {
                        Arguments = pathAux,
                        FileName = "explorer.exe"
                    };

                    Process.Start(abrirExplorer);
                }
            }
        }

        private void pictureBoxSave_MouseHover(object sender, EventArgs e)
        {
            pictureBoxSave.Image = Properties.Resources.save_logo2;
        }

        private void pictureBoxSave_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSave.Image = Properties.Resources.save_logo;
        }
    }
}
