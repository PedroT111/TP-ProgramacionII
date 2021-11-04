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

        public Carrera GetCarreraById(int id);

        public bool CrearMateria(Materia oMateria);

        public bool DeleteMateria(int id);

        public bool EditarMateria(Materia oMateria);

        public bool InsertarCarrera(Carrera oCarrera);

        public bool DeleteCarrera(int id);

        int ObtenerProximoNumero();

        public bool EditCarrera(Carrera oCarrera);

        public bool LogIn(User oUser);
    }
}
