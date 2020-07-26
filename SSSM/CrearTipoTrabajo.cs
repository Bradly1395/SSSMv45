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
    public partial class CrearTipoTrabajo : Form
    {
        public CrearTipoTrabajo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parametros par = new Parametros();
            par.Show();
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom.Text) == false|| string.IsNullOrWhiteSpace(precio.Text) == false)
            {
                string cadenasql = "insert  into TipoTrabajo values ('" + nom.Text + "','" + precio.Text + "');";
                Mantenimiento.insertar(cadenasql);

                Parametros form = new Parametros();
                form.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");


            }
        }
    }
}
