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
    class Mantenimiento:connect
    {

        public static bool resul = false;
        public bool Buscar(string sql)
        {

            using (SqlConnection cone = Conexion.generarConexion())
            {
                bool resultado = false;
                cone.Open();
                SqlCommand comando = new SqlCommand(sql, cone);

                SqlDataReader reg = (null);
                reg = comando.ExecuteReader();
                if (reg.Read())
                {
                    resultado = true;

                }
                cone.Close();
                resul = resultado;
                return resultado;
            }


        }



        public void llenarCB(ComboBox cb, string x, string y)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand(x, Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect[y].ToString());
                }


                Cone.Close();

            }

        }

        public static string lookerSt(string query)
        {
            string look;
            //float isval;

            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                look = comando.ExecuteScalar().ToString();
                
                cnn.Close();
                
            }

            return look;
        }

        /*---------------------------------------------------*/

        public static string consulta(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select a.TipoUsuario from Usuario as a where a.Usuario=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);


                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        public static string Estado(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select a.Estado from Usuario as a where a.Usuario=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);


                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        public static string userid(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select a.ID  from Usuario as a where a.Usuario=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);


                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        public void cargarClientes(DataGridView dgv)
        {
            

            try
            {
                da = new SqlDataAdapter("select * from Cliente order by Nombre", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void cargarTipo(DataGridView dgv)
        {


            try
            {
                da = new SqlDataAdapter("select * from TipoTrabajo", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void cargarTrabajo(DataGridView dgv, int user)
        {
            try
            {
                da = new SqlDataAdapter(@"select top 100 a.IDTrabajo, c.Descripcion as TipoTrabajo, a.Descripcion, a.Valor, 
                                          d.Nombre as Usuario, b.Nombre as Cliente, a.FechaEntrada, a.FechaSalida, a.Estado 
                                          from Trabajo as a inner join Cliente as b on a.Cliente = b.IDCliente 
                                          inner join TipoTrabajo as c on a.TipoTrabajo = c.IDTipo 
                                          inner join Usuario as d on a.Usuario = d.ID where d.ID = "+user+"  and a.Estado = 'Activo' order by a.Estado, a.FechaEntrada", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void cargarEncargo(DataGridView dgv, int user)
        {
            try
            {
                da = new SqlDataAdapter(@"select a.IDEncargo, c.Descripcion, a.Observacion, a.Valor, b.Nombre, a.NombreCliente as Cliente, a.NumeroDeTelefono,
                                        a.FechaEntrada, a.FechaSalida, a.Estado
                                        from Encargo as a
                                        inner join Usuario as b on a.Encargado = b.ID
                                        inner join TipoTrabajo as c on a.TipoTrabajo = c.IDTipo
                                        where a.Encargado = " + user + " and a.Estado = 'Activo' order by a.Estado, a.FechaEntrada", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        /*----------------Creacion general-----------------------------------*/
        public static void insertar(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                comando.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Ingresado!");
            }
        }
        /*---------------------------------------------------*/
        public static void actualizar(string query)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Modificacion realizada!");
            }
        }

        public static int returnInt(string query)
        {
            int resultado;
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cone.Close();

            }

            return resultado;
        }

    }
}
