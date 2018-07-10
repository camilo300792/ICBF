using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class RegistroAcademico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosInfanteDAO infantes = new DatosInfanteDAO();
            MasterDAO master = new MasterDAO();
            ddlInfante.DataSource = infantes.listarInfantes();
            ddlInfante.DataTextField = "_infante";
            ddlInfante.DataValueField = "_idInfante";
            ddlInfante.DataBind();
            ddlNivelAcademico.DataSource = master.listarNivelesInfante();
            ddlNivelAcademico.DataTextField = "nombre";
            ddlNivelAcademico.DataValueField = "idMaster";
            ddlNivelAcademico.DataBind();
            ddlNota.DataSource = master.listarNotas();
            ddlNota.DataTextField = "nombre";
            ddlNota.DataValueField = "idMaster";
            ddlNota.DataBind();
        }

        protected void btnRegistroAcademico_Click(object sender, EventArgs e)
        {
            RegistroAcademicoDAO registroAcademico = new RegistroAcademicoDAO();
            registroAcademico.crearRegistro(int.Parse(ddlInfante.SelectedValue), txtAnioEscolar.Text, int.Parse(ddlNivelAcademico.SelectedValue), int.Parse(ddlNota.SelectedValue), txtDescripcion.Text, DateTime.Parse(txtFechaEntrega.Text));
            Response.Write("<script>alert('El registro se ha alamcenado satisfactoriamente')</script>");
        }
    }
}