using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Victoriano_Smartphone
{
    public partial class BuscarCliente : Form
    {
        operacion oper = new operacion();
        DataTable dt = new DataTable();

        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {

            MostrarTodo();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SeleccionarCliente();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            SeleccionarCliente();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form f = new cliente();
            f.ShowDialog();
            MostrarTodo();

        }

        public void MostrarTodo()
        {
            // Mostrar todo el contenido de la tabla cliente
            dt = oper.ExtraeData("SELECT id, nombre, apellidos, cedula FROM cliente;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        public void SeleccionarCliente()
        {

            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Solo puede seleccionar un Cliente a la vez", "Seleccionar");
                }
                else
                {
                    facturar.idcliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    facturar.nombrecliente = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " "
                       + dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    EditarFactura.idcliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    EditarFactura.nombrecliente = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " "
                       + dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un cliente", "Seleccionar");
            }

        }


    }
}
