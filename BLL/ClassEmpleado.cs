using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetEmpleadoTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassEmpleado
    {
       private procedimiento_verificacionTableAdapter pro_verificacion;
        private sp_listadoEmpleadosTableAdapter listado;
        private Cargo_EmpleadoTableAdapter cargos;
        private EmpleadoTableAdapter empleado;
        private ListaEmpleadoCodigoTableAdapter porCodigo;

    
    private procedimiento_verificacionTableAdapter PROC
    {
        get
        {
            if ( pro_verificacion== null)
                pro_verificacion = new procedimiento_verificacionTableAdapter();
            return pro_verificacion;
        }
    }
        private EmpleadoTableAdapter EMP
        {
            get
            {
                if (empleado == null)
                    empleado = new EmpleadoTableAdapter();
                return empleado;
            }
        }

        private sp_listadoEmpleadosTableAdapter LISTADO
        {
            get
            {
                if (listado == null)
                    listado = new sp_listadoEmpleadosTableAdapter();
                return listado;
            }
        }

        private ListaEmpleadoCodigoTableAdapter PORCODIGO
        {
            get
            {
                if (porCodigo == null)
                    porCodigo = new ListaEmpleadoCodigoTableAdapter();
                return porCodigo;
            }
        }

        private Cargo_EmpleadoTableAdapter CARGO
        {
            get
            {
                if (cargos == null)
                    cargos = new Cargo_EmpleadoTableAdapter();
                return cargos;
            }
        }
        public DataTable Loguear_usuario(string usuar, string contras)
        {
            return PROC.VerificacionUsuario(usuar, contras);

        }
        public DataTable Lista_empleados()
        {
            return LISTADO.Lista_empleados();

        }

        public DataTable Lista_cargos()
        {
            return CARGO.ListadoCargos();

        }

        public int Inserta_Empleado(int tip, string nom, string ape, string tel, string dir, DateTime fech, bool estado, string usua, string cont)
        {

            return EMP.sp_NuevoEmpleado(tip, nom, ape, tel, dir,fech,estado, usua, cont);

        }

        public string ActualizaEmpleado(int id_tip, string nom, string ape, string tel, string dir, string usu, string con, DateTime fech, bool est, int id)
        {
            if (nom != "")
            {
                EMP.sp_Actualiza_Empleado(id_tip,id, nom, ape, tel, dir, fech, est, usu, con);
                return "Sea ha actualizado Los datos del empleado";
            }
            else
            {
                return "Error, no ha sido posible la actualizacion";
            }
        }

        public int Baja_Empleado(int codi)
        {
            return EMP.sp_Baja_Empleado(codi);
        }

        public int Inserta_Cargos(string nomb, string desc)
        {
            return CARGO.InsertaCargo(nomb, desc);
        }

        public DataTable ListadoCodigo(int cod)
        {
            return PORCODIGO.ListadoEmpleadosPorCodigo(cod);
        }
    }

}
