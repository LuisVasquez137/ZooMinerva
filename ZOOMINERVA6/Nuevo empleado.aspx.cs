using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace ZOOMINERVA6
{
    public partial class Nuevo_empleado : System.Web.UI.Page
    {
        public static int PK;
        DataTable tabla = new DataTable();
        ClassEmpleado logica = new ClassEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

             if (Login.bandera == 0)
              {
                  Response.Redirect("Login.aspx");

              }

            Image2.ImageUrl = "~/images/empleados.jpg";
/*
            if (!this.IsPostBack)
            {
                ClassEmpleado logica = new ClassEmpleado();

                this.DropDownList1.DataSource = logica.Lista_cargos();
                this.DropDownList1.DataTextField = "Nombre_cargo";
                this.DropDownList1.DataValueField = "Id_cargo";
                this.DropDownList1.DataBind();
            

            }*/



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empleados.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            ClassEmpleado logica = new ClassEmpleado();
            int codigoCargo;
            codigoCargo = Convert.ToInt32(DropDownList1.SelectedValue);
            logica.Inserta_Empleado(codigoCargo, TextBoxNombre.Text, TextBoxApellido.Text, TextBoxTelefono.Text, TextBoxDireccion.Text, Calendar1.SelectedDate,true, TextBoxUsuario.Text, TextBoxContrasenia.Text);
            GridView1.DataBind();
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                      if (!this.IsPostBack)
                        {
                            ClassEmpleado logica = new ClassEmpleado();

                            this.DropDownList1.DataSource = logica.Lista_cargos();
                            this.DropDownList1.DataTextField = "Nombre_cargo";
                            this.DropDownList1.DataValueField = "Id_cargo";
                            this.DropDownList1.DataBind();


                        }
                      */
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PK = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            tabla = logica.Lista_empleados();
            

            GridViewRow row = GridView1.SelectedRow;

            TextBoxNombre.Text = row.Cells[2].Text;
            TextBoxApellido.Text= row.Cells[3].Text;
            TextBoxTelefono.Text=row.Cells[4].Text;
            TextBoxDireccion.Text= row.Cells[5].Text;
            Calendar1.SelectedDate=Convert.ToDateTime (row.Cells[6].Text);
           //DropDownList1.SelectedValue= row.Cells[7].Text;

            //ddlEstado.SelectedValue = fila[2].ToString();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            logica.Lista_empleados();
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            logica.Baja_Empleado(PK);
            GridView1.DataBind();
        }

        protected void ButtonEditar_Click1(object sender, EventArgs e)
        {
            logica.ActualizaEmpleado(Convert.ToInt32 (DropDownList1.SelectedValue), TextBoxNombre.Text, TextBoxApellido.Text, TextBoxTelefono.Text, TextBoxDireccion.Text, TextBoxUsuario.Text, TextBoxContrasenia.Text, Calendar1.SelectedDate, true, PK);
            GridView1.DataBind();
            TextBoxNombre.Text = "";
            TextBoxApellido.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxUsuario.Text = "";
            TextBoxContrasenia.Text = "";
        }

        protected void ButtonSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect ("Default.aspx");
        }
    }
}