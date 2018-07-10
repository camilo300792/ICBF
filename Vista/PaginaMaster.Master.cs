using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class PaginaMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["idUsuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            int idUsuario = (int)Session["idUsuario"];
            UsuarioDAO usuario = new UsuarioDAO();
            if (!IsPostBack)
            {
                repeaterICBF.DataSource = usuario.permisosUsuario(idUsuario);
                repeaterICBF.DataBind();
            }

        }
    }
}