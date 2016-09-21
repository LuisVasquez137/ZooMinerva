using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Dieta
    {
        DAL.Dieta DTODieta = new DAL.Dieta();

        public bool Create(int idGenero,int idIngrediente,int peso,int idUnidad,string presentacion, int estado)
        {
            return DTODieta.Create(idGenero,idIngrediente,idUnidad,peso,presentacion,estado);
        }

        public bool Update(int idGenero, int idIngrediente, int peso, int idUnidad, string presentacion, int estado, int pk)
        {
            return DTODieta.Update(idGenero,idIngrediente,idUnidad,peso,presentacion,estado,pk);
        }

        public int Count(string presentacion, int estado)
        {
            return DTODieta.Count(presentacion, estado);
        }

        public DataTable Listar()
        {
            return DTODieta.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTODieta.Listar(id);
        }

        public DataTable Listar(string presentacion, int estado)
        {
            return DTODieta.Listar(presentacion, estado);
        }
    }
}
