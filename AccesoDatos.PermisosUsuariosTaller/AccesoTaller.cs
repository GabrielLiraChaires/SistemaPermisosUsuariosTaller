using System;
using System.Data;
using ConectarBd;
namespace AccesoDatos.PermisosUsuariosTaller
{
    public class AccesoTaller : IEntidades
    {
        Base b = new Base("localhost", "root", "", "PermisosTaller");
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(String.Format("call InsertOrUpdateHerramientas('{0}',{1},'{2}','{3}',{4})", Entidad.Nombre,Entidad.Medida,Entidad.Marca,Entidad.Descripcion,Entidad.CodigoHerramienta));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call ShowHerramientas('%{0}%')", filtro), "herramientas");
        }
    }
}
