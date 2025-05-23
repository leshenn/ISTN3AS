using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class frmPOS: Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Stock' table. You can move, or remove it, as needed.
            this.taStock.Fill(this.wstGrp11DS.Stock);

        }
    }
}
