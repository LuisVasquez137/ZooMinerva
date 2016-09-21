using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Origen
    {
        DAL.Origen DTOPersona = new DAL.Origen();

        public DataTable Listar()
        {
            return DTOPersona.Listar();
        }
    }
}
