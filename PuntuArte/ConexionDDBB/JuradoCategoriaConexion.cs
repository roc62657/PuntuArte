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
    public class JuradoCategoriaConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static JuradoCategoriaConexion _instancia = null;

        public JuradoCategoriaConexion()
        {
            
        }
        public static JuradoCategoriaConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new JuradoCategoriaConexion();
                }
                return _instancia;
            }
        }

        public bool guardarJuradoCategoria(JuradoCategoria juradoCategoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Jurado_Categoria (IDJurado,IDCategoria) values (@idJurado,@idCategoria)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idJurado", juradoCategoria.IDJurado));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", juradoCategoria.IDCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }
        public bool validoCategoriaExistente(JuradoCategoria juradoCategoria)
        {
            bool existeCategoria = false;
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Jurado_Categoria where IDJurado = @idJurado and IDCategoria = idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idJurado", juradoCategoria.IDJurado));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", juradoCategoria.IDCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        existeCategoria = true;
                    }                    
                }

            }
            return existeCategoria;
        }

    }
}
