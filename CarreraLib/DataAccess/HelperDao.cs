using CarreraLib.Entities;
using CarreraLib.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarreraLib.DataAccess
{
    class HelperDao
    {
        private static HelperDao instance;

        private string strConnection;
        public SqlConnection cnn { get; }
        public SqlCommand cmd { get; }

        private HelperDao()
        {
            strConnection = @"Data Source=DESKTOP-0QHUI5R\SQLEXPRESS;Initial Catalog=TP_PROGII2;Integrated Security=True";
            cnn = new SqlConnection(strConnection);
            cmd = new SqlCommand();
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }
        private ConnectionState ConnState()
        {
            return cnn.State;
        }

        public void Open()
        {
            if (ConnState().Equals(ConnectionState.Closed))
                cnn.Open();
        }

        public DataTable ConsultaSQL(string nombreSP)
        {
            DataTable tabla = new();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;
        }
        public int ConsultaConParametroEntrada(string nombreSP, List<Parametro> parametros)
        {
            int filas = 0;
            SqlTransaction trans = null;

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                trans = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = trans;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                foreach (Parametro p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                filas = cmd.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception)
            {
                trans.Rollback();
                filas =0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }

            return filas;
        }

        public DataTable GetConParametrosEntrada(string sp, List<Parametro> parametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                foreach (Parametro p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
                tabla = null;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open) cnn.Close();
            }

            return tabla;
        }

        public bool EjecutarSQLMaestroDetalle(string spMaestro, string spDetalle, Carrera oCarrera)
        {
            bool ok = true;
            SqlTransaction trans = null;

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                trans = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = trans;
                cmd.CommandText = spMaestro;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_carrera", Convert.ToInt32(oCarrera.IdCarrera));
                cmd.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmd.ExecuteNonQuery();

               
                foreach (DetalleCarrera item in oCarrera.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand();
                    cmdDet.Connection = cnn;
                    cmdDet.Transaction = trans;
                    cmdDet.CommandText = spDetalle;
                    cmdDet.CommandType = CommandType.StoredProcedure;

                    cmdDet.Parameters.AddWithValue("@anio_cursado", Convert.ToInt32(item.AnioCursado));
                    cmdDet.Parameters.AddWithValue("@cuatrimestre", Convert.ToInt32(item.Cuatrimestre));
                    cmdDet.Parameters.AddWithValue("@id_materia", Convert.ToInt32(item.Materia.IdMateria));
                    cmdDet.Parameters.AddWithValue("@id_carrera", Convert.ToInt32(oCarrera.IdCarrera));

                   cmdDet.ExecuteNonQuery();
                }

                trans.Commit();
            }
            catch (Exception)
            {
                trans.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open) cnn.Close();
            }

            return ok;
        }
               
        public int EjecutarSQLConValorOUT(string nombreSP, string nombreParametro)
        {
            SqlParameter param = new SqlParameter(nombreParametro, SqlDbType.Int);
            int val;
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                param.ParameterName = nombreParametro;
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteScalar();
                val = (int)param.Value;

            }
            catch (SqlException)
            {
                val = 0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return val;
        }

        public bool EditarMateriaSQL(Materia oMateria)
        {

            SqlTransaction transaction = null;
            bool flag = true;

            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_EDITAR_MATERIA", cnn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", oMateria.IdMateria);
                cmd.Parameters.AddWithValue("@nombre", oMateria.NombreMateria);
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                flag = false;
                throw;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flag;
        }


    }
}
