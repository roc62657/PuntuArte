using PuntuArte.Modelo;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace PuntuArte.ConexionDDBB
{
    public class ParticipantesConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static ParticipantesConexion _instancia = null;

        public ParticipantesConexion()
        {

        }
        public static ParticipantesConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ParticipantesConexion();
                }
                return _instancia;
            }
        }

        public Participantes obtenerParticipantePorId(int idParticipante)
        {
            Participantes participante = new Participantes();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Participantes where IDParticipante = @idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        participante.IDParticipante = int.Parse(dr["IDParticipante"].ToString());
                        participante.Nombre = dr["Nombre"].ToString();
                        participante.Apellido = dr["Apellido"].ToString();
                        participante.TipoDocumento = dr["TipoDocumento"].ToString();
                        participante.NroDocumento = dr["NroDocumento"].ToString();
                        participante.Nacionalidad = dr["Nacionalidad"].ToString();
                        participante.NroTelefono = dr["NroTelefono"].ToString();
                        participante.Rol = dr["Rol"].ToString();
                    };

                }

            }
            return participante;
        }

        public int guardarParticipante(Participantes participante)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Participantes (Nombre,Apellido,TipoDocumento,NroDocumento,Nacionalidad,NroTelefono,Rol) " +
                                        "values (@nombre,@apellido,@tipoDocumento,@nroDocumento,@nacionalidad,@nroTelefono,@rol)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", participante.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("apellido", participante.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("tipoDocumento", participante.TipoDocumento));
                cmd.Parameters.Add(new SQLiteParameter("nroDocumento", participante.NroDocumento));
                cmd.Parameters.Add(new SQLiteParameter("nacionalidad", participante.Nacionalidad));
                cmd.Parameters.Add(new SQLiteParameter("nroTelefono", participante.NroTelefono));
                cmd.Parameters.Add(new SQLiteParameter("rol", participante.Rol));
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


        public bool actualizarParticipante(Participantes participante)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update Participantes set Nombre = @nombre, Apellido = @apellido, TipoDocumento = @tipoDocumento, NroDocumento = @nroDocumento, Nacionalidad = @nacionalidad, NroTelefono = @nroTelefono, Rol = @rol where IDParticipante = @idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", participante.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("apellido", participante.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("tipoDocumento", participante.TipoDocumento));
                cmd.Parameters.Add(new SQLiteParameter("nroDocumento", participante.NroDocumento));
                cmd.Parameters.Add(new SQLiteParameter("nacionalidad", participante.Nacionalidad));
                cmd.Parameters.Add(new SQLiteParameter("nroTelefono", participante.NroTelefono));
                cmd.Parameters.Add(new SQLiteParameter("rol", participante.Rol));
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", participante.IDParticipante));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }


        public List<Participantes> obtenerParticipantes()
        {
            List<Participantes> listParticipantes = new List<Participantes>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Participantes where rol = 'Jurado'";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listParticipantes.Add(new Participantes()
                        {
                            IDParticipante = int.Parse(dr["IDParticipante"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoDocumento = dr["TipoDocumento"].ToString(),
                            NroDocumento = dr["NroDocumento"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                            NroTelefono = dr["NroTelefono"].ToString(),
                            Rol = dr["Rol"].ToString()
                        });

                    }
                }
            }
            return listParticipantes;
        }

        //Obtiene Jurado por Nacionalidad y Numero de Documento
        public int obtenerIDParticipanteJuradoPorDocumentoYNacionalidad(string nroDocumento, string nacionalidad)
        {
            int cro = -1;
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Participantes where rol = 'Jurado' and NroDocumento =@nroDocumento and Nacionalidad=@nacionalidad";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nroDocumento", nroDocumento));
                cmd.Parameters.Add(new SQLiteParameter("nacionalidad", nacionalidad));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {                       
                        cro = int.Parse(dr["IDParticipante"].ToString());
                    }
                }
            }
            return cro;
        }

        //Se eliminara jurado de Participantes y de todas las tablas relacionadas
        public bool eliminarJurado(int idParticipante)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();

                //Elimina de Jurado_Categoria_Puntuacion donde esta relacionada
                string query = "DELETE FROM Jurado_Categoria_Puntuacion WHERE IDParticipante=@idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

                //Elimina de Participantes
                query = "DELETE FROM Participantes WHERE IDParticipante = @idParticipante";

                SQLiteCommand cmd2 = new SQLiteCommand(query, conexion_);
                cmd2.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
                cmd2.CommandType = System.Data.CommandType.Text;
                if (cmd2.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                else
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }


        ///Relacion Participantes - Categoria - Compania

        public List<Participantes> obtenerParticipantesNoAsignadosACategoriaCompania(int idCompania, int idCategoria)
        {
            List<Participantes> listParticipantes = new List<Participantes>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "select * from Participantes p WHERE NOT EXISTS (" +
                                    "SELECT 1 FROM Participante_Compania_Categoria pcc WHERE pcc.IDParticipante = p.IDParticipante " +
                                        "AND pcc.IDCompania = @idCompania AND pcc.IDCategoria = @idCategoria) " +
                                     "AND p.Rol != 'Jurado'";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listParticipantes.Add(new Participantes()
                        {
                            IDParticipante = int.Parse(dr["IDParticipante"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoDocumento = dr["TipoDocumento"].ToString(),
                            NroDocumento = dr["NroDocumento"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                            NroTelefono = dr["NroTelefono"].ToString(),
                            Rol = dr["Rol"].ToString()
                        });

                    }
                }
            }
            return listParticipantes;
        }

        public List<Participantes> obtenerParticipantesAsignadosACategoriaCompania(int idCompania, int idCategoria)
        {
            List<Participantes> listParticipantes = new List<Participantes>();

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "select * from Participantes p WHERE EXISTS (" +
                                    "SELECT 1 FROM Participante_Compania_Categoria pcc WHERE pcc.IDParticipante = p.IDParticipante " +
                                        "AND pcc.IDCompania = @idCompania AND pcc.IDCategoria = @idCategoria) ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listParticipantes.Add(new Participantes()
                        {
                            IDParticipante = int.Parse(dr["IDParticipante"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            TipoDocumento = dr["TipoDocumento"].ToString(),
                            NroDocumento = dr["NroDocumento"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                            NroTelefono = dr["NroTelefono"].ToString(),
                            Rol = dr["Rol"].ToString()
                        });

                    }
                }
            }
            return listParticipantes;
        }

        public bool guardarParticipanteAsignadosACategoriaCompania(int idCompania, int idCategoria, int idParticipante)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Participante_Compania_Categoria (IDCompania, IDCategoria, IDParticipante) values (@idCompania,@idCategoria,@idParticipante)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool borrarParticipanteAsignadosACategoriaCompania(int idCompania, int idCategoria, int idParticipante)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Delete from  Participante_Compania_Categoria where IDCompania = @idCompania AND IDCategoria = @idCategoria AND IDParticipante = @idParticipante";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.Parameters.Add(new SQLiteParameter("idCategoria", idCategoria));
                cmd.Parameters.Add(new SQLiteParameter("idParticipante", idParticipante));
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
