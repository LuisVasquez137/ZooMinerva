using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.DataSetNoticiasTableAdapters;

namespace BLL
{
    public class ClassNoticias
    {
        private sp_listadoNoticiasTableAdapter listado;
        private NoticiasTableAdapter noticias;

        private sp_listadoNoticiasTableAdapter LISTADO
        {
            get
            {
                if (listado == null)
                    listado = new sp_listadoNoticiasTableAdapter();
                return listado;
            }
        }

        private NoticiasTableAdapter LISTADO2
        {
            get
            {
                if (noticias == null)
                    noticias = new NoticiasTableAdapter();
                return noticias;
            }
        }

        public DataTable lista_noticias()

        {
            return LISTADO.ListadoNoticias();

        }

        public DataTable lista_noticas2()
        {
            return LISTADO2.ListadoNoti();
        }

    }
}
