using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            repositoryItemMyButtonEdit3.TextToScroll = String.Format("20°C{0}{0}London{0}{0}30°C{0}{0}Paris{0}", Environment.NewLine);
        }


        const int maxValue = 100;
        int value = -maxValue;

        private void timer1_Tick(object sender, EventArgs e)
        {
            value++;
            if (value > maxValue)
                value = -maxValue;
            barEditItem2.EditValue = value;
        }
    }
}