using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SuplaBatteryOnOff
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        float batteryPercent = 0;

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxDirectLinkOn.Text = Properties.Settings.Default.directLinkOn;
            textBoxDirectLinkOff.Text = Properties.Settings.Default.directLinkOff;
            numericUpDownBatteryActionOn.Value = Properties.Settings.Default.batteryActionOn;
            numericUpDownBatteryActionOff.Value = Properties.Settings.Default.batteryActionOff;

            timerGetBatteryInfo.Start();
            timerDirectLink.Start();

            if (timerDirectLink.Enabled)
            {
                buttonActionStart.Enabled = false;
                buttonActionStop.Enabled = true;
            }
            else
            {
                buttonActionStart.Enabled = true;
                buttonActionStop.Enabled = false;

            }
        }

        private void timerGetBatteryInfo_Tick(object sender, EventArgs e)
        {
            ShowPowerStatus();
        }



        private void buttonActionStart_Click(object sender, EventArgs e)
        {
            timerDirectLink.Start();

            if (timerDirectLink.Enabled)
            {
                buttonActionStart.Enabled = false;
                buttonActionStop.Enabled = true;
            }
            else
            {
                buttonActionStart.Enabled = true;
                buttonActionStop.Enabled = false;

            }
        }

        private void buttonActionStop_Click(object sender, EventArgs e)
        {
            timerDirectLink.Stop();

            if (!timerDirectLink.Enabled)
            {
                buttonActionStart.Enabled = true;
                buttonActionStop.Enabled = false;
            }
            else
            {
                buttonActionStart.Enabled = false;
                buttonActionStop.Enabled = true;

            }
        }

        private void timerDirectLink_Tick(object sender, EventArgs e)
        {
            if (batteryPercent <= (float)numericUpDownBatteryActionOn.Value)
                DirectLinkAsync(textBoxDirectLinkOn.Text);
            else if (batteryPercent >= (float)numericUpDownBatteryActionOff.Value)
                DirectLinkAsync(textBoxDirectLinkOff.Text);
        }

        private void buttonTestOn_Click(object sender, EventArgs e)
        {
            DirectLinkAsync(textBoxDirectLinkOn.Text);
        }

        private void buttonTestOff_Click(object sender, EventArgs e)
        {
            DirectLinkAsync(textBoxDirectLinkOff.Text);
        }


        private void ShowPowerStatus()
        {
            PowerStatus status = SystemInformation.PowerStatus;

            batteryPercent = status.BatteryLifePercent * 100;

            textBoxChargeStatus.Text = status.BatteryChargeStatus.ToString();
            if (status.BatteryFullLifetime == -1)
                textBoxFullLifeTime.Text = "Unknown";
            else
                textBoxFullLifeTime.Text = status.BatteryFullLifetime.ToString();
            textBoxCharge.Text = status.BatteryLifePercent.ToString("P0");
            if (status.BatteryLifeRemaining == -1)
                textBoxLifeRemaining.Text = "Unknown";
            else
                textBoxLifeRemaining.Text =
                    status.BatteryLifeRemaining.ToString();
            textBoxLineStatus.Text = status.PowerLineStatus.ToString();
        }

        private async void DirectLinkAsync(string url)
        {
            string patch = "";
            string auth = "";
            string linkAction = "";
            string[] spearator = { "/" };
            int count = 6;

            String[] strlist = url.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

            patch = strlist[0] + "//" + strlist[1] + "/" + strlist[2] + "/" + strlist[3];
            auth = strlist[4];
            linkAction = strlist[5];

            string content = "{\"code\":\"" + auth + "\",\"action\":\"" + linkAction + "\"}";

            using (var httpClient = new HttpClient())
            {

                using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), patch))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");

                    request.Content = new StringContent(content);
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var response = await httpClient.SendAsync(request);
                }
                }
        }

        private void textBoxDirectLinkOn_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.directLinkOn = textBoxDirectLinkOn.Text;
            Properties.Settings.Default.Save();
        }

        private void textBoxDirectLinkOff_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.directLinkOff = textBoxDirectLinkOff.Text;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownBatteryActionOn_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.batteryActionOn = numericUpDownBatteryActionOn.Value;
            Properties.Settings.Default.Save();
        }

        private void numericUpDownBatteryActionOff_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.batteryActionOff = numericUpDownBatteryActionOff.Value;
            Properties.Settings.Default.Save();
        }
    }
}
