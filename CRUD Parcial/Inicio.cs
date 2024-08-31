using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Parcial
{
    //Representa el formulario de inicio de la aplicación.
    public partial class Inicio : Form
    {
        //Inicializa los componentes visuales del formulario.
        public Inicio()
        {
            InitializeComponent();
        }

        //Evento que se dispara al hacer clic en el botón de gestión (bntGestion)
        private void bntGestion_Click(object sender, EventArgs e)
        {
            //Crea una nueva instancia del formulario Conexion
            Conexion gestion = new Conexion();
            //Muestra el formulario de gestión como un cuadro de diálogo modal
            gestion.ShowDialog();
        }

        //Evento que se dispara al hacer clic en el botón de listado (btnListado)
        private void btnListado_Click(object sender, EventArgs e)
        {
            //Crea una nueva instancia del formulario Listado
            Listado listado = new Listado();
            //Muestra el formulario de listado como un cuadro de diálogo modal
            listado.ShowDialog();
        }
    }
}
