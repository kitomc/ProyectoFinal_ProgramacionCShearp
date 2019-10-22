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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        public Inicio( string NombreUsuario)
        {
            InitializeComponent();
            
            lbNombreUsuario.Text = NombreUsuario;
        }

        ctrlCursos ctrlCursos;
        ctrlInscripcion ctrlInscripcion;

        DateTime Date = DateTime.Today;
        private void Inicio_Load(object sender, EventArgs e)
        {
            lbFechaHoy.Text = Date.ToString("dd/MM/yyyy");
        }
        //Variables Globales
       


        //------------ANIMACIONES---------------------------
        private void PnlEstudiante_MouseHover(object sender, EventArgs e)
        {
            pnlEstudiante.BackColor = Color.Blue;
        }

        private void PnlEstudiante_MouseLeave(object sender, EventArgs e)
        {
            // pnlEstudiante.BackColor = pnlMenu.BackColor;
            Utilidad.PnlActivo(pnlEstudiante, pnlCurso, pnlInscripcion, pnlCalificar);
        }


        //-----------BTN Cerrar-------------------------------//
        private void PictureBox8_Click(object sender, EventArgs e)
        {
           Close();
        }
        //------------ANIMACIONES---------------------------
        private void PnlCurso_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Utilidad.PnlActivo( pnlCurso, pnlEstudiante, pnlInscripcion, pnlCalificar);
            // pnlCurso.BackColor = pnlMenu.BackColor;
        }

        private void PnlCurso_MouseHover_1(object sender, EventArgs e)
        {
            pnlCurso.BackColor = Color.Blue;
        }

        private void PnlInscripcion_MouseHover(object sender, EventArgs e)
        {
            pnlInscripcion.BackColor = Color.Blue;
        }

        private void PnlInscripcion_MouseLeave(object sender, EventArgs e)
        {
            Utilidad.PnlActivo( pnlInscripcion, pnlEstudiante, pnlCurso, pnlCalificar);
            //pnlInscripcion.BackColor = pnlMenu.BackColor;

        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            pnlCalificar.BackColor = Color.Blue;
        }

        private void PnlCalificar_MouseLeave(object sender, EventArgs e)
        {
            Utilidad.PnlActivo( pnlCalificar, pnlEstudiante, pnlCurso, pnlInscripcion);
            
        }







        //------------BTN REgistrar------------>
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void TbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {




            
            
        }

        private void PnlEstudiante_Click(object sender, EventArgs e)
        {
           
            
            ctrlEstudiante ctrlEstudiante = new ctrlEstudiante();

            Utilidad.MostrarPanel(pnlContenedor, ctrlEstudiante);

           
           

        }

        private void PnlCurso_Click(object sender, EventArgs e)
        {

            ctrlCursos = new ctrlCursos();
            Utilidad.MostrarPanel(pnlContenedor,ctrlCursos);
        }

        private void PnlInscripcion_Click(object sender, EventArgs e)
        {

            ctrlInscripcion = new ctrlInscripcion();
            Utilidad.MostrarPanel(pnlContenedor, ctrlInscripcion);

        }

        private void PnlCalificar_Click(object sender, EventArgs e)
        {

            ctrlCalificar ctrlCalificar = new ctrlCalificar();
            Utilidad.MostrarPanel(pnlContenedor, ctrlCalificar);
        }
    }
}
