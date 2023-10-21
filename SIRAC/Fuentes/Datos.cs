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

        //------------------------PROCEDIMIENTO PARA INSERTAR DATOS------------------------//
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
    }
}
