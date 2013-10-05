using System.Data;

namespace Rampage.Core.Interfaces
{
    /// <summary>
    /// IMarketDataRetriever
    /// </summary>
    public interface IMarketDataRetriever
    {
        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        DataTable Retrieve(string symbol, out string message, out bool fail);
    }
}