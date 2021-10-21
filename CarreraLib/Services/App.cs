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
    }
}
