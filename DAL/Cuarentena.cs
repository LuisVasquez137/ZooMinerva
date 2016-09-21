using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Mapeo de la tabla Genero
    /// </summary>
    public class Cuarentena
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Cuarentena()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion = new SqlConnection(Configs.CadenaConexion);
        }

        /// <summary>
        /// CREAR ESPECIE
        /// </summary>
        /// <param name="nombre">nombre especie</param>
        /// <param name="estado">estado de la especie</param>
        /// <returns></returns>
        public bool Create(int animal, string fecha, string descripcion, string fechaRecinto, int cantidad, int estado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = @"INSERT INTO Cuarentena(Id_animal,Fecha,Descripcion_cuarentena,Fecha_recinto,Cantidad_Cuarentena,Estado_Cuarentena) 
                    VALUES(" + animal + ",'" + fecha + "','" + descripcion + "','" + fechaRecinto + "'," + cantidad + "," + estado + ")";
                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();
                return Configs.resultadoSQL(resultado);
            }
            catch (Exception ex)
            {
                this.ErrorEspecie = ex.Message.ToString();
                conexion.Close();
                return false;
            }
        }

        /// <summary>
        /// MODIFICAR ESPECIE
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="PK"></param>
        /// <returns></returns>
        public bool Update(int animal, string fecha, string descripcion, string fechaRecinto, int cantidad, int estado, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Cuarentena set Id_animal=" + animal + ",Fecha='" + fecha + "',Descripcion_cuarentena='" + descripcion + "',Fecha_recinto='" + fechaRecinto + "',Cantidad_cuarentena=" + cantidad + ",Estado_cuarentena=" + estado + " WHERE Id_cuarentena=" + PK + "";
                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();
                return Configs.resultadoSQL(resultado);
            }
            catch (Exception ex)
            {
                this.ErrorEspecie = ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// Validacion de existencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int Count(string descripcion, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Cuarentena where Descripcion_cuarentena='" + descripcion + "' and Estado_cuarentena=" + estado + "";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                da.Fill(tabla);
                return tabla.Rows.Count;
            }
            catch (Exception ex)
            {
                this.ErrorEspecie = ex.Message.ToString();
                return -1;
            }
        }

        /// <summary>
        /// Lista todos los registros de la tabla
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            try
            {
                sql = "SELECT Id_cuarentena,Id_animal,Fecha,Descripcion_cuarentena,Fecha_recinto,Cantidad_cuarentena,Estado_cuarentena FROM Cuarentena";
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

        /// <summary>
        /// Listado por estado
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public DataTable Listar(int pk)
        {
            try
            {
                sql = "SELECT Id_cuarentena,Id_animal,Fecha,Descripcion_cuarentena,Fecha_recinto,Cantidad_cuarentena,Estado_cuarentena FROM Cuarentena WHERE Id_cuarentena=" + pk + "";
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

        /// <summary>
        /// Listado por coincidencia al nombre y estado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public DataTable Listar(string descripcion, int estado)
        {
            try
            {
                sql = "SELECT Id_cuarentena,Id_animal,Fecha,Descripcion_cuarentena,Fecha_recinto,Cantidad_cuarentena,Estado_cuarentena FROM Cuarentena WHERE Estado_cuarentena=" + estado + " AND descripcion_cuarentena LIKE '%" + descripcion + "%'";
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
