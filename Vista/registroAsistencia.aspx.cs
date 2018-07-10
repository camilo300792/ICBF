using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class registroAsistencia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatosInfanteDAO infantes = new DatosInfanteDAO();
            MasterDAO estadosInfante = new MasterDAO();
            if (!IsPostBack)
            {
                lblFecha.Text = DateTime.Now.Date.ToString();
                txtFecha.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
                ddlInfante.DataSource = infantes.listarInfantes();
                ddlInfante.DataTextField = "_infante";
                ddlInfante.DataValueField = "_idInfante";
                ddlInfante.DataBind();
                ddlEstadoInfante.DataSource = estadosInfante.listarEstadosInfante();
                ddlEstadoInfante.DataTextField = "nombre";
                ddlEstadoInfante.DataValueField = "idMaster";
                ddlEstadoInfante.DataBind();
            }                        
        }

        protected void btnRegistroAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroAsistenciaDAO registroAsistencia = new RegistroAsistenciaDAO();
                DateTime dateTime = DateTime.Now;
                if (dateTime.Hour < 8 || dateTime.Hour > 10) throw new Exception("La hora de registro de asistencia debe ser en las 8-10 de la mañana");
                registroAsistencia.validarFecha(DateTime.Parse(txtFecha.Text), int.Parse(ddlInfante.SelectedValue));
                registroAsistencia.crearRegistroAcademico(int.Parse(ddlInfante.SelectedValue), int.Parse(ddlEstadoInfante.SelectedValue), DateTime.Parse(txtFecha.Text), cbxAsistencia.Checked);
                Response.Write("<script>alert('El redistro ha sido almacenado Satisfactoriamente')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
            
        }
    }
}