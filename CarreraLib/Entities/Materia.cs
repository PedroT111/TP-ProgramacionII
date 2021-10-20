using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Entities
{
    class Materia
    {
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
