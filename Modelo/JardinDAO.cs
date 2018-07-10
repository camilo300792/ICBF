using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class JardinDAO
    {
        public void crearJardin(string _nombre, string _direccion, int _estadoJardin)
        {
            ORMDataContext orm = new ORMDataContext();
            Jardin jardin = new Jardin();
            jardin.nombre = _nombre;
            jardin.direccion = _direccion;
            jardin.idEstado = _estadoJardin;
            jardin.habilitado = 1;
            orm.Jardin.InsertOnSubmit(jardin);
            orm.SubmitChanges();
        }

        public bool verificarJardin(string _nombre)
        {
            ORMDataContext orm = new ORMDataContext();
            var resultado = (from j in orm.Jardin
                             where j.nombre == _nombre && j.habilitado == 1
                             select j).FirstOrDefault();
            if (resultado != null) throw new Exception("Ya existe un jardin registrado con este nombre.");
            return true;
        }

        public void editarJardin(int _idJardin, string _nombre, string _direccion, int _estadoJardin)
        {
            ORMDataContext orm = new ORMDataContext();
            Jardin jardin = (from j in orm.Jardin
                             where j.idJardin == _idJardin
                             select j).FirstOrDefault();
            if(jardin == null)
            {
                throw new Exception("Hubo un error al procesar la solicitud");
            }
            jardin.nombre = _nombre;
            jardin.direccion = _direccion;
            jardin.idEstado = _estadoJardin;
            if(_estadoJardin == 24) jardin.habilitado = 0;
            orm.SubmitChanges();
        }

        public void eliminarJardin(int _idJardin)
        {
            ORMDataContext orm = new ORMDataContext();
            Jardin jardin = (from j in orm.Jardin
                             where j.idJardin == _idJardin
                             select j).FirstOrDefault();
            if (jardin == null)
            {
                throw new Exception("Hubo un error al procesar la solicitud");
            }
            jardin.habilitado = 0;
            orm.SubmitChanges();
        }

        public object listarJardines()
        {
            ORMDataContext orm = new ORMDataContext();
            var jardines = from j in orm.Jardin
                           join m in orm.Master on j.idEstado equals m.idMaster
                           where j.habilitado == 1 && j.idEstado != 24
                           select new
                           {
                               j.idJardin,
                               _nombre = j.nombre,
                               _direccion = j.direccion,
                               estadoJardin = m.nombre
                           };
            return jardines;

        }
    }
}
