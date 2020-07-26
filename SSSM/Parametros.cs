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
    public partial class Parametros : Form
    {
        public Parametros()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parametros_Load(object sender, EventArgs e)
        {
            Mantenimiento man = new Mantenimiento();
            man.cargarTipo(gridTipoTrabajo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearTipoTrabajo frm3 = new CrearTipoTrabajo();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gridTipoTrabajo.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarTipoTrabajo ec = new EditarTipoTrabajo();
                ec.id.Text = gridTipoTrabajo.CurrentRow.Cells[0].Value.ToString();
                ec.nom.Text = gridTipoTrabajo.CurrentRow.Cells[1].Value.ToString();
                ec.precio.Text = gridTipoTrabajo.CurrentRow.Cells[2].Value.ToString();

                this.Hide();
                ec.Show();

            }

        }
    }
}
