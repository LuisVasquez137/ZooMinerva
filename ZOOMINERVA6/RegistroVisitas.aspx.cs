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
    public partial class RegistroVisitas : System.Web.UI.Page
    {
        public static int PK;
        public static double precio = 0;
        public static Table Tabla2;
        ClassZoologico logica = new ClassZoologico();
        protected void Page_Load(object sender, EventArgs e)
        {
 
            if(Login.bandera==0)
            {
                Response.Redirect("Login.aspx");
            }


            // obtiene el precio del paquete


            DataTable tabla3;

            DropDownList1.DataBind();
            tabla3 = logica.precio_paquete(Convert.ToInt32(DropDownList1.SelectedValue));

            if (tabla3 != null)
            {
                if (tabla3.Rows.Count > 0)
                {
                    precio = Convert.ToDouble(tabla3.Rows[0][0].ToString());
                }
            }

        


    }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PK = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
           


            GridViewRow row = GridView1.SelectedRow;

            PK =Convert.ToInt32( row.Cells[1].Text);
            Calendar1.SelectedDate = Convert.ToDateTime(row.Cells[2].Text);
            TextBoxHora.Text = row.Cells[3].Text;
            TextBoxEstablecimiento.Text = row.Cells[4].Text;
            TextBoxDireccion.Text = row.Cells[5].Text;
            TextBoxAlumnos.Text = row.Cells[6].Text;
            TextBoxGrado.Text = row.Cells[7].Text;
            TextBoxTelefono.Text = row.Cells[9].Text;
            TextBoxComentarios.Text = row.Cells[10].Text;

        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {

           
            double num1=0.00;
            num1 = Convert.ToDouble(TextBoxAlumnos.Text);
            double suma;
            suma =  num1 * precio;
            logica.Inserta_Registro(Convert.ToInt32(DropDownList1.SelectedValue), Login.CodigoEmpleado, Calendar1.SelectedDate, TextBoxHora.Text, TextBoxEstablecimiento.Text, TextBoxDireccion.Text, Convert.ToInt32 (TextBoxAlumnos.Text), TextBoxGrado.Text,Convert.ToDecimal( suma), TextBoxTelefono.Text, TextBoxComentarios.Text);
            }
            catch
            {
                Label1.Text = "Debe ingresar los datos en el formato correcto";
            }
            }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            DataTable tabla3;
         
          
          tabla3 = logica.precio_paquete(Convert.ToInt32( DropDownList1.SelectedValue));

            if (tabla3 != null)
            {
                if (tabla3.Rows.Count > 0)
                {
                    precio = Convert.ToDouble(tabla3.Rows[0][0].ToString());
                }
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            logica.Actualiza_Registro(Convert.ToInt32(DropDownList1.SelectedValue), Login.CodigoEmpleado, Calendar1.SelectedDate, TextBoxHora.Text, TextBoxEstablecimiento.Text, TextBoxDireccion.Text,Convert.ToInt32(TextBoxAlumnos.Text), TextBoxGrado.Text, TextBoxTelefono.Text, TextBoxComentarios.Text);
            GridView1.DataBind();
            TextBoxComentarios.Text = "";
            TextBoxDireccion.Text = "";
            TextBoxAlumnos.Text = "";
            TextBoxEstablecimiento.Text = "";
            TextBoxHora.Text = "";
            TextBoxTelefono.Text = "";
            TextBoxGrado.Text="";
        }
    }
}