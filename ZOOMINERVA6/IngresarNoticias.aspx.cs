using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace ZOOMINERVA6
{
    public partial class IngresarNoticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassNoticias logica = new ClassNoticias();
            GridView1.DataSource = logica.lista_noticas2();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}