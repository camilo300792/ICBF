using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class ListarMadresComunitarias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGrilla();
            }
        }

        public void llenarGrilla()
        {
            UsuarioDAO masdresComunitarias = new UsuarioDAO();
            gvMadresComunitarias.DataSource = masdresComunitarias.listarMadresComunitarias();
            gvMadresComunitarias.DataBind();
        }

        protected void gvMadresComunitarias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMadresComunitarias.EditIndex = e.NewEditIndex;
            llenarGrilla();
        }

        protected void gvMadresComunitarias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            UsuarioDAO madreComunitaria = new UsuarioDAO();
            PersonaDAO persona = new PersonaDAO();
            try
            {
                Label lbId = (Label)gvMadresComunitarias.Rows[e.RowIndex].FindControl("lblId");
                TextBox txtNombre = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtNombre");
                TextBox txtDireccion = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtDireccion");
                TextBox txtDocumento = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtDocumento");
                TextBox txtFechaNacimiento = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtFechaNacimiento");
                TextBox txtCorreo = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtCorreo");
                TextBox txtTelefono = (TextBox)gvMadresComunitarias.Rows[e.RowIndex].FindControl("txtTelefono");
                DropDownList ddlTipoDocumento =(DropDownList)gvMadresComunitarias.Rows[e.RowIndex].FindControl("ddlTipoDocumento");
                madreComunitaria.editarUsuario(int.Parse(lbId.Text), _documento: txtDocumento.Text);
                persona.editarPersona(int.Parse(lbId.Text), _nombre: txtNombre.Text, _direccion: txtDireccion.Text, _numeroDocumento: txtDocumento.Text, _fechaNacimiento: DateTime.Parse(txtFechaNacimiento.Text), _correo: txtCorreo.Text, _telefono: txtTelefono.Text, _tipoDocumento: int.Parse(ddlTipoDocumento.SelectedValue));
                Response.Write("<script>alert('Los datos han sido almacenados satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            
        }

        protected void gvMadresComunitarias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            UsuarioDAO madreComunitaria = new UsuarioDAO();
            try
            {
                Label lbId = (Label)gvMadresComunitarias.Rows[e.RowIndex].FindControl("lblId");
                madreComunitaria.eliminarUsuario(int.Parse(lbId.Text));
                Response.Write("<script>alert('El usuario ha sido eliminado satisfactoriamente')</script>");
            } catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void gvMadresComunitarias_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            MasterDAO tiposDocumento = new MasterDAO();
            DropDownList ddlTipoDocumento = (DropDownList)e.Row.FindControl("ddlTipoDocumento");
            if(ddlTipoDocumento != null)
            {
                ddlTipoDocumento.DataSource = tiposDocumento.listarDocumentos();
                ddlTipoDocumento.DataTextField = "nombre";
                ddlTipoDocumento.DataValueField = "idMaster";
                ddlTipoDocumento.DataBind();
            }
        }

        protected void gvMadresComunitarias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMadresComunitarias.EditIndex = -1;
            llenarGrilla();
        }
    }
}