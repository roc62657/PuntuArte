using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PuntuArte.Modelo
{
    public class Participantes
    {
        public int IDParticipante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nacionalidad { get; set; }
        public string NroTelefono { get; set; }
        public string Rol { get; set; }
    }
}
