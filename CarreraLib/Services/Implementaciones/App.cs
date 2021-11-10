using CarreraLib.DataAccess;
using CarreraLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Services
{
    public class App : IApp
    {
        private ICarreraDao dao;

        public App()
        {
            dao = new CarreraDao();
        }
        public List<Materia> ConsultarMaterias()
        {
            return dao.GetMaterias();
        }
        public List<Carrera> ConsultarCarreras()
        {
            return dao.GetCarrera();
        }

        public bool CrearMateria(Materia oMateria)
        {
            return dao.CrearMateria(oMateria);
        }

        public bool EditarMateria(Materia oMateria)
        {
            return dao.EditarMateria(oMateria);
        }

        public bool CrearCarrera(Carrera oCarrera)
        {
            return dao.InsertarCarrera(oCarrera);
        }

        public int getProximoIdCarrera()
        {
            return dao.ObtenerProximoNumero();
        }

        public Carrera GetCarreraById(int id)
        {
            return dao.GetCarreraById(id);
        }

        public bool DeleteCarrera(int id)
        {
            return dao.DeleteCarrera(id);
        }

        public bool EditarCarrera(Carrera oCarrera)
        {
            return dao.EditCarrera(oCarrera);
        }

        public bool DeleteMateria(int id)
        {
            return dao.DeleteMateria(id);
        }

        public bool LogIn(User oUser)
        {
            return dao.LogIn(oUser);
        }

        public bool Registro(User oUser)
        {
            return dao.Registro(oUser);
        }
    }
}
