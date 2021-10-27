﻿using CarreraLib.DataAccess;
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

        public bool CrearCarrera(Carrera oCarrera)
        {
            return dao.InsertarCarrera(oCarrera);
        }

        public int getProximoIdCarrera()
        {
            return dao.ObtenerProximoNumero();
        }
    }
}
