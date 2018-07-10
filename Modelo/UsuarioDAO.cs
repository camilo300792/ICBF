using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Modelo
{
    public class UsuarioDAO
    {
        public int crearUsuario(int _idPersona, int _idRol, string _username, string _contrasena)
        {
            ORMDataContext orm = new ORMDataContext();
            Usuario usuario = new Usuario();
            usuario.idPersona = _idPersona;
            usuario.idRol = _idRol;
            usuario.username = _username;
            usuario.contrasena = _contrasena;
            usuario.habilitado = 1;
            orm.Usuario.InsertOnSubmit(usuario);
            orm.SubmitChanges();

            return usuario.idUsuario;
        }

        public void editarUsuario(int _idUsuario, string _correo = null, string _documento = null)
        {
            ORMDataContext orm = new ORMDataContext();
            Usuario usuario = (from u in orm.Usuario
                               where u.idUsuario.Equals(_idUsuario)
                               select u).FirstOrDefault();
            if (usuario == null) throw new Exception("No existe registro de este usuario");
            usuario.contrasena = _documento;
            usuario.username = _correo;
            orm.SubmitChanges();
        }

        public void eliminarUsuario(int _idUsuario)
        {
            ORMDataContext orm = new ORMDataContext();
            Usuario usuario = (from u in orm.Usuario
                               where u.idUsuario.Equals(_idUsuario)
                               select u).FirstOrDefault();
            if (usuario == null) throw new Exception("No existe registro de este usuario");
            usuario.habilitado = 0;
            orm.SubmitChanges();
        }

        private object listarUsuariosXRol(int _idRol)
        {
            ORMDataContext orm = new ORMDataContext();
            var usuarios = from u in orm.Usuario
                           join p in orm.Persona on u.idPersona equals p.idPersona
                           join m in orm.Master on p.tipoDocumento equals m.idMaster
                           where u.idRol == _idRol && u.habilitado == 1
                           select new {
                               _idUsuario = u.idUsuario,
                               _nombre = p.nombre,
                               _tipoDocumento = m.nombre,
                               _documento = p.numeroDocumento,
                               _correo = p.correo,
                               _telefono = p.telefono,
                               _celular = p.celular,
                               _fechaNacimiento = p.fechaNacimiento,
                               _direccion = p.direccion
                           };
            return usuarios;
        }

        public object listarAcudientes()
        {
            var acudientes = this.listarUsuariosXRol(3);
            return acudientes;
        }

        public object listarMadresComunitarias()
        {
            var madresComunitarias = this.listarUsuariosXRol(2);
            return madresComunitarias;
        }

        public Usuario verificarUsuario(string _username)
        {
            ORMDataContext orm = new ORMDataContext();
            Usuario usuario = (from u in orm.Usuario
                               where u.username.Equals(_username)
                               select u).FirstOrDefault();
            if (usuario == null) throw new Exception("No se encuentra ningún usuario registrado el nickname " + _username);
            return usuario;
        }

        public object permisosUsuario(int _idUsuario)
        {
            ORMDataContext orm = new ORMDataContext();
            var resultado = from u in orm.Usuario
                            join r in orm.Rol on u.idRol equals r.idRol
                            join pr in orm.PermisoRol on r.idRol equals pr.idRol
                            join p in orm.Permiso on pr.idPermiso equals p.idPermiso
                            where u.idUsuario == _idUsuario
                            select new
                            {
                                accion = p.nombre,
                                url = p.descripcion
                            };
            return resultado;
        }
    }
}
