using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Binance.Net;
using MarketAnalyzer.Forms;

namespace MarketAnalyzer
{
    class Globals
    {
        private static readonly string[] apiData;
        public static Globals Instance { get; set; }
        public BinanceClient RestfulClient { get; private set; }
        public BinanceSocketClient SocketClient { get; private set; }
        public CryptoExchange.Net.Objects.WebCallResult<Binance.Net.Objects.Spot.SpotData.BinanceAccountInfo> SpotInfo { get; set; }
        public Dictionary<string, Coin> Top200MarketCap { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }

        static Globals()
        {
            Instance = new Globals();
            apiData = DotEnv.Load(".env");
        }

        public async Task StartUp()
        {
            FileName = "COIN_LIST";
            FilePath = $"../../../worksheets/{FileName}.xlsx";
            DoExcel.ReadExcel(FilePath);

            RestfulClient = new BinanceClient(new Binance.Net.Objects.BinanceClientOptions()
            {
                // Specify options for the client
                ApiCredentials = new CryptoExchange.Net.Authentication.ApiCredentials(apiData[0], apiData[1]),
                AutoTimestamp = true,
                TradeRulesBehaviour = Binance.Net.Enums.TradeRulesBehaviour.AutoComply
            });

            SocketClient = new BinanceSocketClient(new Binance.Net.Objects.BinanceSocketClientOptions()
            {
                // Specify options for the client
                ApiCredentials = new CryptoExchange.Net.Authentication.ApiCredentials(apiData[0], apiData[1]),
                AutoReconnect = true
            });
            try
            {
                SpotInfo = Instance.RestfulClient.General.GetAccountInfoAsync().GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // ide please wait
            Application.Run(new PleaseWaitForm());
        }
    }
}
