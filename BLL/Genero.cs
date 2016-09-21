using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Genero
    {
        DAL.Genero DTOGenero = new DAL.Genero();

        public bool Create(string nombreComun,string nombreCientifico,int cantidad, int estado,int especie)
        {
            return DTOGenero.Create(nombreComun,nombreCientifico,cantidad,estado,especie);
        }

        public bool Update(string nombreComun,string nombreCientifico,int cantidad,int estado, int especie, int pk)
        {
            return DTOGenero.Update(nombreComun,nombreCientifico,cantidad,estado,especie,pk);
        }

        public int Count(string nombreCientifico, int estado)
        {
            return DTOGenero.Count(nombreCientifico, estado);
        }

        public DataTable Listar()
        {
            return DTOGenero.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTOGenero.Listar(id);
        }

        public DataTable Listar(string nombre, int estado)
        {
            return DTOGenero.Listar(nombre, estado);
        }
    }
}
