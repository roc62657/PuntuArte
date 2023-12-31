﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PuntuArte.Modelo;
using System.Data.SQLite;


namespace PuntuArte.ConexionDDBB
{
    public class CompaniasConexion
    {

        private static string conexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        private static CompaniasConexion _instancia = null;

        public CompaniasConexion()
        {

        }
        public static CompaniasConexion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new CompaniasConexion();
                }
                return _instancia;
            }
        }

        public int guardarCompanias(Companias compania)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Companias (Nombre,Detalle,Nacionalidad) values (@nombre,@detalle,@nacionalidad)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", compania.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("detalle", compania.Detalle));
                cmd.Parameters.Add(new SQLiteParameter("nacionalidad", compania.Nacionalidad));
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

        public int actualizarCompanias(Companias compania)
        {
            int respuesta = 0;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Update Companias set Nombre = @nombre, Detalle = @detalle, Nacionalidad = @nacionalidad where IDCompania = @idCompania";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", compania.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("detalle", compania.Detalle));
                cmd.Parameters.Add(new SQLiteParameter("nacionalidad", compania.Nacionalidad));
                cmd.Parameters.Add(new SQLiteParameter("idCompania", compania.IDCompania));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = -1;
                }
                else
                {
                    respuesta = compania.IDCompania;
                }
            }
            return respuesta;

        }


        public List<Companias> obtenerCompanias()
        {
            List<Companias> listCompanias = new List<Companias>();
            listCompanias.Add(new Companias()
            {
                IDCompania = -1,
                Nombre = "Seleccione Compañia o Creala si no existe",
                Detalle = "",
                Nacionalidad = "",
            });


            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Companias";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listCompanias.Add(new Companias()
                        {
                            IDCompania = int.Parse(dr["IDCompania"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                        });
                    }
                }
            }
            return listCompanias;
        }

        public Companias obtenerCompania(int idCompania)
        {
            Companias compania = new Companias();
            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Select * from Companias where IDCompania = @idCompania";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("idCompania", idCompania));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        compania = new Companias()
                        {
                            IDCompania = int.Parse(dr["IDCompania"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                            Detalle = dr["Detalle"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                        };
                    }
                }
            }
            return compania;
        }

    }
}
