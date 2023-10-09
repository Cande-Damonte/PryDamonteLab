using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PryDamonteLab
{
    public partial class FrmGrilla : Form
    {
        public FrmGrilla()
        {
            InitializeComponent();
        }

        public string ArchivoProveedores = @"../../Resources/Proveedores/datosProveedor.csv";
        ClassGrillaProv x = new ClassGrillaProv();

        private void FrmGrilla_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerGrilla_Click(object sender, EventArgs e)
        {
            x.MostrarDatos(DgvProveedores);

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmABM v5 = new FrmABM();
            v5.Show(); 


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int n = DgvProveedores.CurrentCell.RowIndex;

            if (n != -1)
            {
                //ID es el número de la celda 0 de la fila seleccionada 
                string ID = Convert.ToString(DgvProveedores.Rows[n].Cells[0].Value);

                //Es una lista que funciona igual que un vector pero tiene métodos propios
                List<string> lineasArchivo = new List<string>();

                using (StreamReader reader = new StreamReader(ArchivoProveedores))
                {

                    // Lee el resto de las líneas
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Procesa la línea actual aquí y separo los campos con ";"
                        string[] parametros = linea.Split(';');
                        //Copia todas las lineas que no coincide con el ID para sobreescribir el archivo sin la linea que quiero borrar
                        if (parametros[0] != ID)
                        {
                            lineasArchivo.Add(linea);
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(ArchivoProveedores))
                {
                    foreach (string elemento in lineasArchivo)
                    {
                        // Escribe cada elemento en una línea del archivo, el elemento contiene la línea guardada en el índice momentáneo de la lista
                        writer.WriteLine(elemento);
                    }
                }

                MessageBox.Show("El registro fue eliminado correctamente.");

                DgvProveedores.Rows.RemoveAt(n);
            }
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Posiciono la fila que deseo borrar
            //posicion = DgvProveedores.CurrentRow.Index;
        }

    }
}
