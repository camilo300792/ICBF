using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
namespace Vista
{
    public partial class Jardin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterDAO estadosJardin = new MasterDAO();
            ddlEstadoJardin.DataSource = estadosJardin.listarEstadosJardin();
            ddlEstadoJardin.DataTextField = "nombre";
            ddlEstadoJardin.DataValueField = "idMaster";
            ddlEstadoJardin.DataBind();
        }

        protected void btnCrearAcudiente_Click(object sender, EventArgs e)
        {
            JardinDAO jardin = new JardinDAO();
            try
            {
                jardin.verificarJardin(txtNombre.Text);
                jardin.crearJardin(txtNombre.Text, txtDireccion.Text, int.Parse(ddlEstadoJardin.SelectedValue));
                Response.Write("<script type='text/javascript'>alert('Los datos han sido almacenados satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "')</script>");
            }
        }

        
    }
}