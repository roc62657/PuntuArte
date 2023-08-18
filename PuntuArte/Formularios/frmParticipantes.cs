using PuntuArte.ConexionDDBB;
using PuntuArte.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntuArte.Formularios
{
    public partial class frmParticipantes : Form
    {
        public frmParticipantes()
        {
            InitializeComponent();
        }

        private void frmParticipantes_Load(object sender, EventArgs e)
        {
            mostrarParticipantes();
        }

        private bool validarDatosAGuardar()
        {
            if (tbNombreParticipante.Text=="" ||
                tbApellidoParticipante.Text == ""||
                tbNacionalidadParticipante.Text == "" ||
                tbNroDocParticipante.Text == ""
                ){                
                MessageBox.Show("Los campos NOMBRE, APELLIDO, PAIS ORIGEN y NUMERO DE DOCUMENTO son obligatorios, por favor valide los mismos y vuelva a intentar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
               int idParticipante = ParticipantesConexion.Instancia.obtenerIDParticipanteJuradoPorDocumentoYNacionalidad(tbNroDocParticipante.Text,tbNacionalidadParticipante.Text);
                if( idParticipante >= 0)
                {
                    MessageBox.Show("El jurado que desea crear ya existe, por favor valide los mismos y vuelva a intentar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            
            return true;
        }

        private void guardarCategoria_Click(object sender, EventArgs e)
        {
            if (validarDatosAGuardar()) { 
                Participantes participante = new Participantes()
                {
                    Nombre = tbNombreParticipante.Text,
                    Apellido = tbApellidoParticipante.Text,
                    TipoDocumento = tbTipoDocParticipante.Text,
                    NroDocumento = tbNroDocParticipante.Text,
                    Nacionalidad = tbNacionalidadParticipante.Text,
                    NroTelefono = tbTelefonoParticipante.Text,
                    Rol = "Jurado"
                };

                int respuestaId = 0;
                if (tbIdParticipante.Text == "") // es nuevo si no tiene ID
                {
                    respuestaId = ParticipantesConexion.Instancia.guardarParticipante(participante);
                    if (respuestaId > 0) //no es 0, ni -1
                    {
                        tbIdParticipante.Text = respuestaId.ToString();
                    }
                    
                }
                else
                {
                    participante.IDParticipante = int.Parse(tbIdParticipante.Text);
                    respuestaId = ParticipantesConexion.Instancia.actualizarParticipante(participante);                   
                }


                bABMCategoriasPart.Text = "Agregar Categorias";
                bABMCategoriasPart.Visible = true;
                leyendaHabCateg.Visible = false;
                bABMCategoriasPart.Enabled = true;
                labelCatAg.Enabled = true;
                cbCategorias.Enabled = true;
                llenarListaCategorias();

                //Recarga grilla si no dio error
                if (respuestaId <= 0) //es 0 ó -1
                {
                    MessageBox.Show("Ha ocurrido un error, por favor valide los datos ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mostrarParticipantes();
                }

                //Bloqueo usuario para su creacion
                guardarParticipante.Enabled = false;
                tbNombreParticipante.Enabled = false;
                tbApellidoParticipante.Enabled = false;
                tbTipoDocParticipante.Enabled = false;
                tbNroDocParticipante.Enabled = false;
                tbNacionalidadParticipante.Enabled = false;
                tbTelefonoParticipante.Enabled = false;
                cbCategorias.Text = "";
            }
        }

       

        ///////Custom
        public void mostrarParticipantes()
        {
            listaParticipantes.DataSource = null;
            listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
            

        }

        
        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            leyendaHabCateg.Visible = false;
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                tbNombreParticipante.Text = row.Cells[1].Value.ToString();
                tbApellidoParticipante.Text = row.Cells[2].Value.ToString();
                tbTipoDocParticipante.Text = row.Cells[3].Value.ToString();
                tbNroDocParticipante.Text = row.Cells[4].Value.ToString();
                tbNacionalidadParticipante.Text = row.Cells[5].Value.ToString();
                tbTelefonoParticipante.Text = row.Cells[6].Value.ToString();
                //cbCategorias.Text = row.Cells[7].Value.ToString();               
                List < Categorias > categorias = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(int.Parse(row.Cells[0].Value.ToString()));
                listaCategoriasDeJurado.DataSource = categorias;
                if (categorias.Count > 0)
                {
                    bABMCategoriasPart.Visible = true;
                    bABMCategoriasPart.Text = "Modificar Categoria";
                    bABMCategoriasPart.Enabled = true;
                    cbCategorias.Enabled = true;
                    labelCatAg.Enabled = true;
                    llenarListaCategorias();

                } else
                {
                    bABMCategoriasPart.Visible = true;
                    bABMCategoriasPart.Text = "Agregar Categoria";
                    bABMCategoriasPart.Enabled = true;
                    cbCategorias.Enabled = true;
                    labelCatAg.Enabled = true;
                    llenarListaCategorias();
                }
            }
            else
            {
                gbParticipantes.Enabled = false;
                tbNombreParticipante.Text = "";
                tbApellidoParticipante.Text = "";
                tbTipoDocParticipante.Text = "";
                tbNroDocParticipante.Text = "";
                tbNacionalidadParticipante.Text = "";
                tbTelefonoParticipante.Text = "";
                btnActualizarParticipante.Enabled = false;
                guardarParticipante.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void listaParticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnActualizarParticipante.Enabled = true;
            btnEliminarParticipante.Enabled = true;
            
        }

        //Se eliminara el Jurado seleccionado
        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {
            leyendaHabCateg.Visible = false;
            int selectedRowCount = listaParticipantes.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                gbParticipantes.Enabled = true;
                DataGridViewRow row = listaParticipantes.SelectedRows[0];
                tbIdParticipante.Text = row.Cells[0].Value.ToString();
                bool respuesta = ParticipantesConexion.Instancia.eliminarJurado(int.Parse(tbIdParticipante.Text));
                if (respuesta)
                {
                    MessageBox.Show("Jurado eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, por favor intente mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                gbParticipantes.Enabled = false;
                tbNombreParticipante.Text = "";
                tbApellidoParticipante.Text = "";
                tbTipoDocParticipante.Text = "";
                tbNroDocParticipante.Text = "";
                tbNacionalidadParticipante.Text = "";
                tbTelefonoParticipante.Text = "";
                btnActualizarParticipante.Enabled = false;
                guardarParticipante.Enabled = false;
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            listaParticipantes.DataSource = ParticipantesConexion.Instancia.obtenerParticipantes();
            gbParticipantes.Enabled = false;
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            tbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
            btnActualizarParticipante.Enabled = true;
            guardarParticipante.Enabled = false;
        }

        private void listaParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
     


        private void tbIdParticipante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(tdIdCategoria.Text);
            int idParticipante = int.Parse(tbIdParticipante.Text);
            
            JuradoCategoria juradoCategoria = new JuradoCategoria() { IDCategoria = idCategoria , IDJurado = idParticipante };
            
            bool result = JuradoCategoriaConexion.Instancia.guardarJuradoCategoria(juradoCategoria);
            if (result)
            {
                listaCategoriasDeJurado.DataSource = CategoriasConexion.Instancia.obtenerCategoriasPorJurado(idParticipante);
            }
        }

        private void llenarListaCategorias()
        {            
            cbCategorias.DataSource = CategoriasConexion.Instancia.obtenerCategoriaHabilitadasParaCalificar();
            cbCategorias.DisplayMember = "Nombre";
            cbCategorias.ValueMember = "IDCategoria";
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {            
            Categorias categoriaSeleccionada = (Categorias)cbCategorias.SelectedItem;
            tdIdCategoria.Text = categoriaSeleccionada.IDCategoria.ToString();
        }

        private void btnCrearJurado_Click(object sender, EventArgs e)
        {
            gbParticipantes.Enabled = true;
            tbNombreParticipante.Text = "";
            tbApellidoParticipante.Text = "";
            tbTipoDocParticipante.Text = "";
            tbNroDocParticipante.Text = "";
            tbNacionalidadParticipante.Text = "";
            tbTelefonoParticipante.Text = "";
            bABMCategoriasPart.Text = "Agregar Categoria";
            bABMCategoriasPart.Visible = true;
            bABMCategoriasPart.Enabled = false;
            leyendaHabCateg.Visible = true;
            guardarParticipante.Enabled = true;
            labelCatAg.Enabled = false;
            cbCategorias.Enabled = false;
            listaCategoriasDeJurado.DataSource = null;
            tbIdParticipante.Text = "";

            tbNombreParticipante.Enabled = true;
            tbApellidoParticipante.Enabled = true;
            tbTipoDocParticipante.Enabled = true; ;
            tbNroDocParticipante.Enabled = true;
            tbNacionalidadParticipante.Enabled = true;
            tbTelefonoParticipante.Enabled = true;

        }

    }
    
}
