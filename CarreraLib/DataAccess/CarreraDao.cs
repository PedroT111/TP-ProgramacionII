using CarreraLib.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.DataAccess
{
    class CarreraDao : ICarreraDao
    {
        public List<Carrera> GetCarrera()
        {
            List<Carrera> lstCarrera = new List<Carrera>();
            DataTable tabla = HelperDao.GetInstance().ConsultaSQL("CONSULTAR_CARRERAS");
            foreach (DataRow row in tabla.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.IdCarrera = Convert.ToInt32(row["id_carrera"].ToString());
                oCarrera.Nombre = row["nombre_carrera"].ToString();

                lstCarrera.Add(oCarrera);
            }
            return lstCarrera;
        }

        public List<Materia> GetMaterias()
        {
            List<Materia> lstMateria = new List<Materia>();
            DataTable tabla = HelperDao.GetInstance().ConsultaSQL("CONSULTAR_MATERIAS");
            foreach (DataRow row in tabla.Rows)
            {
                Materia oMateria = new Materia();
                oMateria.IdMateria = Convert.ToInt32(row["id_materia"].ToString());
                oMateria.NombreMateria = row["nombre_materia"].ToString();

                lstMateria.Add(oMateria);
            }
            return lstMateria;
        }
    }
}
