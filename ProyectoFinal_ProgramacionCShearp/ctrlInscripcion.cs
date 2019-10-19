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
    public partial class ctrlInscripcion : UserControl
    {
        public ctrlInscripcion()
        {
            InitializeComponent();
        }
       
        //public ctrlInscripcion(EstudianteCursos estuCurso)
        //{
        //    InitializeComponent();
        //    estudianteCursos = estuCurso;

        //}

        EstudianteCursos estudianteCursos = new EstudianteCursos();

        private void CtrlInscripcion_Load(object sender, EventArgs e)
        {
            
            //Llenando Combobox
            using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
            {

                var estudiantesCB = from a in db.Estudiantes
                           where a.Estado == "A"
                           select a.Nombre;


                var curso = from b in db.Cursos
                            where b.Estado == "A"
                            select b.Nombre;


                foreach (var item in curso)
                {
                    cbCursos.Items.Add(item).ToString();
                    
                }

                foreach (var item in estudiantesCB)
                {
             
                    cbEstudiante.Items.Add(item).ToString();
                }
            }


            refrecartabla();



            
        }



        //cargar tabla
        void refrecartabla()
        {
               
            using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
            {





                var query = from a in db.EstudianteCursos
                                //from c in db.Cursos
                                //from s in db.Estudiantes
                                //where a.IdCurso == c.Id && a.IdEstudiante == s.Id
                            join c in db.Cursos on a.IdCurso equals c.Id
                            join s in db.Estudiantes on a.IdEstudiante equals s.Id
                            select c.Nombre + s.Nombre;


                dataGridView1.DataSource = query.ToList();

                

                            





            }
            



            }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
           
            try
            {
            
            //Agregando a base de datos
            using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
            {
                var estudiante = from a in db.Estudiantes
                                 where a.Nombre == cbEstudiante.SelectedItem.ToString()
                                 select a.Id;
                estudianteCursos.IdEstudiante = estudiante.First();


                var curso = from a in db.Cursos
                            where a.Nombre == cbCursos.SelectedItem.ToString()
                            select a.Id;

                estudianteCursos.IdCurso = curso.First();

                db.EstudianteCursos.Add(estudianteCursos);

                db.SaveChanges();
                MessageBox.Show("Estudiante inscrito  satisfactoriamente");
                refrecartabla();

                    
                  

            }

            }
            catch 
            {

                MessageBox.Show("Error al inscribir estudiante");
            }


        }
    }

}


