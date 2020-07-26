using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSM
{
    class connect
    {
        public string cadenaconexion = (Properties.Settings.Default.SSSMConnectionString);
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;



        public connect()
        {
            
            this.cnn = new SqlConnection(this.cadenaconexion);


        }

        public string Mensaje
        {
            get { return this.mensaje; }


        }
    }
}
