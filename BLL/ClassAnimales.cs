using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetAnimalTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassAnimales
    {
        private sp_DatosAnimalTableAdapter datos;

        private sp_DatosAnimalTableAdapter DATOS
        {
            get
            {
                if (datos == null)
                    datos= new sp_DatosAnimalTableAdapter();
                return datos;
            }
        }


        public DataTable Datos_diagnostico(string codigo)
        {
            return DATOS.Datos_animal (codigo);

        }
    }
}
