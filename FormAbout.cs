using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SuplaBatteryOnOff
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:silar12@gmail.com" + "?subject=SuplaBatteryOnOff " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "&body= Witam serdecznie Panie Krzysztofie\n" + Environment.NewLine);

            //Process.Start("mailto:" + emailAddress + "?subject=" + subject + "&body="
            //            + body);

        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        }

        private void labelEmail_MouseHover(object sender, EventArgs e)
        {
            labelEmail.Font = new Font(labelEmail.Font, FontStyle.Underline);

        }

        private void labelEmail_MouseLeave(object sender, EventArgs e)
        {
            labelEmail.Font = new Font(labelEmail.Font, FontStyle.Regular);

        }
    }
}
