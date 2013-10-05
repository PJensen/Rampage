using System;
using System.Data;
using System.IO;
using System.Net;
using Rampage.Core.Interfaces;
using Rampage.Core.Util;

namespace Rampage.Core
{
    /// <summary>
    /// YahooDataRetriever
    /// </summary>
    public class YahooDataRetriever : IMarketDataRetriever
    {
        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public DataTable Retrieve(string symbol, out string message, out bool fail)
        {
            if (symbol == null) throw new ArgumentNullException("symbol");

            fail = false;
            message = "Ok";

            var dataFileDest = Path.Combine(Properties.Settings.Default.WorkingDirectory, symbol);

            if (!File.Exists(dataFileDest))
            {
                using (var webClient = new WebClient())
                {
                    try
                    {
                        webClient.DownloadFile(string.Format(@"http://ichart.finance.yahoo.com/table.csv?s={0}&d=3&e=17&f=2013&g=d&a=0&b=29&c=1993&ignore=.csv", symbol), dataFileDest);
                    }
                    catch (Exception ex)
                    {
                        message = ex.Message;
                        fail = true;
                    }
                }
            }

            return fail ? default(DataTable) : CSVParser.Parse(File.OpenText(dataFileDest), true);
        }
    }
}
