using PuntuArte.ConexionDDBB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PuntuArte.Modelo
{
    public class CompaniaPuntuacionDTO
    {
        public int IDCompania { get; set; }
        public string Nombre { get; set; }

        public List<ItemsPuntuacion> itemsPuntuacion;
      
    }
}
