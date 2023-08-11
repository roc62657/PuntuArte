using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PuntuArte.Modelo
{
    public class JuradoCategoriaPuntuacion
    {
        public int IDJuradoCatPuntuacion { get; set; }
        public int IDParticipante { get; set; }
        public int IDCatPto { get; set; }
        public string Observacion { get; set; }

    }
}
