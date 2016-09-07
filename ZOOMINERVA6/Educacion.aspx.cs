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
    public partial class Educacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image2.ImageUrl = "~/images/cabras.jpg";

            ClassZoologico logica = new ClassZoologico();
            DataTable tblRespuesta;
            tblRespuesta = logica.lista_paquetes();
            Repeater1.DataSource = tblRespuesta;
            Repeater1.DataBind();
        }
    }
}