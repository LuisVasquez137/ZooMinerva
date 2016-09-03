using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZOOMINERVA6
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetImageUrl();

            }

            if (Login.bandera == 1)
            {
                    LinkButton8.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = true;
                    LinkButton11.Visible = true;
                    LinkButton12.Visible = true;
                    LinkButton13.Visible = true;
                    LinkButton14.Visible = true;
                    LinkButton15.Visible = true;
                LinkButton16.Visible = true;
                LinkButton17.Visible = true;

                LinkButton18.Visible = true;
            }
            else
            {
                LinkButton8.Visible = false;
                LinkButton9.Visible = false;
                LinkButton10.Visible = false;
                LinkButton11.Visible = false;
                LinkButton12.Visible = false;
                LinkButton13.Visible = false;
                LinkButton14.Visible = false;
                LinkButton15.Visible = false;
                LinkButton16.Visible = false;
                LinkButton17.Visible = false;
                LinkButton18.Visible = false;
            }
            }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SetImageUrl();

        }

        private void SetImageUrl()
        {
            Random _rand = new Random();
            int i = _rand.Next(1, 5);

            Image1.ImageUrl = "~/images2/" + i.ToString() + ".jpg";
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empleados.aspx");
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {
            Login.bandera = 0;
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton17_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregaPaquetes.aspx");
        }

        protected void LinkButton18_Click(object sender, EventArgs e)
        {
            Response.Redirect("Diagnostico.aspx");
        }
    }
}