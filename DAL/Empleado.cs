using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Empleado
    {
        public string Error, sql;
        SqlConnection conexion = null;
        DataTable tabla = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Empleado()
        {
            sql = string.Empty;
            this.Error = string.Empty;
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
                sql = "select Id_empleado,Id_cargo,Nombre_empleado,Apellido_empleado,Telefono_empleado,Direccion_empleado,Fecha_ingreso,Estado_empleado,Usuario,contrasenia from Empleado where id_cargo=1";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                this.Error = ex.Message.ToString();
                return tabla;
            }
        }
    }
}
