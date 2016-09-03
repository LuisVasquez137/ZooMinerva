using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetZoologicoTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassZoologico
    {
        private El_zooTableAdapter listado;
        private sp_listadoPaquetesTableAdapter listado_paquetes;

        private El_zooTableAdapter LISTADO
        {
            get
            {
                if (listado == null)
                    listado = new El_zooTableAdapter();
                return listado;
            }
        }


        private sp_listadoPaquetesTableAdapter LISTADO_PAQUETES
        {
            get
            {
                if (listado_paquetes == null)
                    listado_paquetes = new sp_listadoPaquetesTableAdapter();
                return listado_paquetes;
            }
        }

        public DataTable lista_zoologico()

        {
            return LISTADO.ListadoZoo();

        }

        public DataTable lista_paquetes()

        {
            return LISTADO_PAQUETES.Listado_paquetes();

        }

        public int Inserta_Paquete(string nombre, string tema, string objetivos, decimal donacion, string incluye)
        {

            return LISTADO_PAQUETES.sp_NuevoPaquete(nombre, tema, objetivos, donacion, incluye);

        }
    }
}
