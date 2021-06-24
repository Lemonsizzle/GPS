
namespace GPS
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialPortStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.serialCloseB = new System.Windows.Forms.Button();
            this.serialOpenB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parBitBox = new System.Windows.Forms.ComboBox();
            this.stopBitBox = new System.Windows.Forms.ComboBox();
            this.dataBitBox = new System.Windows.Forms.ComboBox();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataTime2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataLon2 = new System.Windows.Forms.TextBox();
            this.dataLat2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.calcSpeed = new System.Windows.Forms.TextBox();
            this.calcDist = new System.Windows.Forms.TextBox();
            this.calcCompass = new System.Windows.Forms.TextBox();
            this.calcTimeT = new System.Windows.Forms.TextBox();
            this.calcDistT = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataTime1 = new System.Windows.Forms.TextBox();
            this.dataLon1 = new System.Windows.Forms.TextBox();
            this.dataLat1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RecDataLen = new System.Windows.Forms.Label();
            this.addToOld = new System.Windows.Forms.CheckBox();
            this.alwaysUpdate = new System.Windows.Forms.CheckBox();
            this.recDataClear = new System.Windows.Forms.Button();
            this.receivedData = new System.Windows.Forms.RichTextBox();
            this.recDataS = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.analysisLon = new System.Windows.Forms.TextBox();
            this.analysisLat = new System.Windows.Forms.TextBox();
            this.GPSDataMap = new System.Windows.Forms.Button();
            this.GPSDataPause = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.SpeedRecord = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.progressBar);
            this.groupBox9.Controls.Add(this.serialCloseB);
            this.groupBox9.Controls.Add(this.serialOpenB);
            this.groupBox9.Location = new System.Drawing.Point(28, 250);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(301, 141);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.serialPortStatus);
            this.groupBox3.Location = new System.Drawing.Point(114, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 88);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Port Status";
            // 
            // serialPortStatus
            // 
            this.serialPortStatus.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialPortStatus.Location = new System.Drawing.Point(6, 13);
            this.serialPortStatus.Name = "serialPortStatus";
            this.serialPortStatus.Size = new System.Drawing.Size(157, 73);
            this.serialPortStatus.TabIndex = 1;
            this.serialPortStatus.Text = "OFF";
            this.serialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.Location = new System.Drawing.Point(17, 106);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 23);
            this.progressBar.TabIndex = 7;
            // 
            // serialCloseB
            // 
            this.serialCloseB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.serialCloseB.Enabled = false;
            this.serialCloseB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialCloseB.Location = new System.Drawing.Point(17, 58);
            this.serialCloseB.Name = "serialCloseB";
            this.serialCloseB.Size = new System.Drawing.Size(91, 41);
            this.serialCloseB.TabIndex = 6;
            this.serialCloseB.Text = "Close";
            this.serialCloseB.UseVisualStyleBackColor = true;
            this.serialCloseB.Click += new System.EventHandler(this.serialCloseB_Click);
            // 
            // serialOpenB
            // 
            this.serialOpenB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.serialOpenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialOpenB.Location = new System.Drawing.Point(17, 11);
            this.serialOpenB.Name = "serialOpenB";
            this.serialOpenB.Size = new System.Drawing.Size(91, 41);
            this.serialOpenB.TabIndex = 5;
            this.serialOpenB.Text = "Open";
            this.serialOpenB.UseVisualStyleBackColor = true;
            this.serialOpenB.Click += new System.EventHandler(this.serialOpenB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parBitBox);
            this.groupBox2.Controls.Add(this.stopBitBox);
            this.groupBox2.Controls.Add(this.dataBitBox);
            this.groupBox2.Controls.Add(this.baudRateBox);
            this.groupBox2.Controls.Add(this.comPortBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(28, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 232);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Parameters";
            // 
            // parBitBox
            // 
            this.parBitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parBitBox.FormattingEnabled = true;
            this.parBitBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parBitBox.Location = new System.Drawing.Point(165, 185);
            this.parBitBox.Name = "parBitBox";
            this.parBitBox.Size = new System.Drawing.Size(121, 28);
            this.parBitBox.TabIndex = 20;
            this.parBitBox.Text = "None";
            // 
            // stopBitBox
            // 
            this.stopBitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBitBox.FormattingEnabled = true;
            this.stopBitBox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopBitBox.Location = new System.Drawing.Point(165, 145);
            this.stopBitBox.Name = "stopBitBox";
            this.stopBitBox.Size = new System.Drawing.Size(121, 28);
            this.stopBitBox.TabIndex = 19;
            this.stopBitBox.Text = "One";
            // 
            // dataBitBox
            // 
            this.dataBitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBitBox.FormattingEnabled = true;
            this.dataBitBox.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.dataBitBox.Location = new System.Drawing.Point(165, 105);
            this.dataBitBox.Name = "dataBitBox";
            this.dataBitBox.Size = new System.Drawing.Size(121, 28);
            this.dataBitBox.TabIndex = 18;
            this.dataBitBox.Text = "8";
            // 
            // baudRateBox
            // 
            this.baudRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.baudRateBox.Location = new System.Drawing.Point(165, 65);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(121, 28);
            this.baudRateBox.TabIndex = 17;
            this.baudRateBox.Text = "9600";
            // 
            // comPortBox
            // 
            this.comPortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.Location = new System.Drawing.Point(165, 25);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(121, 28);
            this.comPortBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Parity Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Com Port #";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GPS Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.receivedData);
            this.groupBox5.Controls.Add(this.recDataS);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 389);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Received Data";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox7);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Location = new System.Drawing.Point(10, 178);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(332, 208);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataTime2);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.dataLon2);
            this.groupBox7.Controls.Add(this.dataLat2);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Location = new System.Drawing.Point(174, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(140, 84);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Current Position";
            // 
            // dataTime2
            // 
            this.dataTime2.Location = new System.Drawing.Point(51, 59);
            this.dataTime2.Name = "dataTime2";
            this.dataTime2.Size = new System.Drawing.Size(86, 20);
            this.dataTime2.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Time2";
            // 
            // dataLon2
            // 
            this.dataLon2.Location = new System.Drawing.Point(51, 37);
            this.dataLon2.Name = "dataLon2";
            this.dataLon2.Size = new System.Drawing.Size(86, 20);
            this.dataLon2.TabIndex = 13;
            // 
            // dataLat2
            // 
            this.dataLat2.Location = new System.Drawing.Point(51, 15);
            this.dataLat2.Name = "dataLat2";
            this.dataLat2.Size = new System.Drawing.Size(86, 20);
            this.dataLat2.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Lon2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Lat2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.calcSpeed);
            this.groupBox4.Controls.Add(this.calcDist);
            this.groupBox4.Controls.Add(this.calcCompass);
            this.groupBox4.Controls.Add(this.calcTimeT);
            this.groupBox4.Controls.Add(this.calcDistT);
            this.groupBox4.Location = new System.Drawing.Point(19, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 100);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculation";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(190, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Compass";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(117, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "speed (km/h)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(162, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Total Time (min)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Total Distance (KM)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Distance (m)";
            // 
            // calcSpeed
            // 
            this.calcSpeed.Location = new System.Drawing.Point(120, 31);
            this.calcSpeed.Name = "calcSpeed";
            this.calcSpeed.Size = new System.Drawing.Size(67, 20);
            this.calcSpeed.TabIndex = 14;
            // 
            // calcDist
            // 
            this.calcDist.Location = new System.Drawing.Point(51, 31);
            this.calcDist.Name = "calcDist";
            this.calcDist.Size = new System.Drawing.Size(63, 20);
            this.calcDist.TabIndex = 13;
            // 
            // calcCompass
            // 
            this.calcCompass.Location = new System.Drawing.Point(193, 31);
            this.calcCompass.Name = "calcCompass";
            this.calcCompass.Size = new System.Drawing.Size(47, 20);
            this.calcCompass.TabIndex = 12;
            // 
            // calcTimeT
            // 
            this.calcTimeT.Location = new System.Drawing.Point(155, 70);
            this.calcTimeT.Name = "calcTimeT";
            this.calcTimeT.Size = new System.Drawing.Size(100, 20);
            this.calcTimeT.TabIndex = 11;
            // 
            // calcDistT
            // 
            this.calcDistT.Location = new System.Drawing.Point(39, 70);
            this.calcDistT.Name = "calcDistT";
            this.calcDistT.Size = new System.Drawing.Size(100, 20);
            this.calcDistT.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataTime1);
            this.groupBox6.Controls.Add(this.dataLon1);
            this.groupBox6.Controls.Add(this.dataLat1);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(19, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(139, 84);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Previous Position";
            // 
            // dataTime1
            // 
            this.dataTime1.Location = new System.Drawing.Point(49, 59);
            this.dataTime1.Name = "dataTime1";
            this.dataTime1.Size = new System.Drawing.Size(86, 20);
            this.dataTime1.TabIndex = 11;
            // 
            // dataLon1
            // 
            this.dataLon1.Location = new System.Drawing.Point(49, 37);
            this.dataLon1.Name = "dataLon1";
            this.dataLon1.Size = new System.Drawing.Size(86, 20);
            this.dataLon1.TabIndex = 10;
            // 
            // dataLat1
            // 
            this.dataLat1.Location = new System.Drawing.Point(49, 15);
            this.dataLat1.Name = "dataLat1";
            this.dataLat1.Size = new System.Drawing.Size(86, 20);
            this.dataLat1.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Time1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Lon1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Lat1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RecDataLen);
            this.groupBox1.Controls.Add(this.addToOld);
            this.groupBox1.Controls.Add(this.alwaysUpdate);
            this.groupBox1.Controls.Add(this.recDataClear);
            this.groupBox1.Location = new System.Drawing.Point(10, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 60);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiving Options";
            // 
            // RecDataLen
            // 
            this.RecDataLen.AutoSize = true;
            this.RecDataLen.Location = new System.Drawing.Point(140, 42);
            this.RecDataLen.Name = "RecDataLen";
            this.RecDataLen.Size = new System.Drawing.Size(133, 13);
            this.RecDataLen.TabIndex = 7;
            this.RecDataLen.Text = "Received Data Length: 00";
            this.RecDataLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addToOld
            // 
            this.addToOld.AutoSize = true;
            this.addToOld.Location = new System.Drawing.Point(213, 15);
            this.addToOld.Name = "addToOld";
            this.addToOld.Size = new System.Drawing.Size(106, 17);
            this.addToOld.TabIndex = 6;
            this.addToOld.Text = "Add To Old Data";
            this.addToOld.UseVisualStyleBackColor = true;
            this.addToOld.CheckedChanged += new System.EventHandler(this.addToOld_CheckedChanged);
            // 
            // alwaysUpdate
            // 
            this.alwaysUpdate.AutoSize = true;
            this.alwaysUpdate.Checked = true;
            this.alwaysUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysUpdate.Location = new System.Drawing.Point(110, 15);
            this.alwaysUpdate.Name = "alwaysUpdate";
            this.alwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.alwaysUpdate.TabIndex = 5;
            this.alwaysUpdate.Text = "Always Update";
            this.alwaysUpdate.UseVisualStyleBackColor = true;
            this.alwaysUpdate.CheckedChanged += new System.EventHandler(this.alwaysUpdate_CheckedChanged);
            // 
            // recDataClear
            // 
            this.recDataClear.Location = new System.Drawing.Point(13, 15);
            this.recDataClear.Name = "recDataClear";
            this.recDataClear.Size = new System.Drawing.Size(90, 40);
            this.recDataClear.TabIndex = 4;
            this.recDataClear.Text = "Clear Received Data";
            this.recDataClear.UseVisualStyleBackColor = true;
            this.recDataClear.Click += new System.EventHandler(this.recDataClear_Click);
            // 
            // receivedData
            // 
            this.receivedData.Location = new System.Drawing.Point(10, 23);
            this.receivedData.Name = "receivedData";
            this.receivedData.Size = new System.Drawing.Size(332, 62);
            this.receivedData.TabIndex = 9;
            this.receivedData.Text = "";
            // 
            // recDataS
            // 
            this.recDataS.Location = new System.Drawing.Point(10, 91);
            this.recDataS.Name = "recDataS";
            this.recDataS.Size = new System.Drawing.Size(332, 20);
            this.recDataS.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.groupBox11);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(366, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GPS Data Analysis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.analysisLon);
            this.groupBox11.Controls.Add(this.analysisLat);
            this.groupBox11.Controls.Add(this.GPSDataMap);
            this.groupBox11.Controls.Add(this.GPSDataPause);
            this.groupBox11.Controls.Add(this.label11);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Location = new System.Drawing.Point(9, 221);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(349, 170);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "GPS Data Virtualisation";
            // 
            // analysisLon
            // 
            this.analysisLon.Location = new System.Drawing.Point(72, 65);
            this.analysisLon.Name = "analysisLon";
            this.analysisLon.Size = new System.Drawing.Size(119, 20);
            this.analysisLon.TabIndex = 11;
            // 
            // analysisLat
            // 
            this.analysisLat.Location = new System.Drawing.Point(72, 33);
            this.analysisLat.Name = "analysisLat";
            this.analysisLat.Size = new System.Drawing.Size(119, 20);
            this.analysisLat.TabIndex = 10;
            // 
            // GPSDataMap
            // 
            this.GPSDataMap.Location = new System.Drawing.Point(72, 129);
            this.GPSDataMap.Name = "GPSDataMap";
            this.GPSDataMap.Size = new System.Drawing.Size(119, 23);
            this.GPSDataMap.TabIndex = 9;
            this.GPSDataMap.Text = "Map Location";
            this.GPSDataMap.UseVisualStyleBackColor = true;
            this.GPSDataMap.Click += new System.EventHandler(this.GPSDataMap_Click);
            // 
            // GPSDataPause
            // 
            this.GPSDataPause.Location = new System.Drawing.Point(72, 100);
            this.GPSDataPause.Name = "GPSDataPause";
            this.GPSDataPause.Size = new System.Drawing.Size(119, 23);
            this.GPSDataPause.TabIndex = 8;
            this.GPSDataPause.Text = "Pause";
            this.GPSDataPause.UseVisualStyleBackColor = true;
            this.GPSDataPause.Click += new System.EventHandler(this.GPSDataPause_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Longitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Latitude:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.SpeedRecord);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(352, 209);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Speed Record";
            // 
            // SpeedRecord
            // 
            this.SpeedRecord.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Time (s)";
            chartArea1.AxisY.Title = "Speed (km/h)";
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowOffset = 2;
            this.SpeedRecord.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SpeedRecord.Legends.Add(legend1);
            this.SpeedRecord.Location = new System.Drawing.Point(3, 9);
            this.SpeedRecord.Name = "SpeedRecord";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Speed";
            this.SpeedRecord.Series.Add(series1);
            this.SpeedRecord.Size = new System.Drawing.Size(343, 197);
            this.SpeedRecord.TabIndex = 0;
            this.SpeedRecord.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 449);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GPS Emulator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox parBitBox;
        private System.Windows.Forms.ComboBox stopBitBox;
        private System.Windows.Forms.ComboBox dataBitBox;
        private System.Windows.Forms.ComboBox baudRateBox;
        private System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RecDataLen;
        private System.Windows.Forms.CheckBox addToOld;
        private System.Windows.Forms.CheckBox alwaysUpdate;
        private System.Windows.Forms.Button recDataClear;
        private System.Windows.Forms.TextBox recDataS;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label serialPortStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button serialCloseB;
        private System.Windows.Forms.Button serialOpenB;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox dataTime2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox dataLon2;
        private System.Windows.Forms.TextBox dataLat2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox calcSpeed;
        private System.Windows.Forms.TextBox calcDist;
        private System.Windows.Forms.TextBox calcCompass;
        private System.Windows.Forms.TextBox calcTimeT;
        private System.Windows.Forms.TextBox calcDistT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox dataTime1;
        private System.Windows.Forms.TextBox dataLon1;
        private System.Windows.Forms.TextBox dataLat1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox analysisLon;
        private System.Windows.Forms.TextBox analysisLat;
        private System.Windows.Forms.Button GPSDataMap;
        private System.Windows.Forms.Button GPSDataPause;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart SpeedRecord;
        private System.Windows.Forms.RichTextBox receivedData;
    }
}

