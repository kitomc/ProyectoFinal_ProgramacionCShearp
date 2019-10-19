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
    public partial class ctrlCursos : UserControl
    {
        public ctrlCursos()
        {
            InitializeComponent();
        }
        public ctrlCursos(ctrlInscripcion ctrlInscripcion)
        {
            InitializeComponent();
        }

        //public ctrlCursos( EstudianteCursos estucurso )
        //{
        //    InitializeComponent();
        //    dbcursos.EstudianteCursos.Add( estucurso);
        //}


            Cursos dbcursos = new Cursos();

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

           
            dbcursos.Nombre = tbNombre.Text.ToString().ToUpper();
            

            if (rbActivo.Checked== true)
            {
                dbcursos.Estado = "A";
            }
            else 
            {
                dbcursos.Estado = "I";
            }

            try
            {

                using(NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                {
                    db.Cursos.Add(dbcursos);
                    db.SaveChanges();

                    MessageBox.Show("Curso agregado satisfactoriamente");
                    refrescarTabla();
                    tbNombre.Text = string.Empty;

                }
            }
            catch 
            {

                MessageBox.Show("Error al agregar curso a la base de datos ");
            }


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CtrlCursos_Load(object sender, EventArgs e)
        {

            refrescarTabla();
            rbActivo.Checked = true;
           
        }
            public void refrescarTabla ()
            {
                using (NOTIFICACIONEntities db = new NOTIFICACIONEntities())
                {


                dataGridView1.DataSource = db.Cursos.ToList();

                }

            }
    }
}
