using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    class users:connect
    {
        private string usuario;
        private string contraseña;

        public users()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;


        }

        //crea funciones de usuario y contraseña para almacenarlas en un espacio primero las lee y despues 
        //las ecribe esto se hace para que en el proceso pueda hacer validaciones
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }

        }
        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }

        }

        //busca en la base de datos que el usuario y contraseña sean validos y compatibles
        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select a.ID from USUARIO as a where a.Usuario='{0}' AND a.Clave='{1}' ", this.usuario, this.contraseña);

            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                Resultado = true;
                this.mensaje = "INGRESO CORRECTO";

            }
            else
            {
                this.mensaje = "Usuario o Contraseña incorrecto";
            }
            this.cnn.Close();
            return Resultado;

        }

        public bool BuscarUser()
        {
            bool Resultado = false;
            this.sql = string.Format(@"select a.ID from USUARIO as a where a.USUARIO='{0}'", this.usuario);

            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                Resultado = true;


            }

            this.cnn.Close();
            return Resultado;

        }

        public void cargarUsers(DataGridView dgv)
        {


            try
            {
                da = new SqlDataAdapter("select ID, Nombre, Usuario, TipoUsuario as Puesto, Estado from Usuario", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }


        public static void insertarUser(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comandosql = new SqlCommand(query, cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Usuario ingresado!");
            }
        }

        public string edit(int id, string nom, string user, string clave, string est, string puesto)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update USUARIO set Nombre = '" + nom + "', Usuario = '" + user + "', Clave= '" + clave + "', TipoUsuario = '" + puesto + "', Estado = '" + est + "' where ID = " + id + " ", cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }


        public string Cambiarcontra(string clave, int id)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update USUARIO set  CLAVE= '" + clave + "', Estado = 'Activo' where ID = " + id + " ", cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }
    }
}
