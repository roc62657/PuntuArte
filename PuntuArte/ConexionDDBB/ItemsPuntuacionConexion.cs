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
    public class ItemsPuntuacionConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static ItemsPuntuacionConexion _instancia = null;

        public ItemsPuntuacionConexion()
        {

        }
        public static ItemsPuntuacionConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ItemsPuntuacionConexion();
                }
                return _instancia;
            }
        }

        public int guardarItemsPuntuacion(ItemsPuntuacion itemsPuntuacion)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into ItemsPuntuacion (Nombre,Detalle) values (@nombre,@detalle)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", itemsPuntuacion.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("detalle", itemsPuntuacion.Detalle));
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

        public int actualizarItemsPuntuacion(ItemsPuntuacion itemsPuntuacion)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update ItemsPuntuacion set Nombre = @nombre, Detalle = @detalle where IDItemPuntuacion = @idItemPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", itemsPuntuacion.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("detalle", itemsPuntuacion.Detalle));
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", itemsPuntuacion.IDItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = -1;
                }
                else
                {
                    respuesta = itemsPuntuacion.IDItemPuntuacion;
                }
            }
            return respuesta;

        }


        public List<ItemsPuntuacion> obtenerItemsPuntuacion()
        {
            List<ItemsPuntuacion> listItemsPuntuacion = new List<ItemsPuntuacion>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from ItemsPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listItemsPuntuacion.Add(new ItemsPuntuacion()
                        {
                            IDItemPuntuacion = int.Parse(dr["IDItemPuntuacion"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                        });
                    }
                }
            }
            return listItemsPuntuacion;
        }

        public ItemsPuntuacion obtenerItemPuntuacion(int idItemPuntuacion)
        {
            ItemsPuntuacion itemsPuntuacion = new ItemsPuntuacion();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from ItemsPuntuacion where IDItemPuntuacion = @idItemPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itemsPuntuacion = new ItemsPuntuacion()
                        {
                            IDItemPuntuacion = int.Parse(dr["IDItemPuntuacion"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                        };
                    }
                }
            }
            return itemsPuntuacion;
        }

        //Se eliminara ItemsPuntuacion y de todas las tablas donde se relaciona
        public bool eliminarItemsPuntuacion(int idItemPuntuacion)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();

                //Elimina de Participante_Compania_Categoria donde esta relacionada
                string query = "DELETE FROM Categoria_Puntuacion WHERE IDItemPuntuacion=@idItemPuntuacion";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery(); //Solo ejecuta y si no borra nada esta bien


                //Elimina de Participantes
                query = "DELETE FROM ItemsPuntuacion WHERE IDItemPuntuacion = @idItemPuntuacion";

                SQLiteCommand cmd2 = new SQLiteCommand(query, conexion_);
                cmd2.Parameters.Add(new SQLiteParameter("idItemPuntuacion", idItemPuntuacion));
                cmd2.CommandType = System.Data.CommandType.Text;
                if (cmd2.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public List<ItemsPuntuacion> obtenerItemsNoAsignadosACategoria(int idCategoria)
        {
            List<ItemsPuntuacion> listItemsPuntuacion = new List<ItemsPuntuacion>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "SELECT * FROM ItemsPuntuacion ip WHERE NOT EXISTS (SELECT 1 FROM Categoria_Puntuacion cp WHERE cp.IDItemPuntuacion = ip.IDItemPuntuacion AND cp.IDCategoria = @idCategoria)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listItemsPuntuacion.Add(new ItemsPuntuacion()
                        {
                            IDItemPuntuacion = int.Parse(dr["IDItemPuntuacion"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                        });
                    }
                }
            }
            return listItemsPuntuacion;
        }

        public List<ItemsPuntuacion> obtenerItemsAsignadosACategoria(int idCategoria)
        {
            List<ItemsPuntuacion> listItemsPuntuacion = new List<ItemsPuntuacion>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "SELECT * FROM ItemsPuntuacion ip WHERE EXISTS (SELECT 1 FROM Categoria_Puntuacion cp WHERE cp.IDItemPuntuacion = ip.IDItemPuntuacion AND cp.IDCategoria = @idCategoria)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listItemsPuntuacion.Add(new ItemsPuntuacion()
                        {
                            IDItemPuntuacion = int.Parse(dr["IDItemPuntuacion"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                        });
                    }
                }
            }
            return listItemsPuntuacion;
        }

        public List<CompaniaPuntuacionDTO> obtenerDatosPuntuacion(int idCategoria)
        {
            List<CompaniaPuntuacionDTO> lcompaniaPuntuacionDTO = new List<CompaniaPuntuacionDTO> { };    

            List<ItemsPuntuacion> lItemsPuntuacion = ItemsPuntuacionConexion.Instancia.obtenerItemsAsignadosACategoria(idCategoria);
            List<Companias> lcompanias = CompaniasConexion.Instancia.obtenerCompaniasEnCompetenciaPorCategoria(idCategoria);
            foreach (Companias compania in lcompanias)
            {
                CompaniaPuntuacionDTO companiaPuntuacion = new CompaniaPuntuacionDTO();
                companiaPuntuacion.IDCompania = compania.IDCompania;
                companiaPuntuacion.Nombre = compania.Nombre;
                companiaPuntuacion.itemsPuntuacion = lItemsPuntuacion;
                lcompaniaPuntuacionDTO.Add(companiaPuntuacion);
            }
            return lcompaniaPuntuacionDTO;
        }
             
    }
}
