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
    public class CategoriasConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static CategoriasConexion _instancia = null;

        public CategoriasConexion()
        {
            
        }
        public static CategoriasConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CategoriasConexion();
                }
                return _instancia;
            }
        }

        public bool guardarCategoria(Categorias categoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Categorias (Nombre,RitmoMusical,Detalle) values (@nombre,@ritmoMusical,@detalle)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", categoria.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("ritmoMusical", categoria.RitmoMusical));
                cmd.Parameters.Add(new SQLiteParameter("detalle", categoria.Detalle));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool actualizarCategoria(Categorias categoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update Categorias set Nombre = @nombre, RitmoMusical = @ritmoMusical, Detalle = @detalle where IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", categoria.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("ritmoMusical", categoria.RitmoMusical));
                cmd.Parameters.Add(new SQLiteParameter("detalle", categoria.Detalle));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", categoria.IDCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }


        public List<Categorias> obtenerCategorias(){
            List<Categorias> listCategorias = new List<Categorias>();


            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Categorias";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listCategorias.Add(new Categorias()
                        {
                            IDCategoria = int.Parse(dr["IDCategoria"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            RitmoMusical = dr["RitmoMusical"].ToString(),
                            Detalle = dr["Detalle"].ToString(),

                        });
                    }
                }
            }
            return listCategorias;
        }

        public bool eliminarCategoria(string categoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Delete from  Categorias where IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", categoria));
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
