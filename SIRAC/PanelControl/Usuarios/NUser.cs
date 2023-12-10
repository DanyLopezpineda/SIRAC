using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIRAC.PanelControl.Usuarios
{
    public partial class NUser : Form
    {
        public NUser()
        {
            InitializeComponent();
            BQBOTONES();
        }

        Fuentes.Listados l = new Fuentes.Listados();

        Fuentes.Insercion i = new Fuentes.Insercion();

        public void BQBOTONES()
        {
            string Codigo = txtcodigo.Text;
            if(Codigo != "")
            {
                txtpnombre.Enabled = false;
                txtsnombre.Enabled = false;
                txtpapellido.Enabled = false;
                txtsapellido.Enabled = false;
                txtuser.Enabled = false;
                txtpassw.Enabled = false;
                cboxrol.Enabled = false;
                btnguardar.Enabled = false;
                btnactualizar.Enabled = false;
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
                btnnuevo.Enabled= true;
            }
            else
            {
                txtpnombre.Enabled = true;
                txtsnombre.Enabled = true;
                txtpapellido.Enabled = true;
                txtsapellido.Enabled = true;
                txtuser.Enabled = true;
                txtpassw.Enabled = true;
                cboxrol.Enabled = true;
                btnguardar.Enabled = true;
                btnactualizar.Enabled = false;
                btneditar.Enabled = false;
                btneliminar.Enabled = false;
                btnnuevo.Enabled = false;
                txtpnombre.Focus();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
