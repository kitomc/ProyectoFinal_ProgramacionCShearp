using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ProgramacionCShearp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(string Usuario )
        {
            InitializeComponent();

            tbUsuario.Text = Usuario;
            tbUsuario.ForeColor = Color.Black;
            tbContrasena.Text = string.Empty;
            tbContrasena.ForeColor = Color.Black;

        }

        private void Label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void TbUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            tbUsuario.Text = string.Empty;
            tbUsuario.ForeColor = Color.Black;
        }

        private void TbContrasena_MouseClick(object sender, MouseEventArgs e)
        {
            tbContrasena.PasswordChar = '*';
            tbContrasena .Text = string.Empty;
            tbContrasena.ForeColor = Color.Black;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            //Validando campos vacios
            tbUsuario.Text.Replace("Usuario",string.Empty);
            tbContrasena.Text.Replace("Contraseña",string.Empty);
            if (tbUsuario.Text==string.Empty || tbContrasena.Text==string.Empty)
            {
                MessageBox.Show("Error!!! Los campos no pueden estar vacios");
            }

            else
            {
                if (Utilidad.ValidacionUsuario(tbUsuario,tbContrasena)==true)
                {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Hide();
                }
                else
                {
                MessageBox.Show("Error al introducir los datos, Intente de nuevo ");
                tbUsuario.Focus();
                }

            }





        }
    }
}
