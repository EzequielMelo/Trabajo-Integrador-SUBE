﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sube.Forms_Admin
{
    public partial class ChartMenu : Form
    {
        public ChartMenu()
        {
            InitializeComponent();

            Series series1 = chart1.Series[0];

            // Set the threshold under which all points will be collected
            series1["CollectedThreshold"] = "5";

            // Set the threshold type to be a percentage of the pie
    // When set to false, this property uses the actual value to determine the collected threshold
            series1["CollectedThresholdUsePercent"] = "true";

            // Set the label of the collected pie slice
            series1["CollectedLabel"] = "Other";

            // Set the legend text of the collected pie slice
            series1["CollectedLegendText"] = "Other";

            // Set the collected pie slice to be exploded
            series1["CollectedSliceExploded"] = "true";

            // Set the color of the collected pie slice
            series1["CollectedColor"] = "Green";

            // Set the tooltip of the collected pie slice
            series1["CollectedToolTip"] = "Other";


        }

    }
}
