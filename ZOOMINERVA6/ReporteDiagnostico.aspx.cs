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
        protected void Page_Load(object sender, EventArgs e)
        {
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

            tblRespuesta2 = logica2.listados_diagnostico(Convert.ToInt32(TextBox1.Text));
            GridView1.DataSource = tblRespuesta2;
            GridView1.DataBind();
            
        }
    }
}