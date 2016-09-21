using System;
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
    public partial class AdministracionCuarentenas : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Cuarentena cuarentena = new Cuarentena();
        public static int PK = 0;
        bool guardando = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = cuarentena.Listar();
            gvListado.DataBind();
            //this.btnEditar.Visible = false;
            //this.btnGuardar.Visible = true;
            lblMensajes.Visible = false;
            guardando = false;

            Animal anim = new Animal();
            DataTable listado = new DataTable();
            listado = anim.Listar();
            ddlAnimales.DataSource = listado;
            ddlAnimales.DataValueField = "Id_animal";
            ddlAnimales.DataTextField = "alias_animal";
            ddlAnimales.DataBind();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            ddlAnimales.SelectedValue = gvListado.SelectedRow.Cells[1].Text;
            txtFecha.Text = gvListado.SelectedRow.Cells[2].Text;
            txtDescripcion.Text = gvListado.SelectedRow.Cells[3].Text;
            txtCantidad.Text = gvListado.SelectedRow.Cells[5].Text;
            txtFechaRecinto.Text = gvListado.SelectedRow.Cells[4].Text;
            ddlEstado.SelectedValue = gvListado.SelectedRow.Cells[6].Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            cuarentena.Listar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            PK = 0;
            guardando = false;
            txtFechaRecinto.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            lblMensajes.Visible = false;
            lblMensajes.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    cuarentena.create(Convert.ToInt32(ddlAnimales.SelectedValue), txtFecha.Text.Trim(), txtDescripcion.Text, txtFechaRecinto.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(ddlEstado.SelectedValue));
                    PK = 0;
                    guardando = false;
                    txtFechaRecinto.Text = string.Empty;
                    txtFecha.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    txtCantidad.Text = string.Empty;
                    lblMensajes.Visible = false;
                    lblMensajes.Text = string.Empty;
                    gvListado.DataSource = cuarentena.Listar();
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    cuarentena.update(Convert.ToInt32(ddlAnimales.SelectedValue), txtFecha.Text.Trim(), txtDescripcion.Text, txtFechaRecinto.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(ddlEstado.SelectedValue), PK);
                    PK = 0;
                    guardando = false;
                    txtFechaRecinto.Text = string.Empty;
                    txtFecha.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    txtCantidad.Text = string.Empty;
                    lblMensajes.Visible = false;
                    lblMensajes.Text = string.Empty;
                    gvListado.DataSource = cuarentena.Listar();
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
        /// 
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

        #region METODOS LOCALES
        bool validar()
        {
            Validador obj = new Validador();
            if (!obj.esNumeroPositivo(txtCantidad.Text))
            {
                lblMensajes.Text = "Error en campo cantidad";
                lblMensajes.Visible = true;
                return false;
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) <= -1)
            {
                lblMensajes.Text = "Error en campo estado";
                lblMensajes.Visible = true;
                return false;
            }

            if (txtDescripcion.Text == string.Empty)
            {
                lblMensajes.Text = "Error en campo descripcipón";
                lblMensajes.Visible = true;
                return false;
            }

            if (txtFecha.Text != string.Empty)
            {
                if (!obj.FechaCorrecta(txtFecha.Text))
                {
                    lblMensajes.Text = "Error en campo fecha";
                    lblMensajes.Visible = true;
                    return false;
                }
            }
            else
            {
                lblMensajes.Text = "Error en campo fecha";
                lblMensajes.Visible = true;
                return false;
            }

            if (txtFechaRecinto.Text != string.Empty)
            {
                if (!obj.FechaCorrecta(txtFechaRecinto.Text))
                {
                    lblMensajes.Text = "Error en campo fecha";
                    lblMensajes.Visible = true;
                    return false;
                }
            }
            else
            {
                lblMensajes.Text = "Error en campo fecha";
                lblMensajes.Visible = true;
                return false;
            }

            return true;
        }
        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Cuarentena");

            ws.Cells[0, 0].Value = "COD CUARENTENA";
            ws.Cells[0, 1].Value = "COD ANIMAL";
            ws.Cells[0, 2].Value = "FECHA";
            ws.Cells[0, 3].Value = "DESCRIPCION CUARENTENA";
            ws.Cells[0, 4].Value = "CANTIDAD";
            ws.Cells[0, 5].Value = "FECHA RECINTO";
            ws.Cells[0, 6].Value = "ESTADO CUARENTENA";


            DataTable reporte = new DataTable();
            reporte = cuarentena.Listar();

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


            ef.Save(ConfigsWP.almacenamiento + "Cuarentena.xls");
        }
    }
}