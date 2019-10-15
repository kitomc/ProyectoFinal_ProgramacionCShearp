using System;
using System.Collections.Generic;
using System.Linq;
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

    









    }
}
