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


            


            
        }



       

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
           
            try
            {
            
            //Agregando a base de datos
            using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
            {
                    //Validacion de curso estudiante
                    var relacionEstudianteCurso = from es in db.Estudiantes
                                         from sc in db.EstudianteCursos
                                         from c in db.Cursos
                                         where sc.IdEstudiante == es.Id && sc.IdCurso == c.Id
                                         select  (sc.Id) ;




                   
                        

                        db.EstudianteCursos.Add(estudianteCursos);

                        db.SaveChanges();
                        MessageBox.Show("Estudiante inscrito  satisfactoriamente");

                   
                   
                       // MessageBox.Show("Este estudiante esta inscrito en esta materia, seleccione otra por favor!");
                   
                    //Carga de datos ComboBox
                var estudiante = from a in db.Estudiantes
                                 where a.Nombre == cbEstudiante.SelectedItem.ToString()
                                 select a.Id;
                estudianteCursos.IdEstudiante = estudiante.FirstOrDefault();


                var curso = from a in db.Cursos
                            where a.Nombre == cbCursos.SelectedItem.ToString()
                            select a.Id;
                estudianteCursos.IdCurso = curso.First();
                    
                  

            }

            }
            catch 
            {

                MessageBox.Show("Error al inscribir estudiante");
            }


        }
                     bool ExisteNombre(ComboBox Estudiante)
                    {
                        
                        using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                        {
                              

                            return db.EstudianteCursos.Any(x => x.IdEstudiante == Estudiante.SelectedIndex );

                        }

                    }
    }

}


