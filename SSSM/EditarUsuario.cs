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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios user1 = new Usuarios();
            user1.Show();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            cbPuesto.Items.Add("Usuario");
            cbPuesto.Items.Add("Administrador");
            cbPuesto.SelectedIndex = 0;

            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");
            cbEstado.Items.Add("CambiarClave");
            cbEstado.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            users us = new users();
            Conexion cone = new Conexion();
            

            if (string.IsNullOrWhiteSpace(nom.Text) == true ||string.IsNullOrWhiteSpace(user.Text) == true || string.IsNullOrWhiteSpace(clave.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }

            else
            {
                //encriptacion contraseña
                string login_pass = clave.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

                
                MessageBox.Show(us.edit((Convert.ToInt32(id.Text)), nom.Text, user.Text, login_pass, cbEstado.Text, cbPuesto.Text));
                

                this.Hide();
                Usuarios user1 = new Usuarios();
                user1.Show();

            }
        }
    }
}
