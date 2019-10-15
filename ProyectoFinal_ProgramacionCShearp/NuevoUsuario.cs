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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void TbUsuario_MouseClick(object sender, MouseEventArgs e)
        { //Cambio de color de letra y  vaciado de textbox
            tbUsuario.Text = string.Empty;
            tbUsuario .ForeColor = Color.Black;
        }

        private void TbContrasena_MouseClick(object sender, MouseEventArgs e)
        {
            //Cambio de color de letra y  vaciado de textbox
            tbContrasena.Text = string.Empty;
            tbContrasena .ForeColor = Color.Black;
            tbContrasena.PasswordChar = '*';
        }

        private void TbContrasenaRepeticion_MouseClick(object sender, MouseEventArgs e)
        {
            //Cambio de color de letra y  vaciado de textbox
            tbContrasenaRepeticion .ForeColor = Color.Black;
            tbContrasenaRepeticion.Text = string.Empty;
            tbContrasenaRepeticion .PasswordChar = '*';

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            //Validando injecto sql
            if (tbUsuario.TextLength<=41 || tbContrasena.TextLength<=41|| !tbUsuario.Text.Contains("Insert,SELECT ,INSERT, DELETE,UPDATE ,CREATE TABLE,DROP TABLE,ALTER TABLE,CREATE VIEW ,DROP VIEW ,CREATE INDEX,DROP INDEX,CREATE SYNOYM,DROP SYNONYM ,and ,or , not,(),*") || !tbContrasena.Text.Contains("Insert,SELECT ,INSERT, DELETE,UPDATE ,CREATE TABLE,DROP TABLE,ALTER TABLE,CREATE VIEW ,DROP VIEW ,CREATE INDEX,DROP INDEX,CREATE SYNOYM,DROP SYNONYM ,and ,or , not,(),*"))
            {
                        //Validando contraseña
                        if (tbContrasena.Text== tbContrasenaRepeticion.Text)
                        {
                                //Ingresando datos a la base de datos 
                                if (Utilidad.RegistroUsuario(tbUsuario, tbContrasena)==true)
                                {

                                MessageBox.Show("El nuevo usuario " + tbUsuario.Text.ToString() + " se ha registrado exitosamente");
                                LogIn logIn = new LogIn( tbUsuario.Text.ToString());
                                this.Hide();
                                logIn.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Error al Ingresar a la base de datos");
                                }

                        }
                        else
                        {
                            MessageBox.Show("Error al introducir contraseña vuelva a intentarlo de nuevo");
                        }

            }

           else
            {
                MessageBox.Show("ERROR CRITICO  DE SEGURIDAD !!!!! Intento de Injeccion SQL, La aplicacion se cerrar en seguida!");
                LogIn logIn = new LogIn();
                logIn.Close();
            }


        }
    }
}
