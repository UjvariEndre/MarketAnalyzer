using System.Collections.Generic;

namespace MarketAnalyzer
{
    class Coin
    {
        public string Ticker { get; set; }
        public decimal LastPrice { get; set; }
        public decimal HV30 { get; set; }
        public List<Ohlc> Candlesticks { get; set; }
    }
}
