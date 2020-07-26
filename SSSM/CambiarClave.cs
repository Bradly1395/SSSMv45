using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSM
{
    public partial class CambiarClave : Form
    {
        public CambiarClave()
        {
            InitializeComponent();
        }

        private void EntrarB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clavetxt.Text) == true || string.IsNullOrWhiteSpace(conftxt.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                users us = new users();
                //users us = new users();
                string login_pass = clavetxt.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

                int clave;

                clave = Int32.Parse(iduser.Text);

                if (clavetxt.Text == conftxt.Text)
                {
                    MessageBox.Show(us.Cambiarcontra(login_pass, clave));
                    Login forma2 = new Login();
                    forma2.Show();
                    this.Hide();

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
