using System.Data;
using Rampage.Core.Interfaces;

namespace Rampage.Core.DataRetriever
{
    /// <summary>
    /// YahooRealtimeRetriever
    /// </summary>
    class YahooRealtimeRetriever : IMarketDataRetriever
    {
        #region Implementation of IMarketDataRetriever

        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public DataTable Retrieve(string symbol, out string message, out bool fail)
        {
            message = null;
            fail = false;

            return new DataTable();
        }

        #endregion
    }
}
