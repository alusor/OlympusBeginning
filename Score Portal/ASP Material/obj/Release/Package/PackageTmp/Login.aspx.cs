using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Material
{
    public partial class Login : System.Web.UI.Page
    {
        Connection connect = new Connection();
        bool usuarios;
        public string usr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null)
                {
                    Textbox_User.Text = Request.Cookies["UserName"].Value;
                }
            }
        }
        public void Button_Entrar_Click(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
            }
            else
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);

            }
            Response.Cookies["UserName"].Value = Textbox_User.Text.Trim();

            if (Textbox_User.Text == " ")
            {
                Textbox_User.Focus();
            }
            else
            {
                try
                {
                    usuarios = connect.consultar1("OBUsers", "UserName", Textbox_User.Text);
                    if (usuarios)
                    {
                        Session["usuario"] = usuarios;
                        usr = Textbox_User.Text;
                        Application["usr"] = usr;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        Label_Mensaje.Text = "<center> Usuario no encontrado </center> <br>";
                    }
                }
                catch { Label_Mensaje.Text = "Error de Acceso a la DB..."; }
            }
        }
    }
}