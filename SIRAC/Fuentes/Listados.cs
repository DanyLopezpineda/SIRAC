using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIRAC.Fuentes
{
    internal class Listados
    {
        SqlConnection DBSIRAC = new SqlConnection("Data Source=DESKTOP-1HQVKF5;Initial Catalog=DBSIRAC;Integrated Security = True;");

        public void ListTTitulacion(ComboBox cbox)
        {
            DBSIRAC.Open();
            SqlCommand CMD;
            CMD = new SqlCommand("Select * from TblCatTitulacion WHERE Vigencia = 1", DBSIRAC);
            SqlDataAdapter da;
            da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBSIRAC.Close();

            DataRow Fila = dt.NewRow();
            Fila["TipoTitulacion"] = " --- SELECCIONE ---";
            dt.Rows.InsertAt(Fila, 0);

            cbox.ValueMember = "IdTitulacion";
            cbox.DisplayMember = "TipoTitulacion";
            cbox.DataSource = dt;
        }

        public void ListPrivilegios(ComboBox cbox)
        {
            DBSIRAC.Open();
            SqlCommand CMD;
            CMD = new SqlCommand("Select * from TblCatPrivilegio WHERE Vigencia = 1", DBSIRAC);
            SqlDataAdapter da;
            da = new SqlDataAdapter(CMD);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DBSIRAC.Close();

            DataRow Fila = dt.NewRow();
            Fila["Privilegio"] = " --- SELECCIONE ---";
            dt.Rows.InsertAt(Fila, 0);

            cbox.ValueMember = "IdPrivilegio";
            cbox.DisplayMember = "Privilegio";
            cbox.DataSource = dt;
        }
    }
}
