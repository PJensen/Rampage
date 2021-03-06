﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Rampage.Core.Util
{
    /// <summary>
    /// Convert
    /// </summary>
    public static class R
    {
        /// <summary>
        /// MarketDataSelectors
        /// </summary>
        public static class MarketDataSelectors
        {
            /// <summary>
            /// RecentMonthSelector
            /// </summary>
            /// <param name="ticks">inbound ticks</param>
            /// <returns>outbound enumeration</returns>
            public static IEnumerable<MarketTick> RecentMonthSelector(IEnumerable<MarketTick> ticks)
            {
                return ticks;
            }
        }

        /// <summary>
        /// random
        /// </summary>
        private static readonly Random random = new Random((int)DateTime.Now.Ticks);

        #region properties

        /// <summary>
        /// Save action
        /// </summary>
        private static readonly Action Save = Properties.Settings.Default.Save;

        /// <summary>
        /// ExitConfirmation
        /// </summary>
        public static bool AskExit
        {
            get { return Properties.Settings.Default.AskExit; }
            set
            {
                Properties.Settings.Default.AskExit = value;

                Save();
            }
        }

        /// <summary>
        /// WorkingDirectory
        /// </summary>
        public static string WorkingDirectory
        {
            get { return Properties.Settings.Default.WorkingDirectory; }
            set
            {
                Properties.Settings.Default.WorkingDirectory = value;

                Save();
            }
        }

        #endregion

        /// <summary>
        /// CurrentDirectory
        /// </summary>
        public static string CurrentDirectory
        {
            get { return Directory.GetCurrentDirectory(); }
        }

        /// <summary>
        /// Convert
        /// </summary>
        /// <param name="symbol"> </param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<MarketTick> Convert(string symbol, DataTable table)
        {
            var retVal = new MarketTick[table.Rows.Count];

            for (var i = 0; i < table.Rows.Count; ++i)
            {
                retVal[i] = new MarketTick()
                {
                    Date = DateTime.Parse(table.Rows[i]["Date"].ToString()),
                    Open = double.Parse(table.Rows[i]["Open"].ToString()),
                    High = double.Parse(table.Rows[i]["High"].ToString()),
                    Low = double.Parse(table.Rows[i]["Low"].ToString()),
                    Close = double.Parse(table.Rows[i]["Close"].ToString()),
                    Volume = long.Parse(table.Rows[i]["Volume"].ToString()),
                    Symbol = symbol
                };
            }

            retVal = retVal.Reverse().ToArray();

            for (var i = 1; i < table.Rows.Count; ++i)
                retVal[i].Prev = retVal[i - 1];

            for (var i = 0; i < table.Rows.Count - 1; ++i)
                retVal[i].Next = retVal[i + 1];

            for (var i = 0; i < table.Rows.Count; ++i)
            {
                retVal[i].First = retVal[0];
                retVal[i].Last = retVal[table.Rows.Count - 1];
            }

            return retVal.ToList();
        }
    }
}
