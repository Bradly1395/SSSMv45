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
    public partial class PantallaPrincipal : Form
    {
        public int userID;
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            userID = Int32.Parse(iduser.Text);
            Mantenimiento man = new Mantenimiento();
            man.cargarTrabajo(gridTrabajosMain, userID);
            man.cargarEncargo(gridEncargos, userID);




            string adm;

            adm = puesto.Text;




            if (adm == "Administrador")
            {
                botonUsuario.Visible = true;
                botonPar.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Salir del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void botonUsuario_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void botonPar_Click(object sender, EventArgs e)
        {
            Parametros cli = new Parametros();
            cli.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearTrabajo t = new CrearTrabajo(this);
            t.idUser.Text = this.iduser.Text; 
            t.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {


        }

        private void editar_Click(object sender, EventArgs e)
        {

        }

        private void gridTrabajosMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridTrabajosMain.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarTrabajo ec = new EditarTrabajo(this);
                ec.id.Text = gridTrabajosMain.CurrentRow.Cells[0].Value.ToString();
                ec.atencion.Text = gridTrabajosMain.CurrentRow.Cells[1].Value.ToString();
                ec.descripcion.Text = gridTrabajosMain.CurrentRow.Cells[2].Value.ToString();
                ec.valor.Text = gridTrabajosMain.CurrentRow.Cells[3].Value.ToString();
                ec.user.Text = gridTrabajosMain.CurrentRow.Cells[4].Value.ToString();
                ec.cliente.Text = gridTrabajosMain.CurrentRow.Cells[5].Value.ToString();

                ec.Show();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void encargo_Click(object sender, EventArgs e)
        {
            CrearPedido t = new CrearPedido(this);
            t.idUser.Text = this.iduser.Text;
            t.Show();
        }

        private void gridEncargos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridEncargos.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                EditarEncargo ec = new EditarEncargo(this);
                ec.id.Text = gridEncargos.CurrentRow.Cells[0].Value.ToString();
                ec.atencion.Text = gridEncargos.CurrentRow.Cells[1].Value.ToString();
                ec.observacion.Text = gridEncargos.CurrentRow.Cells[2].Value.ToString();
                ec.valor.Text = gridEncargos.CurrentRow.Cells[3].Value.ToString();
                ec.user.Text = gridEncargos.CurrentRow.Cells[4].Value.ToString();
                ec.cliente.Text = gridEncargos.CurrentRow.Cells[5].Value.ToString();

                ec.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userID = Int32.Parse(iduser.Text);
            Mantenimiento man = new Mantenimiento();
            man.cargarTrabajo(gridTrabajosMain, userID);
            man.cargarEncargo(gridEncargos, userID);
        }
    }
}
