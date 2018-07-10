using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Modelo
{
    public class ReportesDAO
    {
        public object reporteAsistencias(int _idAcudiente)
        {
            ORMDataContext orm = new ORMDataContext();
            var resultado = from ra in orm.RegistroAsistencia
                            join m in orm.Master on ra.estadoInfante equals m.idMaster
                            join di in orm.DatosInfante on ra.idInfante equals di.idDatosInfante
                            join p in orm.Persona on di.idInfante equals p.idPersona
                            where p.habilitado.Equals(1) && di.idAcudiente.Equals(_idAcudiente)
                            select new
                            {
                                _nombre = p.nombre,
                                _estado = m.nombre,
                                _fecha = ra.fecha,
                                _asistencia = ra.asistencia
                            };
            return resultado;
        }
    }
}
