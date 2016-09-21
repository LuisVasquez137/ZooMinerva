using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Configs
    {
        /// <summary>
        /// Campo para la cadena de conexion
        /// </summary>

        public static string CadenaConexion = "Data Source=EDGAR_CAP\\SQLCAP;Initial Catalog=BDZoologicoMinerva;Integrated Security=True";

        /// <summary>
        /// metodo para devolver resultados en operaciones CUD
        /// </summary>
        /// <param name="resultado"></param>
        /// <returns></returns>
        public static bool resultadoSQL(int resultado)
        {
            if (resultado>0)
                return true;
            else
                return false;
        }        
    }
}
