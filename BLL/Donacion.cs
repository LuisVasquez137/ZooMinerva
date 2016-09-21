using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Donacion
    {
        DAL.Donacion DTODonacion = new DAL.Donacion();
        
        public bool Create(int id_genero,int id_persona,int id_origen,int id_empleado,string fecha_donacion,string motivo_donacion,string fecha_ingreso_recinto, int estado_donacion)
        {
            return DTODonacion.Create(id_genero, id_persona, id_origen, id_empleado, fecha_donacion, motivo_donacion, fecha_ingreso_recinto, estado_donacion);
        }

        public bool Update(int id_genero, int id_persona, int id_origen, int id_empleado, string fecha_donacion, string motivo_donacion, string fecha_ingreso_recinto,int estadoDonacion, int pk)
        {
            return DTODonacion.Update(id_genero, id_persona, id_origen, id_empleado, fecha_donacion, motivo_donacion, fecha_ingreso_recinto, estadoDonacion, pk);
        }
        
        public int Count(string Motivo_donacion, int estado)
        {
            return DTODonacion.Count(Motivo_donacion, estado);
        }

        public DataTable Listar()
        {
            return DTODonacion.Listar();
        }

        public DataTable Listar(int id)
        {
            return DTODonacion.Listar(id);
        }

        public DataTable Listar(string motivo, int estado)
        {
            return DTODonacion.Listar(motivo, estado);
        }
    }
}
