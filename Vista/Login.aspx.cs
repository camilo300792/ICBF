using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Modelo;
using Datos;

namespace Vista
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string redirect = null;
            try
            {
                UsuarioDAO usuario = new UsuarioDAO();
                Usuario usuarioSession = usuario.verificarUsuario(loginICBF.UserName);
                if (loginICBF.Password != usuarioSession.contrasena) throw new Exception("Contraseña Incorrecta");
                Session["idUsuario"] = usuarioSession.idUsuario;
                Session["idRol"] = usuarioSession.idRol;
                if ((int)Session["idRol"] == 1) redirect = "Acudiente.aspx";
                if ((int)Session["idRol"] == 2) redirect = "RegistroAsistencia.aspx";
                if ((int)Session["idRol"] == 3) redirect = "Reportes.aspx";
                Response.Redirect(redirect);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}