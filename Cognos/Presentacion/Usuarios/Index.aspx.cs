using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Usuarios
{
    public partial class Index : System.Web.UI.Page
    {

        NUsuarios capNU = new NUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                grdUsuarios.DataSource = capNU.Consultar();
                // ListaNombre();
                grdUsuarios.DataBind();
            }
        }




        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }

        protected void grdUsuarios_PageIndexChanged(object sender, EventArgs e)
        {
            //grdUsuarios.PageIndex = e.NewPageIndex;
              // ListaNombre();
               grdUsuarios.DataBind();
        }

        protected void grdUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
                if (e.CommandName == "Page")
                {
                    return;
                }

                int nRen = Convert.ToInt32(e.CommandArgument);

                GridViewRow renglon = grdUsuarios.Rows[nRen];


                TableCell cel = renglon.Cells[0];

                int id = Convert.ToInt32(cel.Text);

                switch (e.CommandName)
                {

                    case "CommandEdit":
                        Response.Redirect($"Edit.aspx?id={id}");
                        break;
                    case "CommandDel":
                        Response.Redirect($"Delete.aspx?id={id}");
                        break;
                    case "CommandSel":
                        Response.Redirect($"Details.aspx?id={id}");
                        break;

                }

            }

        protected void grdUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}