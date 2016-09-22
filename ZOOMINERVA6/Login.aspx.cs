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
    public partial class Login : System.Web.UI.Page
    {
        public static int bandera = 0;
        public static int ban = 0;
        public static int CodigoEmpleado=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Attributes.Add("style", "Color:Blue; border-radius: 25px;  background: #73AD21;  padding: 20px; width: 200px;  height: 150px; ");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClassEmpleado logicalog = new ClassEmpleado();
            DataTable tblRespuesta;
            tblRespuesta = logicalog.Loguear_usuario(this.TextBox1.Text, this.TextBox2.Text);

            int conteo;

            conteo = tblRespuesta.Rows.Count;

            if (tblRespuesta != null)
            {
                if (conteo > 0)
                {

                    DataTable TablaCodigo;
                    TablaCodigo = logicalog.ObtieneCodigoEmpleado(TextBox1.Text, TextBox2.Text);

                    CodigoEmpleado=Convert.ToInt32(TablaCodigo.Rows[0][0].ToString());
                    Label4.Text = "Bienvenido";
                    bandera = 1;
                    Response.Redirect("Default.aspx");
                }
            }


            if (tblRespuesta.Rows.Count == 0)
            {
                Label4.Text = "Usted no esta registrado";
            }
        }
    }
}