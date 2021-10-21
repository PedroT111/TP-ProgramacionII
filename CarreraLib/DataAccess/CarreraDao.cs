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
        public List<Materia> GetMaterias()
        {
            List<Materia> lstMateria = new List<Materia>();
            DataTable tabla = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_MATERIAS");
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
