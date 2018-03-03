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
    public partial class ConsultarFacturas : Form
    {
        operacion oper = new operacion();
        DataTable dt = new DataTable();
        string fechaf = "";
        string fechafrom = "2017-01-01";
        string fechato = "2017-01-01";

        //Para Abrir la Factura Seleccionada
        public static string idfacturaeditar = "0";

        //Para la fecha formateada
        string mes = "", dia = "", año = "";

        public ConsultarFacturas()
        {
            InitializeComponent();
        }

        private void ConsultarFacturas_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {

            BuscarPorCódigo();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            MostrarTodo();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            GeneradasHoy();

        }

        private void tbcodigof_KeyUp(object sender, KeyEventArgs e)
        {

            //Si se presiona enter en el cuadro de texto de "Buscar por Código"
            if (e.KeyCode == Keys.Enter) { BuscarPorCódigo(); } else { }

            //Si se presiona ESCAPE en el cuadro de texto de "Buscar por Código" = Salir del formulario
            if (e.KeyCode == Keys.Escape) { this.Close(); } else { }

        }

        private void btbuscar1_Click(object sender, EventArgs e)
        {

            BuscarPorRangoDeFecha();

        }

        public void RellenarTablas()
        {

            int maxrow = dataGridView1update.RowCount;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < maxrow; i++)
            {

                try
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dataGridView1update.Rows[i].Cells[0].Value;
                    dataGridView1.Rows[i].Cells[1].Value = dataGridView1update.Rows[i].Cells[1].Value;
                    dataGridView1.Rows[i].Cells[2].Value = dataGridView1update.Rows[i].Cells[2].Value;
                    dataGridView1.Rows[i].Cells[3].Value = dataGridView1update.Rows[i].Cells[3].Value;
                    dataGridView1.Rows[i].Cells[4].Value = dataGridView1update.Rows[i].Cells[4].Value;

                }
                catch (Exception)
                {

                    MessageBox.Show("Error al Cargar los datos desde la base de datos", "Error");

                }

            }

        }

        void GeneradasHoy()
        {

            //Mostrar facturas generadas el día de hoy
            //Para formatear la fecha
            if (DateTime.Now.Day < 10) { dia = "0" + DateTime.Now.Day.ToString(); } else { dia = DateTime.Now.Day.ToString(); }
            if (DateTime.Now.Month < 10) { mes = "0" + DateTime.Now.Month.ToString(); } else { mes = DateTime.Now.Month.ToString(); }
            año = DateTime.Now.Year.ToString();

            fechaf = año + "-" + mes + "-" + dia;

            dt = oper.ExtraeData("SELECT * from factura WHERE fecha = '" + fechaf + "'");
            dataGridView1update.DataSource = dt;
            dataGridView1update.Refresh();
            RellenarTablas();


        }

        void MostrarTodo()
        {

            //Mostrar todas las facturas generadas
            dt = oper.ExtraeData("SELECT * FROM factura;");
            dataGridView1update.DataSource = dt;
            dataGridView1update.Refresh();
            RellenarTablas();

        }

        private void dtfechafrom_KeyUp(object sender, KeyEventArgs e)
        {

            //Si se presiona enter en el DateTimePicker del "desde" side "Buscar por rango"
            if (e.KeyCode == Keys.Enter) { BuscarPorRangoDeFecha(); dtfechato.Focus(); } else { }

        }

        private void dtfechato_KeyUp(object sender, KeyEventArgs e)
        {

            //Si se presiona enter en el DateTimePicker del "hasta" side "Buscar por rango"
            if (e.KeyCode == Keys.Enter) { BuscarPorRangoDeFecha(); dtfechafrom.Focus(); } else { }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
            return;

            try
            {
                idfacturaeditar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Form f = new EditarFactura();
                f.Show();
            }
            catch (Exception)
            {

            }

        }

        void BuscarPorCódigo()
        {

            string idfactura = tbcodigof.Text;
            dt = oper.ExtraeData("SELECT * FROM factura WHERE id = '" + idfactura + "';");
            dataGridView1update.DataSource = dt;
            dataGridView1update.Refresh();
            RellenarTablas();

            return;
            try
            {
                idfacturaeditar = idfactura;
                Form f = new EditarFactura();
                f.Show();
            }
            catch (Exception)
            {

            }

        }

        void BuscarPorRangoDeFecha()
        {

            //Para formatear las fechas
            if (dtfechafrom.Value.Day < 10) { dia = "0" + dtfechafrom.Value.Day.ToString(); } else { dia = dtfechafrom.Value.Day.ToString(); }
            if (dtfechafrom.Value.Month < 10) { mes = "0" + dtfechafrom.Value.Month.ToString(); } else { mes = dtfechafrom.Value.Month.ToString(); }
            año = dtfechafrom.Value.Year.ToString();

            //Fecha Desde
            fechafrom = año + "-" + mes + "-" + dia;

            if (dtfechato.Value.Day < 10) { dia = "0" + dtfechato.Value.Day.ToString(); } else { dia = dtfechato.Value.Day.ToString(); }
            if (dtfechato.Value.Month < 10) { mes = "0" + dtfechato.Value.Month.ToString(); } else { mes = dtfechato.Value.Month.ToString(); }
            año = dtfechafrom.Value.Year.ToString();

            //Fecha Desde
            fechato = año + "-" + mes + "-" + dia;



            dt = oper.ExtraeData("SELECT * from factura WHERE fecha BETWEEN '" + fechafrom + "' AND '" + fechato + "';");
            dataGridView1update.DataSource = dt;
            dataGridView1update.Refresh();
            RellenarTablas();

        }
    }
}
