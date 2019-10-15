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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pnlCarga.Width += 3;
            if (pnlCarga.Width>=600)
            {
                timer1.Stop();
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
                
            }
        }
    }
}
