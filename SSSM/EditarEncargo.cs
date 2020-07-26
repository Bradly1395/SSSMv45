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
    public partial class EditarEncargo : Form
    {
        private PantallaPrincipal frm1;
        public EditarEncargo(PantallaPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void EditarEncargo_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(observacion.Text) == false && string.IsNullOrWhiteSpace(valor.Text) == false)
            {
                string query = "update Encargo set Observacion= '" + observacion.Text + "',  Valor = " + valor.Text + ", FechaSalida = getdate(), Estado = 'Entregado' where IDEncargo = " + int.Parse(id.Text) + "";
                Mantenimiento.actualizar(query);

                Mantenimiento man = new Mantenimiento();
                man.cargarEncargo(frm1.gridEncargos, frm1.userID);

                this.Hide();

            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }
    }
}
