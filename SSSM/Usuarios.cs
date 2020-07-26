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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            users us = new users();
            us.cargarUsers(gridUsers);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario frm3 = new CrearUsuario();
            frm3.Show();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (gridUsers.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarUsuario ec = new EditarUsuario();
                ec.id.Text = gridUsers.CurrentRow.Cells[0].Value.ToString();
                ec.nom.Text = gridUsers.CurrentRow.Cells[1].Value.ToString();
                ec.user.Text = gridUsers.CurrentRow.Cells[2].Value.ToString();
                ec.cbPuesto.SelectedItem = gridUsers.CurrentRow.Cells[3].Value.ToString();
                ec.cbPuesto.SelectedItem = gridUsers.CurrentRow.Cells[4].Value.ToString();




                this.Hide();
                ec.Show();

            }
        }
    }
}
