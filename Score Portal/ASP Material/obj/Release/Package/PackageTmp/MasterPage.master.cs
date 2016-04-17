using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASP_Material
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        Connection Connect1 = new Connection();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == " ")
            {
                Response.Redirect("Login.aspx");
            }

            try
            {
                string usr = Application["usr"].ToString();
                Application["usr"] = usr;

                Label_User.Text = usr;
                Rol.Text = "Player";
            }
            catch { }
        }
    }
}
