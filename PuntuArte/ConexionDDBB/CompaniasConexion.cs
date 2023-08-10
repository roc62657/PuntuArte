using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PuntuArte.Modelo;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


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

        public bool guardarCompanias(Companias compania)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion_ = new SQLiteConnection(conexion))
            {
                conexion_.Open();
                string query = "Insert into Companias (Nombre,Detalle) values (@nombre,@detalle)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion_);
                cmd.Parameters.Add(new SQLiteParameter("nombre", compania.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("detalle", compania.Detalle));
                cmd.CommandType = System.Data.CommandType.Text;
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }
        public List<Companias> obtenerCompanias(){
            List<Companias> listCompanias = new List<Companias>();


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

                        });
                    }
                }
            }
            return listCompanias;
        }

    }
}
