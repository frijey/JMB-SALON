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
    public partial class suplidores : Form
    {
        bool nuevo = false;
        public static bool modificar = false;
        public static string idmodificar = "1";


        public suplidores()
        {
            InitializeComponent();
        }

        private void suplidores_Load(object sender, EventArgs e)
        {
            
            if (modificar)
            {

                string ids = idmodificar;

                operacion oper = new operacion();
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT * FROM suplidores WHERE id = '" + ids + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbccodigo.Text = fila.Cells[0].Value.ToString();
                        tbcnombre.Text = fila.Cells[1].Value.ToString();
                        tbstipo.Text = fila.Cells[2].Value.ToString();
                        tbstel1.Text = fila.Cells[3].Value.ToString();
                        tbstel2.Text = fila.Cells[4].Value.ToString();
                        tbcdireccion.Text = fila.Cells[5].Value.ToString();
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
                operacion oper = new operacion();
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT MAX(id)FROM suplidores;");
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

                dt = oper.ExtraeData("SELECT * FROM suplidores WHERE id = '" + lsid + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbccodigo.Text = fila.Cells[0].Value.ToString();
                        tbcnombre.Text = fila.Cells[1].Value.ToString();
                        tbstipo.Text = fila.Cells[2].Value.ToString();
                        tbstel1.Text = fila.Cells[3].Value.ToString();
                        tbstel2.Text = fila.Cells[4].Value.ToString();
                        tbcdireccion.Text = fila.Cells[5].Value.ToString();
                    }
                    catch (Exception)
                    {

                    }

                }
            }

        }

        private void btcsave_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(tbccodigo.Text) || !string.IsNullOrWhiteSpace(tbccodigo.Text))
                {
                    operacion oper = new operacion();
                    string id, nombre, tipo, telefono1, telefono2, direccion;
                    id = tbccodigo.Text;
                    nombre = tbcnombre.Text;
                    tipo = tbstipo.Text;
                    telefono1 = tbstel1.Text;
                    telefono2 = tbstel2.Text;
                    direccion = tbcdireccion.Text;

                    if (nuevo)
                    {
                        oper.Sqlsinconsulta("INSERT INTO suplidores (nombre, tipo, telefono1, telefono2, direccion) VALUES('" + nombre + "', '" + tipo + "', '" + telefono1 + "', '" + telefono2 + "', '" + direccion + "');");
                        MessageBox.Show("Se agregó el Suplidor", "Suplidor");
                        nuevo = false;
                    }
                    else
                    {
                        oper.Sqlsinconsulta("UPDATE suplidores SET nombre = '" + nombre + "', tipo = '" + tipo + "', telefono1 = '" + telefono1 + "', telefono2 = '" + telefono2 + "', direccion = '" + direccion + "' WHERE id = '" + id + "';");
                        MessageBox.Show("Se Modificó el Suplidor", "Suplidor");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene por lo menos los campos de Nombre y Teléfono 1", "Guardar");
                }
            }
        }

        private void btcsearch_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void btcdelete_Click(object sender, EventArgs e)
        {


            DialogResult boton = MessageBox.Show("Seguro que desea eliminar el Suplidor", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boton == DialogResult.No)
                return;
            else

                        if (!string.IsNullOrEmpty(tbccodigo.Text) || !string.IsNullOrWhiteSpace(tbccodigo.Text))
            {
                operacion oper = new operacion();
                string id;
                id = tbccodigo.Text;

                oper.Sqlsinconsulta("DELETE FROM suplidores WHERE id = '" + id + "'");
                MessageBox.Show("Se eliminó el Suplidor", "Eliminar");

                tbcnombre.Text = "";
                tbstipo.Text = "";
                tbstel1.Text = "";
                tbstel1.Text = "";
                tbcdireccion.Text = "";

                int lid;
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT SEQ FROM sqlite_sequence;");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbccodigo.Text = fila.Cells[0].Value.ToString();
                        lid = Convert.ToInt32(tbccodigo.Text);
                        lid++;
                        tbccodigo.Text = Convert.ToString(lid);
                    }
                    catch (Exception)
                    {
                    }

                }
                nuevo = true;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún suplidor para eliminar", "Eliminar");
            }

        }

        private void btcnew_Click(object sender, EventArgs e)
        {

            int lid;
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'suplidores';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbccodigo.Text = fila.Cells[0].Value.ToString();
                    lid = Convert.ToInt32(tbccodigo.Text);
                    lid++;
                    tbccodigo.Text = Convert.ToString(lid);
                }
                catch (Exception)
                {
                }

            }

            tbcnombre.Text = "";
            tbstipo.Text = "";
            tbstel1.Text = "";
            tbstel2.Text = "";
            tbcdireccion.Text = "";

            nuevo = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ConsultaSuplidores.mantenimiento)
            {
                ConsultaSuplidores.mantenimiento2 = true;
            }
            else { }

            this.Close();
        }

        private void tbccodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
            else { }
        }

        private void tbcsearchcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { RealizarBusqueda(); } else { }
        }

        void RealizarBusqueda()
        {

            string ids = tbcsearchcode.Text;
            tbcsearchcode.Text = "";

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT * FROM suplidores WHERE id = '" + ids + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbccodigo.Text = fila.Cells[0].Value.ToString();
                    tbcnombre.Text = fila.Cells[1].Value.ToString();
                    tbstipo.Text = fila.Cells[2].Value.ToString();
                    tbstel1.Text = fila.Cells[3].Value.ToString();
                    tbstel2.Text = fila.Cells[4].Value.ToString();
                    tbcdireccion.Text = fila.Cells[5].Value.ToString();
                }
                catch (Exception)
                {

                }

            }

        }
    }
}
