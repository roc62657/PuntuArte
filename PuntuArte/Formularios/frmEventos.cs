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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modelo.EventoModel evento = new Modelo.EventoModel()
            //{
            //    Nombre = tbEventoNombre.Text,
            //    Fecha = DateTime.Today.ToString()
            //};

            //Logica.Evento.NuevoEvento(evento);

        }


        private void Evento_Load(object sender, EventArgs e)
        {
            //List<Modelo.EventoModel> lEvento = Logica.Evento.GetAll().ToList();

            ////foreach (Preset _id in col.FindAll())
            ////{
            ////    list.Add(_id);
            ////}

            //dgvEventos.DataSource = lEvento;
        }
    }
}
