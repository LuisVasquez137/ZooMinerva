<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
<<<<<<< HEAD
using GemBox.Spreadsheet;
=======

>>>>>>> origin/master

namespace ZOOMINERVA6
{
    public partial class AdministracionEspecie : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Especie especie = new Especie();
        public static int PK = 0;
        bool guardando = false;

        /// <summary>
        /// CARGA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = especie.Listar();
            gvListado.DataBind();
            //this.btnEditar.Visible = false;
            //this.btnGuardar.Visible = true;
            lblMensajes.Visible = false;
            guardando = false;
        }

        /// <summary>
        /// SELECCION EDITAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = especie.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtNombre.Text = fila[1].ToString();
            ddlEstado.SelectedValue = fila[2].ToString();
            //btnGuardar.Visible = false;
            //btnEditar.Visible = true;        
        }

        /// <summary>
        /// PAGINACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            especie.Listar();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    especie.Create(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataSource = especie.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    txtNombre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// EDITAR
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
                    especie.Update(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue), PK);
                    gvListado.DataSource = especie.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    txtNombre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = false;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvListado.DataSource = especie.Listar(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                gvListado.DataBind();
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// CANCELAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            lblMensajes.Visible = false;
            guardando = false;
        }

        #region METODOS LOCALES
        bool Validar()
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en el campo nombre";
                return false;
            }

            if ((especie.Count(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) > 0) && (guardando == true))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Información almacenda en el sistema";
                return false;
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) <= -1)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en el campo de estado";
                return false;
            }
            return true;
        }
        #endregion

<<<<<<< HEAD
        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Especies");

            ws.Cells[0, 0].Value = "CODIGO:";
            ws.Cells[0, 1].Value = "NOMBRE";
            ws.Cells[0, 1].Value = "ESTADO";

            DataTable reporte = new DataTable();
            reporte = especie.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
            }


            ef.Save(ConfigsWP.almacenamiento + "Especies.xls");
        }
=======
        /*   protected void btnExportar_Click(object sender, EventArgs e)
           {
               SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

               ExcelFile ef = new ExcelFile();
               ExcelWorksheet ws = ef.Worksheets.Add("Especies");

               ws.Cells[0, 0].Value = "CODIGO:";
               ws.Cells[0, 1].Value = "NOMBRE";
               ws.Cells[0, 1].Value = "ESTADO";

               DataTable reporte = new DataTable();
               reporte = especie.Listar();

               for (int i = 0; i <= reporte.Rows.Count; i++)
               {
                   ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                   ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                   ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
               }


               ef.Save(ConfigsWP.almacenamiento + "Especies.xls");
           }*/
>>>>>>> origin/master
    }
=======
﻿using System;
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
    public partial class AdministracionEspecie : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Especie especie = new Especie();
        public static int PK = 0;
        bool guardando = false;

        /// <summary>
        /// CARGA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = especie.Listar();
            gvListado.DataBind();
            //this.btnEditar.Visible = false;
            //this.btnGuardar.Visible = true;
            lblMensajes.Visible = false;
            guardando = false;
        }

        /// <summary>
        /// SELECCION EDITAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = especie.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtNombre.Text = fila[1].ToString();
            ddlEstado.SelectedValue = fila[2].ToString();
            //btnGuardar.Visible = false;
            //btnEditar.Visible = true;        
        }

        /// <summary>
        /// PAGINACION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            especie.Listar();  
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    especie.Create(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                    gvListado.DataSource = especie.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    txtNombre.Text = string.Empty;
                }               
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// EDITAR
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
                    especie.Update(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue), PK);
                    gvListado.DataSource = especie.Listar();
                    gvListado.DataBind();
                    lblMensajes.Visible = false;
                    txtNombre.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = false;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvListado.DataSource = especie.Listar(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                gvListado.DataBind();
            }
            catch (Exception ex)
            {
                lblMensajes.Text = ex.Message.ToString();
                lblMensajes.Visible = true;
            }
        }

        /// <summary>
        /// CANCELAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            lblMensajes.Visible = false;
            guardando = false;
        }

        #region METODOS LOCALES
        bool Validar()
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en el campo nombre";
                return false;
            }

            if ((especie.Count(txtNombre.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) > 0) && (guardando == true))
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Información almacenda en el sistema";
                return false; 
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) <= -1)
            {
                lblMensajes.Visible = true;
                lblMensajes.Text = "Error en el campo de estado";
                return false;
            }
            return true; 
        }
        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            
            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Especies");
            
            ws.Cells[0, 0].Value = "CODIGO:";
            ws.Cells[0, 1].Value = "NOMBRE";
            ws.Cells[0, 1].Value = "ESTADO";

            DataTable reporte = new DataTable();
            reporte=especie.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
            }

            
            ef.Save(ConfigsWP.almacenamiento+"Especies.xls");
        }
    }
>>>>>>> origin/master
}