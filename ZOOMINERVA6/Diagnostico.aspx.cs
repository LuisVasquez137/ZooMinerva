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
    public partial class Diagnostico : System.Web.UI.Page
    {
        public static int codigoHistorial;
        public static int codiAnimal;
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/images/loros.jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassDiagnostico logica = new ClassDiagnostico();
            int respuesta_diagnostico = 0;
            respuesta_diagnostico = logica.InsertaDiagnostico(Calendar1.SelectedDate, 1, TextBoxMotivo.Text, TextBoxPeso.Text, TextBoxTemperatura.Text, TextBoxCardiaca.Text, TextBoxRespiratoria.Text, TextBoxTllc.Text, TextBoxMucosas.Text, TextBoxTungencia.Text, TextBoxPulso.Text, TextBoxAnamnesis.Text, TextBoxEnfermedades.Text, TextBoxActitud.Text, TextBoxCondicionCorporal.Text, TextBoxHidratacion.Text, TextBoxojos.Text, TextBoxOidos.Text, TextBoxNodulos.Text, TextBoxLocomocion.Text, TextBoxMusculoEsqueletico.Text, TextBoxNervioso.Text, TextBoxCardiobascular.Text, TextBoxDigestivo.Text, TextBoxRespiratorio.Text, TextBoxGeniouriano.Text, TextBoxProblemasEncontrados.Text, TextBoxDiagnosticoPresuntivo.Text, TextBoxDiagnosticoDefinitivo.Text, TextBoxResultados.Text, TextBoxProgreso.Text);


            if(respuesta_diagnostico==1)
            {
                DataTable tblRespuesta;
                tblRespuesta = logica.codigo_Historial();

                if (tblRespuesta != null)
                {
                    if (tblRespuesta.Rows.Count > 0)
                    {

                        codigoHistorial = Convert.ToInt32(tblRespuesta.Rows[0][0].ToString());

                    }
                }

                

                DataTable tblRespuesta2;
                tblRespuesta2 = logica.codigo_animal(TextBoxCodigoAnimal.Text);

                if (tblRespuesta2 != null)
                {
                    if (tblRespuesta2.Rows.Count > 0)
                    {

                        codiAnimal = Convert.ToInt32(tblRespuesta2.Rows[0][0].ToString());

                    }
                }

                int respuesta2 = 0;
                respuesta2 = logica.InsertaDiagnosticoAnimal(codiAnimal, codigoHistorial);

                Response.Redirect("ReporteDiagnostico.aspx");

            }
            else
            {
                Label1.Text = "Error durante el proceso";


            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            


        }
    }
}