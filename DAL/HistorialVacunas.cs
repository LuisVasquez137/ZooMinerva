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
    public class HistorialVacunas
    {
        public string ErrorEspecie, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public HistorialVacunas()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion = new SqlConnection(Configs.CadenaConexion);
        }

        /// <summary>
        /// HISTORIAL VACUNAS
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <param name="idVacuna"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public bool Create(int idAnimal, int idVacuna, DateTime fecha)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO HistorialVacunas(id_animal,id_vacuna,fecha) VALUES(" + idAnimal + "," + idVacuna + "," + fecha + ")";
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
        /// Fecha Vacuna
        /// </summary>
        /// <param name="idVacuna"></param>
        /// <param name="idAnimal"></param>
        /// <param name="fecha"></param>
        /// <param name="PK"></param>
        /// <returns></returns>
        public bool Update(int idVacuna, int idAnimal, DateTime fecha, int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE HistorialVacunas set id_animal=" + idAnimal + ",id_vacuna=" + idVacuna + ",fecha=" + fecha + " WHERE Id_historial_vacuna=" + PK + "";
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
        /// VALIDACION EXISTENCIA
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <param name="idVacuna"></param>
        /// <returns></returns>
        public int Count(int idAnimal, int idVacuna)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Historial_vacunas WHERE id_animal=+" + idAnimal + " and id_vacuna=" + idVacuna + "";
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
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal";
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
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal WHERE HV.id_historial_vacuna=" + pk + "";
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
        /// LISTAR
        /// </summary>
        /// <param name="nombreVacuna"></param>
        /// <param name="nombreAniaml"></param>
        /// <returns></returns>
        public DataTable Listar(string nombreVacuna, string nombreAniaml)
        {
            try
            {
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal WHERE V.nombre_vacuna like '%" + nombreVacuna + "%' AND A.Alias_animal like '%" + nombreAniaml + "%'";
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
    public class HistorialVacunas
    {
        public string ErrorEspecie,sql;
        SqlConnection conexion = null;
        DataTable tabla =null;

        /// <summary>
        /// constructor
        /// </summary>
        public HistorialVacunas()
        {
            sql = string.Empty;
            this.ErrorEspecie = string.Empty;
            tabla = new DataTable();
            conexion=new SqlConnection(Configs.CadenaConexion);            
        }

        /// <summary>
        /// HISTORIAL VACUNAS
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <param name="idVacuna"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public bool Create(int idAnimal,int idVacuna,DateTime fecha)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "INSERT INTO HistorialVacunas(id_animal,id_vacuna,fecha) VALUES("+idAnimal+","+idVacuna+","+fecha+")";
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
        /// Fecha Vacuna
        /// </summary>
        /// <param name="idVacuna"></param>
        /// <param name="idAnimal"></param>
        /// <param name="fecha"></param>
        /// <param name="PK"></param>
        /// <returns></returns>
        public bool Update(int idVacuna,int idAnimal,DateTime fecha,int PK)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE HistorialVacunas set id_animal="+idAnimal+",id_vacuna="+idVacuna+",fecha="+fecha+" WHERE Id_historial_vacuna="+PK+"";
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
        /// VALIDACION EXISTENCIA
        /// </summary>
        /// <param name="idAnimal"></param>
        /// <param name="idVacuna"></param>
        /// <returns></returns>
        public int Count(int idAnimal,int idVacuna)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Configs.CadenaConexion);
                sql = "SELECT *FROM Historial_vacunas WHERE id_animal=+"+idAnimal+" and id_vacuna="+idVacuna+"";
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
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal";
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
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal WHERE HV.id_historial_vacuna="+pk+"";
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
        /// LISTAR
        /// </summary>
        /// <param name="nombreVacuna"></param>
        /// <param name="nombreAniaml"></param>
        /// <returns></returns>
        public DataTable Listar(string nombreVacuna,string nombreAniaml)
        {
            try
            {
                sql = "select hv.Id_historial_vacuna,hv.Id_animal,hv.Id_vacuna,hv.Fecha_vacuna,V.Nombre_vacuna,V.Estado_vacuna,a.Codigo_animal,A.Alias_animal FROM HistorialVacunas HV INNER JOIN Vacunas V on v.Id_vacuna=hv.Id_vacuna INNER JOIN Animal A on A.Id_animal=HV.Id_animal WHERE V.nombre_vacuna like '%"+nombreVacuna+"%' AND A.Alias_animal like '%"+nombreAniaml+"%'";
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
