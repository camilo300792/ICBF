using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class RegistroAcademicoDAO
    {
        public void crearRegistro(int _idInfante, string _anioEscolar, int _idNivel, int _idNota, string _descripcion, DateTime _fechaEntega)
        {
            ORMDataContext orm = new ORMDataContext();
            RegistroAcademico registroAcademico = new RegistroAcademico();
            registroAcademico.idInfante = _idInfante;
            registroAcademico.anioEscolar = _anioEscolar;
            registroAcademico.idNivel = _idNivel;
            registroAcademico.idNota = _idNota;
            registroAcademico.descripcion = _descripcion;
            registroAcademico.fechaEntrega = _fechaEntega;
            orm.RegistroAcademico.InsertOnSubmit(registroAcademico);
            orm.SubmitChanges();
        }
    }
}
