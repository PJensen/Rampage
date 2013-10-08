using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rampage.Core.DataRetriever;
using Rampage.Core.Objects;
using Rampage.Core.Util;
using Rampage.Core;
using Rampage.Core.Interfaces;
using Rampage.Components;
using System.Windows.Forms.DataVisualization.Charting;
using Rampage.Core.Delegates;

namespace Rampage.Controls
{
    /// <summary>
    /// PortfolioViewControl
    /// </summary>
    public partial class PortfolioViewControl : UserControl
    {
        /// <summary>
        /// MarketDataSelector
        /// </summary>
        public MarketDataSelector MarketDataSelector { get; set; }

        /// <summary>
        /// Portfolio
        /// </summary>
        public Portfolio Portfolio { get { return _portfolio; } }

        /// <summary>
        /// _portfolio
        /// </summary>
        private readonly Portfolio _portfolio;

        /// <summary>
        /// _retriever
        /// </summary>
        private readonly IMarketDataRetriever _retriever;

        /// <summary>
        /// _retrievalData
        /// </summary>
        private readonly List<PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs> _retrievalData
            = new List<PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs>();

        /// <summary>
        /// _chartSeries
        /// </summary>
        private readonly List<Series> _chartSeries = new List<Series>();

        /// <summary>
        /// PortfolioViewControl
        /// </summary>
        public PortfolioViewControl(Portfolio portfolio, IMarketDataRetriever retriever = null)
        {
            _portfolio = portfolio;
            _retriever = retriever ?? new YahooHistoricalDataRetriever();

            InitializeComponent();
        }

        /// <summary>
        /// PortfolioViewControl_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PortfolioViewControl_Load(object sender, EventArgs e)
        {
            portfolioDataRetrieverComponent.Get(_retriever, _portfolio);
        }

        /// <summary>
        /// Save
        /// </summary>
        /// <returns></returns>
        public bool Save(string fullPath)
        {
            return _portfolio.Save(fullPath);
        }

        /// <summary>
        /// portfolioDataRetrieverComponent_OnDataRetrieved
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void portfolioDataRetrieverComponent_OnDataRetrieved(object sender, PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs e)
        {
            toolStripStatusLabel.Text = string.Format("[{0}] {1}", e.Portfolio.Name, e.Message);

            if (e.Success)
            {
                _retrievalData.Add(e);
                _chartSeries.Clear();

                listBoxPortfolioItems.Items.Add(e.Security);

                var tmpSeries = new Series(e.Security)
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.Date,
                    YAxisType = AxisType.Primary,
                    XAxisType = AxisType.Secondary,
                    YValueType = ChartValueType.Auto,
                };

                var tmpWorkingData = MarketDataSelector == null ? e.MarketData : MarketDataSelector(e.MarketData);

                foreach (var marketTick in tmpWorkingData)
                {
                    tmpSeries.Points.AddXY(marketTick.Date, marketTick.PercentChangeTotal);
                }

                _chartSeries.Add(tmpSeries);
            }

            foreach (var series in _chartSeries)
            {
                chartOverview.Series.Add(series);
            }
        }

        /// <summary>
        /// listBoxPortfolioItems_SelectedIndexChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPortfolioItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //            var data = _retrievalData.FirstOrDefault(d => d.Security.Equals(listBoxPortfolioItems.SelectedItem));
            //
            //            if (data == null)
            //                return;
            //
            //            if (tabControlPortfolioView.TabPages.ContainsKey(data.Security))
            //                return;
            //
            //            var tmpTabPage = new TabPage(data.Security);
            //            tmpTabPage.Controls.Add(new SecurityViewControl(data) { Dock = DockStyle.Fill });
            //            tabControlPortfolioView.TabPages.Add(tmpTabPage);
        }

        private void chartOverview_DoubleClick(object sender, EventArgs e)
        {

        }

//        private void chartOverview_DoubleClick(object sender, EventArgs e)
//        {
//            chartOverview.Region = new Rectangle(chartOverview.Bounds.X + 1, chartOverview.Bounds.Y + 1,
//                                                 chartOverview.Bounds.Width - 1, chartOverview.Bounds.Height - 1);
//        }
    }
}
