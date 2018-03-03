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
    public partial class ConsultaSuplidores : Form
    {
        public static bool mantenimiento = false;
        public static bool mantenimiento2 = false;

        public ConsultaSuplidores()
        {
            InitializeComponent();
        }

        private void ConsultaSuplidores_Load(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM suplidores;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].ReadOnly = true;

            if (mantenimiento)
            {
                Form f = new suplidores();
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

        private void btbuscar_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            int maxid;
            //Este boton hace que sea posible guardar los datos que se encuentran en el datagridbiew
            string id, nombre, tipo, telefono1, telefono2, direccion;

            maxid = dataGridView1.RowCount;
            maxid--;

            for (int i = 0; i < maxid; i++)
            {
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                nombre = dataGridView1.Rows[i].Cells[1].Value.ToString();
                tipo = dataGridView1.Rows[i].Cells[2].Value.ToString();
                telefono1 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                telefono2 = dataGridView1.Rows[i].Cells[4].Value.ToString();
                direccion = dataGridView1.Rows[i].Cells[5].Value.ToString();

                oper.Sqlsinconsulta("UPDATE suplidores SET nombre = '" + nombre + "', tipo = '" + tipo + "', telefono1 = '" + telefono1 + "', telefono2 = '" + telefono2 + "', direccion = '" + direccion + "' WHERE id = '" + id + "';");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM suplidores;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            suplidores.modificar = true;

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    suplidores.idmodificar = fila.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }

            }
            Form f = new suplidores();
            f.ShowDialog();

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM suplidores;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

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

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {

            RealizarBusqueda();

            if (Convert.ToInt32(e.KeyCode) == 13)
            {

                dataGridView1.Select();

            }

        }

        void RealizarBusqueda()
        {

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM suplidores WHERE nombre LIKE '%" + tbnombre.Text + "%';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }
    }
}
