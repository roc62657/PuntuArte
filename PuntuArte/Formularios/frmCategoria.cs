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

        private void nombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void detalleCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void ritmoMusical_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarDatosCargados();
        }

        private void listaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            gbCategorias.Enabled = true;
            tbIdCategoria.Text = "";
            nombreCategoria.Text = "";
            detalleCategoria.Text = "";
            ritmoMusical.Text = "";
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

        public void mostrar_categorias()
        {
            listaCategorias.DataSource = null;
            listaCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategorias();
        }

        private void validarDatosCargados()
        {
            if (nombreCategoria.Text != "" && detalleCategoria.Text != "" && ritmoMusical.Text != "")
                guardarCategoria.Enabled = true;
            else
                guardarCategoria.Enabled = false;
        }

       
    }
}
