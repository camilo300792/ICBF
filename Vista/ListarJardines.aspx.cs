using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class ListarJardines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarTabla();
            }
        }

        public void llenarTabla()
        {
            JardinDAO jardines = new JardinDAO();
            gvJardines.DataSource = jardines.listarJardines();
            gvJardines.DataBind();
        }

        public void gvJardines_RowDataBound(Object sender, GridViewRowEventArgs e)
        {
            MasterDAO estadosJardin = new MasterDAO();
            DropDownList ddlEstadoJardin = (DropDownList)e.Row.FindControl("ddlEstadoJardin");
            if (ddlEstadoJardin != null)
            {
                ddlEstadoJardin.DataSource = estadosJardin.listarEstadosJardin();
                ddlEstadoJardin.DataTextField = "nombre";
                ddlEstadoJardin.DataValueField = "idMaster";
                ddlEstadoJardin.DataBind();
            }
        }

        protected void gvJardines_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            JardinDAO jardin = new JardinDAO();
            try
            {
                Label lbId = (Label)gvJardines.Rows[e.RowIndex].FindControl("lblId");
                jardin.eliminarJardin(int.Parse(lbId.Text));
                llenarTabla();
                Response.Write("<script>alert('El registro ha sido eliminado satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            
        }

        protected void gvJardines_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            JardinDAO jardin = new JardinDAO();
            try
            {
                Label lbId = (Label) gvJardines.Rows[e.RowIndex].FindControl("lblId");
                TextBox txtNombre = (TextBox) gvJardines.Rows[e.RowIndex].FindControl("txtNombre");
                TextBox txtDireccion = (TextBox) gvJardines.Rows[e.RowIndex].FindControl("txtDireccion");
                DropDownList ddlEstadoJardin = (DropDownList) gvJardines.Rows[e.RowIndex].FindControl("ddlEstadoJardin");
                jardin.editarJardin(int.Parse(lbId.Text), txtNombre.Text, txtDireccion.Text, int.Parse(ddlEstadoJardin.SelectedValue));
                gvJardines.EditIndex = -1;
                llenarTabla();
                Response.Write("<script>alert('Los Datos han sido actualizados satisfactoriamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void gvJardines_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvJardines.EditIndex = e.NewEditIndex;
            llenarTabla();
        }

        protected void gvJardines_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvJardines.EditIndex = -1;
            llenarTabla();
        }
    }
}