using Rampage.Core.Interfaces;
using Rampage.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Rampage.Core.Objects
{
    /// <summary>
    /// TickerData
    /// </summary>
    public sealed class TickerData
    {
        /// <summary>
        /// portfolioData
        /// </summary>
        private List<MarketTick> tickerData;

        /// <summary>
        /// Portfolio
        /// </summary>
        private Portfolio portfolio;

        /// <summary>
        /// PortfolioData
        /// </summary>
        public TickerData(Portfolio portfolio)
        {
            this.portfolio = portfolio;
            tickerData = new List<MarketTick>();
        }
    }
}
