using System;
using System.Data;
using ConectarBd;
namespace AccesoDatos.PermisosUsuariosTaller
{
    public class AccesoPermisos : InterfazPermisos
    {
        Base b = new Base("localhost", "root", "", "PermisosTaller");

        public DataSet ValidacionPermisos(string usuario, string clave, string modulo)
        {
            return b.Obtener(String.Format("SELECT permisolectura,permisoescritura,permisoeliminacion,permisoactualizacion FROM asignacion_p JOIN usuarios ON usuarios.idusuario=asignacion_p.fkidusuario WHERE usuarios.nombre='{0}' AND usuarios.contrasena='{1}' AND asignacion_p.modulo='{2}'", usuario, clave, modulo), "asignacion_p");
        }
        public void Borrar(dynamic Entidad)
        {
            b.Comando(String.Format("call DeletePermisos({0})", Entidad.IdAsignacion));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call InsertOrUpdatePermisos({0},'{1}',{2},{3},{4},{5},{6})", Entidad.Fkidusuario,Entidad.Modulo,Entidad.PermisoLectura,Entidad.PermisoEscritura,Entidad.PermisoEliminacion,Entidad.PermisoActualizacion,Entidad.IdAsignacion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call ShowPermisos('%{0}%')", filtro), "asignacion_p");
        }
    }
}
