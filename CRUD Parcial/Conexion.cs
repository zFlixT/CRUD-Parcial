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
        public Conexion()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Llamamos al customerBindingSource y el metodo que queremos ejecutar
            customersBindingSource.AddNew();
        }

        private void KeyPressEventArgs(object sender, KeyPressEventArgs e)
        {

        }

        private void CajaTextoID_KeyPress(object sender, EventArgs e)
        {

        }

        private void CajaTextoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar == (char)13)
                {
                    var index = customersBindingSource.Find("CustomerID", CajaTextoID);
                    if (index > -1)
                    {
                        customersBindingSource.Position = index;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Elemento no encontrado");
                    }
                };
            }
        }
    }
}
