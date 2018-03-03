using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;

namespace Victoriano_Smartphone
{
    public partial class producto : Form
    {
        bool nuevo = false;
        public static bool modificar = false;
        public static string idmodificar = "1";
        public static string ids = "0";
        public static string tester = ""; //Para Volar un valor si se encontró un producto nulo.

        public producto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(tbpcodigo.Text) || !string.IsNullOrWhiteSpace(tbpcodigo.Text))
                {
                    operacion oper = new operacion();
                    string id, nombre, costo, precio, existencia, suplidor;
                    id = tbpcodigo.Text;
                    nombre = tbpnombre.Text; nombre = nombre.Trim(new Char[] { ' ', '*', '.' }); //Limpiar Nombre de carácteres estraños
                    costo = tbpcosto.Text; 
                    precio = tbpprecio.Text;
                    existencia = tbpexistencia.Text;
                    suplidor = tbpsuplidor.Text;

                    if (nuevo)
                    {
                        oper.Sqlsinconsulta("INSERT INTO producto(nombre, costo, precio, existencia, suplidor) VALUES('" + nombre + "', '" + costo + "', '" + precio + "', '" + existencia + "', '" + suplidor + "');");
                        MessageBox.Show("Se agregó el Producto", "Nuevo");
                        nuevo = false;
                    }
                    else
                    {
                        oper.Sqlsinconsulta("UPDATE producto SET nombre = '" + nombre + "', costo = '" + costo + "', precio = '" + precio + "', existencia = '" + existencia + "', suplidor = '" + suplidor + "' WHERE id = '" + id + "';");
                        MessageBox.Show("Se Modificó el Producto", "Guardar");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos", "Guardar");
                }



            }

        }

        private void producto_Load(object sender, EventArgs e)
        {
            operacion oper = new operacion();

            //Para Cargar los Suplidores
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT nombre FROM suplidores;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();
            tbpsuplidor.Text = "";

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbpsuplidor.Items.Add(fila.Cells[0].Value.ToString());
                }
                catch (Exception)
                {

                }
            }


            if (modificar)
            {

                string ids = idmodificar;

                dt = oper.ExtraeData("SELECT * FROM producto WHERE id = '" + ids + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbpcodigo.Text = fila.Cells[0].Value.ToString();
                        tbpnombre.Text = fila.Cells[1].Value.ToString();
                        tbpcosto.Text = fila.Cells[2].Value.ToString();
                        tbpprecio.Text = fila.Cells[3].Value.ToString();
                        tbpexistencia.Text = fila.Cells[4].Value.ToString();
                        tbpsuplidor.Text = fila.Cells[5].Value.ToString();
                    }
                    catch (Exception)
                    {

                    }

                }
                modificar = false;

            }
            else
            {

                string lsid = "1";
                dt = oper.ExtraeData("SELECT MAX(id)FROM producto;");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        lsid = fila.Cells[0].Value.ToString();
                    }

                    catch (Exception)
                    {
                    }
                }

                dt = oper.ExtraeData("SELECT * FROM producto WHERE id = '" + lsid + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbpcodigo.Text = fila.Cells[0].Value.ToString();
                        tbpnombre.Text = fila.Cells[1].Value.ToString();
                        tbpcosto.Text = fila.Cells[2].Value.ToString();
                        tbpprecio.Text = fila.Cells[3].Value.ToString();
                        tbpexistencia.Text = fila.Cells[4].Value.ToString();
                        tbpsuplidor.Text = fila.Cells[5].Value.ToString();
                    }
                    catch (Exception)
                    {

                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lid;
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'producto';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbpcodigo.Text = fila.Cells[0].Value.ToString();
                    lid = Convert.ToInt32(tbpcodigo.Text);
                    lid++;
                    tbpcodigo.Text = Convert.ToString(lid);
                }
                catch (Exception)
                {
                }

            }

            tbpnombre.Text = "";
            tbpcosto.Text = "";
            tbpprecio.Text = "";
            tbpexistencia.Text = "";

            //Para Cargar los Suplidores
            dt = oper.ExtraeData("SELECT nombre FROM suplidores;");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();
            tbpsuplidor.Items.Clear();
            tbpsuplidor.Text = "";

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbpsuplidor.Items.Add(fila.Cells[0].Value.ToString());
                }
                catch (Exception)
                {

                }
            }

            nuevo = true;

        }

        private void btpsearch_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();
        }

        private void btpdelete_Click(object sender, EventArgs e)
        {

            DialogResult boton = MessageBox.Show("Seguro que desea eliminar este producto", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boton == DialogResult.No)
                return;
            else


            if (!string.IsNullOrEmpty(tbpcodigo.Text) || !string.IsNullOrWhiteSpace(tbpcodigo.Text))
            {
                operacion oper = new operacion();
                string id;
                id = tbpcodigo.Text;

                oper.Sqlsinconsulta("DELETE FROM producto WHERE id = '" + id + "'");
                MessageBox.Show("Se eliminó el Producto", "Eliminar");

                tbpnombre.Text = "";
                tbpcosto.Text = "";
                tbpprecio.Text = "";
                tbpexistencia.Text = "";
                tbpsuplidor.Text = "";

                int lid;
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'producto';");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbpcodigo.Text = fila.Cells[0].Value.ToString();
                        lid = Convert.ToInt32(tbpcodigo.Text);
                        lid++;
                        tbpcodigo.Text = Convert.ToString(lid);
                    }
                    catch (Exception)
                    {
                    }

                }
                nuevo = true;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún producto para eliminar", "Eliminar");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (ConsultaProducto.mantenimiento)
            {
                ConsultaProducto.mantenimiento2 = true;
            }
            else { }

            this.Close();

        }

        private void tbpsearchcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) { RealizarBusqueda(); } else { }

        }

        public void RealizarBusqueda(){

            ids = tbpsearchcode.Text;
            tbpsearchcode.Text = "";

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM producto WHERE id = '" + ids + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbpcodigo.Text = fila.Cells[0].Value.ToString();
                    tbpnombre.Text = fila.Cells[1].Value.ToString();
                    tbpcosto.Text = fila.Cells[2].Value.ToString();
                    tbpprecio.Text = fila.Cells[3].Value.ToString();
                    tbpexistencia.Text = fila.Cells[4].Value.ToString();
                    tbpsuplidor.Text = fila.Cells[5].Value.ToString();
                }
                catch (Exception)
                {

                }

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            tester = tbpcodigo.Text;

            // Mostrar el Producto Anterior
            ids = (Convert.ToInt32(tbpcodigo.Text) - 1).ToString();
            RealizarBusqueda();

            forimaginario:
            if (tbpcodigo.Text == tester)
            {
                ids = (Convert.ToInt32(ids) - 1).ToString();
                RealizarBusqueda();
                goto forimaginario;
            }
            else { }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            tester = tbpcodigo.Text;

            // Mostrar el Producto Siguiente
            ids = (Convert.ToInt32(tbpcodigo.Text) + 1).ToString();
            RealizarBusqueda();

            forimaginario:
            if (tbpcodigo.Text == tester)
            {
                ids = (Convert.ToInt32(ids) + 1).ToString();
                RealizarBusqueda();
                goto forimaginario;
            }
            else { }

        }

        private void tbpcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else { }
        }
    }
}
