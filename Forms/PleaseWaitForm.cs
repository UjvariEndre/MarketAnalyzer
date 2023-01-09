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
    public partial class PleaseWaitForm : Form
    {
        public PleaseWaitForm()
        {
            InitializeComponent();
        }

        private async void PleaseWaitForm_Load(object sender, EventArgs e)
        {
            await Analysis.GetCandleSticks();
            Close();
        }
    }
}
