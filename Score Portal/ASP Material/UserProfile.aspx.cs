using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Drawing;

namespace ASP_Material
{
    public partial class UserProfile : System.Web.UI.Page
    {
        Connection Connect1 = new Connection();
        Connection Connect2 = new Connection();
        Connection Connect3 = new Connection();
        Connection Connect4 = new Connection();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == " ")
            {
                Response.Redirect("Login.aspx");
            }

            //Transmitir Informacion entre Paginas
            string usr = Application["usr"].ToString();
            Application["usr"] = usr;

            //Revisar Privilegios Usuario
            string sql2 = "select Grupo from Usuarios where Usuario = '" + usr + "'";
            SqlCommand comando2 = new SqlCommand(sql2, con);
            con.Open();
            SqlDataReader leer2 = comando2.ExecuteReader();
            if (leer2.Read() == true)
            {
                string grupo = leer2.GetString(leer2.GetOrdinal("Grupo"));

                if (grupo == "Administrador")
                {

                }
                else
                {
                    
                }
            }

            con.Close();

            Button_Actualizar.Visible = true;
            Button_Guardar.Visible = false;
            Label_MensajeProveedor.Visible = false;

            Label_Nombre.Visible = true;
            Label_Nombre.Visible = true;
            
            //Get User Data to Form
            if (IsPostBack == false)
            { 

                TextBox_Usuario.Text = usr;

                string sqlNombre = "select Nombre from Usuarios where Usuario = '" + usr + "'";
                SqlCommand comandoNombre = new SqlCommand(sqlNombre, con);
                con.Open();
                SqlDataReader leerNombre = comandoNombre.ExecuteReader();
                if (leerNombre.Read() == true)
                {
                    string Nombre = leerNombre.GetString(leerNombre.GetOrdinal("Nombre"));
                    TextBox_Nombre.Text = Nombre;
                    con.Close();
                
                }


                string sqlContraseña = "select Contraseña from Usuarios where Usuario = '" + usr + "'";
                SqlCommand comandoContraseña = new SqlCommand(sqlContraseña, con);
                con.Open();
                SqlDataReader leerContraseña = comandoContraseña.ExecuteReader();
                if (leerContraseña.Read() == true)
                {
                    string Contraseña = leerContraseña.GetString(leerContraseña.GetOrdinal("Contraseña"));
                    TextBox_Contraseña.Text = Contraseña;
                    TextBox_Contraseña.Attributes["type"] = "password";
                    con.Close();
                }

            }
        }

        protected void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        public static bool validarcorreo(string correo)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(correo, expresion))
            {
                if (System.Text.RegularExpressions.Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void guardardatos()
        {
            
        }

        protected void Button_Guardar_Click(object sender, EventArgs e)
        {
            guardardatos();
        }

        private void Actualizar()
        {
            string campos = "nombre = '" + TextBox_Nombre.Text + "', contraseña='" + TextBox_Contraseña.Text + "'";
            //string id = TextBox_Id.Text;
            //Condicion que valua la funcionl
            //string id = GridView1.Rows[e.RowIndex].Cells[2].Text;
            if (Connect1.actualizar("Usuarios", campos, "Usuario = '" + TextBox_Usuario.Text + "'"))
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button_Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        protected void TextBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }


        protected void TextBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Correo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox_Contraseña_TextChanged(object sender, EventArgs e)
        {
            
        }
        

    }
}