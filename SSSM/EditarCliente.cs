using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) == false && string.IsNullOrWhiteSpace(idcliente.Text) == false && string.IsNullOrWhiteSpace(telefono.Text) == false)
            {
                string query = "update Cliente set Nombre= '" + nom.Text + "', Identidad = '" + idcliente.Text + "', Telefono = '" + telefono.Text + "' where IDCliente = " + int.Parse(id.Text) + "";
                Mantenimiento.actualizar(query);
                this.Hide();
                Clientes cliente = new Clientes();
                cliente.Show();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void idcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }
    }
}
