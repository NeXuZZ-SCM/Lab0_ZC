using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_Usuarios
    {
        #region ABM

        #region Alta
        public static int AgregarUsuario(A_Entidades.E_Usuario Usuario)
        {
            return Datos.D_Usuarios.AgregarUsuario(Usuario);
        }
        #endregion

        #region BAJA
        public static void EliminarUsuario(A_Entidades.E_Usuario usuario)
        {
            Datos.D_Usuarios.EliminarUsuario(usuario);
        }
        #endregion

        #region Modificacion
        public static void EditarUsuarios(A_Entidades.E_Usuario usuario)
        {
            Datos.D_Usuarios.EditarUsuarios(usuario);
        }
        #endregion


        #endregion

        #region Show Table
        public static DataTable obtenerTabla()
        {
            return Datos.D_Usuarios.ObtenerTabla();
        }
        #endregion

    }
}
