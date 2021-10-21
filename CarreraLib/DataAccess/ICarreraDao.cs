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

    }
}
