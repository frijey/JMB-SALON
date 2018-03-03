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
    public partial class ConsultaProducto : Form
    {
        public static bool mantenimiento = false;
        public static bool mantenimiento2 = false;

        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            int maxid;
            //Este boton hace que sea posible guardar los datos que se encuentran en datagridbiew
            string id, nombre, costo, precio, existencia, suplidor;

            maxid = dataGridView1.RowCount;

            for (int i = 0; i < maxid; i++)
            {
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[i].Cells[1].Value.ToString();
                costo = dataGridView1.Rows[i].Cells[2].Value.ToString();
                precio = dataGridView1.Rows[i].Cells[3].Value.ToString();
                existencia = dataGridView1.Rows[i].Cells[4].Value.ToString();
                suplidor = dataGridView1.Rows[i].Cells[5].Value.ToString();

                //MessageBox.Show(id + " " + nombre + " " + apellidos + " " + cedula + " " + telefono + " " + direccion);
                oper.Sqlsinconsulta("UPDATE producto SET nombre = '" + nombre + "', costo = '" + costo + "', precio = '" + precio + "', existencia = '" + existencia + "', suplidor = '" + suplidor + "' WHERE id = '" + id + "';");
            }

            btnguardar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM producto;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            RealizarModificacion();

        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM producto;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

            if (mantenimiento)
            {
                Form f = new producto();
                this.Hide();
                f.ShowDialog();
                if (!mantenimiento2)
                {
                    this.Close();
                }
                else { }
                mantenimiento = false;
                mantenimiento2 = false;
            }
            else { }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnguardar.Enabled = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Las celdas modificadas no tienen el formato correcto", "Editar");
            SendKeys.Send("{ESC}");
        }

        public void RealizarBusqueda()
        {

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM producto WHERE nombre LIKE '%" + tbnombre.Text + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                RealizarModificacion();
            }

        }

        public void RealizarModificacion()
        {

            producto.modificar = true;

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    producto.idmodificar = fila.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }

            }
            Form f = new producto();
            f.ShowDialog();
            RealizarBusqueda();

        }

        private void ConsultaProducto_KeyDown(object sender, KeyEventArgs e)
        {

            this.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            RealizarModificacion();

        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {

            RealizarBusqueda();

            if (Convert.ToInt32(e.KeyCode) == 13)
            {

                dataGridView1.Select();

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnguardar.Enabled = true;
        }
    }
}
