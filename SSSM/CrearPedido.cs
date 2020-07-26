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
    public partial class CrearPedido : Form
    {
        private PantallaPrincipal frm1;
        public CrearPedido(PantallaPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void CrearPedido_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();

            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCB(cmbTipo, "select Descripcion from TipoTrabajo order by Descripcion", "Descripcion");
            cmbTipo.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void costo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(abono.Text) || string.IsNullOrWhiteSpace(costo.Text))
            {
                saldo.Text = "0.00";
            }
            else
            {
                saldo.Text = Convert.ToString(Convert.ToInt32(costo.Text) - Convert.ToInt32(abono.Text));
            }
        }

        private void abono_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(abono.Text) || string.IsNullOrWhiteSpace(costo.Text))
            {
                saldo.Text = "0.00";
            }
            else
            {
                saldo.Text = Convert.ToString(Convert.ToInt32(costo.Text) - Convert.ToInt32(abono.Text));
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre.Text) == false && string.IsNullOrWhiteSpace(telefono.Text) == false && string.IsNullOrWhiteSpace(costo.Text) == false && string.IsNullOrWhiteSpace(abono.Text) == false && string.IsNullOrWhiteSpace(observacion.Text) == false)
            {
                string queryTipo = "select IDTipo from TipoTrabajo where Descripcion = '" + cmbTipo.Text + "'";
                int idTipo = 0;
                idTipo = Mantenimiento.returnInt(queryTipo);

                //string queryUser = "select ID from Usuario where Nombre = '" + idUser.Text + "'";
                int idUserx = Convert.ToInt32(idUser.Text);
                //idUserx = Mantenimiento.returnInt(queryUser);

                string cadenasql = @"INSERT INTO [dbo].[Encargo] ([NombreCliente],[NumeroDeTelefono],[Valor],[Abono],[Encargado],[Observacion],[TipoTrabajo],[Estado],[FechaEntrada])
                               VALUES('" + nombre.Text + "','" + telefono.Text + "'," + costo.Text + "," + abono.Text + "," + idUserx + ",'" + observacion.Text + "'," + idTipo + ",'Activo',GETDATE())";
                Mantenimiento.insertar(cadenasql);

                Mantenimiento man = new Mantenimiento();
                man.cargarEncargo(frm1.gridEncargos, frm1.userID);

                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }
        }
    }
}
