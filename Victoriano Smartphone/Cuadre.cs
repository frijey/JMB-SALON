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
    public partial class Cuadre : Form
    {

        operacion oper = new operacion();
        DataTable dt = new DataTable();
        string fechaf = "";

        //Para Abrir la Factura Seleccionada
        public static string idfacturaeditar = "0";

        //Para la fecha formateada
        string mes = "", dia = "", año = "";

        public Cuadre()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneradasHoy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Contarmoneda();
            f.ShowDialog();
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

        private void btbuscar1_Click(object sender, EventArgs e)
        {
            BuscarPorFecha();
        }

        public void RellenarTablas()
        {

            double total = 0f;
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
                    total += Convert.ToDouble(dataGridView1update.Rows[i].Cells[4].Value);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al Cargar los datos desde la base de datos", "Error");

                }

            }
            tbtotal.Text = "RD$ " + total.ToString();

        }

        void BuscarPorFecha()
        {

            //Para formatear las fechas
            if (dtfechafrom.Value.Day < 10) { dia = "0" + dtfechafrom.Value.Day.ToString(); } else { dia = dtfechafrom.Value.Day.ToString(); }
            if (dtfechafrom.Value.Month < 10) { mes = "0" + dtfechafrom.Value.Month.ToString(); } else { mes = dtfechafrom.Value.Month.ToString(); }
            año = dtfechafrom.Value.Year.ToString();

            //Fecha Desde
            fechaf = año + "-" + mes + "-" + dia;

            dt = oper.ExtraeData("SELECT * from factura WHERE fecha = '" + fechaf + "'");
            dataGridView1update.DataSource = dt;
            dataGridView1update.Refresh();
            RellenarTablas();

        }

        private void Cuadre_Load(object sender, EventArgs e)
        {
            dtfechafrom.Value = DateTime.Now;
            GeneradasHoy();
        }
    }
}
