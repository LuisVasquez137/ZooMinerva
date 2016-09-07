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
    public partial class Noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image2.ImageUrl = "~/images/tortuga.jpg";

            ClassNoticias logica = new ClassNoticias();
            this.Repeater1.DataSource = logica.lista_noticias();
            
            
            Repeater1.DataBind();

            
        }
    }
}