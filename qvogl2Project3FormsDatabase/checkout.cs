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
    public partial class checkout : Form
    {
        public String sub { get; set; }
        
        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Shown(object sender, EventArgs e)
        {
            Console.WriteLine(sub);
            txtDue.Text = sub;
        }
    }
}
