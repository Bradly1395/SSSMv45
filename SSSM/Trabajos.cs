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
    public partial class Trabajos : Form
    {
        public Trabajos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Trabajos_Load(object sender, EventArgs e)
        {
            int userID = Int32.Parse(this.idUser.Text);
            Mantenimiento man = new Mantenimiento();
            man.cargarTrabajo(gridTrabajos, userID);
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            //if (gridTrabajos.RowCount == 0)
            //{
            //    MessageBox.Show("Selecione una linea");
            //}
            //else
            //{
            //    EditarTrabajo ec = new EditarTrabajo();
            //    ec.id.Text = gridTrabajos.CurrentRow.Cells[0].Value.ToString();
            //    ec.atencion.Text = gridTrabajos.CurrentRow.Cells[1].Value.ToString();
            //    ec.descripcion.Text = gridTrabajos.CurrentRow.Cells[2].Value.ToString();
            //    ec.valor.Text = gridTrabajos.CurrentRow.Cells[3].Value.ToString();
            //    ec.user.Text = gridTrabajos.CurrentRow.Cells[4].Value.ToString();
            //    ec.cliente.Text = gridTrabajos.CurrentRow.Cells[5].Value.ToString();

            //    this.Hide();
            //    ec.Show();

            //}
        }
    }
}
