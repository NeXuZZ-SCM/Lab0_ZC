using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_Entidades;

namespace Datos
{
    public class D_Permisos
    {
        private static string conexionString = ConfigurationManager.ConnectionStrings["Conexion"].ToString();
        public static DataTable MostrarPermisos(int id_Usuario)
        {
            string consulta = "SELECT id_permisos FROM usuarios_grupos WHERE id_usuario="+id_Usuario+";";
            SqlDataAdapter adaptadorDDeDatos = new SqlDataAdapter(consulta, conexionString);
            DataTable tablaDeDatos = new DataTable();
            adaptadorDDeDatos.Fill(tablaDeDatos);
            return tablaDeDatos;
        }
        public static DataTable CompletarchklistBoxPermisos()
        {
            string consulta = "SELECT descripcion FROM grupos;";
            SqlDataAdapter adaptadorDDeDatos = new SqlDataAdapter(consulta, conexionString);
            DataTable tablaDeDatos = new DataTable();
            adaptadorDDeDatos.Fill(tablaDeDatos);
            return tablaDeDatos;
        }

        public static DataTable ConsultarChequeados(int id)
        {
            string queryString = "PERMISOS_C_CHEQUEADOS_MEJORADOS3";
            var lPermisos = new List<E_PermisosChequeados>();
            var dt = new DataTable();

            using (var cnn = new SqlConnection(conexionString))
            {
                cnn.Open();



                using (var cmd = new SqlCommand(queryString, cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@USUARIORECIBIDO", SqlDbType.VarChar)).Value = id;

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    var permisos = new E_PermisosChequeados();
                    //    permisos.id = Convert.ToInt32(reader["id"]);
                    //    permisos.Descripcion = Convert.ToString(reader["descripcion"]);
                    //    permisos.Descripcion = Convert.ToString(reader["id_tipo"]);
                    //    permisos.Descripcion = Convert.ToString(reader["ch"]);
                    //    lPermisos.Add(permisos);
                    //}
                }
            }
            return dt;
        }
        public static void InsertarPermisos(List<int?> idPermisos, int idUsuario)
        {

            //string queryString = @"INSERT INTO usuarios_grupos (id_usuario, id_permisos) values (@idUsuario, @idPermisos);";
            string queryString = "PERMISOS_A_Usuarios";
            using (var cnn = new SqlConnection(conexionString))
            {
                cnn.Open();

                using (var cmd = new SqlCommand(queryString, cnn))
                {
                    foreach (var item in idPermisos)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int)).Value = idUsuario;
                        cmd.Parameters.Add(new SqlParameter("@idPermisos", SqlDbType.Int)).Value = item;

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                }
            }
        }
        public static void EliminarPermisos(int idUsuario) {

            string queryDelete = @"DELETE from usuarios_grupos WHERE id_usuario = @idUsuario;";

            using (var cnn = new SqlConnection(conexionString))
            {
                cnn.Open();

                using (var cmd = new SqlCommand(queryDelete, cnn))
                {
                    cmd.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int)).Value = idUsuario;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
