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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Mantenimiento man = new Mantenimiento();
            man.cargarClientes(gridClientes);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearCliente frm3 = new CrearCliente();
            frm3.Show();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (gridClientes.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarCliente ec = new EditarCliente();
                ec.id.Text = gridClientes.CurrentRow.Cells[0].Value.ToString();
                ec.nom.Text = gridClientes.CurrentRow.Cells[1].Value.ToString();
                ec.idcliente.Text = gridClientes.CurrentRow.Cells[2].Value.ToString();
                ec.telefono.Text = gridClientes.CurrentRow.Cells[3].Value.ToString();
               




                this.Hide();
                ec.Show();

            }
        }
    }
}
