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

        //Sector de Jurados
        public List<Categorias> obtenerCategoriasPorJurado(int idParticipante)
        {
            List<Categorias> listCategorias = new List<Categorias>();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "select DISTINCT ct.* from Categorias ct INNER JOIN Categoria_Puntuacion ctp ON ct.IDCategoria = ctp.IDCategoria INNER join Jurado_Categoria_Puntuacion jctp ON ctp.IDCategoriaPuntuacion = jctp.IDCategoriaPuntuacion where jctp.IDParticipante= @idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
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
                            Detalle = dr["Detalle"].ToString()
                        });
                    }
                }
            }
            return listCategorias;
        }

        public Categorias obtenerCategoriaPorIDCategoria(int idCategoria)
        {
            Categorias categoria = new Categorias();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Participante_Compania where IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        categoria.IDCategoria = int.Parse(dr["IDCategoria"].ToString());
                        categoria.Nombre = dr["Nombre"].ToString();
                        categoria.RitmoMusical = dr["RitmoMusical"].ToString();
                        categoria.Detalle = dr["Detalle"].ToString();
                    }
                }
            }
            return categoria;

        }


        //Sector seleccion de categorias

        public List<Categorias> obtenerCategoriasNoAsignadasACompania(int idCompania)
        {
            List<Categorias> listCategorias = new List<Categorias>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "SELECT * FROM Categorias c WHERE NOT EXISTS (SELECT 1 FROM Compania_Categoria cc WHERE cc.IDCategoria = c.IDCategoria AND cc.IDCompania = @idCompania)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
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

        public List<Categorias> obtenerCategoriasAsignadasACompania(int idCompania)
        {
            List<Categorias> listCategorias = new List<Categorias>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "SELECT * FROM Categorias c WHERE EXISTS (SELECT 1 FROM Compania_Categoria cc WHERE cc.IDCategoria = c.IDCategoria AND cc.IDCompania = @idCompania)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
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

        public bool guardarCategoriaAsignada(int idCompania, int idCategoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Compania_Categoria (IDCompania, IDCategoria) values (@idCompania,@idCategoria)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool borrarCategoriaAsignada(int idCompania, int idCategoria)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();

                //Elimina de Participante_Compania_Categoria donde esta relacionada
                string query = "delete from Participante_Compania_Categoria where IDCompania = @idCompania AND IDCategoria = @idCategoria";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

                //Elimina de Compania_Categoria
                query = "delete from Compania_Categoria where IDCompania = @idCompania AND IDCategoria = @idCategoria";

                SQLiteCommand cmd2 = new SQLiteCommand(query, conexion_);
                cmd2.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd2.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd2.CommandType = System.Data.CommandType.Text;
                if (cmd2.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

    }

}


