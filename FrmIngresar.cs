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
    public partial class FrmIngresar : Form
    {
        public FrmIngresar()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Int32 Intentos = 0;
            if (TxtUsuario.Text == "Administrador" && TxtContraseña.Text == "Administrador")
            {
                this.Hide();
                FrmMain FrmMain = new FrmMain();
                FrmMain.Show();

            }
            else 
            {
                MessageBox.Show("Datos incorrectos.");
                Intentos++;

                if (Intentos== 3)
                {
                    this.Close();

                }
            }
        }
    }
}
