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
    public class Donacion
    {

        public string ErrorDonacion, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Donacion()
        {
            sql = string.Empty;
            this.ErrorDonacion = string.Empty;
            tabla = new DataTable();
            conexion = new SqlConnection(Configs.CadenaConexion);
        }

        /// <summary>
        /// CREAR ESPECIE
        /// </summary>
        /// <param name="nombre">nombre especie</param>
        /// <param name="estado">estado de la especie</param>
        /// <returns></returns>
        public bool Create(int idGenero, int idPersona, int idOrigen, int idEmpleado, string fechaDonacion, string motivoDonacion, string fechaIngreso, int estadoDonacion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO Donaciones(Id_genero,Id_Persona,Id_origen,Id_empleado,Fecha_donacion,Motivo_donacion,Fecha_ingreso_recinto,Estado_donacion) VALUES(" + idGenero + "," + idPersona + "," + idOrigen + "," + idEmpleado + ",'" + fechaDonacion + "','" + motivoDonacion + "','" + fechaIngreso + "'," + estadoDonacion + ")";
                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();
                return Configs.resultadoSQL(resultado);
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
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
        public bool Update(int idGenero, int idPersona, int idOrigen, int idEmpleado, string fechaDonacion, string motivoDonacion, string fechaIngreso, int estadoDonacion, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Donaciones set id_genero=" + idGenero + ",id_persona=" + idPersona + ",id_origen=" + idOrigen + ",id_empleado=" + idEmpleado + ",Fecha_donacion='" + fechaDonacion + "',Motivo_donacion='" + motivoDonacion + "',Fecha_ingreso_recinto='" + fechaIngreso + "',Estado_donacion=" + estadoDonacion + "  WHERE Id_donacion=" + PK + "";
                int resultado = cmd.ExecuteNonQuery();
                conexion.Close();
                return Configs.resultadoSQL(resultado);
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
                return false;
            }
        }

        /// <summary>
        /// Validacion de existencia
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public int Count(string motivoDonacion, int estado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *from Donaciones where Motivo_donacion='" + motivoDonacion + "' AND Estado_donacion=" + estado + "";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                da.Fill(tabla);
                return tabla.Rows.Count;
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
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
                sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM donaciones";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
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
                sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM Donaciones WHERE Id_donacion=" + pk + "";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
                return tabla;
            }
        }

        /// <summary>
        /// Listado por coincidencia al nombre y estado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public DataTable Listar(string motivo, int estado)
        {
            try
            {
                sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM donaciones WHERE Estado_donacion=" + estado + " AND  Motivo_donacion LIKE '%" + motivo + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                this.ErrorDonacion = ex.Message.ToString();
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
    public class Donacion
    {
        
            public string ErrorDonacion, sql;
            SqlConnection conexion = null;
            DataTable tabla = null;

            /// <summary>
            /// constructor
            /// </summary>
            public Donacion()
            {
                sql = string.Empty;
                this.ErrorDonacion = string.Empty;
                tabla = new DataTable();
                conexion = new SqlConnection(Configs.CadenaConexion);
            }

            /// <summary>
            /// CREAR ESPECIE
            /// </summary>
            /// <param name="nombre">nombre especie</param>
            /// <param name="estado">estado de la especie</param>
            /// <returns></returns>
            public bool Create(int idGenero,int idPersona,int idOrigen,int idEmpleado,string fechaDonacion,string motivoDonacion,string fechaIngreso,int estadoDonacion)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    conexion.Open();
                    cmd.Connection = conexion;
                    cmd.CommandText = "INSERT INTO Donaciones(Id_genero,Id_Persona,Id_origen,Id_empleado,Fecha_donacion,Motivo_donacion,Fecha_ingreso_recinto,Estado_donacion) VALUES("+idGenero+","+idPersona+","+idOrigen+","+idEmpleado+",'"+fechaDonacion+"','"+motivoDonacion+"','"+fechaIngreso+"'," + estadoDonacion + ")";
                    int resultado = cmd.ExecuteNonQuery();
                    conexion.Close();
                    return Configs.resultadoSQL(resultado);
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
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
            public bool Update(int idGenero, int idPersona, int idOrigen, int idEmpleado, string fechaDonacion, string motivoDonacion, string fechaIngreso, int estadoDonacion, int PK)
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = "UPDATE Donaciones set id_genero="+idGenero+",id_persona="+idPersona+",id_origen="+idOrigen+",id_empleado="+idEmpleado+",Fecha_donacion='"+fechaDonacion+"',Motivo_donacion='"+motivoDonacion+"',Fecha_ingreso_recinto='"+fechaIngreso+"',Estado_donacion="+estadoDonacion+"  WHERE Id_donacion=" + PK + "";
                    int resultado = cmd.ExecuteNonQuery();
                    conexion.Close();
                    return Configs.resultadoSQL(resultado);
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
                    return false;
                }
            }

            /// <summary>
            /// Validacion de existencia
            /// </summary>
            /// <param name="nombre"></param>
            /// <param name="estado"></param>
            /// <returns></returns>
            public int Count(string motivoDonacion, int estado)
            {
                try
                {
                    SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                    sql = "SELECT *from Donaciones where Motivo_donacion='" + motivoDonacion + "' AND Estado_donacion=" + estado + "";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                    da.Fill(tabla);
                    return tabla.Rows.Count;
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
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
                    sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM donaciones";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
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
                    sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM Donaciones WHERE Id_donacion=" + pk + "";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
                    return tabla;
                }
            }

            /// <summary>
            /// Listado por coincidencia al nombre y estado
            /// </summary>
            /// <param name="nombre"></param>
            /// <param name="estado"></param>
            /// <returns></returns>
            public DataTable Listar(string motivo, int estado)
            {
                try
                {
                    sql = "SELECT Id_donacion,id_genero,id_persona,id_origen,id_empleado,fecha_donacion,motivo_donacion,fecha_ingreso_recinto,estado_donacion FROM donaciones WHERE Estado_donacion=" + estado + " AND  Motivo_donacion LIKE '%" + motivo + "%'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    this.ErrorDonacion = ex.Message.ToString();
                    return tabla;
                }
            }
        }
    
}
>>>>>>> origin/master
