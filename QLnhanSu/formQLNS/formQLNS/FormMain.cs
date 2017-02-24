using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formQLNS
{
    public partial class frmQLNS : Form
    {
       
        public frmQLNS()
        {
            InitializeComponent();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmQLNS fr = new frmQLNS();
            fr.ShowDialog();
        }
    }
}
