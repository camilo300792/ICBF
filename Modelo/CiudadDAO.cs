using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class CiudadDAO
    {
        public object listarCiudades()
        {
            ORMDataContext orm = new ORMDataContext();
            var ciudades = from c in orm.Ciudad
                           where c.habilitado == 1
                           select c;
            return ciudades;
        }
    }
}
