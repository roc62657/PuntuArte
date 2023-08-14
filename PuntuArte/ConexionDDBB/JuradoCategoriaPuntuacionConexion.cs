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
    public class JuradoCategoriaPuntuacionConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static JuradoCategoriaPuntuacionConexion _instancia = null;

        public JuradoCategoriaPuntuacionConexion()
        {
            
        }
        public static JuradoCategoriaPuntuacionConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new JuradoCategoriaPuntuacionConexion();
                }
                return _instancia;
            }
        }

        public bool guardarJuradoCategoriaPuntuacion(JuradoCategoriaPuntuacion juradoCategoriaPuntuacion)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Jurado_Categoria_Puntuacion (IDParticipante,IDCategoriaPuntuacion) values (@idParticipante,@idCategoriaPuntuacion)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", juradoCategoriaPuntuacion.IDParticipante));
                cmd.Parameters.Add(new SQLiteParameter("idCategoriaPuntuacion", juradoCategoriaPuntuacion.IDCategoriaPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

      

        public List<JuradoCategoriaPuntuacion> obtenerJuradoCategoriaPuntuacionPorIDParticipante(int idParticipante)
        {
            List<JuradoCategoriaPuntuacion> listJuradoCategoriaPuntuacion = new List<JuradoCategoriaPuntuacion>();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Jurado_Categoria_Puntuacion where IDParticipante = @idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listJuradoCategoriaPuntuacion.Add(new JuradoCategoriaPuntuacion()
                        {
                            IDJuradoCatPuntuacion = int.Parse(dr["IDJuradoCatPuntuacion"].ToString()),
                            IDParticipante = int.Parse(dr["IDParticipante"].ToString()),
                            IDCategoriaPuntuacion = int.Parse(dr["IDCategoriaPuntuacion"].ToString())
                        });
                    }
                }
            }
            return listJuradoCategoriaPuntuacion;
        }

        public List<JuradoCategoriaPuntuacion> obtenerJuradoCategoriaPuntuacionPorIDCategoria(int idCategoria)
        {
            List<JuradoCategoriaPuntuacion> listJuradoCategoriaPuntuacion = new List<JuradoCategoriaPuntuacion>();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Jurado_Categoria_Puntuacion where IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listJuradoCategoriaPuntuacion.Add(new JuradoCategoriaPuntuacion()
                        {
                            IDJuradoCatPuntuacion = int.Parse(dr["IDJuradoCatPuntuacion"].ToString()),
                            IDParticipante = int.Parse(dr["IDParticipante"].ToString()),
                            IDCategoriaPuntuacion = int.Parse(dr["IDCategoriaPuntuacion"].ToString())
                        });
                    }
                }
            }
            return listJuradoCategoriaPuntuacion;
        }


    }
}
