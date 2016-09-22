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
    /// Clase que mapea a la tabla BD Especie
    /// </summary>
    public class Dieta
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Dieta()
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
        public bool Create(int idGenero, int idIngrediente, int idUnidad, int peso, string presentacion, int estado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Dieta(Id_Genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado) VALUES(" + idGenero + "," + idIngrediente + "," + idUnidad + "," + peso + ",'" + presentacion + "'," + estado + ")";
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
        public bool Update(int idGenero, int idIngrediente, int idUnidad, int peso, string presentacion, int estado, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Dieta set Id_Genero=" + idGenero + ",Id_Ingrediente=" + idIngrediente + ",Id_Unidad=" + idUnidad + ",peso=" + peso + ",presentacion='" + presentacion + "',estado=" + estado + " WHERE idDieta=" + PK + "";
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
        public int Count(string presentacion, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM dieta where Presentacion='" + presentacion + "' AND Estado=" + estado + "";
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
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta";
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
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta WHERE iddieta=" + pk + "";
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
        public DataTable Listar(string presentacion, int estado)
        {
            try
            {
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta WHERE Estado=" + estado + " AND  presentacion LIKE '%" + presentacion + "%'";
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
    /// Clase que mapea a la tabla BD Especie
    /// </summary>
    public class Dieta
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Dieta()
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
        public bool Create(int idGenero,int idIngrediente,int idUnidad,int peso,string presentacion,int estado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Dieta(Id_Genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado) VALUES("+idGenero+","+idIngrediente+","+idUnidad+","+peso+",'"+presentacion+"',"+estado+")";
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
        public bool Update(int idGenero,int idIngrediente,int idUnidad,int peso,string presentacion, int estado, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Dieta set Id_Genero="+idGenero+",Id_Ingrediente="+idIngrediente+",Id_Unidad="+idUnidad+",peso="+peso+",presentacion='"+presentacion+"',estado="+estado+" WHERE idDieta=" + PK + "";
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
        public int Count(string presentacion, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM dieta where Presentacion='" + presentacion + "' AND Estado=" + estado + "";
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
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta";
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
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta WHERE iddieta=" + pk + "";
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
        public DataTable Listar(string presentacion, int estado)
        {
            try
            {
                sql = "SELECT idDieta,Id_genero,Id_Ingrediente,Id_Unidad,Peso,Presentacion,Estado FROM dieta WHERE Estado=" + estado + " AND  presentacion LIKE '%" + presentacion + "%'";
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
