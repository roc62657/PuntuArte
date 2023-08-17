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
    public partial class frmABMItemPuntuacion : Form
    {
        public delegate void agregarItemsPuntuacion(ItemsPuntuacion itemPuntuacion);
        public delegate void borrarItemsPuntuacion(int itemPuntuacion);
        public event agregarItemsPuntuacion crearModificarItemPuntuacion;
        public event borrarItemsPuntuacion eliminarItemPuntuacion;
        public frmABMItemPuntuacion()
        {
            InitializeComponent();
        }

        public frmABMItemPuntuacion(int idItemPuntuacion)
        {
            InitializeComponent();

            ItemsPuntuacion itemPuntuacion = ItemsPuntuacionConexion.Instancia.obtenerItemPuntuacion(idItemPuntuacion);
            tIdItemPuntuacion.Text = itemPuntuacion.IDItemPuntuacion.ToString();
            tNombreItemPuntuacion.Text = itemPuntuacion.Nombre;
            tDetalleItemPuntuacion.Text = itemPuntuacion.Detalle;

            bEliminarItemPuntuacion.Visible = true;
        }

        private void bAltaItemPuntuacion_Click(object sender, EventArgs e)
        {
            if (tNombreItemPuntuacion.Text != "" &&
                tDetalleItemPuntuacion.Text != ""
                )
            {
                ItemsPuntuacion itemPuntuacion = new ItemsPuntuacion()
                {
                    IDItemPuntuacion = tIdItemPuntuacion.Text == "" || tIdItemPuntuacion.Text == "0" ? 0 : int.Parse(tIdItemPuntuacion.Text),
                    Nombre = tNombreItemPuntuacion.Text,
                    Detalle = tDetalleItemPuntuacion.Text
                };

                crearModificarItemPuntuacion(itemPuntuacion);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos del item de puntuación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bEliminarItemPuntuacion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar este item de puntuación?. En caso de aceptar, se eliminará el item de puntuación y todas las relaciones a las categorias", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                eliminarItemPuntuacion(int.Parse(tIdItemPuntuacion.Text));
                this.Dispose();
            }
        }
    }
}
