using IronXL;
using System;
using System.Collections.Generic;
using System.IO;

namespace MarketAnalyzer
{
    class DoExcel
    {
        public static void ReadExcel(string fileName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            WorkSheet sheet = workbook.DefaultWorkSheet;
            Dictionary<string, Coin> top200 = new Dictionary<string, Coin>();
            foreach (var c in sheet.ToArray())
            {
                if (c.StringValue == "")
                    continue;
                Coin coin = new Coin()
                {
                    Ticker = c.StringValue,
                };
                top200.TryAdd(c.StringValue, coin);
            }
            Globals.Instance.Top200MarketCap = top200;
        }

        public static void WriteExcel()
        {
            DateTime now = DateTime.Now;
            string fileName = $"{now.Year}-{now.Month.ToString("D2")}-{now.Day.ToString("D2")}-{now.Hour}-{now.Minute}-{now.Second}.xlsx";
            string filePath = $"../../../worksheets/{fileName}.xlsx";

            WorkBook wb = WorkBook.Create();
            WorkSheet sheet = wb.CreateWorkSheet(fileName);
            //WorkBook workbook = WorkBook.Load(filePath);
            //WorkSheet sheet = wb.DefaultWorkSheet;

            int j = 0;
            foreach (var i in Globals.Instance.Top200MarketCap)
            {
                j++;
                sheet[$"A{j}"].Value = i.Value.Ticker;
                sheet[$"B{j}"].DoubleValue = Convert.ToDouble(Math.Round(i.Value.HV30, 2));
            }
            wb.SaveAs($@"{Directory.GetCurrentDirectory()}\{fileName}");
        }
    }
}
