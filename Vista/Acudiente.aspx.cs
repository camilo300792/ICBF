using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterDAO master = new MasterDAO();
            ddlTipoDocumento.DataSource = master.listarDocumentos();
            ddlTipoDocumento.DataValueField = "idMaster";
            ddlTipoDocumento.DataTextField = "nombre";
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
                int idPersona = persona.crearPersona(_nombre: txtNombre.Text, _telefono: txtTelefono.Text, _direccion: txtDireccion.Text, _correo: txtCorreo.Text, _celular: txtCelular.Text, _tipoDocumento: int.Parse(ddlTipoDocumento.SelectedValue), _numeroDocumento: txtDocumento.Text );
                usuario.crearUsuario(idPersona, 3, txtCorreo.Text, txtDocumento.Text);
                Response.Write("<script type='text/javascript'>alert('Los datos fueron alamcenados satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script language='JavaScript'>alert(" + ex.Message  + "');</script>");
            }
        }
    }
}