using Crud;
using AccesoDatos.PermisosUsuariosTaller;
using System.Windows.Forms;
using System.Drawing;
using System;
using Entidades.PermisosUsuariosTaller;
using System.IO;

namespace LogicaNegocio.PermisosUsuariosTaller
{
    public class ManejadorUsuarios
    {
        AccesoUsuario au = new AccesoUsuario();
        Grafico g = new Grafico();

        public bool Comprobar(string usuario, string clave)
        {
            int c =  Convert.ToInt32( au.Comprobar(usuario, clave).Tables[0].Rows[0]["EXISTE"]);
            if (c==1)
            {
                return true;
            } 
            else
            {
                return false;
            }  
        }
    }
}
