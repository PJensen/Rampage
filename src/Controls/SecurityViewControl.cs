using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rampage.Components;
using System.Windows.Forms.DataVisualization.Charting;

namespace Rampage.Controls
{
    /// <summary>
    /// SecurityViewControl
    /// </summary>
    public partial class SecurityViewControl : UserControl
    {
        /// <summary>
        /// _retrievedData
        /// </summary>
        private readonly PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs _retrievedData;
        /// <summary>
        /// SecurityViewControl
        /// </summary>
        public SecurityViewControl(PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs e)
        {
            InitializeComponent();

            _retrievedData = e;
        }

        /// <summary>
        /// SecurityViewControl_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecurityViewControl_Load(object sender, EventArgs e)
        {
            var tmpSeries = new Series(_retrievedData.Security)
            {
                ChartType = SeriesChartType.Candlestick
            };


            foreach (var marketTicks in _retrievedData.MarketData.Where(dt => dt.Date >= DateTime.Now.AddDays(-90)))
            {
                tmpSeries.Points.Add(marketTicks.AsCandleStick);
            }

            chartSecurity.Series.Add(tmpSeries);
        }
    }
}
