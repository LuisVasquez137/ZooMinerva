using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Ingrediente
    {
        public string ErrorEspecie,sql;
        SqlConnection conexion = null;
        DataTable tabla =null;

        /// <summary>
        /// constructor
        /// </summary>
        public Ingrediente()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion=new SqlConnection(Configs.CadenaConexion);            
        }


        /// <summary>
        /// Lista todos los registros de la tabla
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            try
            {
                sql = "SELECT Id_ingrediente, Ingrediente FROM Ingrediente";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                this.ErrorEspecie = ex.Message.ToString();
                return tabla;
            }
        }

    }
}
