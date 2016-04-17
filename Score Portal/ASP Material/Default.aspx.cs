using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Configuration;

namespace ASP_Material
{
    public partial class Default : System.Web.UI.Page
    {
        Connection Connect1 = new Connection();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        string nombreusuario;
        Configuration webConfigApp = WebConfigurationManager.OpenWebConfiguration("~");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == " ")
            {
                Response.Redirect("Login.aspx");
            }

            string usr = Application["usr"].ToString();
            Application["usr"] = usr;

            string sql1 = "select Score from OBUsers where UserName = '" + usr + "'";
            SqlCommand comando1 = new SqlCommand(sql1, con);
            con.Open();
            SqlDataReader leer1 = comando1.ExecuteReader();
            if (leer1.Read() == true)
            {
                int Score = leer1.GetInt32(leer1.GetOrdinal("Score"));
                ScoreActual.Text = Score.ToString();
                con.Close();
            }

            grvScoreBoard.DataSource = Connect1.consultarTabla("top 10 [UserName], [Score]", "OBUsers", "order by Score desc");
            grvScoreBoard.DataBind();
        }
    }
}