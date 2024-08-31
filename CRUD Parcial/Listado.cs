using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Parcial
{
    public partial class Listado : Form
    {
        //Constructor de la clase Listado, inicializa los componentes del formulario.
        public Listado()
        {
            InitializeComponent();
        }

        //Evento que se dispara al hacer clic en el botón de guardar del BindingNavigator
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Valida los controles del formulario para asegurarse de que no haya errores de entrada, finaliza la edición del registro y guarda los cambios en la base de datos
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        //Evento que se ejecuta cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga los datos de la tabla 'Customers' del DataSet 'northwindDataSet'
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }
    }
}
