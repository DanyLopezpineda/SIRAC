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
            dataGridView1.DataSource = cn.GetConceptos_Pagos();
            BQBOTONES();
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
            string monto = txtmontop.Text;
            string montos = txtmontos.Text;
            if(Conceptos == "")
            {
                MessageBox.Show("POR FAVOR INGRESAR LOS DATOS OBLIGADOS", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string Save = "exec USP_SAVE_CATLOG_PAGOS '" + Conceptos + "','" + monto + "','" + montos + "'";
                if (i.INSERT(Save))
                {
                    MessageBox.Show("REGISTRO INGRESADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = cn.GetConceptos_Pagos();
                    txtcodigo.Text = "";
                    txtconcepto.Text = "";
                    txtmontop.Text = "";
                    txtmontos.Text = "";
                    txtconcepto.Focus();
                    BQBOTONES();
                }
                else
                {
                    MessageBox.Show("NO SE INGRESARON LOS DATOS CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void BQBOTONES()
        {
            string Codigo = txtcodigo.Text;

            if(Codigo != "")
            {
                btnguardar.Enabled = false;
                btneditar.Enabled = true;
                btnactualizar.Enabled = false;
                btnnuevo.Enabled = true;
                btneliminar.Enabled = true;
                txtconcepto.Enabled = false;
                txtmontop.Enabled = false;
                txtmontos.Enabled = false;
            }
            else
            {
                btnguardar.Enabled = true;
                btneditar.Enabled = false;
                btnactualizar.Enabled = false;
                btnnuevo.Enabled = false;
                btneliminar.Enabled = false;
                txtconcepto.Enabled = true;
                txtmontop.Enabled = true;
                txtmontos.Enabled = true;
                txtconcepto.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow indices = dataGridView1.CurrentRow;
            txtcodigo.Text = indices.Cells["IdPago"].Value.ToString();
            txtconcepto.Text = indices.Cells["Concepto"].Value.ToString();
            txtmontop.Text = indices.Cells["MontoInicial"].Value.ToString();
            txtmontos.Text = indices.Cells["MontoSecundario"].Value.ToString();
            BQBOTONES();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtconcepto.Enabled = true;
            txtmontop.Enabled = true;
            txtmontos.Enabled = true;
            txtconcepto.Focus();
            btnactualizar.Enabled=true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string Codigo = txtcodigo.Text;
            int Accion = 1;
            string Deshabilitar = "exec USP_UPDATE_CATLOG_CPAGOS '" + txtconcepto.Text + "'," + txtmontop.Text + "," + txtmontos.Text + "," + Accion + ", '" + txtcodigo.Text + "'";
            if (Codigo == "")
            {
                MessageBox.Show("No se encuentra el registro", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var res = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    if (i.INSERT(Deshabilitar))
                    {
                        MessageBox.Show("REGISTRO DESHABILITADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = cn.GetConceptos_Pagos();
                        txtcodigo.Text = "";
                        txtconcepto.Text = "";
                        txtmontop.Text = "";
                        txtmontos.Text = "";
                        txtconcepto.Focus();
                        BQBOTONES();
                    }
                    else
                    {
                        MessageBox.Show("Error", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (res == DialogResult.No)
                {

                }
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.GetConceptos_Pagos();
            txtcodigo.Text = "";
            txtconcepto.Text = "";
            txtmontop.Text = "";
            txtmontos.Text = "";
            txtconcepto.Focus();
            BQBOTONES();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string Codigo = txtcodigo.Text;
            int Accion = 2;
            string Actualizar = "exec USP_UPDATE_CATLOG_CPAGOS '" + txtconcepto.Text + "'," + txtmontop.Text + "," + txtmontos.Text + "," + Accion + ", '" + txtcodigo.Text + "'";
            if(Codigo == "")
            {
                MessageBox.Show("No se encuentra el registro", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(i.INSERT(Actualizar))
                {
                    MessageBox.Show("REGISTRO ACTUALIZADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = cn.GetConceptos_Pagos();
                    txtcodigo.Text = "";
                    txtconcepto.Text = "";
                    txtmontop.Text = "";
                    txtmontos.Text = "";
                    txtconcepto.Focus();
                    BQBOTONES();
                }
                else
                {
                    MessageBox.Show("Error", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
        }
    }
}
