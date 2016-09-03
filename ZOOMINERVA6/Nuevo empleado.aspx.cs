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
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Login.bandera == 0)
            {
                Response.Redirect("Login.aspx");

            }

            if (!this.IsPostBack)
            {
                ClassEmpleado logica = new ClassEmpleado();

                this.DropDownList1.DataSource = logica.Lista_cargos();
                this.DropDownList1.DataTextField = "Nombre_cargo";
                this.DropDownList1.DataValueField = "Id_cargo";
                this.DropDownList1.DataBind();
            

            }



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
            Response.Redirect("Empleados.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

          if (!this.IsPostBack)
            {
                ClassEmpleado logica = new ClassEmpleado();

                this.DropDownList1.DataSource = logica.Lista_cargos();
                this.DropDownList1.DataTextField = "Nombre_cargo";
                this.DropDownList1.DataValueField = "Id_cargo";
                this.DropDownList1.DataBind();
               

            }
          

        }
    }
}