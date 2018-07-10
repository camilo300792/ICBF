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
             
            ORMDataContext orm = new ORMDataContext();
            RegistroAsistencia registroAsistencia = new RegistroAsistencia();
            registroAsistencia.idInfante = _idInfante;
            registroAsistencia.estadoInfante = _estadoInfante;
            registroAsistencia.fecha = _fecha;
            registroAsistencia.asistencia = asistencia_;
            registroAsistencia.habilitado = 1;
            orm.RegistroAsistencia.InsertOnSubmit(registroAsistencia);
            orm.SubmitChanges();
        }
    }
}
