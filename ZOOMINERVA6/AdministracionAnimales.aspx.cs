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
    public partial class AdministracionAnimales : System.Web.UI.Page
    {
        DataTable tabla = new DataTable();
        Animal animal = new Animal();
        public static int PK = 0;
        bool estaGuardando = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = animal.Listar();
            gvListado.DataBind();
            //this.btnEditar.Visible = false;
            //this.btnGuardar.Visible = true;
            lblMensaje.Visible = false;
            Genero genero = new Genero();
            DataTable listadoEspecies = new DataTable();
            listadoEspecies = genero.Listar();
            ddlGenero.DataSource = listadoEspecies;
            ddlGenero.DataValueField = "Id_genero";
            ddlGenero.DataTextField = "Nombre_cientifico";
            ddlGenero.DataBind();
            estaGuardando = false;
        }

        /// <summary>
        /// seleccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(gvListado.SelectedRow.Cells[0].Text);
            tabla = animal.Listar(PK);
            DataRow fila = tabla.Rows[0];
            txtCodigo.Text = fila[1].ToString();
            txtAlias.Text = fila[2].ToString();
            ddlSexo.SelectedValue = fila[3].ToString();
            ddlEstado.SelectedValue = fila[4].ToString();
            txtEdad.Text = fila[5].ToString();
            txtNacimiento.Text = fila[6].ToString();
            txtMuerte.Text = fila[7].ToString();
            txtCausaMuerte.Text = fila[8].ToString();
            //btnGuardar.Visible = false;
            //btnEditar.Visible = true; 
        }

        /// <summary>
        /// paginado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvListado.PageIndex = e.NewPageIndex;
            animal.Listar();
        }

        /// <summary>
        /// guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                estaGuardando = true;
                if (Validar())
                {
                    animal.Create(txtCodigo.Text, txtAlias.Text, ddlSexo.SelectedValue.ToString(), Convert.ToInt32(txtEdad.Text), Convert.ToInt32(ddlEstado.SelectedValue), txtNacimiento.Text.Trim(), txtMuerte.Text.Trim(), Convert.ToInt32(ddlGenero.SelectedValue), txtCausaMuerte.Text);
                    gvListado.DataSource = animal.Listar();
                    gvListado.DataBind();
                    //borra contenido
                    txtEdad.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                    txtAlias.Text = string.Empty;
                    txtNacimiento.Text = string.Empty;
                    txtMuerte.Text = string.Empty;
                    txtCausaMuerte.Text = string.Empty;
                    lblMensaje.Visible = false;
                }
                else
                {
                    lblMensaje.Text = "Informacion almacenada en el sistema";
                    lblMensaje.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.ToString();
                lblMensaje.Visible = true;
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
                estaGuardando = false;
                if (Validar())
                {
                    animal.Update(txtCodigo.Text, txtAlias.Text, ddlSexo.SelectedValue.ToString(), Convert.ToInt32(txtEdad.Text), Convert.ToInt32(ddlEstado.SelectedValue), txtNacimiento.Text.Trim(), txtMuerte.Text.Trim(), Convert.ToInt32(ddlGenero.SelectedValue), txtCausaMuerte.Text, PK);
                    gvListado.DataSource = animal.Listar();
                    gvListado.DataBind();
                    //borra contenido
                    txtEdad.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                    txtAlias.Text = string.Empty;
                    txtNacimiento.Text = string.Empty;
                    txtMuerte.Text = string.Empty;
                    txtCausaMuerte.Text = string.Empty;
                    lblMensaje.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.ToString();
                lblMensaje.Visible = true;
            }
        }

        /// <summary>
        /// boton de cancelar
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEdad.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtAlias.Text = string.Empty;
            txtNacimiento.Text = string.Empty;
            txtMuerte.Text = string.Empty;
            txtCausaMuerte.Text = string.Empty;
            lblMensaje.Visible = false;
        }

        /// <summary>
        /// busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                gvListado.DataSource = animal.Listar(txtCodigo.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue));
                gvListado.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message.ToString();
                lblMensaje.Visible = true;
            }
        }

        #region METODOS LOCALES

        bool Validar()
        {
            Validador obj = new Validador();

            if (txtCodigo.Text.Trim() == string.Empty)
            {
                lblMensaje.Text = "Error en el campo código";
                lblMensaje.Visible = true;
                return false;
            }

            if (txtAlias.Text.Trim() == string.Empty)
            {
                lblMensaje.Text = "Error en el campo alias";
                lblMensaje.Visible = true;
                return false;
            }

            /*if (Convert.ToInt32(ddlSexo.SelectedValue) <= 0)
            {
                lblMensaje.Text = "Error en el campo sexo";
                lblMensaje.Visible = true;
            }*/

            if (!obj.esNumeroPositivo(txtEdad.Text))
            {
                lblMensaje.Text = "Error en el campo edad";
                lblMensaje.Visible = true;
                return false;
            }

            if (Convert.ToInt32(ddlGenero.SelectedValue) <= 0)
            {
                lblMensaje.Text = "Error en el campo genero";
                lblMensaje.Visible = true;
                return false;
            }

            if (Convert.ToInt32(ddlEstado.SelectedValue) <= -1)
            {
                lblMensaje.Text = "Error en el campo estado";
                lblMensaje.Visible = true;
                return false;
            }

            if (txtCausaMuerte.Text.Trim() == string.Empty)
            {
                lblMensaje.Text = "Error en el campo causa muerte";
                lblMensaje.Visible = true;
                return false;
            }

            if (txtNacimiento.Text.Trim() == string.Empty)
            {
                lblMensaje.Text = "Error en el campo Fecha Nacimiento";
                lblMensaje.Visible = true;
                return false;
            }
            else
            {
                if (!obj.FechaCorrecta(txtNacimiento.Text.Trim()))
                {
                    lblMensaje.Text = "Fecha incorrecta. Se esperaba: YYYY-MM-DD";
                    lblMensaje.Visible = true;
                    return false;
                }

            }

            if (txtMuerte.Text.Trim() != string.Empty)
            {
                if (!obj.FechaCorrecta(txtMuerte.Text.Trim()))
                {
                    lblMensaje.Text = "Fecha incorrecta. Se esperaba: YYYY-MM-DD";
                    lblMensaje.Visible = true;
                    return false;
                }
            }


            if ((animal.Count(txtCodigo.Text.Trim(), Convert.ToInt32(ddlEstado.SelectedValue)) <= 0) && (Convert.ToInt32(ddlEstado.SelectedValue) > 0) && (estaGuardando == true))
            {
                lblMensaje.Text = "Información almacenada en el sistema";
                lblMensaje.Visible = true;
                return false;
            }

            return true;
        }

        #endregion

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            ExcelFile ef = new ExcelFile();
            ExcelWorksheet ws = ef.Worksheets.Add("Animal");

            ws.Cells[0, 0].Value = "ID";
            ws.Cells[0, 1].Value = "CODIGO";
            ws.Cells[0, 2].Value = "ALIAS";
            ws.Cells[0, 3].Value = "SEXO";
            ws.Cells[0, 4].Value = "ESTADO";
            ws.Cells[0, 5].Value = "EDAD";
            ws.Cells[0, 6].Value = "FECHA NACIMIENTO";
            ws.Cells[0, 7].Value = "FECHA MUERTE";
            ws.Cells[0, 8].Value = "CAUSA MUERTE";
            ws.Cells[0, 9].Value = "COD. GENERO";


            DataTable reporte = new DataTable();
            reporte = animal.Listar();

            for (int i = 0; i <= reporte.Rows.Count; i++)
            {
                ws.Cells[i, 0].Value = reporte.Columns[0].ToString();
                ws.Cells[i, 1].Value = reporte.Columns[1].ToString();
                ws.Cells[i, 2].Value = reporte.Columns[2].ToString();
                ws.Cells[i, 3].Value = reporte.Columns[3].ToString();
                ws.Cells[i, 4].Value = reporte.Columns[4].ToString();
                ws.Cells[i, 5].Value = reporte.Columns[5].ToString();
                ws.Cells[i, 6].Value = reporte.Columns[6].ToString();
                ws.Cells[i, 7].Value = reporte.Columns[6].ToString();
                ws.Cells[i, 8].Value = reporte.Columns[6].ToString();
            }

            ef.Save(ConfigsWP.almacenamiento + "Animal.xls");
        }
    }
}