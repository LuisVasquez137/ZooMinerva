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
    public class Genero
    {
        public string ErrorEspecie,sql;
        SqlConnection conexion = null;
        DataTable tabla =null;

        /// <summary>
        /// constructor
        /// </summary>
        public Genero()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion=new SqlConnection(Configs.CadenaConexion);            
        }

        /// <summary>
        /// CREAR ESPECIE
        /// </summary>
        /// <param name="nombre">nombre especie</param>
        /// <param name="estado">estado de la especie</param>
        /// <returns></returns>
        public bool Create(string nombreComun,string nombreCientifico,int cantidad, int estado,int especie)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Genero(Nombre_comun,Nombre_Cientifico,Cantidad_Ejemplares,Estado,Id_especie) VALUES('"+nombreComun+"','"+nombreCientifico+"',"+cantidad+","+estado+","+especie+")";
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
        public bool Update(string nombreComun,string nombreCientifico,int cantidad, int estado,int especie,int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Genero set Nombre_comun='"+nombreComun+"',Nombre_Cientifico='"+nombreCientifico+"',Cantidad_ejemplares="+cantidad+",Estado="+estado+" WHERE Id_genero="+PK+"";
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
        public int Count(string nombreCientifico, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Genero where Nombre_cientifico='"+nombreCientifico+"' and Estado="+estado+"";
                SqlDataAdapter da=new SqlDataAdapter(sql,conexion);
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
                sql = "SELECT Id_genero,Nombre_comun,Nombre_cientifico,cantidad_ejemplares,Estado FROM genero";
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
                sql = "SELECT Id_genero,Nombre_comun,Nombre_cientifico,cantidad_ejemplares,Estado,Id_especie FROM genero WHERE Id_genero=" + pk + "";
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
        public DataTable Listar(string nombre,int estado)
        {
            try
            {
                sql = "SELECT Id_genero,Nombre_comun,Nombre_cientifico,cantidad_ejemplares,Estado FROM genero WHERE Estado=" + estado + " AND nombre_cientifico LIKE '%" + nombre + "%'";
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
