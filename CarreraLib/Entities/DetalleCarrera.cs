using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Entities
{
    class DetalleCarrera
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Materia Materia { get; set; }

        public DetalleCarrera(int anioCursado, int cuatrimestre, Materia materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }

        public DetalleCarrera()
        {
            AnioCursado = 0;
            Cuatrimestre = 0;
            Materia = null;
        }
    }
}
