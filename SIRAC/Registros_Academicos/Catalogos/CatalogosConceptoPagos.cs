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
    public partial class CatalogosConceptoPagos : Form
    {
        public CatalogosConceptoPagos()
        {
            InitializeComponent();
        }
        Fuentes.Datos cn = new Fuentes.Datos(); //conexion a la vista del tabla del catalogo de conceptos de pagos

        Fuentes.Insercion i = new Fuentes.Insercion(); //conexion al procedimiento de guardado de los datos

        private void txtmontop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmontos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string Conceptos = txtconcepto.Text;
            int monto = Convert.ToInt32(txtmontop.Text);
            int montos = Convert.ToInt32(txtmontos.Text);
            if(Conceptos == "" && monto == 0 && montos == 0)
            {
                MessageBox.Show("POR FAVOR INGRESAR LOS DATOS OBLIGADOS", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string Save = "exec USP_SAVE_CATLOG_PAGOS '" + Conceptos + "','" + monto + "','" + montos + "'";
                if (i.INSERT(Save))
                {
                    MessageBox.Show("REGISTRO INGRESADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = cn.GetMaestros_Condicional();
                }
                else
                {
                    MessageBox.Show("NO SE INGRESARON LOS DATOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
