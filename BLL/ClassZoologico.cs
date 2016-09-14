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
        private RegistroTableAdapter registro;
        private Sp_ObtienePrecioTableAdapter precio;


        private Sp_ObtienePrecioTableAdapter PRECIO
        {
            get
            {
                if (precio == null)
                    precio = new Sp_ObtienePrecioTableAdapter();
                return precio;
            }
        }


        private RegistroTableAdapter REGISTRO
        {
            get
            {
                if (registro == null)
                    registro = new RegistroTableAdapter();
                return registro;
            }
        }
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

        public int Actualiza_Registro(int Id_paquete, int Id_empleado,DateTime Fecha_visita,string Hora_ingreso,string Establecimiento,string Direccion_establecimiento,int NoAlumnos,string Grado,string Telefono_establecimiento,string Coentarios)
        {
            return REGISTRO.ActualizaRegistro(Id_paquete, Id_empleado, Fecha_visita, Hora_ingreso, Establecimiento, Direccion_establecimiento, NoAlumnos, Grado,  Telefono_establecimiento, Coentarios);
        }
        public int Inserta_Registro(int Id_paquete,int Id_empleado,DateTime Fecha_visita,string Hora_ingreso,string Establecimiento,string Direccion_establecimiento,int NoAlumnos,string Grado,decimal Donacion,string Telefono_establecimiento,string Coentarios)
        {
            return REGISTRO.sp_InsertaRegistro(Id_paquete, Id_empleado, Fecha_visita, Hora_ingreso, Establecimiento, Direccion_establecimiento, NoAlumnos, Grado, Donacion, Telefono_establecimiento, Coentarios);
        }


        public DataTable precio_paquete(int nombre)

        {
            return PRECIO.ObtienePrecio(nombre);

        }
        public int Actualiza_Zoo(string Zoo,string Mision, string Vision, string Direccion, string Telefono, string facebook, byte[] mapa, string Horario, int idzoo )
        {
            return LISTADO.ActualilzaZoo3(Zoo, Mision, Vision, Direccion, Telefono, facebook, mapa, Horario, idzoo);
        }
    }
}
