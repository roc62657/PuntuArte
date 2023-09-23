using PuntuArte.ConexionDDBB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PuntuArte.Modelo
{
    public class PuntuacionDTO
    {
        public int IDItemPuntuacion { get; set; }
        public int IDCategoria { get; set; }
        public int IDJurado { get; set; }
        public string NombreJurado { get; set; }
        public int IDCompania { get; set; }
        public int Puntuacion { get; set; }

    }
}
