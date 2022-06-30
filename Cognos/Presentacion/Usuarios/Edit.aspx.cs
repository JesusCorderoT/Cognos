using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Usuarios
{
    public partial class Edit : System.Web.UI.Page
    {
        NUsuarios capNU = new NUsuarios();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");
                Entidades.Usuarios users = capNU.Consultar(id);
                txtId.Text = users.id.ToString();
                txtNombre.Text = users.nombre.ToString();
                txtPa.Text = users.apellidoPaterno.ToString();
                txtSp.Text = users.apellidoMaterno.ToString();
                txtFn.Text = String.Format("{0:yyyy-MM-dd}", users.fechaNacimiento);
                txtCorreo.Text = users.correo.ToString();
                txtUsuario.Text = users.usuario.ToString();
                txtContra.Text = users.contrasena.ToString();
            }

            }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
          
                int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");
                Entidades.Usuarios UpUser = capNU.Consultar(id);
                UpUser.nombre = txtNombre.Text;
                UpUser.apellidoPaterno = txtPa.Text;
                UpUser.apellidoMaterno = txtSp.Text;
                UpUser.fechaNacimiento = Convert.ToDateTime(txtFn.Text);
                UpUser.correo = txtCorreo.Text;
                UpUser.usuario = txtUsuario.Text;
                UpUser.contrasena = txtContra.Text;
                capNU.Actualizar(UpUser);
                Response.Redirect($"Index.aspx");
            
        }
    }
}