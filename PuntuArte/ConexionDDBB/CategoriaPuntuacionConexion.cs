using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PuntuArte.Modelo;
using System.Data.SQLite;


namespace PuntuArte.ConexionDDBB
{
    public class CategoriaPuntuacionConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static CategoriaPuntuacionConexion _instancia = null;

        public CategoriaPuntuacionConexion()
        {
            
        }
        public static CategoriaPuntuacionConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CategoriaPuntuacionConexion();
                }
                return _instancia;
            }
        }

        public bool guardarCategoriaPuntuacion(int idCategoria, int idItemPuntuacion)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Categoria_Puntuacion (IDCategoria,IDItemPuntuacion) values (@idCategoria,@idItemPuntuacion)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool eliminarCategoriaPuntuacion(int idCategoria, int idItemPuntuacion)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Delete from  Categoria_Puntuacion where IDCategoria = @idCategoria and IDItemPuntuacion = @idItemPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

    }
}
