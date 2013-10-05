using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rampage.Core.Objects;
using Rampage.Core.Util;
using Rampage.Core;
using Rampage.Core.Interfaces;
using Rampage.Components;

namespace Rampage.Controls
{
    /// <summary>
    /// PortfolioViewControl
    /// </summary>
    public partial class PortfolioViewControl : UserControl
    {
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
        /// PortfolioViewControl
        /// </summary>
        public PortfolioViewControl(Portfolio portfolio, IMarketDataRetriever retriever = null)
        {
            _portfolio = portfolio;
            _retriever = retriever ?? new YahooDataRetriever();

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
                listBoxPortfolioItems.Items.Add(e.Security);
            }
        }


    }
}
