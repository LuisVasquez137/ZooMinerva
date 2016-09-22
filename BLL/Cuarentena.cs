<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Cuarentena
    {

        DAL.Cuarentena obj = new DAL.Cuarentena();

        /// <summary>
        /// LISTADO GENERAL
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            return obj.Listar();
        }

        /// <summary>
        /// CREAR
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="fechaRecinto"></param>
        /// <param name="cuarentena"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool create(int codigo, string fecha, string descripcion, string fechaRecinto, int cantidad, int estado)
        {
            try
            {
                obj.Create(codigo, fecha, descripcion, fechaRecinto, cantidad, estado);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="fechaRecinto"></param>
        /// <param name="cuarentena"></param>
        /// <param name="estado"></param>
        /// <param name="pk"></param>
        /// <returns></returns>
        public bool update(int codigo, string fecha, string descripcion, string fechaRecinto, int cantidad, int estado, int pk)
        {
            try
            {
                obj.Update(codigo, fecha, descripcion, fechaRecinto, cantidad, estado, pk);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Cuarentena
    {

        DAL.Cuarentena obj = new DAL.Cuarentena();

        /// <summary>
        /// LISTADO GENERAL
        /// </summary>
        /// <returns></returns>
        public DataTable Listar()
        {
            return obj.Listar();
        }

        /// <summary>
        /// CREAR
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="fechaRecinto"></param>
        /// <param name="cuarentena"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool create(int codigo, string fecha,string descripcion,string fechaRecinto,int cantidad, int estado)
        {
            try
            {
                obj.Create(codigo, fecha, descripcion, fechaRecinto, cantidad, estado);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="fecha"></param>
        /// <param name="descripcion"></param>
        /// <param name="fechaRecinto"></param>
        /// <param name="cuarentena"></param>
        /// <param name="estado"></param>
        /// <param name="pk"></param>
        /// <returns></returns>
        public bool update(int codigo, string fecha, string descripcion, string fechaRecinto, int cantidad, int estado,int pk)
        {
            try
            {
                obj.Update(codigo, fecha, descripcion, fechaRecinto, cantidad, estado, pk);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
>>>>>>> origin/master
