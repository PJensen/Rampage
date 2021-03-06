﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Rampage.Core
{
    /// <summary>
    /// MarketTicks
    /// </summary>
    [DebuggerDisplay("{Date} [{Open}, {High}, {Low}, {Close}]")]
    public class MarketTick
    {
        /// <summary>
        /// HasNext
        /// </summary>
        public bool HasNext { get { return Next != null; } }

        /// <summary>
        /// HasPrev
        /// </summary>
        public bool HasPrev { get { return Prev != null; } }

        /// <summary>
        /// The next market tick
        /// </summary>
        public MarketTick Next { get; set; }

        /// <summary>
        /// The next market tick
        /// </summary>
        public MarketTick Prev { get; set; }

        /// <summary>
        /// First
        /// </summary>
        public MarketTick First { get; set; }

        /// <summary>
        /// Last
        /// </summary>
        public MarketTick Last { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>string representation of this market data element</returns>
        public override string ToString()
        {
            return string.Format("{0} [{1}, {2}, {3}, {4}]", Date, Open, High, Low, Close);
        }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Close
        /// </summary>
        public double Close { get; set; }

        /// <summary>
        /// Open
        /// </summary>
        public double Open { get; set; }

        /// <summary>
        /// High
        /// </summary>
        public double High { get; set; }

        /// <summary>
        /// Low
        /// </summary>
        public double Low { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        public long Volume { get; set; }

        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// PercentChange
        /// </summary>
        public double PercentChangeTotal
        {
            get
            {
                var current = Close;

                if (!HasPrev)
                {
                    return 0;
                }

                var firstClose = First.Close;

                return ((current - firstClose) / firstClose) * 100.0d;
            }
        }

        /// <summary>
        /// Technicals
        /// </summary>
        public Dictionary<string, double> Technicals { get; set; }

        /// <summary>
        /// AsCandleStick
        /// </summary>
        public double[] AsCandleStick
        {
            get
            {
                return new[]
                       {
                           Low,
                           High,
                           Close,
                           Open
                       };
            }
        }

        /// <summary>
        /// AsLine is just the closing price
        /// </summary>
        public double AsLine
        {
            get
            {
                return Close;
            }
        }
    }
}
