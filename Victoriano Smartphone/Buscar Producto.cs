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
    public partial class Buscar_Producto : Form
    {
        //Variable utilizada para realizar Comandos SQlite, enlazada a la clase publica operacion
        operacion oper = new operacion();
        DataTable dt = new DataTable(); //Variable para resultados con consultas

        //Variables necesarias para recibir datos desde otro formulario
        public static string busqueda = "";


        public Buscar_Producto()
        {
            InitializeComponent();
        }

        private void Buscar_Producto_Load(object sender, EventArgs e)
        {

            //Al inicio del formulario para Buscar los productos escritos o mostrar todo
            dt = oper.ExtraeData("SELECT * FROM producto WHERE nombre LIKE '%" + busqueda + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;
            if (dataGridView1.RowCount > 0 && !String.IsNullOrEmpty(busqueda))
            {
                dataGridView1.Select();
            }
            else { tbnombre.Select(); }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            SeleccionarProducto();

        }

        public void SeleccionarProducto()
        {
            try
            {
                facturar.idproducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                EditarFactura.idproducto = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                facturar.probuscar = true;
                EditarFactura.probuscar = true;
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un producto", "Seleccionar");

            }


        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            SeleccionarProducto();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dt = oper.ExtraeData("SELECT * FROM producto;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        public void RealizarBusqueda()
        {

            dt = oper.ExtraeData("SELECT * FROM producto WHERE nombre LIKE '%" + tbnombre.Text + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Convert.ToInt32(e.KeyCode) == 13)
            {

                SeleccionarProducto();

            }


        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            
            RealizarBusqueda();
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                dataGridView1.Select();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new producto();
            f.Show();
        }
    }
}
