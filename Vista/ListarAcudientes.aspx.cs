using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class ListarAcudientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                acudientesBind();
            }
        }

        protected void acudientesBind()
        {
            UsuarioDAO acudientes = new UsuarioDAO();
            dgvAcudientes.DataSource = acudientes.listarAcudientes();
            dgvAcudientes.DataBind();
        }


        protected void dgvAcudientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvAcudientes.EditIndex = e.NewEditIndex;
            acudientesBind();
        }

        protected void dgvAcudientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                UsuarioDAO usuario = new UsuarioDAO();
                PersonaDAO persona = new PersonaDAO();
                Label lbId = (Label)dgvAcudientes.Rows[e.RowIndex].FindControl("lblId");
                TextBox txtNombre = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtNombre");
                TextBox txtDocumento = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtDocumento");
                DropDownList ddlTipoDocumento = (DropDownList)dgvAcudientes.Rows[e.RowIndex].FindControl("ddlTipoDocumento");
                TextBox txtCorreo = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtCorreo");
                TextBox txtTelefono = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtTelefono");
                TextBox txtCelular = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtCelular");
                TextBox txtDireccion = (TextBox)dgvAcudientes.Rows[e.RowIndex].FindControl("txtDireccion");
                usuario.editarUsuario(int.Parse(lbId.Text), txtCorreo.Text, txtDocumento.Text);
                persona.editarPersona(int.Parse(lbId.Text), _nombre: txtNombre.Text, _numeroDocumento: txtDocumento.Text, _tipoDocumento: int.Parse(ddlTipoDocumento.SelectedValue), _correo: txtCorreo.Text, _celular: txtCelular.Text, _telefono: txtTelefono.Text, _direccion: txtDireccion.Text);
                acudientesBind();
                Response.Write("<script>alert('Los datos han sido actualizados satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void dgvAcudientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvAcudientes.EditIndex = -1;
            acudientesBind();
        }

        protected void dgvAcudientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                UsuarioDAO usuario = new UsuarioDAO();
                Label lbId = (Label) dgvAcudientes.Rows[e.RowIndex].FindControl("lblId");
                usuario.eliminarUsuario(int.Parse(lbId.Text));
                acudientesBind();
                Response.Write("<script>alert('El usuario ha sido eliminado satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void dgvAcudientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            MasterDAO tipoDocumentos = new MasterDAO();
            DropDownList ddlTipoDocumento = (DropDownList)e.Row.FindControl("ddlTipoDocumento");
            if (ddlTipoDocumento != null)
            {
                ddlTipoDocumento.DataSource = tipoDocumentos.listarDocumentos();
                ddlTipoDocumento.DataTextField = "nombre";
                ddlTipoDocumento.DataValueField = "idMaster";
                ddlTipoDocumento.DataBind();
            }
        }
    }
}