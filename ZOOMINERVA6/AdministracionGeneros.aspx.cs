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
    public partial class AdministracionGeneros : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Genero genero = new Genero();
        public static int PK = 0;
        bool estaGuardando = false;
        /// <summary>
        /// carga de la informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = genero.Listar();
            gvListado.DataBind();
            //this.btnEditar.Visible = false;
            //this.btnAgregar.Visible = true;

            Especie especie = new Especie();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = especie.Listar();
            ddlEspecies.DataSource = listadoEspecies;
            ddlEspecies.DataValueField = "Id_especie";
            ddlEspecies.DataTextField = "Nombre_especie";
            ddlEspecies.DataBind();
            lblMensajes.Visible = false;
            lblMensajes.Text = string.Empty;
        }

        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            genero.Listar();
        }

        /// <summary>
        /// captura el codigo y setea la informacion al editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = genero.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtNombreCientifico.Text = fila[2].ToString();
            txtNombreComun.Text = fila[1].ToString();
            txtCantidad.Text = fila[3].ToString();
            ddlEstado.SelectedValue = fila[4].ToString();
            ddlEspecies.SelectedValue = fila[5].ToString();
            //btnAgregar.Visible = false;
            //btnEditar.Visible = true; 
        }

        /// <summary>
        /// boton para agregar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                estaGuardando = true;
                if (Validar())
                {
                    if (genero.Count(txtNombreCientifico.Text.Trim(), 1) <= 0)
                    {
                        genero.Create(txtNombreComun.Text, txtNombreCientifico.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(ddlEstado.SelectedValue), Convert.ToInt32(ddlEspecies.SelectedValue));
                        gvListado.DataSource = genero.Listar();
                        gvListado.DataBind();
                        //borra contenido de los controles
                        txtCantidad.Text = string.Empty;
                        txtNombreComun.Text = string.Empty;
                        txtNombreCientifico.Text = string.Empty;
                        lblMensajes.Visible = false;
                        lblMensajes.Text = string.Empty;
                    }
                    else
                    {
                        lblMensajes.Text = "La informacion ya se encuentra almacenada en el sistema";
                        lblMensajes.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// boton para editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                estaGuardando = false;
                if (Validar())
                {
                    genero.Update(txtNombreComun.Text, txtNombreCientifico.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(ddlEstado.SelectedValue), Convert.ToInt32(ddlEspecies.SelectedValue), PK);
                    gvListado.DataSource = genero.Listar();
                    gvListado.DataBind();
                    //borra contenido de los controles
                    txtCantidad.Text = string.Empty;
                    txtNombreComun.Text = string.Empty;
                    txtNombreCientifico.Text = string.Empty;
                    lblMensajes.Visible = false;
                    lblMensajes.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                this.lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// boton para cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            PK = 0;
            //borra contenido de los controles
            txtCantidad.Text = string.Empty;
            txtNombreComun.Text = string.Empty;
            txtNombreCientifico.Text = string.Empty;
            lblMensajes.Visible = false;
        }

        /// <summary>
        /// boton para buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNombreCientifico.Text.Trim() != string.Empty) && ((Convert.ToInt32(ddlEstado.SelectedValue)) > -1))
                {
                    this.gvListado.DataSource = genero.Listar(txtNombreCientifico.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    this.gvListado.DataBind();
                }
            }
            catch (Exception ex)
            {
                this.lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        #region MetodosPagina
        public bool Validar()
        {
            Validador validar = new Validador();
            if (!validar.esNumeroPositivo(txtCantidad.Text.Trim()))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en campo cantidad";
                return false;
            }

            if (txtNombreCientifico.Text == string.Empty)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en campo Nombre científico";
                return false;
            }

            if (txtNombreComun.Text == string.Empty)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en campo nombre comun";
                return false;
            }

            if ((genero.Count(txtNombreCientifico.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) > 0) && (estaGuardando == true))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Información se encuentra almacenada en el sistema";
                return false;
            }
            return true;
        }
        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Genero");



            ws.Cells[0, 0].Value = "COD. GENERO";
            ws.Cells[0, 1].Value = "NOMBRE COMUN";
            ws.Cells[0, 2].Value = "NOMBRE CIENTIFICO";
            ws.Cells[0, 3].Value = "CANTIDAD";
            ws.Cells[0, 4].Value = "ESTADO";
            ws.Cells[0, 5].Value = "COD. ESPECIE";


            DataTable reporte = new DataTable();
            reporte = genero.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Genero.xls");
        }
    }
}