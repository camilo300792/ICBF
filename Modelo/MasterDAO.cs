using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class MasterDAO
    {
        private object listarMaster(int _idDependencia)
        {
            ORMDataContext orm = new ORMDataContext();
            var master = from td in orm.Master
                                 where td.idDependencia == _idDependencia
                                 select td;
            return master;
        }

        public object listarDocumentos()
        {
            var tiposDocumento = this.listarMaster(2);
            return tiposDocumento;
        }

        public object listarNivelesInfante()
        {
            var nivelesInfate = this.listarMaster(3);
            return nivelesInfate;
        }

        public object listarNotas()
        {
            var notas = this.listarMaster(4);
            return notas;
        }

        public object listarEstadosInfante()
        {
            var estadosInfante = this.listarMaster(5);
            return estadosInfante;
        }

        public object listarEstadosJardin()
        {
            var estadosJardin = this.listarMaster(6);
            return estadosJardin;
        }   
      
    }
}
