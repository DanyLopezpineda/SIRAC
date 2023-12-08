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
            dataGridView1.DataSource = d.GetCarreras();
            BQBOTONES();
        }

        Fuentes.Listados list = new Fuentes.Listados();
        Fuentes.Datos d = new Fuentes.Datos();
        Fuentes.Insercion s = new Fuentes.Insercion();

        private void CatalogosCarreras_Load(object sender, EventArgs e)
        {

        }

        public void BQBOTONES()
        {
            string Codigo = txtcodigo.Text;

            if(Codigo != "")
            {
                btnguardar.Enabled = false;
                btnactualizar.Enabled = false;
                btneliminar.Enabled = true;
                btnnuevo.Enabled = true;
                btneditar.Enabled = true;
                txtcarrera.Enabled = false;
                cboxtipotitulacion.Enabled = false;
            }
            else
            {
                btnguardar.Enabled = true;
                btnactualizar.Enabled = false;
                btneliminar.Enabled = false;
                btnnuevo.Enabled = false;
                btneditar.Enabled = false;
                txtcarrera.Enabled = true;
                cboxtipotitulacion.Enabled = true;
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string Carrera = txtcarrera.Text;
            string titulo = cboxtipotitulacion.Text;

            if(Carrera == "" && titulo == "")
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
                    dataGridView1.DataSource = d.GetCarreras();
                }
                else
                {
                    MessageBox.Show("Error", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow indices = dataGridView1.CurrentRow;
            txtcodigo.Text = indices.Cells["IdCarrera"].Value.ToString();
            txtcarrera.Text = indices.Cells["Carrera"].Value.ToString();
            BQBOTONES();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string Deshabilitar = "exec USP_UPDATE_CATLOG_CARRERAS '" + txtcodigo.Text + "', '" + txtcarrera.Text + "' , '" + 0 + "', '" + cboxtipotitulacion.SelectedIndex + "', '" + 1 + "'";
            if(txtcodigo.Text == "")
            {
                MessageBox.Show("No se encuentra el registro", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var res = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if(res == DialogResult.Yes)
                {
                    if (s.INSERT(Deshabilitar))
                    {
                        MessageBox.Show("REGISTRO DESHABILITADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = d.GetCarreras();
                    }
                    else
                    {
                        MessageBox.Show("Error", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if(res == DialogResult.No)
                {

                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string Actualizar = "exec USP_UPDATE_CATLOG_CARRERAS '" + txtcodigo.Text + "', '" + txtcarrera.Text + "' , '" + 1 + "', '" + cboxtipotitulacion.SelectedIndex + "', '" + 2 + "'";
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("No se encuentra el registro", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var res = MessageBox.Show("¿Esta seguro que desea Actualizar el registro?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                {
                    if (s.INSERT(Actualizar))
                    {
                        MessageBox.Show("REGISTRO ACTUALIZADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = d.GetCarreras();
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
            txtcodigo.Text = "";
            txtcarrera.Text = "";
            cboxtipotitulacion.Text = "";
            BQBOTONES();
            txtcarrera.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtcarrera.Enabled = true;
            cboxtipotitulacion.Enabled = true;

            btnactualizar.Enabled = true;
            btneditar.Enabled = false;
        }
    }
}
