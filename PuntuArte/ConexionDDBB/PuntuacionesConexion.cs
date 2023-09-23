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

        //public int actualizarCompanias(Companias compania)
        //{
        //    int respuesta = 0;

        //    using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
        //    {
        //        conexion_.Open();
        //        string query = "Update Companias set Nombre = @nombre, Detalle = @detalle, Nacionalidad = @nacionalidad where IDCompania = @idCompania";

        //        SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
        //        cmd.Parameters.Add(new SQLiteParameter("nombre", compania.Nombre));
        //        cmd.Parameters.Add(new SQLiteParameter("detalle", compania.Detalle));
        //        cmd.Parameters.Add(new SQLiteParameter("nacionalidad", compania.Nacionalidad));
        //        cmd.Parameters.Add(new SQLiteParameter("idCompania", compania.IDCompania));
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        if (cmd.ExecuteNonQuery() < 1)
        //        {
        //            respuesta = -1;
        //        }
        //        else
        //        {
        //            respuesta = compania.IDCompania;
        //        }
        //    }
        //    return respuesta;

        //}



    }
}
