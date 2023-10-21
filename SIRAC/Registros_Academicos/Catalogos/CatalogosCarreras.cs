using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIRAC.Registros_Academicos.Catalogos
{
    public partial class CatalogosCarreras : Form
    {
        public CatalogosCarreras()
        {
            InitializeComponent();

            list.ListTTitulacion(cboxtipotitulacion);
        }

        Fuentes.Listados list = new Fuentes.Listados();
        Fuentes.Datos s = new Fuentes.Datos();

        private void CatalogosCarreras_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string Carrera = txtcarrera.Text;
            int titulo = cboxtipotitulacion.SelectedIndex;

            if(Carrera == "" && titulo == 0)
            {
                MessageBox.Show("COMPLETAR LOS CAMPOS OBLIGATORIOS", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcarrera.Focus();
            }
            else
            {
                string Guardar = "exec USP_SAVE_CATLOG_CARRERAS '" + txtcarrera.Text + "','" + cboxtipotitulacion.SelectedIndex + "'";
                if (s.INSERT(Guardar))
                {
                    MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
