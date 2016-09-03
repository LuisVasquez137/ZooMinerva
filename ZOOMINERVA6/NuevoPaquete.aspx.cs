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
    public partial class NuevoPaquete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregaPaquetes.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if((TextBoxNombre.Text!="")&& (TextBoxTema.Text!="")&& (TextBoxObjetivos.Text!="")&&(TextBoxIncluye.Text!="")&&(TextBoxDonacion.Text!=""))
            {
                ClassZoologico logica = new ClassZoologico();
            int i = 0;
            i=logica.Inserta_Paquete(TextBoxNombre.Text, TextBoxTema.Text, TextBoxObjetivos.Text, Convert.ToDecimal(TextBoxDonacion.Text), TextBoxIncluye.Text);
            if (i==1)
            {
                Response.Redirect("AgregaPaquetes.aspx");
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Error durante el proceso, intente de nuevo";
                Response.Redirect("NuevoPaquete.aspx");
            }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Debe llenar todos los campos";
            }
        }
    }
}