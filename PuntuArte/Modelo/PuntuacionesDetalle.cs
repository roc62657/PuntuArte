using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PuntuArte.Modelo
{
    public class PuntuacionesDetalle
    {
        public int IDPuntuacionDetalle { get; set; }
        public int IDPuntuacionFinal { get; set; }
        public int IDJurado { get; set; }
        public int IDCompania { get; set; }
        public int IDCategoria { get; set; }
        public int IDItemPuntuacion { get; set; }
        public string Puntuacion { get; set; }

    }
}
