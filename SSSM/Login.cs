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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string login_usuario;
        private void EntrarB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usuariotxt.Text) == true || string.IsNullOrWhiteSpace(passwordtxt.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                //desencripta las contraseñas en la base de datos 
                users u = new users();
                string login_pass = passwordtxt.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");
                login_usuario = passwordtxt.Text;
                u.Usuario = this.usuariotxt.Text;
                u.Contraseña = login_pass;

                if (u.Buscar() == true)
                {
                    string adm;
                    string est;
                    string idus;

                    puesto.Text = Mantenimiento.consulta(usuariotxt.Text).ToString();

                    //Cheque estado
                    estado.Text = Mantenimiento.Estado(usuariotxt.Text).ToString();

                    //Copia Id
                    id.Text = Mantenimiento.userid(usuariotxt.Text).ToString();

                    adm = puesto.Text;
                    est = estado.Text;
                    idus = id.Text;

                    switch (est)
                    {
                        case "Activo":
                            PantallaPrincipal menuf = new PantallaPrincipal();
                            var txt6 = menuf.Controls["puesto"];
                            var txt7 = menuf.Controls["iduser"];
                            txt7.Text = id.Text.ToString();
                            txt6.Text = puesto.Text.ToString();
                            menuf.Show();
                            this.Hide();
                            break;
                        case "Inactivo":
                            MessageBox.Show(u.mensaje, "Usuario Inactivo");
                            break;
                        case "CambiarClave":
                            CambiarClave clave = new CambiarClave();
                            var txt8 = clave.Controls["iduser"];
                            txt8.Text = id.Text.ToString();
                            clave.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(u.mensaje, "Ingreso Incorrecto");
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EntrarB_Click(this, new EventArgs());
            }
        }
    }
}
