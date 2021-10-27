using CarreraLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.DataAccess
{
    interface ICarreraDao
    {
        public List<Materia> GetMaterias();
        public List<Carrera> GetCarrera();

        public bool CrearMateria(Materia oMateria);

        public bool InsertarCarrera(Carrera oCarrera);

        int ObtenerProximoNumero();
    }
}
