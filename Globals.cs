using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAnalyzer
{
    class Globals
    {
        private static readonly string[] apiData;
        public static Globals Instance { get; set; }

        static Globals()
        {
            Instance = new Globals();
            apiData = DotEnv.Load(".env");
        }

        public async Task StartUp()
        {
            
        }
    }
}
