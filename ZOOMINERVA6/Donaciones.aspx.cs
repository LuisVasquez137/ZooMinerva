<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using GemBox.Spreadsheet;

namespace ZOOMINERVA6
{
    public partial class Donaciones : System.Web.UI.Page
    {
        Donacion miDonacion = new Donacion();
        bool guardando = false;
        int PK = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = miDonacion.Listar();
            gvListado.DataBind();
            guardando = false;
            lblMensajes.Visible = false;
            cargarGeneros();
            cargarOrigen();
            cargarPersona();
            cargarEmpleado();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        /// <summary>
        /// REFRESCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// BUSCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }

        }

        /// <summary>
        /// editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                guardando = false;
                if (Validar())
                {
                    miDonacion.Update(Convert.ToInt32(ddlGenero.SelectedValue), Convert.ToInt32(ddlPersona.SelectedValue), Convert.ToInt32(ddlOrigen.SelectedValue), Convert.ToInt32(ddlEmpleado.SelectedValue), txtFechaDonacion.Text.Trim(), txtMotivo.Text.Trim(), txtFechaIngreso.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue), PK);
                    gvListado.DataSource = miDonacion.Listar();
                    gvListado.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }

        }

        /// <summary>
        /// CREAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardando = true;
                if (Validar())
                {
                    miDonacion.Create(Convert.ToInt32(ddlGenero.SelectedValue), Convert.ToInt32(ddlPersona.SelectedValue), Convert.ToInt32(ddlOrigen.SelectedValue), Convert.ToInt32(ddlEmpleado.SelectedValue), txtFechaDonacion.Text.Trim(), txtMotivo.Text.Trim(), txtFechaIngreso.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataSource = miDonacion.Listar();
                    gvListado.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }
        }

        #region metodoslocales
        bool Validar()
        {
            Validador obj = new Validador();
            if (!obj.FechaCorrecta(txtFechaIngreso.Text.Trim()))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Revisar formato de fecha: YYYY-MM-DD";
                return false;
            }

            if (!obj.FechaCorrecta(txtFechaDonacion.Text.Trim()))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Revisar formato de fecha: YYYY-MM-DD";
                return false;
            }
            return true;
        }

        void cargarGeneros()
        {
            Genero genero = new Genero();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlGenero.DataSource = listadoEspecies;
            ddlGenero.DataValueField = "Id_genero";
            ddlGenero.DataTextField = "Nombre_cientifico";
            ddlGenero.DataBind();
        }


        void cargarOrigen()
        {
            Origen genero = new Origen();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlOrigen.DataSource = listadoEspecies;
            ddlOrigen.DataValueField = "Id_origen";
            ddlOrigen.DataTextField = "Nombre_origen";
            ddlOrigen.DataBind();
        }

        void cargarPersona()
        {
            Persona genero = new Persona();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlPersona.DataSource = listadoEspecies;
            ddlPersona.DataValueField = "Id_persona";
            ddlPersona.DataTextField = "Nombre_persona";
            ddlPersona.DataBind();
        }

        void cargarEmpleado()
        {
            Empleado genero = new Empleado();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlEmpleado.DataSource = listadoEspecies;
            ddlEmpleado.DataValueField = "Id_empleado";
            ddlEmpleado.DataTextField = "Nombre_empleado";
            ddlEmpleado.DataBind();
        }

        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Donaciones");

            ws.Cells[0, 0].Value = "COD DONACION:";
            ws.Cells[0, 1].Value = "COD GENERO";
            ws.Cells[0, 2].Value = "COD PERSONA";
            ws.Cells[0, 3].Value = "COD ORIGEN";
            ws.Cells[0, 4].Value = "COD EMPLEADO";
            ws.Cells[0, 5].Value = "FECHA DONACION";
            ws.Cells[0, 6].Value = "MOTIVO DONACION";
            ws.Cells[0, 7].Value = "FECHA INGRESO";
            ws.Cells[0, 8].Value = "ESTADO";


            DataTable reporte = new DataTable();
            reporte = miDonacion.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[6].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[7].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[8].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Donaciones.xls");
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using GemBox.Spreadsheet;

namespace ZOOMINERVA6
{
    public partial class Donaciones : System.Web.UI.Page
    {
        Donacion miDonacion = new Donacion();
        bool guardando = false;
        int PK = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = miDonacion.Listar();
            gvListado.DataBind();
            guardando = false;
            lblMensajes.Visible = false;
            cargarGeneros();
            cargarOrigen();
            cargarPersona();
            cargarEmpleado();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        /// <summary>
        /// REFRESCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// BUSCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }

        }

        /// <summary>
        /// editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                guardando = false;
                if (Validar())
                {
                    miDonacion.Update(Convert.ToInt32(ddlGenero.SelectedValue), Convert.ToInt32(ddlPersona.SelectedValue), Convert.ToInt32(ddlOrigen.SelectedValue), Convert.ToInt32(ddlEmpleado.SelectedValue), txtFechaDonacion.Text.Trim(), txtMotivo.Text.Trim(), txtFechaIngreso.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue),PK);
                    gvListado.DataSource = miDonacion.Listar();
                    gvListado.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }

        }

        /// <summary>
        /// CREAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardando = true;
                if (Validar())
                {
                    miDonacion.Create(Convert.ToInt32(ddlGenero.SelectedValue), Convert.ToInt32(ddlPersona.SelectedValue), Convert.ToInt32(ddlOrigen.SelectedValue), Convert.ToInt32(ddlEmpleado.SelectedValue), txtFechaDonacion.Text.Trim(), txtMotivo.Text.Trim(), txtFechaIngreso.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataSource = miDonacion.Listar();
                    gvListado.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }
        }

        #region metodoslocales
        bool Validar()
        {
            Validador obj=new Validador();
            if (!obj.FechaCorrecta(txtFechaIngreso.Text.Trim()))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Revisar formato de fecha: YYYY-MM-DD";
                return false;
            }

            if (!obj.FechaCorrecta(txtFechaDonacion.Text.Trim()))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Revisar formato de fecha: YYYY-MM-DD";
                return false;
            }
            return true;
        }

        void cargarGeneros()
        {
            Genero genero = new Genero();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlGenero.DataSource = listadoEspecies;
            ddlGenero.DataValueField = "Id_genero";
            ddlGenero.DataTextField = "Nombre_cientifico";
            ddlGenero.DataBind();
        }


        void cargarOrigen()
        {
            Origen genero = new Origen();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlOrigen.DataSource = listadoEspecies;
            ddlOrigen.DataValueField = "Id_origen";
            ddlOrigen.DataTextField = "Nombre_origen";
            ddlOrigen.DataBind();
        }

        void cargarPersona()
        {
            Persona genero = new Persona();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlPersona.DataSource = listadoEspecies;
            ddlPersona.DataValueField = "Id_persona";
            ddlPersona.DataTextField = "Nombre_persona";
            ddlPersona.DataBind();
        }

        void cargarEmpleado()
        {
            Empleado genero = new Empleado();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlEmpleado.DataSource = listadoEspecies;
            ddlEmpleado.DataValueField = "Id_empleado";
            ddlEmpleado.DataTextField = "Nombre_empleado";
            ddlEmpleado.DataBind();
        }

        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Donaciones");

            ws.Cells[0, 0].Value = "COD DONACION:";
            ws.Cells[0, 1].Value = "COD GENERO";
            ws.Cells[0, 2].Value = "COD PERSONA";
            ws.Cells[0, 3].Value = "COD ORIGEN";
            ws.Cells[0, 4].Value = "COD EMPLEADO";
            ws.Cells[0, 5].Value = "FECHA DONACION";
            ws.Cells[0, 6].Value = "MOTIVO DONACION";
            ws.Cells[0, 7].Value = "FECHA INGRESO";
            ws.Cells[0, 8].Value = "ESTADO";

            
            DataTable reporte = new DataTable();
            reporte = miDonacion.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[6].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[7].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[8].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Donaciones.xls");
        }
    }
>>>>>>> origin/master
}