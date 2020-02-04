using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qvogl2Project3FormsDatabase
{
    public partial class frmSize : Form
    {
        public String itemSize { get; set; }

        public frmSize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemSize = "SML";
            Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            itemSize = "MED";
            Close();
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            itemSize = "LRG";
            Close();
        }
    }
}
