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
    public partial class CatalogosMaestros : Form
    {
        public CatalogosMaestros()
        {
            InitializeComponent();

            dataGridView1.DataSource = cn.GetMaestros_Condicional();
        }

        Fuentes.Datos cn = new Fuentes.Datos(); //conexion a la vista del tabla del catalogo de maestros

        Fuentes.Insercion i = new Fuentes.Insercion(); //conexion al procedimiento de guardado de los datos

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string N1 = txtpnombre.Text;
            string A1 = txtpapellido.Text;
            
            if(N1 == "" && A1 == "")
            {
                MessageBox.Show("POR FAVOR INGRESAR LOS DATOS OBLIGADOS", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string Datos = "exec USP_SAVE_CATLOG_MAESTROS '" + txtpnombre.Text + "','" + txtsnombre.Text + "','" + txtpapellido.Text + "','" + txtsapellido.Text + "','" + 1 + "','" + txtcelular.Text + "','" + txtcarrera.Text + "','" + txtdireccion.Text + "','" + 1 + "'";
                if (i.INSERT(Datos))
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow indices = dataGridView1.CurrentRow;
            txtcodigo.Text = indices.Cells["Id_Maestros"].Value.ToString();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;

            if(codigo == "")
            {
                MessageBox.Show("NO SE ENCONTRO EL MAESTRO QUE DESEA ELIMINAR", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string Desh = "exec USP_UPDATE_CATLOG_MAESTROS '" + txtpnombre.Text + "','" + txtsnombre.Text + "','" + txtpapellido.Text + "','" + txtsapellido.Text + "','" + 1 + "','" + txtcarrera.Text + "', '" + codigo + "'";
                if(i.INSERT(Desh))
                {
                    MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
