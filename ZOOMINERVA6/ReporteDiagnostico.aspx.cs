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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            TextBoxMotivo.Text = row.Cells[3].Text;
            TextBoxPeso.Text = row.Cells[4].Text;
            TextBoxTemperatura.Text = row.Cells[5].Text;
            TextBoxCardiaca.Text = row.Cells[6].Text;
            TextBoxRespiratoria.Text = row.Cells[7].Text;
            TextBoxTllc.Text = row.Cells[8].Text;
            TextBoxMucosas.Text = row.Cells[9].Text;

            TextBoxTungencia.Text = row.Cells[10].Text;
            TextBoxPulso.Text = row.Cells[11].Text;
            TextBoxAnamnesis.Text = row.Cells[12].Text;
            TextBoxEnfermedades.Text = row.Cells[13].Text;
            TextBoxActitud.Text = row.Cells[14].Text;
            TextBoxCondicionCorporal.Text = row.Cells[15].Text;
            TextBoxLocomocion.Text = row.Cells[16].Text;
            TextBoxMusculoEsqueletico.Text = row.Cells[17].Text;
            TextBoxNervioso.Text = row.Cells[18].Text;
            TextBoxCardiobascular.Text = row.Cells[19].Text;
            TextBoxDigestivo.Text = row.Cells[20].Text;
            TextBoxRespiratorio.Text = row.Cells[21].Text;
            TextBoxGeniouriano.Text = row.Cells[22].Text;
            TextBoxProblemasEncontrados.Text = row.Cells[23].Text;
            TextBoxDiagnosticoPresuntivo.Text = row.Cells[24].Text;
            TextBoxResultados.Text = row.Cells[25].Text;
            TextBoxProgreso.Text = row.Cells[26].Text;
            
            Calendar1.SelectedDate = Convert.ToDateTime(row.Cells[2].Text);
        }
    }
}