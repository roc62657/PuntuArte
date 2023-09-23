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
    public class PuntuacionesConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static PuntuacionesConexion _instancia = null;

        public PuntuacionesConexion()
        {

        }
        public static PuntuacionesConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PuntuacionesConexion();
                }
                return _instancia;
            }
        }

        public int guardarPuntuacionFinal(PuntuacionesFinales puntuacionFinal)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Puntuaciones_Finales (IDCompania,IDCategoria,PuntajeFinal,Puesto,Observacion) values (@idCompania,@idCategoria,@puntajeFinal,@puesto,@observacion)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", puntuacionFinal.IDCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", puntuacionFinal.IDCategoria));
                cmd.Parameters.Add(new SQLiteParameter("puntajeFinal", puntuacionFinal.PuntajeFinal));
                cmd.Parameters.Add(new SQLiteParameter("puesto", puntuacionFinal.Puesto));
                cmd.Parameters.Add(new SQLiteParameter("observacion", puntuacionFinal.Observacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = -1;
                }
                else
                {
                    respuesta = int.Parse(conexion_.LastInsertRowId.ToString());
                }
            }
            return respuesta;

        }

        public int actualizarPuntuacionFinal(PuntuacionesFinales puntuacionFinal)
        {
            int respuesta = puntuacionFinal.IDPuntuacionFinal;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update Puntuaciones_Finales set PuntajeFinal = @puntajeFinal, Puesto = @puesto, Observacion = @observacion where IDPuntuacionFinal = @idPuntuacionFinal";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("puntajeFinal", puntuacionFinal.PuntajeFinal));
                cmd.Parameters.Add(new SQLiteParameter("puesto", puntuacionFinal.Puesto));
                cmd.Parameters.Add(new SQLiteParameter("observacion", puntuacionFinal.Observacion));
                cmd.Parameters.Add(new SQLiteParameter("idPuntuacionFinal", puntuacionFinal.IDPuntuacionFinal));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = 0;
                }
            }
            return respuesta;

        }


        public int guardarPuntuacionDetalle(PuntuacionesDetalle puntuacionDetalle)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Puntuaciones_Detalle (IDPuntuacionFinal,IDJurado,IDCompania,IDCategoria,IDItemPuntuacion,Puntuacion) values (@idPuntuacionFinal,@idJurado,@idCompania,@idCategoria,@idItemPuntuacion,@puntuacion)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idPuntuacionFinal", puntuacionDetalle.IDPuntuacionFinal));
                cmd.Parameters.Add(new SQLiteParameter("idJurado", puntuacionDetalle.IDJurado));
                cmd.Parameters.Add(new SQLiteParameter("idCompania", puntuacionDetalle.IDCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", puntuacionDetalle.IDCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", puntuacionDetalle.IDItemPuntuacion));
                cmd.Parameters.Add(new SQLiteParameter("puntuacion", puntuacionDetalle.Puntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = -1;
                }
                else
                {
                    respuesta = int.Parse(conexion_.LastInsertRowId.ToString());
                }
            }
            return respuesta;

        }

        public int actualizarPuntuacionDetalle(PuntuacionesDetalle puntuacionDetalle)
        {
            int respuesta = puntuacionDetalle.IDPuntuacionDetalle;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update Puntuaciones_Detalle set Puntuacion = @puntuacion where IDPuntuacionDetalle = @idPuntuacionDetalle";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("puntuacion", puntuacionDetalle.Puntuacion));
                cmd.Parameters.Add(new SQLiteParameter("idPuntuacionDetalle", puntuacionDetalle.IDPuntuacionDetalle));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = 0;
                }
            }
            return respuesta;

        }


        public PuntuacionesFinales obtenerPuntuacionFinal(int idCategoria, int idCompania)
        {
            PuntuacionesFinales puntuacionFinal = new PuntuacionesFinales();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Puntuaciones_Finales where IDCompania = @idCompania and IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        puntuacionFinal.IDPuntuacionFinal = int.Parse(dr["IDPuntuacionFinal"].ToString());
                        puntuacionFinal.IDCompania = int.Parse(dr["IDCompania"].ToString());
                        puntuacionFinal.IDCategoria = int.Parse(dr["IDCategoria"].ToString());
                        puntuacionFinal.PuntajeFinal = int.Parse(dr["PuntajeFinal"].ToString());
                        puntuacionFinal.Puesto = int.Parse(dr["Puesto"].ToString());
                        puntuacionFinal.Observacion = int.Parse(dr["Observacion"].ToString());
                    };

                }

            }
            return puntuacionFinal;
        }

        public PuntuacionesDetalle obtenerPuntuacionDetalle(int idCategoria, int idCompania, int idPuntuacionFinal, int idJurado, int idItemPuntuacion)
        {
            PuntuacionesDetalle puntuacionDetalle = new PuntuacionesDetalle();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Puntuaciones_Detalle where IDCompania = @idCompania and IDCategoria = @idCategoria and IDPuntuacionFinal = @idPuntuacionFinal and IDJurado = @idJurado and IDItemPuntuacion = @idItemPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idPuntuacionFinal", idPuntuacionFinal));
                cmd.Parameters.Add(new SQLiteParameter("idJurado", idJurado));
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        puntuacionDetalle.IDPuntuacionDetalle = int.Parse(dr["IDPuntuacionDetalle"].ToString());
                        puntuacionDetalle.IDPuntuacionFinal = int.Parse(dr["IDPuntuacionFinal"].ToString());
                        puntuacionDetalle.IDJurado = int.Parse(dr["IDJurado"].ToString());
                        puntuacionDetalle.IDCompania = int.Parse(dr["IDCompania"].ToString());
                        puntuacionDetalle.IDCategoria = int.Parse(dr["IDCategoria"].ToString());
                        puntuacionDetalle.IDItemPuntuacion = int.Parse(dr["IDItemPuntuacion"].ToString());
                        puntuacionDetalle.Puntuacion = dr["Puntuacion"].ToString();
                    };

                }

            }
            return puntuacionDetalle;
        }



    }
}
