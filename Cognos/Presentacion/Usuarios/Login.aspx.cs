using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using System.Configuration;

namespace Presentacion.Usuarios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CognosConnection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from USUARIO where usuario = @usuario and contrasena = @contrasena", con);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@contrasena", txtContra.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Response.Redirect("Index.aspx");

            }

            else
            {

                Label3.Visible = true;
                Label3.Text = "Inicio de sesion incorrecto";
            }
        }
        
    }
}