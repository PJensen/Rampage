using System.Collections.Generic;

namespace Rampage.Core.Delegates
{
    /// <summary>
    /// MarketDataSelector
    /// </summary>
    /// <param name="marketTicks">The market ticks to select from</param>
    /// <returns>A list of market data ticks</returns>
    public delegate IEnumerable<MarketTick> MarketDataSelector(IEnumerable<MarketTick> marketTicks);
}
