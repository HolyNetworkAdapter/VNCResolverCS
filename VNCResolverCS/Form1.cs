using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNCResolverCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newVNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VNCDetails vd = new VNCDetails();
            vd.MdiParent = this;
            vd.Show();
        }
    }
}
