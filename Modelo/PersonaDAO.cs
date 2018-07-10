using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Datos;

namespace Modelo
{
    public class PersonaDAO
    {
        public int crearPersona(
            string _nombre = null, 
            DateTime? _fechaNacimiento = null, 
            int? _ciudadNacimiento = null, 
            string _telefono = null, 
            string _tipoSangre = null,
            string _direccion = null,
            string _correo = null,
            string _celular = null,
            int _tipoDocumento = 10, 
            string _numeroDocumento = null)
        {
            ORMDataContext orm = new ORMDataContext();
            Persona persona = new Persona();
            persona.nombre = _nombre;
            persona.fechaNacimiento = _fechaNacimiento;
            persona.telefono = _telefono;
            persona.ciudadNacimiento = _ciudadNacimiento;
            persona.tipoSangre = _tipoSangre;
            persona.direccion = _direccion;
            persona.correo = _correo;
            persona.celular = _celular;
            persona.tipoDocumento = _tipoDocumento;
            persona.numeroDocumento = _numeroDocumento;
            persona.habilitado = 1;
            orm.Persona.InsertOnSubmit(persona);
            orm.SubmitChanges();

            return persona.idPersona;
        }

        public void editarPersona(
            int _idUsuario,
            string _nombre = null,
            DateTime? _fechaNacimiento = null,
            int? _ciudadNacimiento = null,
            string _telefono = null,
            string _tipoSangre = null,
            string _direccion = null,
            string _correo = null,
            string _celular = null,
            int _tipoDocumento = 10,
            string _numeroDocumento = null)
        {
            ORMDataContext orm = new ORMDataContext();
            Usuario usuario = (from u in orm.Usuario
                               where u.idUsuario.Equals(_idUsuario)
                               select u).FirstOrDefault();
            if (usuario == null) throw new Exception("No se encontro registro de esta persona");
            Persona persona = (from p in orm.Persona
                               where p.idPersona.Equals(usuario.idPersona)
                               select p).FirstOrDefault();
            if (persona == null) throw new Exception("No se encontro registro de esta persona");

            if (String.IsNullOrEmpty(_fechaNacimiento.ToString())) persona.nombre = _nombre;
            if (String.IsNullOrEmpty(_fechaNacimiento.ToString())) persona.fechaNacimiento = _fechaNacimiento;
            if (String.IsNullOrEmpty(_telefono)) persona.telefono = _telefono;
            if (String.IsNullOrEmpty(_ciudadNacimiento.ToString())) persona.ciudadNacimiento = _ciudadNacimiento;
            if (String.IsNullOrEmpty(_tipoSangre)) persona.tipoSangre = _tipoSangre;
            if (String.IsNullOrEmpty(_direccion)) persona.direccion = _direccion;
            if (String.IsNullOrEmpty(_correo)) persona.correo = _correo;
            if (String.IsNullOrEmpty(_celular)) persona.celular = _celular;
            if (String.IsNullOrEmpty(_tipoDocumento.ToString())) persona.tipoDocumento = _tipoDocumento;
            if (String.IsNullOrEmpty(_numeroDocumento)) persona.numeroDocumento = _numeroDocumento;
            orm.SubmitChanges();
        }

        public bool verificarPersona(string _numeroDocumento)
        {
            ORMDataContext orm = new ORMDataContext();
            var persona = (from p in orm.Persona
                           where p.numeroDocumento.Equals(_numeroDocumento)
                           select p).FirstOrDefault();
            if(persona != null)
            {
                throw new Exception("Ya existe una persona con este número de documento");
            }
            return true;
        }

        public bool verificarPersonaXCorreo(string _correo)
        {
            ORMDataContext orm = new ORMDataContext();
            var persona = (from p in orm.Persona
                           where p.correo.Equals(_correo)
                           select p).FirstOrDefault();
            if (persona != null)
            {
                throw new Exception("Ya existe una persona con este correo");
            }
            return true;
        }

        public bool validarMail(string _email)
        {
            Regex rgx = new Regex(@"[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})");
            if (!rgx.IsMatch(_email)) throw new Exception("El correo ingresado no es válido");
            return true;
        }

        public bool validarEdad(DateTime fecha)
        {
            DateTime actual = DateTime.Now;
            TimeSpan edad = actual.Subtract(fecha);
            if (edad.Days > 1825) throw new Exception("La edad no puede del infante no puede ser mayor a 5 años superar");
            return true;
        }
    }
}
