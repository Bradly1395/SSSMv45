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
    public partial class EditarTrabajo : Form
    {
        private PantallaPrincipal frm1;
        public EditarTrabajo(PantallaPrincipal frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void EditarTrabajo_Load(object sender, EventArgs e)
        {
            fechaL.Text = DateTime.Now.ToString("dd / MM / yyyy");
            horaL.Text = DateTime.Now.ToShortTimeString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descripcion.Text) == false && string.IsNullOrWhiteSpace(valor.Text) == false && string.IsNullOrWhiteSpace(txtlink.Text) == false)
            {
                string query = "update Trabajo set Descripcion= '" + descripcion.Text + "', Link = '" + txtlink.Text + "', Valor = "+valor.Text+", FechaSalida = getdate(), Estado = 'Entregado' where IDTrabajo = "+ int.Parse(id.Text) + "";
                Mantenimiento.actualizar(query);

                Mantenimiento man = new Mantenimiento();
                man.cargarTrabajo(frm1.gridTrabajosMain, frm1.userID);

                this.Hide();
                
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numero = new Validaciones();
            numero.SoloNumeros(e);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
