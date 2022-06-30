using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.Usuarios
{
    public partial class Details : System.Web.UI.Page
    {
        NUsuarios _capNU = new NUsuarios();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");


            Entidades.Usuarios userDE = _capNU.Consultar(id);

            lblId.Text = userDE.id.ToString();
            lblNombre.Text = userDE.nombre.ToString();
            lblPa.Text = userDE.apellidoPaterno.ToString();
            lblSp.Text = userDE.apellidoMaterno.ToString();
            lblFn.Text = userDE.fechaNacimiento.ToString();
            lblCorreo.Text = userDE.correo.ToString();
            lblUsuario.Text = userDE.usuario.ToString();
            lblContra.Text = userDE.contrasena.ToString();

        }
    }
}