using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using PuntuArte.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            cbCompania.DataSource  = CompaniasConexion.Instancia.obtenerCompaniasEnCompetenciaPorCategoria(categoriaSeleccionada.IDCategoria);
            cbCompania.DisplayMember = "Nombre";
            cbCompania.ValueMember = "IDCompania";
        }


        private void cbCompania_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            Companias companiaSeleccionada = (Companias)cbCompania.SelectedItem;
            if (companiaSeleccionada.IDCompania != -1) { 
            obtenerPuntuacion(categoriaSeleccionada.IDCategoria, companiaSeleccionada.IDCompania -1);
            }

        }

        private void obtenerPuntuacion(int idCategoria, int indiceCompania)
        {
            List<CompaniaPuntuacionDTO> lCompaniaPuntuacionDTO = ItemsPuntuacionConexion.Instancia.obtenerDatosPuntuacion(idCategoria);
            lbCompania.Text = lCompaniaPuntuacionDTO[indiceCompania].Nombre;

            TextBox[] valorItems;
            Label[] items;

            int totalItems = lCompaniaPuntuacionDTO[indiceCompania].itemsPuntuacion.Count;
            if(totalItems > 0)
            {
                btEnviar.Visible = true;
            }

            int y = 240;
            items = new Label[totalItems];
            for (int i = 0; i < totalItems; i++)
            {
                items[i] = new Label();
                items[i].Location = new Point(59, y);
                items[i].Name = String.Concat("lb_",lCompaniaPuntuacionDTO[indiceCompania].itemsPuntuacion[i].Nombre);
                items[i].Size = new Size(200,30);
                items[i].TabIndex = i;
                items[i].Text = lCompaniaPuntuacionDTO[indiceCompania].itemsPuntuacion[i].Nombre;
                items[i].Visible = true;
                items[i].Tag = i;
                this.Controls.Add(items[i]);
                y += 40;
            }
            valorItems = new TextBox[totalItems];
            int _y = 239;
            for (int i = 0; i < totalItems; i++)
            {
                valorItems[i] = new TextBox();
                valorItems[i].Location = new Point(300, _y);
                valorItems[i].Name = String.Concat("lb_", i.ToString());
                valorItems[i].Size = new Size(45, 15);
                valorItems[i].Text = "";
                valorItems[i].Visible = true;
                valorItems[i].Tag = i;
                this.Controls.Add(valorItems[i]);
                _y += 40;
            }

        }

        private void obtenerPuntuacionOld(int idCategoria)
        {

            dgPuntuaciones.DataSource = null;
            List<CompaniaPuntuacionDTO> lCompaniaPuntuacionDTO = ItemsPuntuacionConexion.Instancia.obtenerDatosPuntuacion(idCategoria);

            DataGridViewTextBoxColumn Col_Text;
            Col_Text = new DataGridViewTextBoxColumn()
            {
                Name = "companias",
                HeaderText = " ",
                Width = 10
            };
            this.dgPuntuaciones.Columns.Add(Col_Text);
            Col_Text = new DataGridViewTextBoxColumn()
            {
                Name = "companias",
                HeaderText = " ",
                Width = 100
            };
            this.dgPuntuaciones.Columns.Add(Col_Text);

            //Cargo las filas con las companias de puntuacion
            foreach (CompaniaPuntuacionDTO companiaPuntuacion in lCompaniaPuntuacionDTO)
            {
                dgPuntuaciones.Rows.Add(companiaPuntuacion.IDCompania, companiaPuntuacion.Nombre);
            }


            //Cargo las columnas con items de puntuacion
            foreach (ItemsPuntuacion itemPuntuacion in lCompaniaPuntuacionDTO[0].itemsPuntuacion)
            {
                Col_Text = new DataGridViewTextBoxColumn()
                {
                    Name = "companias",
                    HeaderText = itemPuntuacion.Nombre,
                    Width = 100
                };
                this.dgPuntuaciones.Columns.Add(Col_Text);
            }
            

            //dgPuntuaciones.DataSource = ItemsPuntuacionConexion.Instancia.obtenerDatosPuntuacion(idCategoria);
            //dgPuntuaciones.Rows[0].Selected = false;




        }


        private void dgPuntuaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
           //     fr.Text = dgPuntuaciones.CurrentCell.Value.ToString();
            }catch (Exception ex)
            {

            }
        }

    }
}
