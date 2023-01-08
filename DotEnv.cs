using System.IO;
using System.Windows.Forms;
using MarketAnalyzer.Forms;

namespace MarketAnalyzer
{
    public static class DotEnv
    {
        public static string[] Load(string fileName)
        {
            if (!File.Exists(fileName)){
                var myFile = File.Create(fileName);
                myFile.Close();
                Application.Run(new ApiForm());
            }

            string[] apiData = File.ReadAllLines(fileName);

            return apiData;
        }

        public static void Save(string fileName, string[] apiData)
        {
            File.WriteAllLines(fileName, apiData);
        }
    }
}
