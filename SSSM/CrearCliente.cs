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
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) == false && string.IsNullOrWhiteSpace(idcliente.Text) == false && string.IsNullOrWhiteSpace(telefono.Text) == false)
            {
                string cadenasql = "insert  into Cliente values ('" + nom.Text + "','" + idcliente.Text + "','"+ telefono.Text+"');";
                Mantenimiento.insertar(cadenasql);
                
                Clientes form = new Clientes();
                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes cliente = new Clientes();
            cliente.Show();
        }
    }
}
