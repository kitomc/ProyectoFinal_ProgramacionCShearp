using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ProgramacionCShearp
{
    public partial class ctrlEstudiante : UserControl
    {
        public ctrlEstudiante()
        {
            InitializeComponent();
        }

        DateTime Date = DateTime.Today;
        Estudiantes DBestudiantes = new Estudiantes();








        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            DBestudiantes.Nombre = tbNombre.Text.ToString();
            DBestudiantes.Apellido = tbApellido.Text.ToString();

            //-Validando Cedula-->
            string cedula, mensaje;
            cedula = tbCedula.Text.ToString();
            if (Utilidad.ValidadorDeCedula(cedula, out mensaje) == true)
            {
                DBestudiantes.Cedula = cedula;



                //--Validacion de numero telefonico--->
                if (tbTelefono.Text.Length <= 10)
                {
                    DBestudiantes.Telefono = tbTelefono.Text.ToString();



                    //Genero
                    if (rbHmbre.Checked == true)
                    {
                        DBestudiantes.Genero = "M";
                    }
                    if (rbMujer.Checked == true)
                    {
                        DBestudiantes.Genero = "F";
                    }

                    //Correo
                    string correo;
                    correo = tbEmail.Text.ToString();

                    if (Utilidad.ValidadorDeCorreo(correo) == true)
                    {
                        DBestudiantes.Email = correo;

                        try
                        {
                        var db = new NOTIFICACIONEntities();
                        var query = from a in db.Estudiantes
                                    where a.Cedula==tbCedula.Text
                                    select a;

                            MessageBox.Show("Esta cedula ya esta siendo usada por otra persona!");
                        }
                        catch 
                        {

                                    using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                                    {
                                        try
                                        {
                                            db.Estudiantes.Add(DBestudiantes);
                                            db.SaveChanges();
                                            MessageBox.Show("Estudiante Registrado exitosamente");
                                            Refrescar();

                                        }
                                        catch 
                                        {

                                           MessageBox.Show("Error al agregar datos a la base de datos" );
                                        }


                        }
        
                           

                        }
                    }

                    //Validando estado
                    if (rbActivo.Checked == true)
                    {
                        DBestudiantes.Estado = "A";
                    }
                    else
                    {
                        DBestudiantes.Estado = "I";
                    }





                }
                else 
                {
                    MessageBox.Show("Error!! Escriba el telefono sin guiones");


                }



                DBestudiantes.Fecha_N = Date;




            }
            else
            {
                MessageBox.Show(mensaje);

            }


            try
            {
                using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                {

                    if (DBestudiantes.Id== 0) // Insertar
                    {
                        db.Estudiantes.Add(DBestudiantes);
                        Refrescar();
                    }
                    else //Actualizar
                    {
                    db.Entry(DBestudiantes).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Usuario Actualizado correctamente");
                    Refrescar();

                    }
                    Refrescar();
                    Utilidad.Limpiar(tbNombre, tbApellido, tbCedula, tbEmail, tbTelefono, tbTelefono);
                    btnRegistrar.Text = "Registrar";
                }

            }
            catch
            {

                MessageBox.Show("Error al actualizar registro");
            }


        }











        //-------Fin Agregar---
        private void CtrlEstudiante_Load(object sender, EventArgs e)
        {
            Refrescar();
            rbActivo.Checked = true;
            rbHmbre.Checked = true;
        }



        public void Refrescar()
        {



            using (NOTIFICACIONEntities Basededatos = new NOTIFICACIONEntities())
            {


                dataGridView1.DataSource = Basededatos.Estudiantes.ToList<Estudiantes>();
                //foreach (var item in Basededatos.Estudiantes)
                //{

                //dataGridView1.Rows[1].Cells[0].Value = item.Nombre.ToList();
                //}

            }
        }

        //Update
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.CurrentRow.Index !=1)
            {
                DBestudiantes.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (NOTIFICACIONEntities db= new NOTIFICACIONEntities())
                {
                    DBestudiantes = db.Estudiantes.Where(x => x.Id == DBestudiantes.Id).FirstOrDefault();
                    tbNombre.Text = DBestudiantes.Nombre.ToString();
                    tbApellido.Text = DBestudiantes.Apellido;
                    if (DBestudiantes.Cedula == tbCedula.Text)
                    {
                    tbCedula.Text = string.Empty;

                    }
                    else
                    {
                        tbCedula.Text = DBestudiantes.Cedula;
                    }
                    tbTelefono.Text = DBestudiantes.Telefono;
                    if (rbMujer.Checked == true)
                    {
                        DBestudiantes.Genero = "F";
                    }
                    else 
                    {
                        DBestudiantes.Genero = "M";
                    }

                    tbEmail.Text = DBestudiantes.Email;

                    if (rbActivo.Checked == true)
                    {
                        DBestudiantes.Estado = "A";
                    }
                    else if (rbActivo.Checked == true)
                    {
                        DBestudiantes.Estado = "I";
                    }
                    

                }
                btnRegistrar.Text = "Actualizar";
                btnBorrar.Enabled = true;
            }


           
            

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
                      

        }
    }
}
