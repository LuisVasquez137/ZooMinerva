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
    public partial class AgregaPaquetes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassZoologico logica = new ClassZoologico();
            DataTable tblRespuesta;
            tblRespuesta = logica.lista_paquetes();
            GridView1.DataSource = tblRespuesta;
            GridView1.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoPaquete.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}