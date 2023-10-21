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
    internal class Insercion
    {
        SqlConnection DBSIRAC = new SqlConnection("Data Source=DESKTOP-1HQVKF5;Initial Catalog=DBSIRAC;Integrated Security = True;");
        public SqlDataAdapter DA;
        public DataSet ds = new DataSet();
        public SqlCommand Cmd;

        //------------------------PROCEDIMIENTO PARA INSERTAR DATOS------------------------//
        public bool INSERT(string SQL)
        {
            DBSIRAC.Open();
            Cmd = new SqlCommand(SQL, DBSIRAC);
            int i = Cmd.ExecuteNonQuery();
            DBSIRAC.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
