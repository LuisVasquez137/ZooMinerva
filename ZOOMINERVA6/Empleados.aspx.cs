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
    public partial class Empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifica si esta logueado
            if (Login.bandera == 0)
            {
                Response.Redirect("Login.aspx");

            }

            ClassEmpleado logicalog = new ClassEmpleado();

            this.GridView1.DataSource = logicalog.Lista_empleados();
            GridView1.DataBind();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nuevo empleado");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaEmpleado.aspx");
        }
    }
}