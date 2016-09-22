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
    public partial class Editar_Info : System.Web.UI.Page
    {
        public int cod;
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassZoologico logica = new ClassZoologico();
            DataTable tblRespuesta;
            tblRespuesta = logica.lista_zoologico();

            if (tblRespuesta != null)
            {
                if (tblRespuesta.Rows.Count > 0)
                {

                    TextBoxZoo.Text = (tblRespuesta.Rows[0][1].ToString());
                    TextBoxMision.Text = (tblRespuesta.Rows[0][2].ToString());
                    TextBoxVision.Text = (tblRespuesta.Rows[0][3].ToString());
                    TextBoxDireccion.Text = (tblRespuesta.Rows[0][4].ToString());
                    TextBoxTelefono.Text = (tblRespuesta.Rows[0][5].ToString());
                    TextBoxHorario.Text = (tblRespuesta.Rows[0][8].ToString());
                    cod =Convert.ToInt32( tblRespuesta.Rows[0][0].ToString());

                }
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassZoologico logica = new ClassZoologico();
            try
            {
                int respuesta;
                respuesta= logica.Actualiza_Zoo(TextBoxZoo.Text, TextBoxMision.Text, TextBoxVision.Text, TextBoxDireccion.Text, TextBoxTelefono.Text, "",null, TextBoxHorario.Text, cod);
              
                Label1.Text = Convert.ToString(respuesta);
                //Response.Redirect("About.aspx");
            }
            catch
            {
                Label1.Text = "Ocurrio un error, favor de verificar los datos ingresados";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}