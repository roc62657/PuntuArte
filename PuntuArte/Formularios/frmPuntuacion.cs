using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using PuntuArte.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO.Ports;
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
            List<Companias> lCompanias = new List<Companias>();
            lCompanias.Add(new Companias()
            {
                IDCompania = -1,
                Nombre = "Seleccione Compañía a evaluar",
                Detalle = "",
                Nacionalidad = "",
            });
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            lCompanias.AddRange(CompaniasConexion.Instancia.obtenerCompaniasEnCompetenciaPorCategoria(categoriaSeleccionada.IDCategoria));
            cbCompania.DataSource = lCompanias;
            cbCompania.DisplayMember = "Nombre";
            cbCompania.ValueMember = "IDCompania";

        }

        private void cbCompania_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            Companias companiaSeleccionada = (Companias)cbCompania.SelectedItem;
            if (companiaSeleccionada.IDCompania != -1 && categoriaSeleccionada.IDCategoria != -1) { 
                obtenerPuntuacion(categoriaSeleccionada.IDCategoria, companiaSeleccionada.IDCompania);
            }
        }

        private void obtenerPuntuacion(int idCategoria, int idCompania)
        {
            //se crean las columnas segun items de puntuacion
            List<ItemsPuntuacion> lItemPuntuacion = ItemsPuntuacionConexion.Instancia.obtenerItemsAsignadosACategoria(idCategoria).OrderBy(a => a.IDItemPuntuacion).ToList();
            foreach (ItemsPuntuacion itemPuntuacion in lItemPuntuacion)
            {
                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = itemPuntuacion.Nombre;
                columna.Name = itemPuntuacion.IDItemPuntuacion + ";" + itemPuntuacion.Nombre;
                columna.Tag = itemPuntuacion.IDItemPuntuacion;
                dgPuntuaciones.Columns.Add(columna);
            }

            //se obtienen puntuaciones por compania
            int idJuradoRecorrido = 0;
            int numeroColumna = 0;
            int cantidadColumnasRecorridas = 0;
            DataTable dt = new DataTable();
            //dt.Columns.Add(dgPuntuaciones.Columns as DataColumn)
            DataGridViewRow fila = (DataGridViewRow)dgPuntuaciones.Rows[0].Clone();
            List<PuntuacionDTO> puntuacionDTOs = ItemsPuntuacionConexion.Instancia.obtenerPuntuacionPorCompania(idCompania); //lo trae ordenado por IDJurado + IDItemPuntuacion
            foreach (PuntuacionDTO itemPuntuacionDto in puntuacionDTOs)
            {
                if (idJuradoRecorrido != itemPuntuacionDto.IDJurado) //la primera vez que entra carga las primeras 3 filas
                {
                    fila = (DataGridViewRow)dgPuntuaciones.Rows[0].Clone();
                    idJuradoRecorrido = itemPuntuacionDto.IDJurado;
                    fila.Cells[0].Value = itemPuntuacionDto.IDJurado;
                    fila.Cells[1].Value = itemPuntuacionDto.NombreJurado;
                    fila.Cells[2].Value = itemPuntuacionDto.Puntuacion;
                    numeroColumna = 3;
                }
                else
                { //entra cuando va completando las columnas de la fila que se esta cargando
                    fila.Cells[numeroColumna].Value = itemPuntuacionDto.Puntuacion;
                    numeroColumna ++;
                }

                cantidadColumnasRecorridas++; //si es la ultima fila, la agrega a la tabla
                if (cantidadColumnasRecorridas == lItemPuntuacion.Count)
                {
                    dgPuntuaciones.Rows.Add(fila);
                    cantidadColumnasRecorridas = 0; //reinicia
                }
            }

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Companias companiaSeleccionada = (Companias)cbCompania.SelectedItem;
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;

            PuntuacionesFinales pFinal = new PuntuacionesFinales();
            pFinal.IDCompania = companiaSeleccionada.IDCompania;
            pFinal.IDCategoria = categoriaSeleccionada.IDCategoria;
            pFinal.PuntajeFinal = 0;
            pFinal.Puesto = 0;
            pFinal.Observacion = 0;

            int idPuntuacionFinal = PuntuacionesConexion.Instancia.guardarPuntuacionFinal(pFinal);

            foreach (DataGridViewRow fila in dgPuntuaciones.Rows)
            {
                int idJurado = int.Parse(fila.Cells[0].Value.ToString()); //siempre la ubicacion 0 va a ser el IDJurado
                for (int i = 2; i < fila.Cells.Count; i++)
                {
                    int puntaje = int.Parse(fila.Cells[i].Value.ToString());
                    //int indexColumna = fila.Cells[i].ColumnIndex;
                    int idItemPuntuacion = int.Parse(dgPuntuaciones.Columns[fila.Cells[i].ColumnIndex].Tag.ToString());

                    PuntuacionesDetalle pDetalle = new PuntuacionesDetalle();
                    pDetalle.IDPuntuacionFinal = idPuntuacionFinal;
                    pDetalle.IDJurado = idJurado;
                    pDetalle.IDCompania = companiaSeleccionada.IDCompania;
                    pDetalle.IDCategoria = categoriaSeleccionada.IDCategoria;
                    pDetalle.IDItemPuntuacion = idItemPuntuacion;
                    pDetalle.Puntuacion = puntaje.ToString();

                    int idPuntuacionDetalle = PuntuacionesConexion.Instancia.guardarPuntuacionDetalle(pDetalle);
                }
                
            }
        }
    }
}
