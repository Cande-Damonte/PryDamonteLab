using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryDamonteLab
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmABM v5 = new FrmABM();
            v5.Show();

        }

        private void agregarArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMostrar v4 = new FrmMostrar();
            v4.Show();
        }
    }
}
