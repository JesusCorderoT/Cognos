using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Usuarios
{
    public partial class Create : System.Web.UI.Page
    {
        NUsuarios _capNU = new NUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {


            Entidades.Usuarios usuInse = new Entidades.Usuarios();
            usuInse.nombre = txtNombre.Text;
            usuInse.apellidoPaterno = txtPa.Text;
            usuInse.apellidoMaterno = txtSp.Text;
            usuInse.fechaNacimiento = Convert.ToDateTime(txtFn.Text);
            usuInse.correo = txtCorreo.Text;
            usuInse.usuario = txtUsuario.Text;
            usuInse.contrasena = txtContra.Text;
            _capNU.Agregar(usuInse);
            Response.Redirect($"Index.aspx");

            
        }


    }
}