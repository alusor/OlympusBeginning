using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Material
{
    public partial class service : System.Web.UI.Page
    {
        Connection Connect1 = new Connection();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        string nombreusuario;
        Configuration webConfigApp = WebConfigurationManager.OpenWebConfiguration("~");

        protected void Page_Load(object sender, EventArgs e)
        {
            string opType = Request.QueryString["type"];

            if (opType == "select")
            {
                string UserName = Request.QueryString["username"];

                string sql1 = "select Score from OBUsers where UserName = '" + UserName + "'";
                SqlCommand comando1 = new SqlCommand(sql1, con);
                con.Open();
                SqlDataReader leer1 = comando1.ExecuteReader();
                if (leer1.Read() == true)
                {
                    int Score = leer1.GetInt32(leer1.GetOrdinal("Score"));
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write(Score.ToString());
                    Response.End(); 
                    con.Close();
                }
                else
                {
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write("0");
                    Response.End(); 
                }
            }

            if (opType == "update")
            {
                string UserName = Request.QueryString["username"];
                string Score = Request.QueryString["score"];

                if (Connect1.actualizar("OBUsers", "Score = " + Score, "UserName = '" + UserName + "'"))
                {
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write("1");
                    Response.End();
                }
                else
                {
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write("0");
                    Response.End(); 
                }
            }
            if (opType == "insert")
            {
                string UserName = Request.QueryString["username"];

                if (Connect1.insertar("insert into OBUsers values ('" + UserName + "', 0);"))
                {
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write("1");
                    Response.End();
                }
                else
                {
                    Response.Clear();
                    Response.ContentType = "text/plain";
                    Response.Write("0");
                    Response.End();
                }
            }
        }
    }
}