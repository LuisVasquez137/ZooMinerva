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
    public partial class ReporteDiagnostico : System.Web.UI.Page
    {
        public static string alias;
        public static string comun;
        public static string cientifico;
        public static string sexo;
        public static int codigoHistorial;
        public static int codiAnimal;
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/images/loros.jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ClassAnimales logica = new ClassAnimales();
            DataTable tblRespuesta;
            tblRespuesta = logica.Datos_diagnostico(TextBox1.Text);

            if (tblRespuesta != null)
            {
                if (tblRespuesta.Rows.Count > 0)
                {
                    alias = tblRespuesta.Rows[0][0].ToString();
                    comun = tblRespuesta.Rows[0][1].ToString();
                    cientifico = tblRespuesta.Rows[0][2].ToString();
                    sexo = tblRespuesta.Rows[0][3].ToString();

                    LabelAlias.Text = alias;
                    LabelNombreComun.Text = comun;
                    LabelNombreCientifico.Text = cientifico;
                    LabelSexo.Text = sexo;


                }
            }



            ClassDiagnostico logica2 = new ClassDiagnostico();
            DataTable tblRespuesta2;

           // tblRespuesta2 = logica2.listados_diagnostico(Convert.ToInt32(TextBox1.Text));
            //GridView1.DataSource = tblRespuesta2;
            GridView1.DataBind();
            
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            ClassDiagnostico logica = new ClassDiagnostico();
            int respuesta_diagnostico = 0;
            respuesta_diagnostico = logica.InsertaDiagnostico(Calendar1.SelectedDate, 1, TextBoxMotivo.Text, TextBoxPeso.Text, TextBoxTemperatura.Text, TextBoxCardiaca.Text, TextBoxRespiratoria.Text, TextBoxTllc.Text, TextBoxMucosas.Text, TextBoxTungencia.Text, TextBoxPulso.Text, TextBoxAnamnesis.Text, TextBoxEnfermedades.Text, TextBoxActitud.Text, TextBoxCondicionCorporal.Text, TextBoxHidratacion.Text, TextBoxojos.Text, TextBoxOidos.Text, TextBoxNodulos.Text, TextBoxLocomocion.Text, TextBoxMusculoEsqueletico.Text, TextBoxNervioso.Text, TextBoxCardiobascular.Text, TextBoxDigestivo.Text, TextBoxRespiratorio.Text, TextBoxGeniouriano.Text, TextBoxProblemasEncontrados.Text, TextBoxDiagnosticoPresuntivo.Text, TextBoxDiagnosticoDefinitivo.Text, TextBoxResultados.Text, TextBoxProgreso.Text);


            if (respuesta_diagnostico == 1)
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
                tblRespuesta2 = logica.codigo_animal(TextBox1.Text);

                if (tblRespuesta2 != null)
                {
                    if (tblRespuesta2.Rows.Count > 0)
                    {

                        codiAnimal = Convert.ToInt32(tblRespuesta2.Rows[0][0].ToString());

                    }
                }

                int respuesta2 = 0;
                respuesta2 = logica.InsertaDiagnosticoAnimal(codiAnimal, codigoHistorial);
                GridView1.DataBind();

              
            }
            else
            {
                Label1.Text = "Error durante el proceso, porfavor verifique los datos";
            }
        }

    }
}