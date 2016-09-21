using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Unidad
    {
        DAL.Unidad DTODieta = new DAL.Unidad();

        public DataTable Listar()
        {
            return DTODieta.Listar();
        }

    }
}
