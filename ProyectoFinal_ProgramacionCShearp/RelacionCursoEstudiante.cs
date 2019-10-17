using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_ProgramacionCShearp
{
  public  class RelacionCursoEstudiante
    {

        public IQueryable<List<char>> ListaCursos { get; set; }
        public IQueryable < List <char> >ListaEstudiantes{ get; set; }
    }
}
