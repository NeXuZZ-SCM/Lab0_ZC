using System.Collections.Generic;
using System.Data;
using A_Entidades;

namespace Servicios
{
    public class S_Permisos
    {
        public static DataTable MostrarPermisos(int id_Usuario)
        {
            return Datos.D_Permisos.MostrarPermisos(id_Usuario);
        }
        public static DataTable CompletarchklistBoxPermisos()
        {
            return Datos.D_Permisos.CompletarchklistBoxPermisos();
        }

        public static DataTable ConsultarChequeados(int id)
        {
            return Datos.D_Permisos.ConsultarChequeados(id);
        }
        public static void InsertarPermisos(List<int?> idPermisos, int idUsuario) {

            Datos.D_Permisos.InsertarPermisos(idPermisos, idUsuario);
        }
        public static void EliminarPermisos(int idUsuario)
        {
            Datos.D_Permisos.EliminarPermisos(idUsuario);
        }
    }
}
