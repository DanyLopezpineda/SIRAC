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
    internal class Datos
    {
        SqlConnection DBSIRAC = new SqlConnection("Data Source=DESKTOP-1HQVKF5;Initial Catalog=DBSIRAC;Integrated Security = True;");
        public SqlDataAdapter DA;
        public DataSet ds = new DataSet();
        public SqlCommand Cmd;

        //------------------------VISTA PARA OBTENER LOS DATOS DE LAS CARRERAS DE LA BASE DE DATOS SIRAC------------------------//
        public DataTable GetCarreras()
        {
            DBSIRAC.Open();
            SqlCommand CMD;
            CMD = new SqlCommand("SELECT * FROM Vw_Carreras", DBSIRAC);
            SqlDataAdapter DA;
            DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS, "TABLA");
            DBSIRAC.Close();
            return DS.Tables["TABLA"];
        }

        //------------------------VISTA PARA OBTENER LOS DATOS DE LOS MAESTROS DE LA TABLA DE CATALOGOS DE MAESTROS------------------------//

        public DataTable GetMaestros_Condicional()
        {
            DBSIRAC.Open();
            SqlCommand CMD;
            CMD = new SqlCommand("SELECT * FROM Vw_Maestros_condicional", DBSIRAC);
            SqlDataAdapter DA;
            DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Tabla");
            DBSIRAC.Close();
            return DS.Tables["Tabla"];
        }

        //------------------------VISTA PARA OBTENER LOS DATOS DE LOS CONCEPTOS DE PAGOS DE LA TABLA DE CATALOGOS------------------------//

        public DataTable GetConceptos_Pagos()
        {
            DBSIRAC.Open();
            SqlCommand CMD;
            CMD = new SqlCommand("SELECT * FROM Vw_Concept_Pagos", DBSIRAC);
            SqlDataAdapter DA;
            DA = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Tabla");
            DBSIRAC.Close();
            return DS.Tables["Tabla"];
        }
    }
}
