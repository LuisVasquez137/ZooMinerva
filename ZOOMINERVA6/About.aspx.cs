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
    public partial class About : Page
    {
        public static string info;
        public static string mision;
        public static string vision;
        public static string direccion;
        public static string telefono;
        public static string horario;
        protected void Page_Load(object sender, EventArgs e)
        {

            Image1.ImageUrl = "~/images/zoo.jpg";

            ClassZoologico zoo = new ClassZoologico();
            DataTable tblRespuesta;

            tblRespuesta = zoo.lista_zoologico();


            if (tblRespuesta != null)
            {
                if (tblRespuesta.Rows.Count > 0)
                {
                    info=tblRespuesta.Rows[0][1].ToString();
                    mision = tblRespuesta.Rows[0][2].ToString();
                    vision = tblRespuesta.Rows[0][3].ToString();
                    direccion = tblRespuesta.Rows[0][4].ToString();
                    telefono = tblRespuesta.Rows[0][5].ToString();
                    horario = tblRespuesta.Rows[0][8].ToString();



                    Label1.Text = info;
                    LabelMision.Text = mision;
                    LabelVision.Text = vision;
                    LabelDireccion.Text = direccion;
                    LabelTelefono.Text = telefono;
                    LabelHorario.Text = horario;

                }
            }
        }
    }
}