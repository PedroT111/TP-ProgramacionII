using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Entities
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }

        public Materia()
        {
            NombreMateria = "";
        }

        public Materia(string nombreMateria)
        {
            NombreMateria = nombreMateria;
        }

        public override string ToString()
        {
            return NombreMateria;
        }
    }
}
