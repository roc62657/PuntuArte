﻿using PuntuArte.Modelo;
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

        public bool guardarParticipante(Participantes participante)
        {
            bool respuesta = true;

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
                    respuesta = false;
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

        public int obtenerIDParticipantePorDocumento(string nroDocumento)
        {
            int cro = 0;
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Participantes where rol = 'Jurado' and NroDocumento =@nroDocumento";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nroDocumento", nroDocumento));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cmd.Parameters.Add(new SQLiteParameter("nroDocumento", nroDocumento));
                        cro = int.Parse(dr["IDParticipante"].ToString());
                    }
                }
            }
            return cro;
        }

        public bool eliminarParticipante(string Participante)
        {
            bool respuesta = true;

            //using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            //{
            //    conexion_.Open();
            //    string query = "Delete from  Categorias where IDCategoria = @idCategoria";

            //    SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
            //    cmd.Parameters.Add(new SQLiteParameter("idCategoria", categoria));
            //    cmd.CommandType = System.Data.CommandType.Text;
            //    if (cmd.ExecuteNonQuery() < 1)
            //    {
            //        respuesta = false;
            //    }
            //}
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
