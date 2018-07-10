using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class MadreComunitaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterDAO tiposDocumento = new MasterDAO();
            ddlTipoDocumento.DataSource = tiposDocumento.listarDocumentos();
            ddlTipoDocumento.DataTextField = "nombre";
            ddlTipoDocumento.DataValueField = "idMaster";
            ddlTipoDocumento.DataBind();
        }

        protected void btnCrearAcudiente_Click(object sender, EventArgs e)
        {
            PersonaDAO persona = new PersonaDAO();
            UsuarioDAO usuario = new UsuarioDAO();
            try
            {
                persona.validarMail(txtCorreo.Text);
                persona.verificarPersona(txtDocumento.Text);
                persona.verificarPersonaXCorreo(txtCorreo.Text);
                int idPersona = persona.crearPersona(_nombre: txtNombre.Text, _fechaNacimiento: DateTime.Parse(txtFechaNacimiento.Text), _tipoDocumento: int.Parse(ddlTipoDocumento.SelectedValue), _numeroDocumento: txtDocumento.Text, _direccion: txtDireccion.Text, _telefono: txtTelefono.Text, _correo: txtCorreo.Text);
                usuario.crearUsuario(idPersona, 2, txtCorreo.Text, txtDocumento.Text);
                Response.Write("<script type='text/javascript'>alert('Los datos han sido almacenados satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "')</script>");
            }

        }
    }
}