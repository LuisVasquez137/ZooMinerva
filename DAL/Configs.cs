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

<<<<<<< HEAD
        public static string CadenaConexion = "Data Source=EDGAR_CAP\\SQLCAP;Initial Catalog=BDZoologicoMinerva;Integrated Security=True";
=======
        public static string CadenaConexion = "Data Source=WINDOWS-SFCQVL1;Initial Catalog=BDzoologicoMinerva;Integrated Security=True";
>>>>>>> origin/master

        /// <summary>
        /// metodo para devolver resultados en operaciones CUD
        /// </summary>
        /// <param name="resultado"></param>
        /// <returns></returns>
        public static bool resultadoSQL(int resultado)
        {
            if (resultado > 0)
                return true;
            else
                return false;
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> origin/master
