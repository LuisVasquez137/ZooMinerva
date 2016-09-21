using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class Animal
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Animal()
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
        public bool Create(string codigo_animal, string alias_animal, string sexo_animal, int estado_animal, int edad_animal, string fecha_nacimiento, string fecha_muerte, string causa_muerte, int id_genero)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Animal(codigo_animal,alias_animal,sexo_animal,estado_animal,edad_animal,fecha_nacimiento,fecha_muerte,causa_muerte,id_genero) VALUES('" + codigo_animal + "','" + alias_animal + "','" + sexo_animal + "'," + estado_animal + "," + edad_animal + ",'" + fecha_nacimiento + "','" + fecha_muerte + "','" + causa_muerte + "'," + id_genero + ")";
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
        public bool Update(string codigo_animal, string alias_animal, string sexo_animal, int estado_animal, int edad_animal, string fecha_nacimiento, string fecha_muerte, string causa_muerte, int id_genero, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Animal set codigo_animal='" + codigo_animal + "',alias_animal='" + alias_animal + "',sexo_animal='" + sexo_animal + "',estado_animal=" + estado_animal + ",fecha_nacimiento='" + fecha_nacimiento + "',fecha_muerte='" + fecha_muerte + "',causa_muerte='" + causa_muerte + "',id_genero=" + id_genero + " WHERE Id_animal=" + PK + "";
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
        public int Count(string codigoAnimal, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Animal where codigo_animal='" + codigoAnimal + "' and Estado_animal=" + estado + "";
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
                sql = "SELECT id_animal,codigo_animal,alias_animal,sexo_animal,estado_animal,edad_animal,fecha_nacimiento,fecha_muerte,causa_muerte,id_genero FROM Animal";
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
                sql = "SELECT id_animal,codigo_animal,alias_animal,sexo_animal,estado_animal,edad_animal,fecha_nacimiento,fecha_muerte,causa_muerte,id_genero FROM Animal WHERE Id_animal=" + pk + "";
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
        public DataTable Listar(string codigo, int estado)
        {
            try
            {
                sql = "SELECT id_animal,codigo_animal,alias_animal,sexo_animal,estado_animal,edad_animal,fecha_nacimiento,fecha_muerte,causa_muerte,id_genero FROM Animal WHERE Estado_animal=" + estado + " AND codigo_animal LIKE '%" + codigo + "%'";
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
