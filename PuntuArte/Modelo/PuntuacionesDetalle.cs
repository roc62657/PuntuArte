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
        public int IDJuradoCatPuntuacion { get; set; }
        public int IDCompaniaCategoria { get; set; }
        public int Puntuacion { get; set; }
        public string Observacion { get; set; }

    }
}
