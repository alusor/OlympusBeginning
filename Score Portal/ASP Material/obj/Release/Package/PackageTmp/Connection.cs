using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ASP_Material
{
    public class Connection
    {
        public SqlConnection con;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;
        public DataTable dt;
    
        //LLamar cadena de conexion Web Config
        public void conectar(){
        string cadena = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        con = new SqlConnection(cadena);
        }

        //Metodo constructor
        public Connection() {
            conectar();
        }

        //Consulta Login
        public bool consultar1(string tabla, string campo, string dato) {
            string sql = "Select * from " + tabla + " where " + campo + "='" + dato + "'";
            con.Open();
            da = new SqlDataAdapter(sql, con); 
            dt = new DataTable();
            da.Fill(dt); //se debe agregar el IIS AppPool Default AppPool a la DB | No aplica en Azure
            con.Close();
            if (dt.Rows.Count > 0) {
                return true;
            } else {
                return false;
            }

        }
        
        //Metodo para realizar la consulta a las tablas
        public DataTable consultarTabla(string campos, string tabla, string filter)
        {
            string sql = "select " + campos + " from " + tabla + " " + filter;
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, tabla);
            con.Close();
            dt = new DataTable();
            dt = ds.Tables[tabla];
            return dt;
        }
        
        //Metodo para insertar los datos a las tablas 
        public bool insertar(string sql) {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Consulta para buscar registros duplicados
        public bool consultar3(string campo1, string tabla, string campo2, string campo3)
        {
            string sql = "Select " + campo1 + " from " + tabla + " where " + campo2 + "='" + campo3 + "'";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt); //se debe agregar el IIS AppPool Default AppPool a la DB | No aplica en Azure
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Metodo para actualizar datos
        public bool actualizar(string tabla, string campos, string condicion)
        {
            string sql = "update " + tabla + " set " + campos + " where " + condicion;
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        //Metodo para eliminar datos
        public bool eliminar(string tabla, string condicion)
        {
            string sql = "delete from " + tabla + " where " + condicion;
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            { 
                return true;            
            }
            else
            {
                return false;
            }
        }
        
        //Metodo para buscar registros en la base de datos
        public DataTable consultar4(string campo1, string tabla, string campo2, string campo3)
        {
            string sql = "select " + campo1 + " from " + tabla + " where " + campo2 + " like '%" + campo3 + "%'";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, tabla);
            dt = new DataTable();
            dt = ds.Tables[tabla];
            con.Close();
            return dt;
        }

        public DataTable consultar4detalle(string campo1, string tabla, string campo2, string campo3, string condicion1, string condicion2)
        {
            string sql = "select " + campo1 + " from " + tabla + " where " + campo2 + " like '%" + campo3 + "%' and " + condicion1 + " ='" + condicion2 + "'";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, tabla);
            dt = new DataTable();
            dt = ds.Tables[tabla];
            con.Close();
            return dt;
        }

        public bool consultarfiltroabiertobool(string campos, string tabla, string condicion1, string condicion2, string condicion3, string condicion4, string condicion5, string condicion6, string condicion7)
        {
            string sql = "select " + campos + " from " + tabla + " where " + condicion1 + " = " + condicion2 + " or " + condicion1 + " = " + condicion3 + " or " + condicion1 + " = " + condicion4 + " or " + condicion1 + " = " + condicion5 + " or " + condicion1 + " = " + condicion6 + " or " + condicion1 + " = " + condicion7;
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt); //se debe agregar el IIS AppPool Default AppPool a la DB | No aplica en Azure
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool consultarfiltrousuarioestatusbool(string campos, string tabla, string usuario, string nombreusuario, string condicion1, string condicion2, string condicion3, string condicion4, string condicion5, string condicion6, string condicion7)
        {
            string sql = "select " + campos + " from " + tabla + " where (" + usuario + " = " + nombreusuario + ") and (" + condicion1 + " = " + condicion2 + " or " + condicion1 + " = " + condicion3 + " or " + condicion1 + " = " + condicion4 + " or " + condicion1 + " = " + condicion5 + " or " + condicion1 + " = " + condicion6 + " or " + condicion1 + " = " + condicion7 + ")";
            con.Open();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt); //se debe agregar el IIS AppPool Default AppPool a la DB | No aplica en Azure
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}