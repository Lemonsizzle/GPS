using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Device.Location;

namespace GPS
{
    public partial class Form1 : Form
    {
        static private bool SPS = false;
        static SerialPort sp = new SerialPort();
        GeoCoordinate preLoc;
        GeoCoordinate curLoc;

        // GPS Data page variables
        string recData;     // received data (the GPGGA stuff)
        string[] splitData;
        bool AU = true, ATOD = false;      // always update and add to old data ticks
        int RDL = 0;        // Received Data Length
        string curLatData, curLonData; // current raw data
        double latP, lonP;   // prev position data
        double latC, lonC;   // curr position data
        double timeP, timeC; // prev/curr position time
        double dist, time, speed, totalDist = 0, totalTime = 0;   // Calculation
        string compY, compX;

        bool dataPause = false;

        /// <summary>
        /// main method
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            comPortBox.Items.AddRange(ports);
            comPortBox.Sorted = true;

            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            SpeedRecord.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            SpeedRecord.ChartAreas[0].AxisX.Minimum = 0;

            SpeedRecord.ChartAreas[0].AxisY.Interval = 50;
            SpeedRecord.ChartAreas[0].AxisY.Minimum = 0;
            SpeedRecord.ChartAreas[0].AxisY.Maximum = 150;
        }

        /// <summary>
        /// method called for dealing with major calculations
        /// </summary>
        public void calculate()
        {
            // latitude calculation
            double latDeg = double.Parse(splitData[2].Substring(0, 2));
            double latMin = double.Parse(splitData[2].Substring(2));
            latC = (latDeg + (latMin / 60));
            if (splitData[3] == "S")
            {
                latC *= -1.0;
            }

            // longitude calculation
            double lonDeg = double.Parse(splitData[4].Substring(0, 3));
            double lonMin = double.Parse(splitData[4].Substring(3));
            lonC = (lonDeg + (lonMin / 60));
            if(splitData[5] == "W")
            {
                lonC *= -1.0;
            }

            // direction of travel
            if (latC < latP)
            {
                compY = "S";
            }
            else
            {
                compY = "N";
            }
            if(lonC < lonP)
            {
                compX = "W";
            }
            else
            {
                compX = "E";
            }

            preLoc = curLoc;
            curLoc = new GeoCoordinate(latC, lonC);

            // time calculation
            double timeH = double.Parse(splitData[1].Substring(0, 2));
            double timeM = double.Parse(splitData[1].Substring(2, 2));
            double timeS = double.Parse(splitData[1].Substring(4));
            timeC = (timeH * 3600) + (timeM * 60) + timeS;

            if(timeP != 0)
            {
                dist = preLoc.GetDistanceTo(curLoc);
                time = timeC - timeP;
            }

            speed = (double)((3.6) * (dist / time)); // speed is km/h
            totalDist += (dist/1000);  // total distance is in km
            totalTime += (time/60); // total time is in minutes
        }

        private void update(object sender, EventArgs e)
        {
            if (AU)
            {
                receivedData.Text = recData;
                RDL = recData.Length;
            }
            else if (ATOD)
            {
                receivedData.AppendText(recData);
                RDL += recData.Length;
            }
            updateBox(recDataS, recData.Substring(1));
            updateLab(RecDataLen, "Received Data Length: " + RDL);

            updateBox(dataLat1, dataLat2.Text);
            updateBox(dataLon1, dataLon2.Text);
            updateBox(dataTime1, dataTime2.Text);

            updateBox(dataLat2, curLatData);
            updateBox(dataLon2, curLonData);
            updateBox(dataTime2, splitData[1]);

            updateBox(calcDist, string.Format("{0:N2}", dist));
            updateBox(calcSpeed, string.Format("{0:N2}", speed));
            updateBox(calcCompass, (compY + compX));
            updateBox(calcDistT, string.Format("{0:N4}", totalDist));
            updateBox(calcTimeT, string.Format("{0:N4}", totalTime));

            SpeedRecord.Series[0].Points.AddXY(totalTime * 60, speed);

            if (!dataPause)
            {
                updateBox(analysisLat, curLatData);
                updateBox(analysisLon, curLonData);
            }
        }

        /// <summary>
        /// method called for updating continuously altered text boxes
        /// </summary>
        /// <param name="o">text box being changed</param>
        /// <param name="s">text being put on the text box</param>
        private void updateBox(TextBox o, string s)
        {
            o.Text = s;
        }

        /// <summary>
        /// method called for updating continuously altered labels
        /// </summary>
        /// <param name="o">label being changed</param>
        /// <param name="s">text being put on the label</param>
        private void updateLab(Label o, string s)
        {
            o.Text = s;
        }

        /// <summary>
        /// event handler for receiving data through the serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (SPS)
            {
                recData = sp.ReadExisting();
                splitData = recData.Split(',');

                latP = latC;
                lonP = lonC;
                timeP = timeC;

                curLatData = splitData[3] + string.Format("{0:N8}", Math.Abs(latC));
                curLonData = splitData[5] + string.Format("{0:N8}", Math.Abs(lonC));

                calculate();
                this.BeginInvoke(new EventHandler(update));
            }
        }

        /// <summary>
        /// event handler for interacting with the "Open" button in the Serial Port tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialOpenB_Click(object sender, EventArgs e)
        {
            serialOpenB.Enabled = false;
            serialCloseB.Enabled = true;
            serialPortStatus.Text = "ON";
            SPS = true;

            try
            {
                sp.PortName = comPortBox.Text;
                sp.BaudRate = int.Parse(baudRateBox.SelectedItem.ToString());
                sp.Parity = (Parity)Enum.Parse(typeof(Parity), parBitBox.SelectedItem.ToString(), true);
                sp.DataBits = int.Parse(dataBitBox.SelectedItem.ToString());
                sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitBox.SelectedItem.ToString(), true);
                sp.ReadTimeout = 500;
                sp.WriteTimeout = 500;
                sp.RtsEnable = true;
                sp.Open();
                progressBar.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialCloseB.PerformClick();
            }
        }

        /// <summary>
        /// event handler for interacting with the "Close" button in the Serial Port tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialCloseB_Click(object sender, EventArgs e)
        {
            serialOpenB.Enabled = true;
            serialCloseB.Enabled = false;
            serialPortStatus.Text = "OFF";
            SPS = false;

            if (sp.IsOpen)
            {
                sp.Close();
            }

            progressBar.Value = 0;
        }

        /// <summary>
        /// event handler for interacting with the "Clear Received Data" button in the GPS Data tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void recDataClear_Click(object sender, EventArgs e)
        {
            if(receivedData.Text != "")
            {
                receivedData.Text = "";
                RDL = receivedData.TextLength;
                updateLab(RecDataLen, "Received Data Length: " + RDL);
            }
        }

        /// <summary>
        /// event handler for interacting with the "Always Update" check in the GPS Data tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            AU = alwaysUpdate.Checked;
            addToOld.Checked = !alwaysUpdate.Checked;
        }

        /// <summary>
        /// event handler for interacting with the "Add To Old Data" check in the GPS Data tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToOld_CheckedChanged(object sender, EventArgs e)
        {
            ATOD = addToOld.Checked;
            alwaysUpdate.Checked = !addToOld.Checked;
        }

        /// <summary>
        /// event handler for interacting with the "Pause/Resume" button in the GPS Data Analysis tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GPSDataPause_Click(object sender, EventArgs e)
        {
            dataPause = !dataPause;
            if (dataPause)
            {
                GPSDataPause.Text = "Resume";
            }
            else
            {
                GPSDataPause.Text = "Pause";
            }
        }

        /// <summary>
        /// event handler for interacting with the "Map Location" button in the GPS Data Analysis tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GPSDataMap_Click(object sender, EventArgs e)
        {
            if (curLoc != null)
            {
                string mapLat = curLoc.Latitude.ToString(), mapLon = curLoc.Longitude.ToString();
                string mapURL;
                
                mapURL = $"https://www.google.com/maps/dir//'{mapLat},{mapLon}'/@{mapLat},{mapLon},15z";

                System.Diagnostics.Process.Start(mapURL);
            }
        }
    }
}
