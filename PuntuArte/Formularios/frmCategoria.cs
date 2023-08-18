using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PuntuArte.Modelo;
using PuntuArte.ConexionDDBB;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using static PuntuArte.Formularios.frmABMParticipante;

namespace PuntuArte.Formularios
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            mostrar_categorias();
        }

        private void guardarCategoria_Click(object sender, EventArgs e)
        {
            if (nombreCategoria.Text != "" && detalleCategoria.Text != "" && ritmoMusical.Text != "") //validacion de carga de datos
            {
                Categorias categoria = new Categorias()
                {
                    Nombre = nombreCategoria.Text,
                    RitmoMusical = ritmoMusical.Text,
                    Detalle = detalleCategoria.Text
                };

                bool respuesta = false;
                if (tbIdCategoria.Text == "") // es nuevo si no tiene ID
                {
                    respuesta = CategoriasConexion.Instancia.guardarCategoria(categoria);
                }
                else
                {
                    categoria.IDCategoria = int.Parse(tbIdCategoria.Text);
                    respuesta = CategoriasConexion.Instancia.actualizarCategoria(categoria);
                }

                //Recarga grilla
                if (respuesta)
                    mostrar_categorias();

                //Limpia controles e inhabilita sector alta y modificacion
                gbCategorias.Enabled = false;
                tbIdCategoria.Text = "";
                nombreCategoria.Text = "";
                detalleCategoria.Text = "";
                ritmoMusical.Text = "";
                guardarCategoria.Enabled = false;

            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void listaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;

            //Limpia controles e inhabilita sector alta y modificacion
            gbCategorias.Enabled = false;
            tbIdCategoria.Text = "";
            nombreCategoria.Text = "";
            detalleCategoria.Text = "";
            ritmoMusical.Text = "";
            guardarCategoria.Enabled = false;

            //Habilita sector de items correspondientes a la categoria seleccionada
            habilitaSectorItems();
        }

        private void bAgregarItem_Click(object sender, EventArgs e)
        {
            int cantidadColumnasSeleccionadasCategorias = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int cantidadColumnasSeleccionadasItems = listaItemsDisponibles.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadColumnasSeleccionadasItems == 1)
            {
                DataGridViewRow selectRowCategoria = listaCategorias.SelectedRows[0];
                DataGridViewRow selectRowItem = listaItemsDisponibles.SelectedRows[0];

                bool rta = CategoriaPuntuacionConexion.Instancia.guardarCategoriaPuntuacion( int.Parse(selectRowCategoria.Cells[0].Value.ToString()), int.Parse(selectRowItem.Cells[0].Value.ToString())); //IDCategoriaSeleccionada, IDItemSeleccionado

                cargaDeDatosGrillasItems(int.Parse(selectRowCategoria.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item de puntuacion para agregar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void bQuitarItem_Click(object sender, EventArgs e)
        {
            int cantidadColumnasSeleccionadasCategorias = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int cantidadColumnasSeleccionadasItemsAsociados = listaItemsAsociados.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadColumnasSeleccionadasItemsAsociados == 1)
            {
                DataGridViewRow selectRowCategoria = listaCategorias.SelectedRows[0];
                DataGridViewRow selectRowItemAsociado = listaItemsAsociados.SelectedRows[0];

                CategoriaPuntuacionConexion.Instancia.eliminarCategoriaPuntuacion(int.Parse(selectRowCategoria.Cells[0].Value.ToString()), int.Parse(selectRowItemAsociado.Cells[0].Value.ToString())); //IDCategoriaSeleccionada, IDItemAsociadoSeleccionado

                cargaDeDatosGrillasItems(int.Parse(selectRowCategoria.Cells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Debe seleccionar un item de puntuacion para quitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            gbCategorias.Enabled = true;
            tbIdCategoria.Text = "";
            nombreCategoria.Text = "";
            detalleCategoria.Text = "";
            ritmoMusical.Text = "";
            guardarCategoria.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int selectedRowCount = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbCategorias.Enabled = true;
                DataGridViewRow row = listaCategorias.SelectedRows[0];
                tbIdCategoria.Text = row.Cells[0].Value.ToString();
                nombreCategoria.Text = row.Cells[1].Value.ToString();
                ritmoMusical.Text = row.Cells[2].Value.ToString();
                detalleCategoria.Text = row.Cells[3].Value.ToString();

                guardarCategoria.Enabled = true;
            }
            else
            {
                gbCategorias.Enabled = false;
                tbIdCategoria.Text = "";
                nombreCategoria.Text = "";
                detalleCategoria.Text = "";
                ritmoMusical.Text = "";
                btnActualizarCategoria.Enabled = false;
                guardarCategoria.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            int selectedRowCount = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbCategorias.Enabled = true;
                DataGridViewRow row = listaCategorias.SelectedRows[0];
                string idCategoria = row.Cells[0].Value.ToString();
                string nombreCategoria = row.Cells[2].Value.ToString();

                if (MessageBox.Show("Seguro que desea eliminar la categoria " + idCategoria + " - "+ nombreCategoria + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    CategoriasConexion.Instancia.eliminarCategoria(idCategoria);
                    mostrar_categorias();
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //////////////////Custom
        
        private void habilitaSectorItems()
        {

            int cantidadColumnasSeleccionadas = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (cantidadColumnasSeleccionadas == 1) //solo debe seleccionar una categoria
            {
                gbItemsPuntuacion.Enabled = true;

                //carga de grillas de Items
                DataGridViewRow selectRow = listaCategorias.SelectedRows[0];

                cargaDeDatosGrillasItems(int.Parse(selectRow.Cells[0].Value.ToString()));

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de categorias para asignar items de puntuación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void cargaDeDatosGrillasItems(int idCategoria, int idItem = 0)
        {
            if (gbItemsPuntuacion.Enabled != true) gbItemsPuntuacion.Enabled = true;

            List<ItemsPuntuacion> lItemsPuntuacionNoAsignadosACategoria = ItemsPuntuacionConexion.Instancia.obtenerItemsNoAsignadosACategoria(idCategoria); //IDCategoriaSeleccionada
            listaItemsDisponibles.DataSource = null;
            listaItemsDisponibles.DataSource = lItemsPuntuacionNoAsignadosACategoria;
            bAgregarItem.Enabled = lItemsPuntuacionNoAsignadosACategoria.Count > 0 ? true : false;
            bModificacionItem.Enabled = lItemsPuntuacionNoAsignadosACategoria.Count > 0 ? true : false;

            //manda el selected al recien creado / modificado
            if (idItem > 0)
            {
                int indice = lItemsPuntuacionNoAsignadosACategoria.FindIndex(a => a.IDItemPuntuacion == idItem);
                listaItemsDisponibles.Rows[0].Selected = false;
                listaItemsDisponibles.Rows[indice].Selected = true;
            }

            List<ItemsPuntuacion> lItemsPuntuacionAsignadosACategoria = ItemsPuntuacionConexion.Instancia.obtenerItemsAsignadosACategoria(idCategoria); //IDCategoriaSeleccionada
            listaItemsAsociados.DataSource = null;
            listaItemsAsociados.DataSource = lItemsPuntuacionAsignadosACategoria;
            bQuitarItem.Enabled = lItemsPuntuacionAsignadosACategoria.Count > 0 ? true : false;

        }


        public void mostrar_categorias()
        {
            listaCategorias.DataSource = null;
            listaCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategorias();
        }


        ///// Alta de Items de puntuacion
        private void bAltaItem_Click(object sender, EventArgs e)
        {
            frmABMItemPuntuacion formAltaItemPuntuacion = new frmABMItemPuntuacion();
            formAltaItemPuntuacion.crearModificarItemPuntuacion += new frmABMItemPuntuacion.agregarItemsPuntuacion(crearModificarItemPuntuacion);
            formAltaItemPuntuacion.ShowDialog();
        }

        public void crearModificarItemPuntuacion(ItemsPuntuacion itemPuntuacion)
        {
            if (itemPuntuacion != null)
            {
                int rta = 0;

                if (itemPuntuacion.IDItemPuntuacion == 0) //si trae Id es de edicion
                    rta = ItemsPuntuacionConexion.Instancia.guardarItemsPuntuacion(itemPuntuacion);
                else
                    rta = ItemsPuntuacionConexion.Instancia.actualizarItemsPuntuacion(itemPuntuacion);


                if (rta != 0)
                {
                    int cantidadColumnasSeleccionadasCategorias = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    if (cantidadColumnasSeleccionadasCategorias == 1)
                    {
                        DataGridViewRow selectRowCategoria = listaCategorias.SelectedRows[0];//IDCategoriaSeleccionada
                        cargaDeDatosGrillasItems(int.Parse(selectRowCategoria.Cells[0].Value.ToString()), rta);
                    }
                }
            }
        }

        private void bModificacionItem_Click(object sender, EventArgs e)
        {
            int cantidadColumnasSeleccionadas = listaItemsDisponibles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (cantidadColumnasSeleccionadas == 1)
            {
                DataGridViewRow selectRow = listaItemsDisponibles.SelectedRows[0];

                frmABMItemPuntuacion formAltaItemPuntuacion = new frmABMItemPuntuacion(int.Parse(selectRow.Cells[0].Value.ToString())); //IDCategoriaSeleccionada
                formAltaItemPuntuacion.crearModificarItemPuntuacion += new frmABMItemPuntuacion.agregarItemsPuntuacion(crearModificarItemPuntuacion);
                formAltaItemPuntuacion.eliminarItemPuntuacion += new frmABMItemPuntuacion.borrarItemsPuntuacion(eliminarItemPuntuacion);
                formAltaItemPuntuacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un participante de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarItemPuntuacion(int itemPuntuacion)
        {
            if (itemPuntuacion != 0)
            {
                bool rta = false;

                //Elimina participante y Participante_Compania_Categoria
                rta = ItemsPuntuacionConexion.Instancia.eliminarItemsPuntuacion(itemPuntuacion);

                if (rta)
                {
                    int cantidadColumnasSeleccionadas = listaCategorias.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (cantidadColumnasSeleccionadas == 1)
                    {
                        DataGridViewRow selectRow = listaCategorias.SelectedRows[0];
                        cargaDeDatosGrillasItems(int.Parse(selectRow.Cells[0].Value.ToString()));
                    }
                }
            }
        }


        
    }
}
