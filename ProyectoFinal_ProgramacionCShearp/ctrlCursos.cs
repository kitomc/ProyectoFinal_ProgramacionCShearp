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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            Cursos dbcursos = new Cursos();

            dbcursos.Nombre = tbNombre.Text.ToString();

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

                }
            }
            catch 
            {

                MessageBox.Show("Error al agregar curso a la base de datos ");
            }


        }
    }
}
