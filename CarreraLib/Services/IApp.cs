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
    }
}
