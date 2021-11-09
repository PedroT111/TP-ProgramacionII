using CarreraLib.Entities;
using CarreraLib.Services;
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
        public bool CrearMateria(Materia oMateria)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nombre_materia", oMateria.NombreMateria));
            bool result = true;
            int materias = 0;
            materias = HelperDao.GetInstance().ConsultaConParametroEntrada("CREAR_MATERIA", parametros);

            if (materias == 0)
            {
                result = false;
            }

            return result;
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

        public bool DeleteMateria(int id)
        {
            List<Parametro> parametro = new List<Parametro>();
            parametro.Add(new Parametro("@id_materia", id));
            bool result = true;
            int files = 0;

            files = HelperDao.GetInstance().ConsultaConParametroEntrada("DELETE_MATERIA", parametro);

            if (files == 0)
            {
                result = false;
            }

            return result;

        }

        public bool EditarMateria(Materia oMateria)
        {
            bool result = false;
            result = HelperDao.GetInstance().EditarMateriaSQL(oMateria);

            return result;
        }

        public bool InsertarCarrera(Carrera oCarrera)
        {
            return HelperDao.GetInstance().EjecutarSQLMaestroDetalle("SP_INSERTAR_CARRERA", "SP_INSERTAR_DETALLE_CARRERA", oCarrera);
        }

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
        public int ObtenerProximoNumero()
        {
            return HelperDao.GetInstance().EjecutarSQLConValorOUT("SP_PROXIMO_ID_CARRERA", "@next");
        }

        public Carrera GetCarreraById(int id)
        {
            return HelperDao.GetInstance().GetById(id);        

        }

        public bool DeleteCarrera(int id)
        {
            List<Parametro> parametro = new List<Parametro>();
            parametro.Add(new Parametro("@nro", id));
            bool result = true;
            int files = 0;

            files = HelperDao.GetInstance().ConsultaConParametroEntrada("SP_ELIMINAR_PLAN_DE_ESTUDIO", parametro);

            if (files == 0)
            {
                result = false;
            }

            return result;
        }

        public bool EditCarrera(Carrera oCarrera)
        {
            return HelperDao.GetInstance().EjecutarSQLMaestroDetalle("SP_EDITAR_CARRERA", "SP_INSERTAR_DETALLE_CARRERA", oCarrera);
        }

        public bool LogIn(User oUser)
        {
            List<Parametro> parametro = new List<Parametro>();
            parametro.Add(new Parametro("@user", oUser.usuario));
            parametro.Add(new Parametro("@pass", oUser.pass));
            bool result = true;
            DataTable tabla;
            tabla = HelperDao.GetInstance().Login("SP_LOGIN", parametro);

            if (tabla.Rows.Count == 0)
            {
                result = false;
            }

            return result;
        }
    }
}
