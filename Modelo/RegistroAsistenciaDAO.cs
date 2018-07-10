using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class RegistroAsistenciaDAO
    {
        private ORMDataContext orm;
        public RegistroAsistenciaDAO()
        {
            this.orm = orm = new ORMDataContext();
        }

        public void crearRegistroAcademico(int _idInfante, int _estadoInfante, DateTime _fecha, bool _asistencia)
        {
            byte asistencia_;
            if (_asistencia)
            {
                asistencia_ = 1;
            }
            else
            {
                asistencia_ = 0;
            }
            RegistroAsistencia registroAsistencia = new RegistroAsistencia();
            registroAsistencia.idInfante = _idInfante;
            registroAsistencia.estadoInfante = _estadoInfante;
            registroAsistencia.fecha = _fecha;
            registroAsistencia.asistencia = asistencia_;
            registroAsistencia.habilitado = 1;
            this.orm.RegistroAsistencia.InsertOnSubmit(registroAsistencia);
            this.orm.SubmitChanges();
        }

        public bool validarFecha(DateTime _fecha, int _idInfante)
        {
            var resultado = (from ra in this.orm.RegistroAsistencia
                             where ra.fecha.Equals(_fecha) && ra.idInfante.Equals(_idInfante)
                             select ra).FirstOrDefault();
            if (resultado != null) throw new Exception("Ya había registrado este infante el día de hoy");
            return true;
        }
    }
}
