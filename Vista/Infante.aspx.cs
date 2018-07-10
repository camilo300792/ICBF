using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class Infante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterDAO tiposDocumento = new MasterDAO();
            UsuarioDAO acudientes = new UsuarioDAO();
            CiudadDAO ciudades = new CiudadDAO();
            JardinDAO jardines = new JardinDAO();
            ddlTipoDocumento.DataSource = tiposDocumento.listarDocumentos();
            ddlTipoDocumento.DataTextField = "nombre";
            ddlTipoDocumento.DataValueField = "idMaster";
            ddlTipoDocumento.DataBind();
            ddlAcudiente.DataSource = acudientes.listarAcudientes();
            ddlAcudiente.DataTextField = "_nombre";
            ddlAcudiente.DataValueField = "_idUsuario";
            ddlAcudiente.DataBind();
            ddlCiudadNacimiento.DataSource = ciudades.listarCiudades();
            ddlCiudadNacimiento.DataTextField = "nombre";
            ddlCiudadNacimiento.DataValueField = "idCiudad";
            ddlCiudadNacimiento.DataBind();
            ddlJardin.DataSource = jardines.listarJardines();
            ddlJardin.DataTextField = "_nombre";
            ddlJardin.DataValueField = "idJardin";
            ddlJardin.DataBind();
        }

        protected void btnCrearAcudiente_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaDAO infante = new PersonaDAO();
                DatosInfanteDAO datosInfante = new DatosInfanteDAO();
                infante.verificarPersona(txtDocumento.Text);
                infante.validarEdad(DateTime.Parse(txtFechaIngreso.Text));
                int idInfante = infante.crearPersona(_nombre: txtNombre.Text, _fechaNacimiento: DateTime.Parse(txtFechaNacimiento.Text), _ciudadNacimiento: int.Parse(ddlCiudadNacimiento.SelectedValue), _telefono: txtTelefono.Text, _tipoSangre: txtTipoSangre.Text, _direccion: txtDireccion.Text, _tipoDocumento: int.Parse(ddlTipoDocumento.SelectedValue), _numeroDocumento: txtDocumento.Text);
                datosInfante.guardarDatosInfante(txtEps.Text, int.Parse(ddlJardin.SelectedValue), int.Parse(ddlAcudiente.SelectedValue), idInfante, float.Parse(txtPeso.Text), float.Parse(txtTalla.Text), _fechaIngreso: DateTime.Parse(txtFechaIngreso.Text));
                Response.Write("<script type='text/javascript'>alert('Los Datos del infante han sido almacenados satisfactoriamente')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script type='text/javascript'>alert('" + ex.Message + "')</script>");
            }
        }
    }
}