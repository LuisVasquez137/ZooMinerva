using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Empleado
    {
        DAL.Empleado DTOEmpleado = new DAL.Empleado();

        public DataTable Listar()
        {
            return DTOEmpleado.Listar();
        }
    }
}
