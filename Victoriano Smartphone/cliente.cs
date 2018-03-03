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
    public partial class cliente : Form
    {
        bool nuevo = false;
        public static bool modificar = false;
        public static string idmodificar = "1";

        public cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(tbccodigo.Text) || !string.IsNullOrWhiteSpace(tbccodigo.Text))
                {
                    operacion oper = new operacion();
                    string id, nombre, apellidos, cedula, telefono, direccion;
                    id = tbccodigo.Text;
                    nombre = tbcnombre.Text; nombre= nombre.Trim(new Char[] { ' ', '*', '.' }); //Limpiar el nombre de puntos y carácteres raros
                    apellidos = tbcapellidos.Text; apellidos = apellidos.Trim(new Char[] { ' ', '*', '.' });
                    cedula = tbccedula.Text; cedula = cedula.Trim(new Char[] { ' ', '*', '.' });
                    telefono = tbctelefono.Text; telefono = telefono.Trim(new Char[] { ' ', '*', '.' });
                    direccion = tbcdireccion.Text; 

                    if (nuevo)
                    {
                        oper.Sqlsinconsulta("INSERT INTO cliente(nombre, apellidos, cedula, telefono, direccion) VALUES('" + nombre + "', '" + apellidos + "', '" + cedula + "', '" + telefono + "', '" + direccion + "');");
                        MessageBox.Show("Se agregó el Cliente", "Cliente");
                        nuevo = false;
                    }
                    else
                    {
                        oper.Sqlsinconsulta("UPDATE cliente SET nombre = '" + nombre + "', apellidos = '" + apellidos + "', cedula = '" + cedula + "', telefono = '" + telefono + "', direccion = '" + direccion + "' WHERE id = '" + id + "';");
                        MessageBox.Show("Se Modificó el Cliente", "Cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene por lo menos los campos de Nombre y Teléfono", "Guardar");
                }



            }
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            if (modificar)
            {

                string ids = idmodificar;

                operacion oper = new operacion();
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT * FROM cliente WHERE id = '" + ids + "'");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.SelectAll();

                foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                {
                    try
                    {
                        tbccodigo.Text = fila.Cells[0].Value.ToString();
                        tbcnombre.Text = fila.Cells[1].Value.ToString();
                        tbcapellidos.Text = fila.Cells[2].Value.ToString();
                        tbccedula.Text = fila.Cells[3].Value.ToString();
                        tbctelefono.Text = fila.Cells[4].Value.ToString();
                        tbcdireccion.Text = fila.Cells[5].Value.ToString();
                    }
                    catch (Exception)
                    {

                    }

                }
                modificar = false;

            }
            else { 

            string lsid = "1";
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT MAX(id)FROM cliente;");
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

            dt = oper.ExtraeData("SELECT * FROM cliente WHERE id = '" + lsid + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbccodigo.Text = fila.Cells[0].Value.ToString();
                    tbcnombre.Text = fila.Cells[1].Value.ToString();
                    tbcapellidos.Text = fila.Cells[2].Value.ToString();
                    tbccedula.Text = fila.Cells[3].Value.ToString();
                    tbctelefono.Text = fila.Cells[4].Value.ToString();
                    tbcdireccion.Text = fila.Cells[5].Value.ToString();
                }
                catch (Exception)
                {

                }

            }
         }

        }

        private void btcdelete_Click(object sender, EventArgs e)
        {

            DialogResult boton = MessageBox.Show("Seguro que desea eliminar el Cliente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boton == DialogResult.No)
                return;
            else

                        if (!string.IsNullOrEmpty(tbccodigo.Text) || !string.IsNullOrWhiteSpace(tbccodigo.Text))
            {
                operacion oper = new operacion();
                string id;
                id = tbccodigo.Text;
                
                oper.Sqlsinconsulta("DELETE FROM cliente WHERE id = '" + id + "'");
                MessageBox.Show("Se eliminó el Cliente", "Eliminar");

                tbcnombre.Text = "";
                tbcapellidos.Text = "";
                tbccedula.Text = "";
                tbctelefono.Text = "";
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
                MessageBox.Show("No ha seleccionado ningún cliente para eliminar", "Eliminar");
            }

        }

        private void btcnew_Click(object sender, EventArgs e)
        {
            int lid;
            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'cliente';");
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
            tbcapellidos.Text = "";
            tbccedula.Text = "";
            tbctelefono.Text = "";
            tbcdireccion.Text = "";

            nuevo = true;

        }

        private void btcsearch_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ConsultaCliente.mantenimiento)
            {
                ConsultaCliente.mantenimiento2 = true;
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
            dt = oper.ExtraeData("SELECT * FROM cliente WHERE id = '" + ids + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    tbccodigo.Text = fila.Cells[0].Value.ToString();
                    tbcnombre.Text = fila.Cells[1].Value.ToString();
                    tbcapellidos.Text = fila.Cells[2].Value.ToString();
                    tbccedula.Text = fila.Cells[3].Value.ToString();
                    tbctelefono.Text = fila.Cells[4].Value.ToString();
                    tbcdireccion.Text = fila.Cells[5].Value.ToString();
                }
                catch (Exception)
                {

                }

            }

        }
    }
}
