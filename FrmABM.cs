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
    public partial class FrmABM : Form
    {
        public FrmABM()
        {
            InitializeComponent();
        }

        ClassGrillaProv x = new ClassGrillaProv();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            x.GuardarDatos
        }
    }
}
