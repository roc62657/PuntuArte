using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    public partial class frmPuntuacion : Form
    {
        public frmPuntuacion()
        {
            InitializeComponent();

        }

        private void frmPuntuacion_Load(object sender, EventArgs e)
        {
            List<Categorias> lCatHabilitadas = new List<Categorias>(); //Se agrega para obligar a seleccionar categoria
            lCatHabilitadas.Add(new Categorias()
            {
                IDCategoria = -1,
                Nombre = "Seleccione Categoría a evaluar",
                Detalle = "",
                RitmoMusical = "",
            });
            lCatHabilitadas.AddRange(CategoriasConexion.Instancia.obtenerCategoriaHabilitadasParaCalificar());
            cbCategorias.DataSource = lCatHabilitadas;
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.ValueMember = "IDCategoria";

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            if (categoriaSeleccionada != null && categoriaSeleccionada.IDCategoria != -1)
            {
                List<Companias> lCompaniasVinculadas = new List<Companias>(); //Se agrega para obligar a seleccionar Compania
                lCompaniasVinculadas.Add(new Companias()
                {
                    IDCompania = -1,
                    Nombre = "Seleccione Compañia a evaluar",
                    Detalle = "",
                    Nacionalidad = "",
                      
                });
                lCompaniasVinculadas.AddRange(CompaniasConexion.Instancia.obtenerCompaniasEnCompetenciaPorCategoria(categoriaSeleccionada.IDCategoria));
                cbCompanias.DataSource = lCompaniasVinculadas;
                cbCompanias.DisplayMember = "Nombre";
                cbCompanias.ValueMember = "IDCompania";
            }
            else
            {
                cbCompanias.DataSource = null;
            }
        }

        private void cbCompanias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listaItemsJurados.DataSource = 
        }
    }
}
