using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    public partial class frmCompanias : Form
    {
        public frmCompanias()
        {
            InitializeComponent();
        }

        private void frmCompanias_Load(object sender, EventArgs e)
        {
            mostrarCompanias();
            habilitarSeleccionCompania();
        }
        private void bGuardarCompania_Click(object sender, EventArgs e)
        {
            Companias compania = new Companias()
            {
                Nombre = tbNombreCompania.Text,
                Detalle = tbDetalleCompania.Text,
                Nacionalidad = tbNacionalidadCompania.Text
            };

            int idRespuesta = 0;
            if (tbIdCompania.Text == "") // es nuevo si no tiene ID
            {
                idRespuesta = CompaniasConexion.Instancia.guardarCompanias(compania);
            }
            else
            {
                compania.IDCompania = int.Parse(tbIdCompania.Text);
                idRespuesta = CompaniasConexion.Instancia.actualizarCompanias(compania);
            }

            //Recarga grilla
            if (idRespuesta != 0)
            {
                mostrarCompaniasConSeleccionYDetalle(idRespuesta);
                //actualizarDatosSeleccionados(idRespuesta);

                //Limpia controles e inhabilita sector alta y modificacion
                habilitarSeleccionCompania();
                rbSeleccionarCompania.Checked = true;
            }

        }


        private void rbSeleccionarCompania_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbSeleccionarCompania.Checked)
            {
                mostrarCompanias();
                cbCompanias.SelectedText = tbNombreCompania.Text;
                habilitarSeleccionCompania();
            }
        }


        private void rbCrearActualizarCompania_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbCrearActualizarCompania.Checked)
            {
                habilitarNuevo();
            }
        }

        private void cbCompanias_SelectedValueChanged(object sender, EventArgs e)
        {
            Companias companiaSeleccionada = (Companias)cbCompanias.SelectedItem;
            if (companiaSeleccionada != null && companiaSeleccionada.IDCompania != -1)
            {
                lDetalleDesc.Text =  companiaSeleccionada.Detalle;
                lNacionalidadDesc.Text = companiaSeleccionada.Nacionalidad;
                bActualizarCompania.Visible = true;

                habilitarSectorSeleccionDeCategorias(companiaSeleccionada.IDCompania);
            }
            else
            {
                lDetalleDesc.Text = "";
                lNacionalidadDesc.Text = "";
                bActualizarCompania.Visible = false;
            }
        }

        private void bActualizarCompania_Click(object sender, EventArgs e)
        {
            Companias companiaSeleccionada = (Companias)cbCompanias.SelectedItem;
            habilitarNuevo();
            tbIdCompania.Text = companiaSeleccionada.IDCompania.ToString();
            tbNombreCompania.Text = companiaSeleccionada.Nombre;
            tbDetalleCompania.Text = companiaSeleccionada.Detalle;
            tbNacionalidadCompania.Text = companiaSeleccionada.Nacionalidad;
            rbCrearActualizarCompania.Checked = true;
        }

        ///////Custom

        public void mostrarCompanias()
        {
            cbCompanias.DataSource = CompaniasConexion.Instancia.obtenerCompanias();
            cbCompanias.DisplayMember = "Nombre";
            cbCompanias.ValueMember = "IDCompania";
        }

        public void mostrarCompaniasConSeleccionYDetalle(int idCompaniaSeleccionada)
        {
            List<Companias> lCompania = CompaniasConexion.Instancia.obtenerCompanias();
            cbCompanias.DataSource = lCompania;
            cbCompanias.DisplayMember = "Nombre";
            cbCompanias.ValueMember = "IDCompania";


            Companias compania = lCompania.FirstOrDefault(x => x.IDCompania == idCompaniaSeleccionada);
            //cbCompanias.SelectedIndex = cbCompanias.Items.Count - 1;
            int indice = lCompania.FindIndex(a => a.IDCompania == idCompaniaSeleccionada);
            cbCompanias.SelectedIndex = indice;
            lDetalleDesc.Text = compania.Detalle;
            lNacionalidadDesc.Text = compania.Nacionalidad;


        }

        public void habilitarNuevo()
        {
            //parte nuevo
            lNombreNuevoTitulo.Enabled = true;
            lDetalleNuevoTitulo.Enabled = true;
            lNacionalidadNuevoTitulo.Enabled = true;

            tbIdCompania.Text = "";
            tbNombreCompania.Text = "";
            tbDetalleCompania.Text = "";
            tbNacionalidadCompania.Text = "";

            tbNombreCompania.Enabled = true;
            tbDetalleCompania.Enabled = true;
            tbNacionalidadCompania.Enabled = true;

            //parte seleccion
            lCompaniaTitulo.Enabled = false;
            cbCompanias.Enabled = false;
            lDetalleTitulo.Visible = false;
            lDetalleDesc.Visible = false;
            lNacionalidadTitulo.Visible = false;
            lNacionalidadDesc.Visible = false;

            bGuardarCompania.Enabled = true;
            bActualizarCompania.Visible = false;

            rbCrearActualizarCompania.Checked = true;
        }

        public void habilitarSeleccionCompania()
        {
            //parte nuevo
            lNombreNuevoTitulo.Enabled = false;
            lDetalleNuevoTitulo.Enabled = false;
            lNacionalidadNuevoTitulo.Enabled = false;

            tbNombreCompania.Text = "";
            tbDetalleCompania.Text = "";
            tbNacionalidadCompania.Text = "";

            tbNombreCompania.Enabled = false;
            tbDetalleCompania.Enabled = false;
            tbNacionalidadCompania.Enabled = false;

            //parte seleccion
            lCompaniaTitulo.Enabled = true;
            cbCompanias.Enabled = true;
            lDetalleTitulo.Visible = true;
            lDetalleDesc.Visible = true;
            lNacionalidadTitulo.Visible = true;
            lNacionalidadDesc.Visible = true;

            bGuardarCompania.Enabled = false;

            Companias companiaSeleccionada = (Companias)cbCompanias.SelectedItem;
            if (companiaSeleccionada != null && companiaSeleccionada.IDCompania != -1) { bActualizarCompania.Visible = true; } else { bActualizarCompania.Visible = false; };

            rbSeleccionarCompania.Checked = true;
        }


        //////////Sector de Seleccion de categorias 

        private void bAgregarCategoria_Click(object sender, EventArgs e)
        {
            int cantidadColumnasSeleccionadas = listaCategoriasDisponibles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Companias companiaSeleccionada = (Companias)cbCompanias.SelectedItem;
            
            if (cantidadColumnasSeleccionadas >= 1)
            {
                foreach (DataGridViewRow selectRow in listaCategoriasDisponibles.SelectedRows)
                {
                    CategoriasConexion.Instancia.guardarCategoriaAsignada(companiaSeleccionada.IDCompania, int.Parse(selectRow.Cells[0].Value.ToString())); //IDCompania,IDCategoriaSeleccionada
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de categorias para agregar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cargaDeDatosGrillas(companiaSeleccionada.IDCompania);

        }

        private void bQuitarCategoria_Click(object sender, EventArgs e)
        {
            int cantidadColumnasSeleccionadas = listaCategoriasAgregadas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            Companias companiaSeleccionada = (Companias)cbCompanias.SelectedItem;

            if (cantidadColumnasSeleccionadas >= 1)
            {
                foreach (DataGridViewRow selectRow in listaCategoriasAgregadas.SelectedRows)
                {
                    CategoriasConexion.Instancia.borrarCategoriaAsignada(companiaSeleccionada.IDCompania, int.Parse(selectRow.Cells[0].Value.ToString())); //IDCompania,IDCategoriaSeleccionada
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de categorias para borrarla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cargaDeDatosGrillas(companiaSeleccionada.IDCompania);
        }

        public void habilitarSectorSeleccionDeCategorias(int idCompania)
        {
            gbSeleccionCategorias.Enabled = true;

            cargaDeDatosGrillas(idCompania);
        }

        public void cargaDeDatosGrillas(int idCompania)
        {
            gbSeleccionCategorias.Enabled = true;

            List<Categorias> catNoAsignadas = CategoriasConexion.Instancia.obtenerCategoriasNoAsignadasACompania(idCompania);
            listaCategoriasDisponibles.DataSource = null;
            listaCategoriasDisponibles.DataSource = catNoAsignadas;

            bAgregarCategoria.Enabled = catNoAsignadas.Count > 0 ?  true : false;

            List<Categorias> catAgregadas = CategoriasConexion.Instancia.obtenerCategoriasAsignadasACompania(idCompania);
            listaCategoriasAgregadas.DataSource = null;
            listaCategoriasAgregadas.DataSource = catAgregadas;

            bQuitarCategoria.Enabled = catAgregadas.Count > 0 ? true : false;

            ///Combo de seleccion de categorias, sector participantes por categoria
            if (catAgregadas.Count > 0)
            {
                gbParticipantesPorCategoria.Enabled = true;
                cbCategoriasPorCompania.DataSource = catAgregadas;
                cbCategoriasPorCompania.DisplayMember = "Nombre";
                cbCategoriasPorCompania.ValueMember = "IDCategoria";
            }
            else
            {
                gbParticipantesPorCategoria.Enabled = false;
                cbCategoriasPorCompania.DataSource = null;
            }

        }

        


        //////Sector de asignacion de participantes por categoria
        

        
    }
}
