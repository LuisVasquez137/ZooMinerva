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
    public partial class Dieta : System.Web.UI.Page
    {
        BLL.Dieta dieta = new BLL.Dieta();
        DataTable tabla = new DataTable();
        Especie especie = new Especie();
        public static int PK = 0;
        bool estaGuardando = false;

        /// <summary>
        /// CARGA PAGINA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarIngredientes();
            CargarUnidades();
            CargarGeneros();

            gvListado.DataSource = dieta.Listar();
            gvListado.DataBind();
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// GUARDAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            estaGuardando = true;
            if (ValidarGuardar())
            {
                dieta.Create(Convert.ToInt32(ddlGeneros.SelectedValue), Convert.ToInt32(ddlIngrediente.SelectedValue), Convert.ToInt32(txtPeso.Text), Convert.ToInt32(ddlUnidad.SelectedValue), txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue));
                gvListado.DataSource = dieta.Listar();
                gvListado.DataBind();
                txtPresentacion.Text = string.Empty;
                txtPeso.Text = string.Empty;
                lblMensaje.Visible = false;
            }
            /*else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Revisar campos de la información que se está registrando.";
            }*/
        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = dieta.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtPeso.Text = fila[4].ToString();
            txtPresentacion.Text = fila[5].ToString();
            ddlEstado.SelectedValue = fila[6].ToString();
            //btnGuardar.Visible = false;
            //btnEditar.Visible = true;         
        }

        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            especie.Listar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = string.Empty;
            txtPresentacion.Text = string.Empty;
            CargarGeneros();
            CargarIngredientes();
            CargarUnidades();
            PK = 0;
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// EDITAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            estaGuardando = false;
            dieta.Update(Convert.ToInt32(ddlGeneros.SelectedValue), Convert.ToInt32(ddlIngrediente.SelectedValue), Convert.ToInt32(txtPeso.Text), Convert.ToInt32(ddlUnidad.SelectedValue), txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue), PK);
            gvListado.DataSource = dieta.Listar();
            gvListado.DataBind();
            txtPresentacion.Text = string.Empty;
            txtPeso.Text = string.Empty;
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// BUSCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtPresentacion.Text != string.Empty)
            {
                dieta.Listar(txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue));
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ingresar la presentación a buscar";
            }
        }

        #region MetodosPagina

        /// <summary>
        /// validaciones
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            Validador validar = new Validador();
            if (!validar.esNumeroPositivo(txtPeso.Text.Trim()))
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error en el campo peso";
                return false;
            }

            if (txtPresentacion.Text.Trim() == string.Empty)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error en el campo presentación";
                return false;
            }

            if ((dieta.Count(txtPresentacion.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) > 0) && (estaGuardando == true))
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Registro en la entidad dietas se encuentra almacenado";
                return false;
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) < 0)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccionar un estado";
                return false;
            }

            return true;
        }
        /// <summary>
        /// cargar ingredientes
        /// </summary>
        void CargarIngredientes()
        {
            Ingrediente ingredientes = new Ingrediente();
            DataTable listadoIngredientes = new DataTable();
            listadoIngredientes = ingredientes.Listar();
            ddlIngrediente.DataSource = listadoIngredientes;
            ddlIngrediente.DataValueField = "Id_ingrediente";
            ddlIngrediente.DataTextField = "Ingrediente";
            ddlIngrediente.DataBind();
        }

        /// <summary>
        /// cargar unidades
        /// </summary>
        void CargarUnidades()
        {
            Unidad obj = new Unidad();
            DataTable listado = new DataTable();
            listado = obj.Listar();
            ddlUnidad.DataSource = listado;
            ddlUnidad.DataValueField = "Id_unidad";
            ddlUnidad.DataTextField = "Descripcion_unidad";
            ddlUnidad.DataBind();
        }

        /// <summary>
        /// cargar generos
        /// </summary>
        void CargarGeneros()
        {
            Genero genero = new Genero();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlGeneros.DataSource = listadoEspecies;
            ddlGeneros.DataValueField = "Id_genero";
            ddlGeneros.DataTextField = "Nombre_cientifico";
            ddlGeneros.DataBind();
        }


        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Dieta");

            ws.Cells[0, 0].Value = "COD DIETA:";
            ws.Cells[0, 1].Value = "COD GENERO";
            ws.Cells[0, 2].Value = "COD INGREDIENTE";
            ws.Cells[0, 3].Value = "COD UNIDAD";
            ws.Cells[0, 4].Value = "PESO";
            ws.Cells[0, 5].Value = "PRESENTACION";
            ws.Cells[0, 6].Value = "ESTADO";

            DataTable reporte = new DataTable();
            reporte = dieta.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[6].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Dieta.xls");
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
    public partial class Dieta : System.Web.UI.Page
    {
        BLL.Dieta dieta=new BLL.Dieta();
        DataTable tabla = new DataTable();
        Especie especie = new Especie();
        public static int PK = 0;
        bool estaGuardando = false;

        /// <summary>
        /// CARGA PAGINA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarIngredientes();
            CargarUnidades();
            CargarGeneros();

            gvListado.DataSource = dieta.Listar();
            gvListado.DataBind();
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// GUARDAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            estaGuardando = true;
            if (ValidarGuardar())
            {
                dieta.Create(Convert.ToInt32(ddlGeneros.SelectedValue), Convert.ToInt32(ddlIngrediente.SelectedValue), Convert.ToInt32(txtPeso.Text), Convert.ToInt32(ddlUnidad.SelectedValue), txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue));
                gvListado.DataSource = dieta.Listar();
                gvListado.DataBind();
                txtPresentacion.Text = string.Empty;
                txtPeso.Text = string.Empty;
                lblMensaje.Visible = false;
            }
            /*else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Revisar campos de la información que se está registrando.";
            }*/
        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = dieta.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtPeso.Text = fila[4].ToString();
            txtPresentacion.Text = fila[5].ToString();
            ddlEstado.SelectedValue = fila[6].ToString();
            //btnGuardar.Visible = false;
            //btnEditar.Visible = true;         
        }

        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            especie.Listar(); 
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = string.Empty;
            txtPresentacion.Text = string.Empty;
            CargarGeneros();
            CargarIngredientes();
            CargarUnidades();
            PK = 0;
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// EDITAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            estaGuardando = false;
            dieta.Update(Convert.ToInt32(ddlGeneros.SelectedValue), Convert.ToInt32(ddlIngrediente.SelectedValue), Convert.ToInt32(txtPeso.Text), Convert.ToInt32(ddlUnidad.SelectedValue), txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue),PK);
            gvListado.DataSource = dieta.Listar();
            gvListado.DataBind();
            txtPresentacion.Text = string.Empty;
            txtPeso.Text = string.Empty;
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// BUSCAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtPresentacion.Text != string.Empty)
            {
                dieta.Listar(txtPresentacion.Text, Convert.ToInt32(ddlEstado.SelectedValue));
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ingresar la presentación a buscar";
            }
        }

        #region MetodosPagina

        /// <summary>
        /// validaciones
        /// </summary>
        /// <returns></returns>
        public bool ValidarGuardar()
        {
            Validador validar=new Validador();
            if (!validar.esNumeroPositivo(txtPeso.Text.Trim()))
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error en el campo peso";
                return false;
            }

            if (txtPresentacion.Text.Trim()==string.Empty)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error en el campo presentación";
                return false;
            }

            if ((dieta.Count(txtPresentacion.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) > 0) && (estaGuardando==true))
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Registro en la entidad dietas se encuentra almacenado";
                return false;
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) < 0)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Seleccionar un estado";
                return false;
            }

            return true;
        }
        /// <summary>
        /// cargar ingredientes
        /// </summary>
        void CargarIngredientes()
        {
            Ingrediente ingredientes = new Ingrediente();
            DataTable listadoIngredientes = new DataTable();
            listadoIngredientes = ingredientes.Listar();
            ddlIngrediente.DataSource = listadoIngredientes;
            ddlIngrediente.DataValueField = "Id_ingrediente";
            ddlIngrediente.DataTextField = "Ingrediente";
            ddlIngrediente.DataBind();
        }

        /// <summary>
        /// cargar unidades
        /// </summary>
        void CargarUnidades()
        {
            Unidad obj = new Unidad();
            DataTable listado = new DataTable();
            listado = obj.Listar();
            ddlUnidad.DataSource = listado;
            ddlUnidad.DataValueField = "Id_unidad";
            ddlUnidad.DataTextField = "Descripcion_unidad";
            ddlUnidad.DataBind();
        }

        /// <summary>
        /// cargar generos
        /// </summary>
        void CargarGeneros()
        {
            Genero genero = new Genero();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlGeneros.DataSource = listadoEspecies;
            ddlGeneros.DataValueField = "Id_genero";
            ddlGeneros.DataTextField = "Nombre_cientifico";
            ddlGeneros.DataBind();
        }


        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Dieta");

            ws.Cells[0, 0].Value = "COD DIETA:";
            ws.Cells[0, 1].Value = "COD GENERO";
            ws.Cells[0, 2].Value = "COD INGREDIENTE";
            ws.Cells[0, 3].Value = "COD UNIDAD";
            ws.Cells[0, 4].Value = "PESO";
            ws.Cells[0, 5].Value = "PRESENTACION";
            ws.Cells[0, 6].Value = "ESTADO";            

            DataTable reporte = new DataTable();
            reporte = dieta.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[6].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Dieta.xls");
        }
    }
>>>>>>> origin/master
}