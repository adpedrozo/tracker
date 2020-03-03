/*** Clase donde se encuentran los datos de Versionado, Familias y Modelos de GPUs ***/
using System.Windows.Forms;

namespace GpuTracker
{
    class DatosGPU
    {
        public string DataBaseVersion() { return "January 22, 2020"; }

        public string AppVersion() { return "v1.0.0.1"; }

        public void VaciarComboBox(ComboBox cb) { cb.Items.Clear(); }

        public void MostrarFamilias(ComboBox cb, string brand)
        {
            switch (brand)
            {
                case "Nvidia":
                    cb.Items.AddRange(new object[] {
                    "GeForce 600 Series",
                    "GeForce 700 Series",
                    "GeForce 900 Series",
                    "GeForce 10 Series",
                    "GeForce 16 Series",
                    "GeForce 20 Series"});
                    break;

                case "AMD Radeon":
                    cb.Items.AddRange(new object[] {
                    "HD 7000 Series",
                    "HD 8000 Series",
                    "RX 200 Series",
                    "RX 300 Series",
                    "RX 400 Series",
                    "RX 500 Series",
                    "RX Vega Series",
                    "RX 5000 Series"});
                    break;
            }
        }

        public void MostrarModelos(ComboBox cb, string familia)
        {
            switch (familia)
            {
                #region Nvidia
                case "GeForce 600 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce GT 610 DDR3",
                        "GeForce GT 620 DDR3",
                        "GeForce GT 630 DDR3",
                        "GeForce GT 640 DDR3",
                        "GeForce GTX 650",
                        "GeForce GTX 650 Ti",
                        "GeForce GTX 660",
                        "GeForce GTX 660 Ti",
                        "GeForce GTX 670",
                        "GeForce GTX 680",
                        "GeForce GTX 690"});
                    break;
                case "GeForce 700 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce GT 720 DDR3",
                        "GeForce GT 730 DDR3",
                        "GeForce GT 740 DDR3",
                        "GeForce GTX 750",
                        "GeForce GTX 750 Ti",
                        "GeForce GTX 760",
                        "GeForce GTX 760 Ti",
                        "GeForce GTX 770",
                        "GeForce GTX 780",
                        "GeForce GTX 780 Ti",
                        "GeForce GTX Titan",
                        "GeForce GTX Titan Black",
                        "GeForce GTX Titan Z"});
                    break;
                case "GeForce 900 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce GTX 950",
                        "GeForce GTX 960",
                        "GeForce GTX 970",
                        "GeForce GTX 980",
                        "GeForce GTX 980 Ti",
                        "GeForce GTX Titan X"});
                    break;
                case "GeForce 10 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce GT 1030 DDR4",
                        "GeForce GT 1030 GDDR5",
                        "GeForce GTX 1050 2GB",
                        "GeForce GTX 1050 3GB",
                        "GeForce GTX 1050 Ti",
                        "GeForce GTX 1060 3GB",
                        "GeForce GTX 1060 6GB",
                        "GeForce GTX 1070",
                        "GeForce GTX 1070 Ti",
                        "GeForce GTX 1080",
                        "GeForce GTX 1080 Ti",
                        "Nvidia Titan X",
                        "Nvidia Titan XP"});
                    break;
                case "GeForce 16 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce GTX 1650",
                        "GeForce GTX 1650 Super",
                        "GeForce GTX 1660",
                        "GeForce GTX 1660 Super",
                        "GeForce GTX 1660 Ti"});
                    break;
                case "GeForce 20 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "GeForce RTX 2060",
                        "GeForce RTX 2060 Super",
                        "GeForce RTX 2070",
                        "GeForce RTX 2070 Super",
                        "GeForce RTX 2080",
                        "GeForce RTX 2080 Super",
                        "GeForce RTX 2080 Ti",
                        "Nvidia Titan RTX"});
                    break;
                #endregion

                #region Radeon
                case "HD 7000 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon HD 7350 DDR3",
                        "Radeon HD 7450 DDR3",
                        "Radeon HD 7470 GDDR5",
                        "Radeon HD 7510 DDR3",
                        "Radeon HD 7570",
                        "Radeon HD 7670",
                        "Radeon HD 7730",
                        "Radeon HD 7750",
                        "Radeon HD 7770",
                        "Radeon HD 7790",
                        "Radeon HD 7850",
                        "Radeon HD 7870",
                        "Radeon HD 7870 XT",
                        "Radeon HD 7950",
                        "Radeon HD 7970",
                        "Radeon HD 7990"});
                    break;
                case "HD 8000 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon HD 8350 DDR3",
                        "Radeon HD 8450 DDR3",
                        "Radeon HD 8470",
                        "Radeon HD 8490",
                        "Radeon HD 8570",
                        "Radeon HD 8670",
                        "Radeon HD 8730",
                        "Radeon HD 8760",
                        "Radeon HD 8770",
                        "Radeon HD 8870",
                        "Radeon HD 8950",
                        "Radeon HD 8970",
                        "Radeon HD 8990"});
                    break;
                case "RX 200 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon R5 220",
                        "Radeon R5 230",
                        "Radeon R5 235",
                        "Radeon R5 235X",
                        "Radeon R5 240",
                        "Radeon R7 240",
                        "Radeon R7 250",
                        "Radeon R7 250E",
                        "Radeon R7 250X",
                        "Radeon R7 260",
                        "Radeon R7 260X",
                        "Radeon R7 265",
                        "Radeon R9 270",
                        "Radeon R9 270X",
                        "Radeon R9 280",
                        "Radeon R9 280X",
                        "Radeon R9 285",
                        "Radeon R9 290",
                        "Radeon R9 290X",
                        "Radeon R9 295"});
                    break;
                case "RX 300 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon R5 330 DDR3",
                        "Radeon R5 340 DDR3",
                        "Radeon R5 340X DDR3",
                        "Radeon R7 340",
                        "Radeon R7 350",
                        "Radeon R7 350X",
                        "Radeon R7 360",
                        "Radeon R7 370",
                        "Radeon R9 360",
                        "Radeon R9 370",
                        "Radeon R9 370X",
                        "Radeon R9 380",
                        "Radeon R9 380X",
                        "Radeon R9 390",
                        "Radeon R9 390X",
                        "Radeon R9 Fury",
                        "Radeon R9 Fury X",
                        "Radeon R9 Nano",
                        "Radeon Pro Duo"});
                    break;
                case "RX 400 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon R5 430 DDR3",
                        "Radeon R5 435 DDR3",
                        "Radeon R7 430 DDR3",
                        "Radeon R7 435 DDR3",
                        "Radeon R7 450",
                        "Radeon RX 455",
                        "Radeon RX 460",
                        "Radeon RX 470",
                        "Radeon RX 480"});
                    break;
                case "RX 500 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon RX 540",
                        "Radeon RX 550",
                        "Radeon RX 560",
                        "Radeon RX 570",
                        "Radeon RX 580",
                        "Radeon RX 590"});
                    break;
                case "RX Vega Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon RX Vega 56",
                        "Radeon RX Vega 64",
                        "Radeon RX Vega 64 Liquid",
                        "Radeon VII"});
                    break;
                case "RX 5000 Series":
                    VaciarComboBox(cb);
                    cb.Items.AddRange(new object[] {
                        "Radeon RX 5500 XT",
                        "Radeon RX 5600 XT",
                        "Radeon RX 5700",
                        "Radeon RX 5700 XT"});
                    break;

                    #endregion
            }
        }

        public void MostrarCoreInfo(ToolTip tt, Label forInfo, string tipo)
        {
            switch (tipo)
            {
                case "Nvidia1":
                    tt.Show("1) Shader Processors\n" +
                            "2) Texture Mapping Units\n" +
                            "3) Render Output Units", forInfo);
                    break;
                case "Nvidia2":
                    tt.Show("1) Shader Processors\n" +
                            "2) Texture Mapping Units\n" +
                            "3) Render Output Units\n" +
                            "4) Streaming\n" +
                            "    Multiprocessors", forInfo);
                    break;
                case "Nvidia3":
                    tt.Show("1) Shader Processors\n" +
                            "2) Texture Mapping Units\n" +
                            "3) Render Output Units\n" +
                            "4) Ray Tracing Cores\n" +
                            "5) Tensor Cores\n" +
                            "6) Streaming\n" +
                            "    Multiprocessors", forInfo);
                    break;
                case "Radeon1":
                    tt.Show("1) Unified Shaders\n" +
                            "2) Texture Mapping Units\n" +
                            "3) Render Output Units", forInfo);
                    break;
                case "Radeon2":
                    tt.Show("1) Unified Shaders\n" +
                            "2) Texture Mapping Units\n" +
                            "3) Render Output Units\n" +
                            "4) Compute Units (CU)", forInfo);
                    break;
            }
        }

        public void MostrarCoreInfoHover(ComboBox cb, ToolTip tt, Label forInfo)
        {
            if (cb.SelectedItem.ToString() == "GeForce 600 Series" || cb.SelectedItem.ToString() == "GeForce 700 Series" ||
                cb.SelectedItem.ToString() == "GeForce 900 Series" || cb.SelectedItem.ToString() == "GeForce 10 Series")
            {
                MostrarCoreInfo(tt, forInfo, "Nvidia1");
            }
            if (cb.SelectedItem.ToString() == "GeForce 16 Series")
            {
                MostrarCoreInfo(tt, forInfo, "Nvidia2");
            }
            if (cb.SelectedItem.ToString() == "GeForce 20 Series")
            {
                MostrarCoreInfo(tt, forInfo, "Nvidia3");
            }

            if (cb.SelectedItem.ToString() == "HD 7000 Series" || cb.SelectedItem.ToString() == "HD 8000 Series" ||
                cb.SelectedItem.ToString() == "RX 200 Series" || cb.SelectedItem.ToString() == "RX 300 Series")
            {
                MostrarCoreInfo(tt, forInfo, "Radeon1");
            }
            if (cb.SelectedItem.ToString() == "RX 400 Series" || cb.SelectedItem.ToString() == "RX 500 Series" ||
                cb.SelectedItem.ToString() == "RX Vega Series" || cb.SelectedItem.ToString() == "RX 5000 Series")
            {
                MostrarCoreInfo(tt, forInfo, "Radeon2");
            }
        }

        public void VaciarDetalles(Label launch, Label codeName, Label arch,
                    Label coreConfig, Label clockBase, Label clockBoost, Label memClock,
                    Label busW, Label memType, Label size, Label bandwidth, Label tdp, Label msrp)
        {
            launch.Text = "";
            codeName.Text = "";
            arch.Text = "";
            coreConfig.Text = "";
            clockBase.Text = "";
            clockBoost.Text = "";
            memClock.Text = "";
            busW.Text = "";
            memType.Text = "";
            size.Text = "";
            bandwidth.Text = "";
            tdp.Text = "";
            msrp.Text = "";
        }

        public void MostrarDetallesGPU(string modelo, Label launch, Label codeName, Label arch,
                    Label coreConfig, Label clockBase, Label clockBoost, Label memClock,
                    Label busW, Label memType, Label size, Label bandwidth, Label tdp, Label msrp,
                    Label forInfo, ToolTip tt)
        {
            switch (modelo)
            {
                #region 600 Series

                case "GeForce GT 610 DDR3":
                    launch.Text = "May 15, 2012";
                    codeName.Text = "GF119-300-A1";
                    arch.Text = "Kepler / 40 nm";
                    coreConfig.Text = "48:8:4";
                    clockBase.Text = "810 MHz";
                    clockBoost.Text = "810 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 620 DDR3":
                    launch.Text = "May 15, 2012";
                    codeName.Text = "GF108-100-KB-A1";
                    arch.Text = "Kepler / 40 nm";
                    coreConfig.Text = "96:16:4";
                    clockBase.Text = "700 MHz";
                    clockBoost.Text = "700 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 630 DDR3":
                    launch.Text = "May 15, 2012";
                    codeName.Text = "GF108-400-A1";
                    arch.Text = "Kepler / 40 nm";
                    coreConfig.Text = "96:16:4";
                    clockBase.Text = "810 MHz";
                    clockBoost.Text = "810 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 640 DDR3":
                    launch.Text = "June 5, 2012";
                    codeName.Text = "GK107-300-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "96:16:4";
                    clockBase.Text = "900 MHz";
                    clockBoost.Text = "900 MHz";
                    memClock.Text = "1782 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "28.5 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "$ 100";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 650":
                    launch.Text = "September 13, 2012";
                    codeName.Text = "GK107-450-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "384:32:16";
                    clockBase.Text = "1058 MHz";
                    clockBoost.Text = "1058 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "80 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 650 Ti":
                    launch.Text = "March 26, 2013";
                    codeName.Text = "GK106-240-A1";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "768:64:24";
                    clockBase.Text = "980 MHz";
                    clockBoost.Text = "1033 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "144 GB/s";
                    tdp.Text = "135 Watts";
                    msrp.Text = "$ 170";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 660":
                    launch.Text = "September 13, 2012";
                    codeName.Text = "GK106-400-A1";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "960:80:24";
                    clockBase.Text = "980 MHz";
                    clockBoost.Text = "1084 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 3 GB";
                    bandwidth.Text = "144 GB/s";
                    tdp.Text = "140 Watts";
                    msrp.Text = "$ 230";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 660 Ti":
                    launch.Text = "August 16, 2012";
                    codeName.Text = "GK104-300-KD-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1344:112:24";
                    clockBase.Text = "915 MHz";
                    clockBoost.Text = "1058 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 3 GB";
                    bandwidth.Text = "144.2 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 300";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 670":
                    launch.Text = "May 10, 2012";
                    codeName.Text = "GK104-325-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1344:112:32";
                    clockBase.Text = "915 MHz";
                    clockBoost.Text = "1084 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "192.2 GB/s";
                    tdp.Text = "170 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 680":
                    launch.Text = "March 22, 2012";
                    codeName.Text = "GK104-400-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1536:128:32";
                    clockBase.Text = "1006 MHz";
                    clockBoost.Text = "1110 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "192.2 GB/s";
                    tdp.Text = "195 Watts";
                    msrp.Text = "$ 500";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 690":
                    launch.Text = "April 29, 2012";
                    codeName.Text = "2 x GK104-355-A2";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2 x 1536:128:32";
                    clockBase.Text = "915 MHz";
                    clockBoost.Text = "1058 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "2 x 256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 x 2 GB";
                    bandwidth.Text = "2 x 192.2 GB/s";
                    tdp.Text = "300 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;

                #endregion

                #region 700 Series

                case "GeForce GT 720 DDR3":
                    launch.Text = "March 27, 2014";
                    codeName.Text = "GK208-201-A1";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "192:16:8";
                    clockBase.Text = "797 MHz";
                    clockBoost.Text = "797 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "$ 50";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 730 DDR3":
                    launch.Text = "June 18, 2014";
                    codeName.Text = "GK208-400-A1";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "384:16:8";
                    clockBase.Text = "902 MHz";
                    clockBoost.Text = "902 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "23 Watts";
                    msrp.Text = "Unknown";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 740 DDR3":
                    launch.Text = "May 29, 2014";
                    codeName.Text = "GK107-425";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "384:32:16";
                    clockBase.Text = "993 MHz";
                    clockBoost.Text = "993 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "2 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "$ 90";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 750":
                    launch.Text = "February 29, 2014";
                    codeName.Text = "GM107-300";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "512:32:16";
                    clockBase.Text = "1020 MHz";
                    clockBoost.Text = "1085 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "80 GB/s";
                    tdp.Text = "55 Watts";
                    msrp.Text = "$ 120";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 750 Ti":
                    launch.Text = "February 18, 2014";
                    codeName.Text = "GM107-400";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "640:40:16";
                    clockBase.Text = "1020 MHz";
                    clockBoost.Text = "1085 MHz";
                    memClock.Text = "5400 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "86.4 GB/s";
                    tdp.Text = "60 Watts";
                    msrp.Text = "$ 150";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 760":
                    launch.Text = "June 25, 2013";
                    codeName.Text = "GK104-225";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1152:96:32";
                    clockBase.Text = "980 MHz";
                    clockBoost.Text = "1033 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "192.2 GB/s";
                    tdp.Text = "170 Watts";
                    msrp.Text = "$ 250";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 760 Ti":
                    launch.Text = "August 25, 2013";
                    codeName.Text = "GK104-325";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1344:112:32";
                    clockBase.Text = "915 MHz";
                    clockBoost.Text = "980 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "192.2 GB/s";
                    tdp.Text = "170 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 770":
                    launch.Text = "May 30, 2013";
                    codeName.Text = "GK104-425";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "1536:128:32";
                    clockBase.Text = "1046 MHz";
                    clockBoost.Text = "1085 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "224.3 GB/s";
                    tdp.Text = "230 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 780":
                    launch.Text = "February 29, 2014";
                    codeName.Text = "GK110-300";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2304:192:48";
                    clockBase.Text = "836 MHz";
                    clockBoost.Text = "900 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB / 6 GB";
                    bandwidth.Text = "288.3 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 650";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 780 Ti":
                    launch.Text = "November 7, 2013";
                    codeName.Text = "GK110-425";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2880:240:48";
                    clockBase.Text = "876 MHz";
                    clockBoost.Text = "928 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "336 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX Titan":
                    launch.Text = "February 19, 2013";
                    codeName.Text = "GK110-400";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2688:224:48";
                    clockBase.Text = "837 MHz";
                    clockBoost.Text = "876 MHz";
                    memClock.Text = "6008 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "6 GB";
                    bandwidth.Text = "288.3 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX Titan Black":
                    launch.Text = "February 18, 2014";
                    codeName.Text = "GK110-430";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2880:240:48";
                    clockBase.Text = "889 MHz";
                    clockBoost.Text = "980 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "6 GB";
                    bandwidth.Text = "336 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX Titan Z":
                    launch.Text = "March 25, 2014";
                    codeName.Text = "2 x GK110-350";
                    arch.Text = "Kepler / 28 nm";
                    coreConfig.Text = "2 x 2880:240:48";
                    clockBase.Text = "705 MHz";
                    clockBoost.Text = "876 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "2 x 384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 x 6 GB";
                    bandwidth.Text = "2 x 336 GB/s";
                    tdp.Text = "375 Watts";
                    msrp.Text = "$ 3000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;

                #endregion

                #region 900 Series

                case "GeForce GTX 950":
                    launch.Text = "August 20, 2015";
                    codeName.Text = "GM206-250";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "768:48:32";
                    clockBase.Text = "1024 MHz";
                    clockBoost.Text = "1188 MHz";
                    memClock.Text = "6610 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "105.7 GB/s";
                    tdp.Text = "90 Watts";
                    msrp.Text = "$ 160";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 960":
                    launch.Text = "January 22, 2015";
                    codeName.Text = "GM206-300";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "1024:64:32";
                    clockBase.Text = "1127 MHz";
                    clockBoost.Text = "1178 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "112.1 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 200";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 970":
                    launch.Text = "September 18, 2014";
                    codeName.Text = "GM204-200";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "1664:104:56";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1178 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB (3.5 GB + 0.5 GB)";
                    bandwidth.Text = "224.3 GB/s";
                    tdp.Text = "145 Watts";
                    msrp.Text = "$ 330";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 980":
                    launch.Text = "September 18, 2014";
                    codeName.Text = "GM204-400";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "2084:128:64";
                    clockBase.Text = "1126 MHz";
                    clockBoost.Text = "1216 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "224.3 GB/s";
                    tdp.Text = "165 Watts";
                    msrp.Text = "$ 550";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 980 Ti":
                    launch.Text = "June 2, 2015";
                    codeName.Text = "GM200-310";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "2816:176:96";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1076 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "6 GB";
                    bandwidth.Text = "336.4 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 650";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX Titan X":
                    launch.Text = "March 17, 2015";
                    codeName.Text = "GM200-400";
                    arch.Text = "Maxwell / 28 nm";
                    coreConfig.Text = "3072:192:96";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1089 MHz";
                    memClock.Text = "7010 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "12 GB";
                    bandwidth.Text = "336.4 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;

                #endregion

                #region 10 Series

                case "GeForce GT 1030 DDR4":
                    launch.Text = "March 12, 2018";
                    codeName.Text = "GP108-310-A1";
                    arch.Text = "Pascal / 14 nm";
                    coreConfig.Text = "384:24:16";
                    clockBase.Text = "1151 MHz";
                    clockBoost.Text = "1379 MHz";
                    memClock.Text = "2100 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR4";
                    size.Text = "2 GB";
                    bandwidth.Text = "16.8 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "$ 80";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GT 1030 GDDR5":
                    launch.Text = "May 17, 2017";
                    codeName.Text = "GP108-300-A1";
                    arch.Text = "Pascal / 14 nm";
                    coreConfig.Text = "384:24:16";
                    clockBase.Text = "1227 MHz";
                    clockBoost.Text = "1468 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "48 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "$ 80";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1050 2GB":
                    launch.Text = "October 25, 2016";
                    codeName.Text = "GP107-300-A1";
                    arch.Text = "Pascal / 14 nm";
                    coreConfig.Text = "640:40:32";
                    clockBase.Text = "1354 MHz";
                    clockBoost.Text = "1455 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "112 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1050 3GB":
                    launch.Text = "May 21, 2018";
                    codeName.Text = "GP107-301-A1";
                    arch.Text = "Pascal / 14 nm";
                    coreConfig.Text = "768:48:24";
                    clockBase.Text = "1392 MHz";
                    clockBoost.Text = "1518 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "96 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "84 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "Unknown";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1050 Ti":
                    launch.Text = "October 25, 2016";
                    codeName.Text = "GP107-400-A1";
                    arch.Text = "Pascal / 14 nm";
                    coreConfig.Text = "768:48:32";
                    clockBase.Text = "1290 MHz";
                    clockBoost.Text = "1392 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "112 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 140";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1060 3GB":
                    launch.Text = "August 18, 2016";
                    codeName.Text = "GP106-300-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "1152:72:48";
                    clockBase.Text = "1506 MHz";
                    clockBoost.Text = "1708 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "192 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 200";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1060 6GB":
                    launch.Text = "July 19, 2016";
                    codeName.Text = "GP106-400-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "1280:80:48";
                    clockBase.Text = "1506 MHz";
                    clockBoost.Text = "1708 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "6 GB";
                    bandwidth.Text = "192 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 250";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1070":
                    launch.Text = "June 10, 2016";
                    codeName.Text = "GP104-200-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "1920:120:64";
                    clockBase.Text = "1506 MHz";
                    clockBoost.Text = "1683 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "8 GB";
                    bandwidth.Text = "256 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 380";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1070 Ti":
                    launch.Text = "November 2, 2017";
                    codeName.Text = "GP104-300-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "2432:152:64";
                    clockBase.Text = "1607 MHz";
                    clockBoost.Text = "1683 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "8 GB";
                    bandwidth.Text = "256 GB/s";
                    tdp.Text = "180 Watts";
                    msrp.Text = "$ 450";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1080":
                    launch.Text = "May 27, 2016";
                    codeName.Text = "GP104-400-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "2560:160:64";
                    clockBase.Text = "1607 MHz";
                    clockBoost.Text = "1733 MHz";
                    memClock.Text = "10000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5X";
                    size.Text = "8 GB";
                    bandwidth.Text = "320 GB/s";
                    tdp.Text = "180 Watts";
                    msrp.Text = "$ 600";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "GeForce GTX 1080 Ti":
                    launch.Text = "March 10, 2017";
                    codeName.Text = "GP102-350-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "3584:224:88";
                    clockBase.Text = "1480 MHz";
                    clockBoost.Text = "1582 MHz";
                    memClock.Text = "11000 MT/s";
                    busW.Text = "352 bits";
                    memType.Text = "GDDR5X";
                    size.Text = "11 GB";
                    bandwidth.Text = "484 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "Nvidia Titan X":
                    launch.Text = "August 2, 2016";
                    codeName.Text = "GP102-400-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "3584:224:96";
                    clockBase.Text = "1417 MHz";
                    clockBoost.Text = "1531 MHz";
                    memClock.Text = "10000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5X";
                    size.Text = "12 GB";
                    bandwidth.Text = "480 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1200";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;
                case "Nvidia Titan XP":
                    launch.Text = "April 6, 2017";
                    codeName.Text = "GP102-450-A1";
                    arch.Text = "Pascal / 16 nm";
                    coreConfig.Text = "3840:240:96";
                    clockBase.Text = "1405 MHz";
                    clockBoost.Text = "1582 MHz";
                    memClock.Text = "11410 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5X";
                    size.Text = "12 GB";
                    bandwidth.Text = "547.6 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1200";
                    MostrarCoreInfo(tt, forInfo, "Nvidia1");
                    break;

                #endregion

                #region 16 Series

                case "GeForce GTX 1650":
                    launch.Text = "April 23, 2019";
                    codeName.Text = "TU117-300-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "896:56:32:14";
                    clockBase.Text = "1485 MHz";
                    clockBoost.Text = "1665 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "128 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 150";
                    MostrarCoreInfo(tt, forInfo, "Nvidia2");
                    break;
                case "GeForce GTX 1650 Super":
                    launch.Text = "November 22, 2019";
                    codeName.Text = "TU116-250-KA-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "1280:64:32:16";
                    clockBase.Text = "1530 MHz";
                    clockBoost.Text = "1725 MHz";
                    memClock.Text = "12000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR6";
                    size.Text = "4 GB";
                    bandwidth.Text = "192 GB/s";
                    tdp.Text = "100 Watts";
                    msrp.Text = "$ 160";
                    MostrarCoreInfo(tt, forInfo, "Nvidia2");
                    break;
                case "GeForce GTX 1660":
                    launch.Text = "March 14, 2019";
                    codeName.Text = "TU116-300-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "1408:88:48:22";
                    clockBase.Text = "1530 MHz";
                    clockBoost.Text = "1785 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR5";
                    size.Text = "6 GB";
                    bandwidth.Text = "192 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 220";
                    MostrarCoreInfo(tt, forInfo, "Nvidia2");
                    break;
                case "GeForce GTX 1660 Super":
                    launch.Text = "October 29, 2019";
                    codeName.Text = "TU116-300-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "1408:88:48:22";
                    clockBase.Text = "1530 MHz";
                    clockBoost.Text = "1785 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR6";
                    size.Text = "6 GB";
                    bandwidth.Text = "336 GB/s";
                    tdp.Text = "125 Watts";
                    msrp.Text = "$ 230";
                    MostrarCoreInfo(tt, forInfo, "Nvidia2");
                    break;
                case "GeForce GTX 1660 Ti":
                    launch.Text = "February 22, 2019";
                    codeName.Text = "TU116-400-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "1536:96:48:24";
                    clockBase.Text = "1500 MHz";
                    clockBoost.Text = "1770 MHz";
                    memClock.Text = "12000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR6";
                    size.Text = "6 GB";
                    bandwidth.Text = "288 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 280";
                    MostrarCoreInfo(tt, forInfo, "Nvidia2");
                    break;

                #endregion

                #region 20 Series

                case "GeForce RTX 2060":
                    launch.Text = "January 15, 2019";
                    codeName.Text = "TU106-200A-KA-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "1920:120:48:30:240:30";
                    clockBase.Text = "1365 MHz";
                    clockBoost.Text = "1680 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR6";
                    size.Text = "6 GB";
                    bandwidth.Text = "336 GB/s";
                    tdp.Text = "160 Watts";
                    msrp.Text = "$ 350";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2060 Super":
                    launch.Text = "July 9, 2019";
                    codeName.Text = "TU106-410-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "2176:136:64:34:272:34";
                    clockBase.Text = "1407 MHz";
                    clockBoost.Text = "1650 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "175 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2070":
                    launch.Text = "October 17, 2018";
                    codeName.Text = "TU106-400-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "2304:144:64:36:288:36";
                    clockBase.Text = "1410 MHz";
                    clockBoost.Text = "1620 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "175 Watts";
                    msrp.Text = "$ 500";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2070 Super":
                    launch.Text = "July 9, 2019";
                    codeName.Text = "TU104-410-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "2560:160:64:40:320:40";
                    clockBase.Text = "1605 MHz";
                    clockBoost.Text = "1770 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "215 Watts";
                    msrp.Text = "$ 500";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2080":
                    launch.Text = "September 20, 2018";
                    codeName.Text = "TU104-400-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "2944:184:64:46:368:46";
                    clockBase.Text = "1515 MHz";
                    clockBoost.Text = "1710 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "215 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2080 Super":
                    launch.Text = "July 23, 2019";
                    codeName.Text = "TU104-450-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "3072:192:64:48:384:48";
                    clockBase.Text = "1650 MHz";
                    clockBoost.Text = "1815 MHz";
                    memClock.Text = "15500 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "496 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "GeForce RTX 2080 Ti":
                    launch.Text = "September 27, 2018";
                    codeName.Text = "TU102-300-K1-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "4352:272:88:68:544:68";
                    clockBase.Text = "1350 MHz";
                    clockBoost.Text = "1545 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "352 bits";
                    memType.Text = "GDDR6";
                    size.Text = "11 GB";
                    bandwidth.Text = "616 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;
                case "Nvidia Titan RTX":
                    launch.Text = "December 18, 2018";
                    codeName.Text = "TU102-400-A1";
                    arch.Text = "Turing / 12 nm";
                    coreConfig.Text = "4608:288:96:72:576:72";
                    clockBase.Text = "1350 MHz";
                    clockBoost.Text = "1770 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR6";
                    size.Text = "24 GB";
                    bandwidth.Text = "672 GB/s";
                    tdp.Text = "280 Watts";
                    msrp.Text = "$ 2500";
                    MostrarCoreInfo(tt, forInfo, "Nvidia3");
                    break;

                #endregion


                #region HD 7000 Series

                case "Radeon HD 7350 DDR3":
                    launch.Text = "January, 2012";
                    codeName.Text = "Cedar PRO";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "80:8:4";
                    clockBase.Text = "400 MHz";
                    clockBoost.Text = "650 MHz";
                    memClock.Text = "Up to 1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "256 MB / 512 MB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7450 DDR3":
                    launch.Text = "January, 2012";
                    codeName.Text = "Caimour";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "625 MHz";
                    clockBoost.Text = "750 MHz";
                    memClock.Text = "Up to 1600 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "512 MB / 1 GB";
                    bandwidth.Text = "12.8 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7470 GDDR5":
                    launch.Text = "January, 2012";
                    codeName.Text = "Caicos PRO";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "625 MHz";
                    clockBoost.Text = "775 MHz";
                    memClock.Text = "3600 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "GDDR5";
                    size.Text = "512 MB / 1 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7510 DDR3":
                    launch.Text = "February, 2013";
                    codeName.Text = "Turks LE";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "320:16:4";
                    clockBase.Text = "650 MHz";
                    clockBoost.Text = "650 MHz";
                    memClock.Text = "Up to 1334 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB";
                    bandwidth.Text = "21.3 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7570":
                    launch.Text = "January, 2012";
                    codeName.Text = "Turks PRO-L";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "480:24:8";
                    clockBase.Text = "650 MHz";
                    clockBoost.Text = "650 MHz";
                    memClock.Text = "4000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "512 MB / 1 GB";
                    bandwidth.Text = "64 GB/s";
                    tdp.Text = "60 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7670":
                    launch.Text = "January, 2012";
                    codeName.Text = "Turks XT";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "480:24:8";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "800 MHz";
                    memClock.Text = "4000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "512 MB / 1 GB";
                    bandwidth.Text = "64 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7730":
                    launch.Text = "April, 2013";
                    codeName.Text = "Cape Verde LE";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "512:32:16";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "900 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "$ 60";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7750":
                    launch.Text = "February, 2012";
                    codeName.Text = "Cape Verde PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "512:32:16";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "900 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "55 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7770":
                    launch.Text = "February, 2012";
                    codeName.Text = "Cape Verde PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "640:40:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "80 Watts";
                    msrp.Text = "$ 160";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7790":
                    launch.Text = "March, 2013";
                    codeName.Text = "Bonaire XT";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "896:56:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "96 GB/s";
                    tdp.Text = "85 Watts";
                    msrp.Text = "$ 150";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7850":
                    launch.Text = "March, 2012";
                    codeName.Text = "Pitcairn LE";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1024:64:32";
                    clockBase.Text = "860 MHz";
                    clockBoost.Text = "860 MHz";
                    memClock.Text = "4800 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "153.6 GB/s";
                    tdp.Text = "130 Watts";
                    msrp.Text = "$ 250";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7870":
                    launch.Text = "March, 2012";
                    codeName.Text = "Pitcairn XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1280:80:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4800 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "153.6 GB/s";
                    tdp.Text = "175 Watts";
                    msrp.Text = "$ 350";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7870 XT":
                    launch.Text = "November, 2012";
                    codeName.Text = "Tahiti LE";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1536:96:32";
                    clockBase.Text = "925 MHz";
                    clockBoost.Text = "975 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "192 GB/s";
                    tdp.Text = "185 Watts";
                    msrp.Text = "$ 270";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7950":
                    launch.Text = "January, 2012";
                    codeName.Text = "Tahiti PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1792:112:32";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "800 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "240 GB/s";
                    tdp.Text = "200 Watts";
                    msrp.Text = "$ 450";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7970":
                    launch.Text = "June, 2012";
                    codeName.Text = "Tahiti XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "2048:128:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB / 6 GB";
                    bandwidth.Text = "288 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 500";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 7990":
                    launch.Text = "April, 2013";
                    codeName.Text = "2 x Tahiti XT2";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "2 x 2048:128:32";
                    clockBase.Text = "95 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "2 x 384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 x 3 GB";
                    bandwidth.Text = "2 x 288 GB/s";
                    tdp.Text = "375 Watts";
                    msrp.Text = "$ 1000";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;

                #endregion

                #region HD 8000 Series

                case "Radeon HD 8350 DDR3":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Cedar PRO";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "80:8:4";
                    clockBase.Text = "450 MHz";
                    clockBoost.Text = "650 MHz";
                    memClock.Text = "1600 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "256 MB / 512 MB";
                    bandwidth.Text = "12.8 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8450 DDR3":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Caicos PRO-L";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "625 MHz";
                    clockBoost.Text = "625 MHz";
                    memClock.Text = "1066 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "512 MB";
                    bandwidth.Text = "8.5 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8470":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Caicos PRO";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "750 MHz";
                    clockBoost.Text = "750 MHz";
                    memClock.Text = "3200 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB";
                    bandwidth.Text = "25.6 GB/s";
                    tdp.Text = "35 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8490":
                    launch.Text = "July 23, 2013";
                    codeName.Text = "Caicos XT";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "875 MHz";
                    clockBoost.Text = "875 MHz";
                    memClock.Text = "3600 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "35 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8570":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Oland";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "730 MHz";
                    memClock.Text = "4600 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "73.6 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8670":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Oland XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4600 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "73.6 GB/s";
                    tdp.Text = "85 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8730":
                    launch.Text = "September 5, 2013";
                    codeName.Text = "Cape Verde LE";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "800 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8760":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Cape Verde XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "640:40:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "80 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8770":
                    launch.Text = "September 2, 2013";
                    codeName.Text = "Bonaire XT";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "896:56:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "96 GB/s";
                    tdp.Text = "85 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8870":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Pitcairn XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1280:80:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4800 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "153.6 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8950":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Tahiti PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1792:112:32";
                    clockBase.Text = "850 MHz";
                    clockBoost.Text = "925 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "240 GB/s";
                    tdp.Text = "225 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8970":
                    launch.Text = "January 8, 2013";
                    codeName.Text = "Tahiti XT2";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "2048:128:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "288 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon HD 8990":
                    launch.Text = "April 24, 2013";
                    codeName.Text = "2 x Tahiti XT2";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "2 x 2048:128:32";
                    clockBase.Text = "950 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "2 x 384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 x 3 GB";
                    bandwidth.Text = "2 x 288 GB/s";
                    tdp.Text = "375 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;

                #endregion

                #region RX 200 Series

                case "Radeon R5 220":
                    launch.Text = "December 21, 2013";
                    codeName.Text = "Cedar PRO";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "80:8:4";
                    clockBase.Text = "625 MHz";
                    clockBoost.Text = "650 MHz";
                    memClock.Text = "1066 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB";
                    bandwidth.Text = "8.5 GB/s";
                    tdp.Text = "18 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 230":
                    launch.Text = "April 3, 2014";
                    codeName.Text = "Caicos PRO-L";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "625 MHz";
                    clockBoost.Text = "625 MHz";
                    memClock.Text = "1066 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "8.5 GB/s";
                    tdp.Text = "20 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 235":
                    launch.Text = "December 21, 2013";
                    codeName.Text = "Caicos XT";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "775 MHz";
                    clockBoost.Text = "775 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "35 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 235X":
                    launch.Text = "December 21, 2013";
                    codeName.Text = "Caicos XT";
                    arch.Text = "TeraScale 2 / 40 nm";
                    coreConfig.Text = "160:8:4";
                    clockBase.Text = "875 MHz";
                    clockBoost.Text = "875 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB";
                    bandwidth.Text = "14.4 GB/s";
                    tdp.Text = "18 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 240":
                    launch.Text = "November 1, 2013";
                    codeName.Text = "Oland";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "780 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "16 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 240":
                    launch.Text = "August 8, 2013";
                    codeName.Text = "Oland PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "320:20:8";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "780 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "45 Watts";
                    msrp.Text = "$ 70";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 250":
                    launch.Text = "August 8, 2013";
                    codeName.Text = "Oland XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "4600 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "73.6 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 90";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 250E":
                    launch.Text = "December 21, 2013";
                    codeName.Text = "Cape Verde PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "512:32:16";
                    clockBase.Text = "800 MHz";
                    clockBoost.Text = "800 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "55 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 250X":
                    launch.Text = "February 10, 2014";
                    codeName.Text = "Cape Verde XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "640:40:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "95 Watts";
                    msrp.Text = "$ 100";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 260":
                    launch.Text = "December 17, 2013";
                    codeName.Text = "Bonaire PRO";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "768:48:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB";
                    bandwidth.Text = "96 GB/s";
                    tdp.Text = "95 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 260X":
                    launch.Text = "August 8, 2013";
                    codeName.Text = "Bonaire XTX";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "896:56:16";
                    clockBase.Text = "1100 MHz";
                    clockBoost.Text = "1100 MHz";
                    memClock.Text = "6500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "104 GB/s";
                    tdp.Text = "115 Watts";
                    msrp.Text = "$ 140";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 265":
                    launch.Text = "February 13, 2014";
                    codeName.Text = "Pitcairn PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1024:64:32";
                    clockBase.Text = "900 MHz";
                    clockBoost.Text = "925 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 150";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 270":
                    launch.Text = "November 13, 2013";
                    codeName.Text = "Curacao PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1280:80:32";
                    clockBase.Text = "900 MHz";
                    clockBoost.Text = "925 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 180";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 270X":
                    launch.Text = "August 8, 2013";
                    codeName.Text = "Curacao XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1280:80:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "180 Watts";
                    msrp.Text = "$ 200";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 280":
                    launch.Text = "March 4, 2014";
                    codeName.Text = "Tahiti PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1792:112:32";
                    clockBase.Text = "827 MHz";
                    clockBoost.Text = "933 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "240 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 250";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 280X":
                    launch.Text = "August 8, 2013";
                    codeName.Text = "Tahiti XTL";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "2048:128:32";
                    clockBase.Text = "850 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "384 bits";
                    memType.Text = "GDDR5";
                    size.Text = "3 GB";
                    bandwidth.Text = "288 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 300";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 285":
                    launch.Text = "September 2, 2014";
                    codeName.Text = "Tonga PRO";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "1792:112:32";
                    clockBase.Text = "918 MHz";
                    clockBoost.Text = "918 MHz";
                    memClock.Text = "5500 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "176 GB/s";
                    tdp.Text = "190 Watts";
                    msrp.Text = "$ 250";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 290":
                    launch.Text = "November 5, 2013";
                    codeName.Text = "Hawaii PRO";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "2560:160:64";
                    clockBase.Text = "947 MHz";
                    clockBoost.Text = "947 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "512 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "320 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 290X":
                    launch.Text = "November 6, 2014";
                    codeName.Text = "Hawaii XT";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "2816:176:64";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "512 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "320 GB/s";
                    tdp.Text = "250 Watts";
                    msrp.Text = "$ 560";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 295":
                    launch.Text = "April 8, 2014";
                    codeName.Text = "2 x Hawaii XT";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "2 x 2816:176:64";
                    clockBase.Text = "1018 MHz";
                    clockBoost.Text = "1018 MHz";
                    memClock.Text = "5000 MT/s";
                    busW.Text = "2 x 512 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 x 4 GB";
                    bandwidth.Text = "2 x 320 GB/s";
                    tdp.Text = "500 Watts";
                    msrp.Text = "$ 1500";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;

                #endregion

                #region RX 300 Series

                case "Radeon R5 330 DDR3":
                    launch.Text = "May, 2015";
                    codeName.Text = "Oland";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "320:20:8";
                    clockBase.Text = "855 MHz";
                    clockBoost.Text = "855 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 340 DDR3":
                    launch.Text = "May, 2015";
                    codeName.Text = "Oland XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "825 MHz";
                    clockBoost.Text = "825 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R5 340X DDR3":
                    launch.Text = "May, 2015";
                    codeName.Text = "Samoa XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "2 GB";
                    bandwidth.Text = "32 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 340":
                    codeName.Text = "Oland XT";
                    launch.Text = "May, 2015";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "780 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 350":
                    launch.Text = "May, 2015";
                    codeName.Text = "Oland XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "512:32:16";
                    clockBase.Text = "925 MHz";
                    clockBoost.Text = "925 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 90";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 350X":
                    launch.Text = "May, 2015";
                    codeName.Text = "Samoa XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "32 GB/s";
                    tdp.Text = "30 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 360":
                    launch.Text = "June, 2015";
                    codeName.Text = "Tobago PRO";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "768:48:16";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "104 GB/s";
                    tdp.Text = "100 Watts";
                    msrp.Text = "$ 110";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R7 370":
                    launch.Text = "June, 2015";
                    codeName.Text = "Trinidad PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1024:64:32";
                    clockBase.Text = "975 MHz";
                    clockBoost.Text = "975 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "110 Watts";
                    msrp.Text = "$ 150";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 360":
                    launch.Text = "May, 2015";
                    codeName.Text = "Tobago PRO";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "768:48:16";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "104 GB/s";
                    tdp.Text = "85 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 370":
                    launch.Text = "May, 2015";
                    codeName.Text = "Trinidad PRO";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1024:64:32";
                    clockBase.Text = "950 MHz";
                    clockBoost.Text = "975 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 370X":
                    launch.Text = "August, 2015";
                    codeName.Text = "Trinidad XT";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "1280:80:32";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "5600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "179.2 GB/s";
                    tdp.Text = "185 Watts";
                    msrp.Text = "$ 180";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 380":
                    launch.Text = "May, 2015";
                    codeName.Text = "Antigua PRO";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "1792:112:32";
                    clockBase.Text = "970 MHz";
                    clockBoost.Text = "970 MHz";
                    memClock.Text = "5700 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "182.4 GB/s";
                    tdp.Text = "190 Watts";
                    msrp.Text = "$ 200";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 380X":
                    launch.Text = "November, 2015";
                    codeName.Text = "Antigua XT";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "2048:128:32";
                    clockBase.Text = "970 MHz";
                    clockBoost.Text = "970 MHz";
                    memClock.Text = "5700 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB";
                    bandwidth.Text = "182.4 GB/s";
                    tdp.Text = "190 Watts";
                    msrp.Text = "$ 230";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 390":
                    launch.Text = "June, 2015";
                    codeName.Text = "Grenada PRO";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "2560:160:64";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "512 bits";
                    memType.Text = "GDDR5";
                    size.Text = "8 GB";
                    bandwidth.Text = "384 GB/s";
                    tdp.Text = "275 Watts";
                    msrp.Text = "$ 329";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 390X":
                    launch.Text = "June, 2015";
                    codeName.Text = "Grenada XT";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "2816:176:64";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "512 bits";
                    memType.Text = "GDDR5";
                    size.Text = "8 GB";
                    bandwidth.Text = "384 GB/s";
                    tdp.Text = "275 Watts";
                    msrp.Text = "$ 430";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 Fury":
                    launch.Text = "July, 2015";
                    codeName.Text = "Fiji PRO";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "3584:224:64";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "1000 MT/s";
                    busW.Text = "4096 bits";
                    memType.Text = "HBM";
                    size.Text = "4 GB";
                    bandwidth.Text = "512 GB/s";
                    tdp.Text = "275 Watts";
                    msrp.Text = "$ 550";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 Nano":
                    launch.Text = "August, 2015";
                    codeName.Text = "Fiji";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "4096:256:64";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "1000 MT/s";
                    busW.Text = "4096 bits";
                    memType.Text = "HBM";
                    size.Text = "4 GB";
                    bandwidth.Text = "512 GB/s";
                    tdp.Text = "175 Watts";
                    msrp.Text = "$ 650";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon R9 Fury X":
                    launch.Text = "June, 2015";
                    codeName.Text = "Fiji XT";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "4096:256:64";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "1000 MT/s";
                    busW.Text = "4096 bits";
                    memType.Text = "HBM";
                    size.Text = "4 GB";
                    bandwidth.Text = "512 GB/s";
                    tdp.Text = "275 Watts";
                    msrp.Text = "$ 650";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;
                case "Radeon Pro Duo":
                    launch.Text = "April, 2016";
                    codeName.Text = "2 x Fiji XT";
                    arch.Text = "GCN 3rd Gen / 28 nm";
                    coreConfig.Text = "2 x 4096:256:64";
                    clockBase.Text = "1000 MHz";
                    clockBoost.Text = "1000 MHz";
                    memClock.Text = "1000 MT/s";
                    busW.Text = "2 x 4096 bits";
                    memType.Text = "HBM";
                    size.Text = "2 x 4 GB";
                    bandwidth.Text = "2 x 512 GB/s";
                    tdp.Text = "350 Watts";
                    msrp.Text = "$ 1500";
                    MostrarCoreInfo(tt, forInfo, "Radeon1");
                    break;

                #endregion

                #region RX 400 Series

                case "Radeon R5 430 DDR3":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Oland PRO)";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8:6";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "780 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon R5 435 DDR3":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Oland)";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "320:20:8:5";
                    clockBase.Text = "1030 MHz";
                    clockBoost.Text = "1030 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "2 GB";
                    bandwidth.Text = "16 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon R7 430 DDR3":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Oland PRO)";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "384:24:8:6";
                    clockBase.Text = "730 MHz";
                    clockBoost.Text = "780 MHz";
                    memClock.Text = "1800 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "DDR3";
                    size.Text = "1 GB / 2 GB / 4 GB";
                    bandwidth.Text = "28.8 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon R7 435 DDR3":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Oland)";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "320:24:8:5";
                    clockBase.Text = "920 MHz";
                    clockBoost.Text = "920 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "64 bits";
                    memType.Text = "DDR3";
                    size.Text = "2 GB";
                    bandwidth.Text = "16 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon R7 450":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Cape Verde PRO)";
                    arch.Text = "GCN 1st Gen / 28 nm";
                    coreConfig.Text = "512:32:16:8";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "4500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "72 GB/s";
                    tdp.Text = "65 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 455":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Bonaire PRO)";
                    arch.Text = "GCN 2nd Gen / 28 nm";
                    coreConfig.Text = "768:48:16:12";
                    clockBase.Text = "1050 MHz";
                    clockBoost.Text = "1050 MHz";
                    memClock.Text = "6500 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB";
                    bandwidth.Text = "104 GB/s";
                    tdp.Text = "100 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 460":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Baffin)";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "896:56:16:14";
                    clockBase.Text = "1090 MHz";
                    clockBoost.Text = "1200 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "112 GB/s";
                    tdp.Text = "75 Watts";
                    msrp.Text = "$ 110 (2 GB) / $140 (4 GB)";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 470":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Ellesmere PRO)";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "2048:128:32:32";
                    clockBase.Text = "926 MHz";
                    clockBoost.Text = "1206 MHz";
                    memClock.Text = "6600 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "211.2 GB/s";
                    tdp.Text = "120 Watts";
                    msrp.Text = "$ 180";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 480":
                    launch.Text = "June, 2016";
                    codeName.Text = "Polaris (Ellesmere XT)";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "2304:144:32:36";
                    clockBase.Text = "1120 MHz";
                    clockBoost.Text = "1266 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "256 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 200 (4 GB) / $240 (8 GB)";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;

                #endregion

                #region RX 500 Series

                case "Radeon RX 540":
                    launch.Text = "April 18, 2017";
                    codeName.Text = "Polaris (Lexa)";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "512:32:16:8";
                    clockBase.Text = "1219 MHz";
                    clockBoost.Text = "1219 MHz";
                    memClock.Text = "6000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "96 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "OEM";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 550":
                    launch.Text = "April 20, 2017";
                    codeName.Text = "Polaris (Lexa PRO)";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "640:40:16:10";
                    clockBase.Text = "1100 MHz";
                    clockBoost.Text = "1183 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "112 GB/s";
                    tdp.Text = "50 Watts";
                    msrp.Text = "$ 80";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 560":
                    launch.Text = "May, 2017";
                    codeName.Text = "Polaris 21 XT";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "1024:64:16:16";
                    clockBase.Text = "1175 MHz";
                    clockBoost.Text = "1275 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR5";
                    size.Text = "2 GB / 4 GB";
                    bandwidth.Text = "112 GB/s";
                    tdp.Text = "80 Watts";
                    msrp.Text = "$ 100";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 570":
                    launch.Text = "April 18, 2017";
                    codeName.Text = "Polaris 20 XL";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "2048:128:32:32";
                    clockBase.Text = "1168 MHz";
                    clockBoost.Text = "1244 MHz";
                    memClock.Text = "7000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "224 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 170";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 580":
                    launch.Text = "April 18, 2017";
                    codeName.Text = "Polaris 20 XT";
                    arch.Text = "GCN 4th Gen / 14 nm";
                    coreConfig.Text = "2304:144:32:36";
                    clockBase.Text = "1257 MHz";
                    clockBoost.Text = "1340 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "256 GB/s";
                    tdp.Text = "185 Watts";
                    msrp.Text = "$ 200 (4 GB) / $ 230 (8 GB)";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 590":
                    launch.Text = "November 15, 2018";
                    codeName.Text = "Polaris 30 XT";
                    arch.Text = "GCN 4th Gen / 12 nm";
                    coreConfig.Text = "2304:144:32:36";
                    clockBase.Text = "1469 MHz";
                    clockBoost.Text = "1545 MHz";
                    memClock.Text = "8000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR5";
                    size.Text = "8 GB";
                    bandwidth.Text = "256 GB/s";
                    tdp.Text = "225 Watts";
                    msrp.Text = "$ 280";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;

                #endregion

                #region RX Vega Series

                case "Radeon RX Vega 56":
                    launch.Text = "August 28, 2017";
                    codeName.Text = "Vega 10 XL";
                    arch.Text = "GCN 5th Gen / 14 nm";
                    coreConfig.Text = "3584:224:64:56";
                    clockBase.Text = "1156 MHz";
                    clockBoost.Text = "1471 MHz";
                    memClock.Text = "1600 MT/s";
                    busW.Text = "2048 bits";
                    memType.Text = "HBM2";
                    size.Text = "8 GB";
                    bandwidth.Text = "409.6 GB/s";
                    tdp.Text = "210 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX Vega 64":
                    launch.Text = "August 14, 2017";
                    codeName.Text = "Vega 10 XT";
                    arch.Text = "GCN 5th Gen / 14 nm";
                    coreConfig.Text = "4096:256:64:64";
                    clockBase.Text = "1247 MHz";
                    clockBoost.Text = "1546 MHz";
                    memClock.Text = "1890 MT/s";
                    busW.Text = "2048 bits";
                    memType.Text = "HBM2";
                    size.Text = "8 GB";
                    bandwidth.Text = "483.8 GB/s";
                    tdp.Text = "295 Watts";
                    msrp.Text = "$ 500";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX Vega 64 Liquid":
                    launch.Text = "August 14, 2017";
                    codeName.Text = "Vega 10 XTX";
                    arch.Text = "GCN 5th Gen / 14 nm";
                    coreConfig.Text = "4096:256:64:64";
                    clockBase.Text = "1406 MHz";
                    clockBoost.Text = "1677 MHz";
                    memClock.Text = "1890 MT/s";
                    busW.Text = "2048 bits";
                    memType.Text = "HBM2";
                    size.Text = "8 GB";
                    bandwidth.Text = "483.8 GB/s";
                    tdp.Text = "345 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon VII":
                    launch.Text = "February 7, 2019";
                    codeName.Text = "Vega 20";
                    arch.Text = "GCN 5th Gen / 7 nm";
                    coreConfig.Text = "3840:240:64:60";
                    clockBase.Text = "1400 MHz";
                    clockBoost.Text = "1750 MHz";
                    memClock.Text = "2000 MT/s";
                    busW.Text = "4096 bits";
                    memType.Text = "HBM2";
                    size.Text = "16 GB";
                    bandwidth.Text = "1024 GB/s";
                    tdp.Text = "300 Watts";
                    msrp.Text = "$ 700";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;

                #endregion

                #region RX 5000 Series

                case "Radeon RX 5500 XT":
                    launch.Text = "December 12, 2019";
                    codeName.Text = "Navi 14 XTX";
                    arch.Text = "RDNA 1st Gen / 7 nm";
                    coreConfig.Text = "1408:88:32:22";
                    clockBase.Text = "1670 MHz";
                    clockBoost.Text = "1845 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "128 bits";
                    memType.Text = "GDDR6";
                    size.Text = "4 GB / 8 GB";
                    bandwidth.Text = "224 GB/s";
                    tdp.Text = "130 Watts";
                    msrp.Text = "$ 170 (4 GB) / $ 200 (8 GB)";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 5600 XT":
                    launch.Text = "January 21, 2020";
                    codeName.Text = "Navi 10 XLE";
                    arch.Text = "RDNA 1st Gen / 7 nm";
                    coreConfig.Text = "2304:144:48:36";
                    clockBase.Text = "1130 MHz";
                    clockBoost.Text = "1560 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "192 bits";
                    memType.Text = "GDDR6";
                    size.Text = "6 GB";
                    bandwidth.Text = "336 GB/s";
                    tdp.Text = "150 Watts";
                    msrp.Text = "$ 280";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 5700":
                    launch.Text = "July 7, 2019";
                    codeName.Text = "Navi 10 XL";
                    arch.Text = "RDNA 1st Gen / 7 nm";
                    coreConfig.Text = "2304:144:64:36";
                    clockBase.Text = "1465 MHz";
                    clockBoost.Text = "1725 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "180 Watts";
                    msrp.Text = "$ 350";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;
                case "Radeon RX 5700 XT":
                    launch.Text = "July 7, 2019";
                    codeName.Text = "Navi 10 XT";
                    arch.Text = "RDNA 1st Gen / 7 nm";
                    coreConfig.Text = "2560:160:64:40";
                    clockBase.Text = "1605 MHz";
                    clockBoost.Text = "1905 MHz";
                    memClock.Text = "14000 MT/s";
                    busW.Text = "256 bits";
                    memType.Text = "GDDR6";
                    size.Text = "8 GB";
                    bandwidth.Text = "448 GB/s";
                    tdp.Text = "225 Watts";
                    msrp.Text = "$ 400";
                    MostrarCoreInfo(tt, forInfo, "Radeon2");
                    break;

                #endregion

                default:
                    VaciarDetalles(launch, codeName, arch, coreConfig, clockBase, clockBoost,
                        memClock, busW, memType, size, bandwidth, tdp, msrp);    
                    break;
            }
        }
    }
}
