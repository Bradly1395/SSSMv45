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
    public partial class EditarTipoTrabajo : Form
    {
        public EditarTipoTrabajo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parametros par = new Parametros();
            par.Show();
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) == false && string.IsNullOrWhiteSpace(precio.Text) == false)
            {
                string query = "update TipoTrabajo set Descripcion= '" + nom.Text + "', Precio = '" + precio.Text + "' where IDTipo = " + int.Parse(id.Text) + "";
                Mantenimiento.actualizar(query);
                this.Hide();
                Parametros cliente = new Parametros();
                cliente.Show();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }
    }
}
