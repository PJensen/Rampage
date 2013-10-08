using Rampage.Core;
using Rampage.Core.Interfaces;
using Rampage.Core.Objects;
using Rampage.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Rampage.Components
{
    /// <summary>
    /// PortfolioDataRetrieverComponent
    /// </summary>
    public partial class PortfolioDataRetrieverComponent : Component
    {
        /// <summary>
        /// PortfolioDataRetrieverComponent
        /// </summary>
        public PortfolioDataRetrieverComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PortfolioDataRetrieverComponent
        /// </summary>
        /// <param name="container"></param>
        public PortfolioDataRetrieverComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// PortfolioDataRetievedEventArgs
        /// </summary>
        public class PortfolioDataRetievedEventArgs : EventArgs
        {
            /// <summary>
            /// PortfolioDataRetievedEventArgs
            /// </summary>
            /// <param name="portfolio"></param>
            /// <param name="security"> </param>
            /// <param name="message"> </param>
            /// <param name="fail"> </param>
            public PortfolioDataRetievedEventArgs(Portfolio portfolio, string security, string message, bool fail = false)
            {
                Security = security;
                ExecDt = DateTime.Now;
                Portfolio = portfolio;
                Message = message;
                Success = fail;
            }

            /// <summary>
            /// Portfolio
            /// </summary>
            public Portfolio Portfolio { get; private set; }

            /// <summary>
            /// The execution time of this event
            /// </summary>
            public DateTime ExecDt { get; private set; }

            /// <summary>
            /// The security loaded
            /// </summary>
            public string Security { get; private set; }

            /// <summary>
            /// The message
            /// </summary>
            public string Message { get; private set; }

            /// <summary>
            /// Failure
            /// </summary>
            public bool Success { get; private set; }

            /// <summary>
            /// Market Data
            /// </summary>
            public List<MarketTick> MarketData { get; set; }

            /// <summary>
            /// Raw data
            /// </summary>
            public DataTable RawData { get; set; }
        }

        /// <summary>
        /// OnDataRetrieved
        /// </summary>
        public event EventHandler<PortfolioDataRetievedEventArgs> OnDataRetrieved;

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="retriever"> </param>
        /// <param name="portfolio"></param>
        /// <returns></returns>
        public void Get(IMarketDataRetriever retriever, Portfolio portfolio)
        {
            foreach (var item in portfolio.Items)
            {
                bool fail;
                string msg;

                var tmpDataTable = retriever.Retrieve(item, out msg, out fail);
                var tmpMarketTicks = R.Convert(item, tmpDataTable);

                if (OnDataRetrieved != null)
                {
                    OnDataRetrieved(this, new PortfolioDataRetievedEventArgs(portfolio, item, msg, !fail)
                    {
                        MarketData = tmpMarketTicks ?? new List<MarketTick>(),
                        RawData = tmpDataTable,
                    });
                }
            }
        }
    }
}
