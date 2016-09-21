using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Vacuna
    {
        DAL.Vacuna DTOVacuna = new DAL.Vacuna();

        public bool Create(string nombre, int estado)
        {
            return DTOVacuna.Create(nombre, estado);
        }

        public bool Update(string nombre, int estado, int PK)
        {
            return DTOVacuna.Update(nombre, estado, PK);
        }

        public int Count(string nombre, int estado)
        {
            return DTOVacuna.Count(nombre, estado);
        }

        public DataTable Listar()
        {
            return DTOVacuna.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOVacuna.Listar(id);
        }

        public DataTable Listar(string nombre, int estado)
        {
            return DTOVacuna.Listar(nombre, estado);
        }
    }
}
