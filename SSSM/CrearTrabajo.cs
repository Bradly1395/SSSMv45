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
    public partial class CrearTrabajo : Form
    {
        private PantallaPrincipal frm1;
        public CrearTrabajo(PantallaPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(valor.Text) == false && string.IsNullOrWhiteSpace(descripcion.Text) == false)
            {
                string queryCliente = "select IDCliente from Cliente where Nombre = '" + cmbCliente.Text + "'";
                int idCliente = 0;
                idCliente = Mantenimiento.returnInt(queryCliente);

                string queryTipo = "select IDTipo from TipoTrabajo where Descripcion = '" + cmbTipo.Text + "'";
                int idTipo = 0;
                idTipo = Mantenimiento.returnInt(queryTipo);

                string cadenasql = "INSERT INTO [dbo].[Trabajo] ([TipoTrabajo] ,[Descripcion] ,[Cliente] ,[Valor] ,[FechaEntrada] ,[Usuario], [Estado]) VALUES ( " + idTipo + " ,'" + descripcion.Text + "', " + idCliente + ", " + valor.Text + ", GETDATE() , " + idUser.Text + ", 'Activo');";
                Mantenimiento.insertar(cadenasql);

                Mantenimiento man = new Mantenimiento();
                man.cargarTrabajo(frm1.gridTrabajosMain, frm1.userID);

                

                this.Hide();

            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CrearTrabajo_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCB(cmbTipo,"select Descripcion from TipoTrabajo order by Descripcion","Descripcion");
            cmbTipo.SelectedIndex = 0;
            llenar.llenarCB(cmbCliente,"select Nombre from Cliente order by Nombre","Nombre");
            cmbCliente.SelectedIndex = 0;

            this.user.Text= Mantenimiento.lookerSt("Select Nombre from Usuario where ID = "+this.idUser.Text+"");
        }

        private void horaL_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.valor.Text = Mantenimiento.lookerSt("select Precio from TipoTrabajo where Descripcion = '"+cmbTipo.Text+"'");
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
