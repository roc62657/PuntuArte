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

namespace PuntuArte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardarCategoria_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias()
            {
                Nombre = nombreCategoria.Text,
                RitmoMusical = ritmoMusical.Text,
                Detalle = detalleCategoria.Text
            };

            bool respuesta = CategoriasConexion.Instancia.guardarCategoria(categoria);

            if(respuesta)
            {
                mostrar_categorias();
            }
        }

        public void mostrar_categorias()
        {
            listaCategorias.DataSource = null;
            listaCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategorias();
        }
    }
}
