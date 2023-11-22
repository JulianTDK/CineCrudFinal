using CineBack.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos
{
    internal class HelperDao
    {
        private SqlConnection cnn;
        private static HelperDao instance;

        private HelperDao()
        {
            cnn = new SqlConnection("Data Source=LAPTOP-NG836ULB\\SQLEXPRESS;Initial Catalog=CINE;Integrated Security=True");
        }

        public static HelperDao GetInstance()
        {
            if (instance == null)
                instance = new HelperDao();
            return instance;
        }

        public SqlConnection GetCnn()
        {
            return cnn;
        } 
        
        public DataTable GetTable(string nombreSP)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            cnn.Close();

            return table;
        }

        public DataTable GetTable(string nombreSP, List<Parametro> lParams)
        {
            cnn.Open();

            SqlCommand cmd = new SqlCommand(nombreSP, cnn);
            cmd.CommandType= CommandType.StoredProcedure;

            cmd.Parameters.Clear();

            foreach (Parametro param in lParams)
            {
                if (param.Valor == null)
                    cmd.Parameters.AddWithValue(param.Nombre, DBNull.Value);
                else
                {
                    if (DateTime.TryParse(param.Valor.ToString(), out DateTime fecha))
                        cmd.Parameters.AddWithValue(param.Nombre, fecha);
                    else
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor.ToString());
                }
            }

            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            cnn.Close();

            return table;
        }
    }
}
