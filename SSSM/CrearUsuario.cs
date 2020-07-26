using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) == true || string.IsNullOrWhiteSpace(cbPuesto.Text) == true || string.IsNullOrWhiteSpace(user.Text) == true || string.IsNullOrWhiteSpace(clave.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }

            else
            {

                string Query = "select *from Usuario where Usuario= '" + user.Text + "'";

                //llama la funcion buscar 
                //copia el texto de las cajas de texto y lo compara en la base de datos para asegurarase de que
                //no existe
                Mantenimiento cl = new Mantenimiento();
                if (cl.Buscar(Query) == true)
                {
                    MessageBox.Show("Usuario ya existe");
                }

                else
                {
                    //encripta contraseña
                    users us = new users();
                    string login_pass = clave.Text;
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                    byte[] hash = md5.ComputeHash(inputBytes);
                    login_pass = BitConverter.ToString(hash).Replace("-", "");

                    string cadenasql = "insert  into Usuario values ('" + nom.Text + "',  '" + user.Text + "', '" + login_pass + "', '" + cbPuesto.Text + "', 'CambiarClave');";
                    users.insertarUser(cadenasql);

                    nom.Clear();
                    clave.Clear();
                    user.Clear();

                    this.Hide();
                    Usuarios user1 = new Usuarios();
                    user1.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios user1 = new Usuarios();
            user1.Show();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            cbPuesto.Items.Add("Usuario");
            cbPuesto.Items.Add("Administrador");
            cbPuesto.SelectedIndex = 0;

        }
    }
}
