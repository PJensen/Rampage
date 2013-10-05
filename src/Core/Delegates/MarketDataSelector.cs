using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rampage.Core.Delegates
{
    /// <summary>
    /// MarketDataSelector
    /// </summary>
    /// <param name="marketTicks">The market ticks to select from</param>
    /// <param name="predicate">The predicate to use for selecting</param>
    /// <returns>A list of market data ticks</returns>
    public delegate IEnumerable<MarketTick> MarketDataSelector(IEnumerable<MarketTick> marketTicks);
}
