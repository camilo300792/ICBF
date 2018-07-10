using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class DatosInfanteDAO
    {
        public void guardarDatosInfante(string _eps, int _idJardin, int _idAcudiente, int _idInfante, float _peso, float _talla, DateTime _fechaIngreso)
        {
            ORMDataContext orm = new ORMDataContext();
            DatosInfante datosInfante = new DatosInfante();
            datosInfante.eps = _eps;
            datosInfante.idJardin = _idJardin;
            datosInfante.idAcudiente = _idAcudiente;
            datosInfante.idInfante = _idInfante;
            datosInfante.peso = _peso;
            datosInfante.talla = _talla;
            datosInfante.fechaIngreso = _fechaIngreso;
            datosInfante.habilitado = 1;
            orm.DatosInfante.InsertOnSubmit(datosInfante);
            orm.SubmitChanges();
        }

        public object listarInfantes()
        {
            ORMDataContext orm = new ORMDataContext();
            var resultado = from d in orm.DatosInfante
                            join p in orm.Persona on d.idInfante equals p.idPersona
                            join j in orm.Jardin on d.idJardin equals j.idJardin
                            join u in orm.Usuario on d.idAcudiente equals u.idUsuario
                            join a in orm.Persona on u.idPersona equals a.idPersona
                            where d.habilitado == 1
                            select new
                            {
                                _idInfante = d.idDatosInfante,
                                _infante = p.nombre 
                            };

            return resultado;
        }
    }
}
