using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Especie
    {
        DAL.Especie DTOEspecie = new DAL.Especie();

        public bool Create(string nombre, int estado)
        {
            return DTOEspecie.Create(nombre, estado);
        }

        public bool Update(string nombre, int estado, int pk)
        {
            return DTOEspecie.Update(nombre, estado, pk);
        }

        public int Count(string nombre, int estado)
        {
            return DTOEspecie.Count(nombre, estado);
        }

        public DataTable Listar()
        {
            return DTOEspecie.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOEspecie.Listar(id);
        }

        public DataTable Listar(string nombre, int estado)
        {
            return DTOEspecie.Listar(nombre, estado);
        }
    }
}
