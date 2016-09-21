using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Unidad
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Unidad()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion = new SqlConnection(Configs.CadenaConexion);
        }


        /// <summary>
        /// Lista todos los registros de la tabla
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            try
            {
                sql = "SELECT Id_unidad, Descripcion_unidad FROM Unidad";
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
