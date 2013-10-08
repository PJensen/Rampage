using System.Xml.Serialization;

namespace Rampage.Core.DataRetriever
{
    /// <summary>
    /// YahooFlds
    /// </summary>
    public enum YahooFlds
    {
        [XmlEnum(Name = "a")]
        Ask,
        [XmlEnum(Name = "a")]
        AverageDailyVolume,
        [XmlEnum(Name = "a5")]
        AskSize,
        [XmlEnum(Name = "b")]
        Bid,
        [XmlEnum(Name = "b2")]
        AskRealtime,
        [XmlEnum(Name = "b3")]
        BidRealtime,
        [XmlEnum(Name = "b4")]
        BookValue,
        [XmlEnum(Name = "b6")]
        BidSize,
        [XmlEnum(Name = "c")]
        ChangePercentChange,
        [XmlEnum(Name = "c1")]
        Change,
        [XmlEnum(Name = "c3")]
        Commission,
        [XmlEnum(Name = "c6")]
        ChangeRealtime,
        [XmlEnum(Name = "c8")]
        AfterHoursChangeRealtime,
        [XmlEnum(Name = "d")]
        DividendgShare,
        [XmlEnum(Name = "d1")]
        LastTradeDat,
        [XmlEnum(Name = "d2")]
        TradeDate,
        [XmlEnum(Name = "e")]
        EarningsgShare,
        [XmlEnum(Name = "e1")]
        ErrorIndication,
        [XmlEnum(Name = "e7")]
        EPSEstimateCurrentYear,
        [XmlEnum(Name = "e8")]
        EPSEstimateNextYear,
        [XmlEnum(Name = "e9")]
        EPSEstimateNextQuarte,
        [XmlEnum(Name = "f6")]
        FloatShares,
        [XmlEnum(Name = "g")]
        DaysLow,
        [XmlEnum(Name = "h")]
        DaysHig,
        [XmlEnum(Name = "j")]
        Week52Low,
        [XmlEnum(Name = "k")]
        Week52High,
        [XmlEnum(Name = "g1")]
        HoldingsGainPercent,
        [XmlEnum(Name = "g3")]
        AnnualizedGain,
        [XmlEnum(Name = "g4")]
        HoldingsGain,
        [XmlEnum(Name = "g5")]
        HoldingsGainPercentRealtime,
        [XmlEnum(Name = "g6")]
        HoldingsGainRealtime,
        [XmlEnum(Name = "i")]
        MoreInfo,
        [XmlEnum(Name = "i5")]
        OrderBookRealtime,
        [XmlEnum(Name = "j1")]
        MarketCapitalization,
        [XmlEnum(Name = "j3")]
        MarketCapRealtime,
        [XmlEnum(Name = "j4")]
        EBITD,
        [XmlEnum(Name = "j5")]
        ChangeFrom52weekLow,
        [XmlEnum(Name = "j6")]
        PercentChangeFrom52weekLow,
        [XmlEnum(Name = "k1")]
        LastTradeRealtimeWithTime,
        [XmlEnum(Name = "k2")]
        ChangePercentRealtime,
        [XmlEnum(Name = "k3")]
        LastTradeSize,
        [XmlEnum(Name = "k4")]
        ChangeFrom52weekHig,
        [XmlEnum(Name = "k5")]
        PercebtChangeFrom52weekHigh,
        [XmlEnum(Name = "l")]
        LastTradeWithTime,
        [XmlEnum(Name = "l1")]
        LastTradePriceOnly,
        [XmlEnum(Name = "l2")]
        HighLimit,
        [XmlEnum(Name = "l3")]
        LowLimit,
        [XmlEnum(Name = "m")]
        DaysRang,
        [XmlEnum(Name = "m2")]
        DaysRangeRealtime,
        [XmlEnum(Name = "m3")]
        FiftyDayMovingAverage,
        [XmlEnum(Name = "m4")]
        TwoHundredDayMovingAverage,
        [XmlEnum(Name = "m5")]
        ChangeFrom200dayMovingAverage,
        [XmlEnum(Name = "m6")]
        PercentChangeFrom200dayMovingAverage,
        [XmlEnum(Name = "m7")]
        ChangeFrom50dayMovingAverag,
        [XmlEnum(Name = "m8")]
        PercentChangeFrom50dayMovingAverage,
        [XmlEnum(Name = "n")]
        Name,
        [XmlEnum(Name = "n4")]
        Note,
        [XmlEnum(Name = "o")]
        Open,
        [XmlEnum(Name = "p")]
        PreviousClose,
        [XmlEnum(Name = "p1")]
        PricePai,
        [XmlEnum(Name = "p2")]
        ChangeinPercent,
        [XmlEnum(Name = "p5")]
        PricegSales,
        [XmlEnum(Name = "p6")]
        PricegBoo,
        [XmlEnum(Name = "q")]
        ExDividendDate,
        [XmlEnum(Name = "r")]
        PERatio,
        [XmlEnum(Name = "r1")]
        DividendPayDate,
        [XmlEnum(Name = "r2")]
        PERatioRealtime,
        [XmlEnum(Name = "r5")]
        PEGRatio,
        [XmlEnum(Name = "r6")]
        PriceEPSEstimateCurrentYear,
        [XmlEnum(Name = "r7")]
        PriceEPSEstimateNextYear,
        [XmlEnum(Name = "s")]
        Symbol,
        [XmlEnum(Name = "s1")]
        SharesOwned,
        [XmlEnum(Name = "s7")]
        ShortRatio,
        [XmlEnum(Name = "t1")]
        LastTradeTime,
        [XmlEnum(Name = "t6")]
        TradeLink,
        [XmlEnum(Name = "t7")]
        TickerTrend,
        [XmlEnum(Name = "t8")]
        OneyrTargetPrice,
        [XmlEnum(Name = "v")]
        Volum,
        [XmlEnum(Name = "v1")]
        HoldingsValue,
        [XmlEnum(Name = "v7")]
        HoldingsValueRealtime,
        [XmlEnum(Name = "w")]
        Week52Range,
        [XmlEnum(Name = "w1")]
        DaysValueChange,
        [XmlEnum(Name = "w4")]
        DaysValueChangeRealtime,
        [XmlEnum(Name = "x")]
        StockExchange,
    }
}