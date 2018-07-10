using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
namespace Vista
{
    public partial class Reportes : System.Web.UI.Page
    {
        private ReportesDAO reporteAsistencia;
        public Reportes()
        {
            this.reporteAsistencia = new ReportesDAO();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGridViewAsistencias();
            }
        }

        public void llenarGridViewAsistencias()
        {
            gvAsistencias.DataSource = this.reporteAsistencia.reporteAsistencias((int)Session["idUsuario"]);
            gvAsistencias.DataBind();
        }
    }
}