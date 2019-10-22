using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ProgramacionCShearp
{
    public static class Utilidad
    {

        //Validar usuario y contraseña en log in  usando base de datos OJO  return Booleano



        public static bool ValidacionUsuario(TextBox Usuario, TextBox contra)
        {


            Usuario.Text.Trim();
            Usuario.Text.Replace(" ", "");
            contra.Text.Trim();
            contra.Text.Replace(" ", "");
            try
            {
                using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                {
                    var lst = from d in db.Usuarios
                              where d.Nombre_Usuario == Usuario.Text && d.Pwd == contra.Text
                              select d;


                    if (lst.SingleOrDefault() != null)
                    {
                        return true;
                    }



                }

            }
            catch
            {
                return false;
            }
            return false;

        }



        //Registro de nuevo usuario

        public static bool RegistroUsuario(TextBox Usuario, TextBox Contra)
        {
            Usuario.Text.Trim();
            Usuario.Text.Replace(" ", "");
            Contra.Text.Trim();
            Contra.Text.Replace(" ", "");



            try
            {
                NOTIFICACIONEntities db = new NOTIFICACIONEntities();
                Usuarios usuarios = new Usuarios();

                usuarios.Nombre_Usuario = Usuario.Text.ToString();
                usuarios.Pwd = Contra.Text.ToString();
                usuarios.Estado = "A";
                db.Usuarios.Add(usuarios);
                db.SaveChanges();
                return true;



            }
            catch
            {

                return false;
            }


        }




        //Validacion de cedula 

        public static bool ValidadorDeCedula(string Cedula, out string mensaje)
        {

            mensaje = string.Empty;
            if (string.IsNullOrEmpty(Cedula.Trim()))
            {
                mensaje = "Debe de escribir La Cedula";
                return false;
            }

            if (!EsNumero(Cedula))
            {
                mensaje = "La Cedula solo debe de contener numeros";
                return false;
            }

            if (Cedula.Length != 11)
            {
                mensaje = "La Cedula debe tener 11 digitos";
                return false;
            }
            int[] Por = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            char[] Valores = Cedula.ToCharArray();
            int[] sequence = Valores.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            char[] Resultado;
            Cedula = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                Cedula += ((Por[i] * sequence[i]).ToString()); ;
            }
            Resultado = Cedula.ToCharArray();
            int suma = 0;
            for (int i = 0; i < Resultado.Length; i++)
            {
                suma += int.Parse(Resultado[i].ToString());
            }

            int unidad = int.Parse(suma.ToString().Remove(0, 1));
            int restante = unidad == 0 ? 0 : 10 - unidad;
            if (((suma + restante) - suma) == sequence[10])
            //if ((suma + int.Parse(Valores[10].ToString())) % 2 == 0)
            {
                return true;
            }
            else
            {
                mensaje = "La Cedula es Invalida";
                return false;
            }
        }


        //Quitar espacio

        public static String Quitar_Espacios(ref string s)
        {
            if (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
                Quitar_Espacios(ref s);
            }
            return s;
        }


        public static bool EsNumero(string s)
        {
            long valor;
            if (long.TryParse(s, out valor))
            {
                return true;
            }
            else
            {
                return false;
            }


        }




        //Validacion de mail--- OJO Libreria (using System.Net.Mail) contiene validador

        static public bool ValidadorDeCorreo(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch
            {
                MessageBox.Show("Correo invalido");
                return false;
            }
        }





        //Limpieza de textbox

        static public void Limpiar(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f)
        {
            a.Text = b.Text = c.Text = d.Text = e.Text = f.Text = string.Empty;
        }
        static public void Limpiar(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e)
        {
            a.Text = b.Text = c.Text = d.Text = e.Text = string.Empty;
        }
        static public void Limpiar(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            a.Text = b.Text = c.Text = d.Text = string.Empty;
        }
        static public void Limpiar(TextBox a, TextBox b)
        {
            a.Text = b.Text = string.Empty;
        }


        //Llamado de panel 

        public static bool MostrarPanel(Panel contenedor, Control contenido)
        {


            try
            {
                contenedor.Controls.Add(contenido);
                contenido.BringToFront();
                contenido.Show();
                contenido.Visible = true;
                return true;

            }
            catch
            {

                return false;
            }




        }


        //Refrescar Data Grid View Estudiante

        public static void RefrescarTablaEstudiante( DataGridView dataGridView)
        {

            
            
                using (NOTIFICACIONEntities Basededatos = new NOTIFICACIONEntities())
                {
                

                dataGridView.DataSource = Basededatos.Estudiantes.ToList<Estudiantes>();

                }
            
        }

        //Panel Activo
       public static void PnlActivo(Panel activo, Panel noactivo1, Panel noactivo2, Panel noactivo3)
        {
            activo.BackColor = Color.CornflowerBlue;
            noactivo1.BackColor = Color.FromArgb(246, 248, 247);
            noactivo2.BackColor = Color.FromArgb(246, 248, 247);
            noactivo3.BackColor = Color.FromArgb(246, 248, 247);
        }


        public static bool ValidadorCamposVacios(TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f)
        {

        if (string.IsNullOrEmpty(a.Text ) && string.IsNullOrEmpty(b.Text) && string.IsNullOrEmpty(c.Text) && string.IsNullOrEmpty(d.Text) && string.IsNullOrEmpty(e.Text) && string.IsNullOrEmpty(f.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return true;
            }
            else
            {
                return false;
            }

        }



        //Enviar el mail

            public static void EnviarNotaMail(string MailEstudiante,string  curso , string expresion , int nota )
        {
            try
            {
            MailMessage mail = new MailMessage();

            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(MailEstudiante));
            email.From = new MailAddress("kitomc.rd@gmail.com");
            email.Subject = "NOTA DEL CURSO "+ curso  ;
            email.Body = " <b> " + expresion + " su nota  fue  " + nota  +" de 100</b> ";
            email.IsBodyHtml =true;
            email.Priority = MailPriority.Normal;

            MessageBox.Show("Mensaje enviado exitosamente!! Gracias por preferirnos");

            }
            catch 
            {

                MessageBox.Show("Error al enviar mensaje");
            }


        }

        
}
}


    