<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// clase que modela la tabla vacuna
    /// </summary>
    public class Vacuna
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Vacuna()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion = new SqlConnection(Configs.CadenaConexion);
        }

        /// <summary>
        /// CREAR VACUNA
        /// </summary>
        /// <param name="nombreComun"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool Create(string nombre, int estado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Vacunas(Nombre_vacuna,estado_vacuna) VALUES('" + nombre + "'," + estado + ")";
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
        /// MODIFICAR VACUNA
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool Update(string nombre, int estado, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Vacunas set Nombre_vacuna='" + nombre + "',Estado_vacuna=" + estado + " WHERE Id_vacuna=" + PK + "";
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
        /// validacon existencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int Count(string nombre, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Vacunas WHERE nombre_vacuna='" + nombre + "' and Estado_vacuna=" + estado + "";
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
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas";
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
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas WHERE Id_vacuna=" + pk + "";
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
        public DataTable Listar(string nombre, int estado)
        {
            try
            {
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas WHERE Estado_vacuna=" + estado + " AND nombre_vacuna LIKE '%" + nombre + "%'";
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// clase que modela la tabla vacuna
    /// </summary>
    public class Vacuna
    {
        public string ErrorEspecie,sql;
        SqlConnection conexion = null;
        DataTable tabla =null;

        /// <summary>
        /// constructor
        /// </summary>
        public Vacuna()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion=new SqlConnection(Configs.CadenaConexion);            
        }

        /// <summary>
        /// CREAR VACUNA
        /// </summary>
        /// <param name="nombreComun"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool Create(string nombre,int estado)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Vacunas(Nombre_vacuna,estado_vacuna) VALUES('"+nombre+"',"+estado+")";
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
        /// MODIFICAR VACUNA
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool Update(string nombre, int estado,int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Vacunas set Nombre_vacuna='"+nombre+"',Estado_vacuna="+estado+" WHERE Id_vacuna="+PK+"";
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
        /// validacon existencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int Count(string nombre, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Vacunas WHERE nombre_vacuna='"+nombre+"' and Estado_vacuna="+estado+"";
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
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas";
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
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas WHERE Id_vacuna=" + pk + "";
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
                sql = "SELECT Id_vacuna,nombre_vacuna,estado_vacuna FROM vacunas WHERE Estado_vacuna=" + estado + " AND nombre_vacuna LIKE '%" + nombre + "%'";
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
>>>>>>> origin/master
