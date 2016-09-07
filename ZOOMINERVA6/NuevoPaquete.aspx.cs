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

            Image2.ImageUrl = "~/images/leopardo.jpg";
            ClassZoologico logica = new ClassZoologico();
            GridView1.DataSource = logica.lista_paquetes();
            GridView1.DataBind();
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((TextBoxNombre.Text != "") && (TextBoxTema.Text != "") && (TextBoxObjetivos.Text != "") && (TextBoxIncluye.Text != "") && (TextBoxDonacion.Text != ""))
            {
                ClassZoologico logica = new ClassZoologico();
                int i = 0;
                i = logica.Inserta_Paquete(TextBoxNombre.Text, TextBoxTema.Text, TextBoxObjetivos.Text, Convert.ToDecimal(TextBoxDonacion.Text), TextBoxIncluye.Text);
                if (i == 1)
                {
                    GridView1.DataSource = logica.lista_paquetes();
                    GridView1.DataBind();
                    Label1.Visible = true;
                    Label1.Text = "Ingresado correctamente";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregaPaquetes.aspx");
        }
    }
}