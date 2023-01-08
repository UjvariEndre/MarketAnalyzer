using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAnalyzer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.TryAdd("egy", "kettő");
            dict.TryAdd("három", "négy");
            foreach (var i in dict)
            {
                dataGridView1.Rows.Add(i.Key, i.Value);
            }

        }
    }
}
