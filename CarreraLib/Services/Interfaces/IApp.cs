using CarreraLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Services
{
    public interface IApp
    {
        public List<Materia> ConsultarMaterias();
        public List<Carrera> ConsultarCarreras();

        public bool CrearMateria(Materia oMateria);

        public bool DeleteMateria(int id);

        public bool EditarMateria(Materia oMateria);
        public bool CrearCarrera(Carrera oCarrera);

        public int getProximoIdCarrera();

        public Carrera GetCarreraById(int id);

        public bool DeleteCarrera(int id);

        public bool EditarCarrera(Carrera oCarrera);

        public bool LogIn(User oUser);
        bool Registro(User oUser);
    }
}
