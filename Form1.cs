using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryDamonteLab
{
    public partial class FrmBroker : Form
    {
        public FrmBroker()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            LblPorcentaje.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();

                FrmIngresar FrmIngresar = new FrmIngresar();
                FrmIngresar.Show();

                this.Close();

            }
        }
    }
}
