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
    public partial class Conexion : Form
    {
        // Constructor de la clase Conexion.
        // Inicializa los componentes del formulario.
        public Conexion()
        {
            InitializeComponent();
        }

        // Evento que se dispara al hacer clic en el botón de guardar en el BindingNavigator (fue eliminado)
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        //Evento que se dispara al hacer clic en el botón de guardar (Guardar)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }

        //Evento que se ejecuta cuando el formulario se carga
        private void Conexion_Load(object sender, EventArgs e)
        {
            //Carga los datos de la tabla 'Customers' del DataSet 'northwindDataSet'
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        //Evento que se dispara al hacer clic en 'Añadir nuevo'
        private void button1_Click(object sender, EventArgs e)
        {
            //Llama al BindingSource 'customersBindingSource' y agrega un nuevo registro
            customersBindingSource.AddNew();
        }

        //Evento para manejar la entrada de teclas en un cuadro de texto (no implementado)
        private void CajaTextoID_KeyPress(object sender, EventArgs e)
        {

        }

        //Evento que se ejecuta cuando se presiona una tecla en el cuadro de texto 'CajaTextoID'
        private void CajaTextoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Si se presiona la tecla Enter (char 13)
                if (e.KeyChar == (char)13)
                {
                    //Busca el índice del registro en el BindingSource basado en el 'CustomerID' ingresado en CajaTextoID
                    var index = customersBindingSource.Find("CustomerID", CajaTextoID);

                    // Si el índice es válido (encontró un registro).
                    if (index > -1)
                    {
                        // Establece la posición del BindingSource al registro encontrado
                        customersBindingSource.Position = index;
                        return;
                    }
                    else
                    {
                        // Muestra un mensaje si no se encuentra el elemento.
                        MessageBox.Show("Elemento no encontrado");
                    }
                };
            }
        }


    }
}
