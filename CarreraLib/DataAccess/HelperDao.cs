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
        private DataTable table { get; set; }

        private HelperDao()
        {
            strConnection = @"Data Source=DESKTOP-0QHUI5R\SQLEXPRESS;Initial Catalog=TP_PROGII;Integrated Security=True";
            cnn = new SqlConnection(strConnection);
            cmd = new SqlCommand();
            table = new DataTable();
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
    }
}
