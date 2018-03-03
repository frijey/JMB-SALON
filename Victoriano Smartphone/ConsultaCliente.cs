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
    public partial class ConsultaCliente : Form
    {
        public static bool mantenimiento = false;
        public static bool mantenimiento2 = false;

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        public void ConsultaCliente_Load(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM cliente;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

            if (mantenimiento)
            {
                Form f = new cliente();
                this.Hide();
                f.ShowDialog();
                if (!mantenimiento2)
                {
                    this.Close();
                }
                else
                {
                    dt = oper.ExtraeData("SELECT * FROM cliente;");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    dataGridView1.Columns[0].ReadOnly = true;
                }
                mantenimiento = false;
                mantenimiento2 = false;
            }
            else { }

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            RealizarModificacion();

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM cliente;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            int maxid;
            //Este boton hace que sea posible guardar los datos que se encuentran en datagridview
            string id, nombre, apellidos, cedula, telefono, direccion;

            maxid = dataGridView1.RowCount;
            maxid--;

            for (int i = 0; i < maxid; i++)
            {
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[i].Cells[1].Value.ToString();
                apellidos = dataGridView1.Rows[i].Cells[2].Value.ToString();
                cedula = dataGridView1.Rows[i].Cells[3].Value.ToString();
                telefono = dataGridView1.Rows[i].Cells[4].Value.ToString();
                direccion = dataGridView1.Rows[i].Cells[5].Value.ToString();

                //MessageBox.Show(id + " " + nombre + " " + apellidos + " " + cedula + " " + telefono + " " + direccion);
                oper.Sqlsinconsulta("UPDATE cliente SET nombre = '" + nombre + "', apellidos = '" + apellidos + "', cedula = '" + cedula + "', telefono = '" + telefono + "', direccion = '" + direccion + "' WHERE id = '" + id + "';");
            }
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
            dt = oper.ExtraeData("SELECT * FROM cliente WHERE nombre LIKE '%" + tbnombre.Text + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        public void RealizarModificacion()
        {

            cliente.modificar = true;

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    cliente.idmodificar = fila.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }

            }
            Form f = new cliente();
            f.ShowDialog();

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM cliente WHERE nombre LIKE '%" + tbnombre.Text + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            RealizarModificacion();

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                RealizarModificacion();
            }

        }

        private void ConsultaCliente_KeyDown(object sender, KeyEventArgs e)
        {

            this.Close();

        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {

            //Si se presiona ESCAPE en el cuadro de texto de "Buscar por Código" = Salir del formulario
            if (e.KeyCode == Keys.Escape) { this.Close(); } else { }

            RealizarBusqueda();

            if (Convert.ToInt32(e.KeyCode) == 13)
            {

                dataGridView1.Select();

            }

        }
    }
}
