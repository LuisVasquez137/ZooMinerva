using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using GemBox.Spreadsheet;


namespace ZOOMINERVA6
{
    public partial class AdministracionVacunas : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Vacuna vacuna = new Vacuna();
        public static int PK = 0;
        bool guardando = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = vacuna.Listar();
            gvListado.DataBind();
            guardando = false;
            lblMensajes.Visible = false;
            lblMensajes.Text = string.Empty;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                guardando = true;
                if (Validar())
                {
                    vacuna.Create(txtVacuna.Text, Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataSource = vacuna.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    lblMensajes.Visible = false;
                    txtVacuna.Text = string.Empty;
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
                if (Validar())
                {
                    vacuna.Update(txtVacuna.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue), PK);
                    gvListado.DataSource = vacuna.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    txtVacuna.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }
        }

        /// <summary>
        /// BUSQUEDA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVacuna.Text.Trim() != string.Empty)
                {
                    gvListado.DataSource = vacuna.Listar(txtVacuna.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = ex.Message.ToString();
            }
        }

        /// <summary>
        /// boton de cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblMensajes.Visible = false;
            txtVacuna.Text = string.Empty;
            guardando = false;
        }

        /// <summary>
        /// cambio de pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            vacuna.Listar();
        }

        /// <summary>
        /// captura de valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = vacuna.Listar(PK);
            DataRow fila = tabla.Rows[0];

            txtVacuna.Text = fila[1].ToString();
            ddlEstado.SelectedValue = fila[2].ToString();
        }

        #region METODOS LOCALES
        bool Validar()
        {
            if (((vacuna.Count(txtVacuna.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) <= -1) && (Convert.ToInt32(ddlEstado.SelectedValue) > -1)) && (guardando==true))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Información almacenada en el sistema";
                return false; 
            }

            if (txtVacuna.Text.Trim() == string.Empty)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en campo vacuna";
                return false; 
            }

            return true;
        }

        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Vacuna");

            ws.Cells[0, 0].Value = "COD VACUNA";
            ws.Cells[0, 1].Value = "NOMBRE";
            ws.Cells[0, 2].Value = "ESTADO";
            
            DataTable reporte = new DataTable();
            reporte = vacuna.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();                
            }


            ef.Save(ConfigsWP.almacenamiento + "Vacuna.xls");
        }
    }
}