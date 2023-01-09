using System;
using System.Data;
using System.Linq;
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
            foreach(var i in Globals.Instance.Top200MarketCap.OrderByDescending(y => y.Value.HV30))
            {
                dataGridView1.Rows.Add(i.Key, Math.Round(i.Value.HV30, 2));
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            DoExcel.WriteExcel();
        }
    }
}
