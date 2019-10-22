using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ProyectoFinal_ProgramacionCShearp
{
    public partial class ctrlCalificar : UserControl
    {
        public ctrlCalificar()
        {
            InitializeComponent();
        }

        EstudianteCursos estudianteCursos = new EstudianteCursos();
        private void PnlRegistroEstudiante_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CtrlCalificar_Load(object sender, EventArgs e)
        {
            //Llenando Combobox
            using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
            {

                var estudiantesCB = from a in db.Estudiantes
                                    where a.Estado == "A"
                                    select a.Nombre;

                foreach (var item in estudiantesCB)
                {

                    cbEstudiante.Items.Add(item).ToString();
                }



                var curso = from b in db.Cursos
                            where b.Estado == "A"
                            select b.Nombre;


                foreach (var item in curso)
                {
                    cbCursos.Items.Add(item).ToString();

                }

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            if (cbNota.Text.Length <1)
            {
                MessageBox.Show("Califique a este estudiante pro favor! ");
                return;
            }
            else
            {
                    if (Convert.ToInt32( cbNota.Text)<70 )
                    {
                        cbNota.ForeColor = Color.Red;
                    }
                    else
                    {
                        cbNota.ForeColor = Color.Blue;
                    }

            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

            if (cbEstudiante.SelectedItem==null )
            {
                MessageBox.Show("Debe seleccionar a un estudiante para calificarlo");
                if (cbNota.Text == null)
                {
                    MessageBox.Show("Debe introducir a calificacion de este estudiante");
                }
            }
            else
            {
                try
                {
                    using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                    {
                        string expresion;
                        //busqueda email
                        var EmailEstudiante = from a in db.Estudiantes
                                   where cbEstudiante.SelectedItem.ToString() == a.Nombre
                                   select a.Email.ToString();



                        var cursodb = from a in db.EstudianteCursos
                                      from c in db.Cursos
                                      from s in db.Estudiantes
                                      where estudianteCursos.IdCurso == c.Id
                                      where estudianteCursos.IdEstudiante == s.Id
                                      select a.Nota; 

                        
                        estudianteCursos.Nota = int.Parse(cbNota.Text);
                        db.EstudianteCursos.Add(estudianteCursos);
                        db.SaveChanges();
                       
                        
                      

                        MessageBox.Show("Nota registrada en la base de datos");
                        if (Convert.ToInt32(cbNota.Text) >= 70)
                        {
                            expresion = "FELICIDADES!!! paso la materia  ";
                        }
                        else
                        {
                            expresion = "Lo sentimos quemo la materia ";
                        }

                        try
                        {
                            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
                            string servidor = "smtp.gmail.com";
                            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
                            MailMessage mensaje = new MailMessage(
                               "kitomc.rd@gmail.com",
                               EmailEstudiante.Single(),
                               "Nota Profesor",
                               " " + expresion + " su nota  fue  " + Convert.ToInt32(cbNota.Text) + " de 100 en " + cbCursos.SelectedItem.ToString() );

                            //Envía el mensaje.
                            SmtpClient cliente = new SmtpClient(servidor);

                            cliente.UseDefaultCredentials = false;
                            cliente.Credentials = new System.Net.NetworkCredential("kitomc.rd@gmail.com", "Laprofecia1312");
                            cliente.Port = 587;
                            cliente.Host = "smtp.gmail.com";
                            cliente.EnableSsl = true;

                           
                            cliente.Send(mensaje);

                            MessageBox.Show("Corre electrónico fue enviado satisfactoriamente.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error enviando correo electrónico: " + ex.Message);
                        }
                    }

                }
                catch 
                {

                    MessageBox.Show("Error con conexion a base de datos ");
                }
            }


        }

        private void CbNota_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsDigit(e.KeyChar))
                   {
                       e.Handled = false;
                    }
              else if (Char.IsControl(e.KeyChar))
                  {
                         e.Handled = false;
                     }
               else if (Char.IsSeparator(e.KeyChar))
                  {
                         e.Handled = false;
                     }
                 else
                     {
                         e.Handled = true;
                     }
        }








         public void smtp()
        {


                

        }



    }
}
