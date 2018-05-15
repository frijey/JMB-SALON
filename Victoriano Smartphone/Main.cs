using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Victoriano_Smartphone
{
    public partial class frmmain : Form
    {
        //Para Abrir Otros Formularios desde el Principal
        public static bool buscar = false;
        public static bool Editar = false;

        public frmmain()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void devoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Registrar();
            f.ShowDialog();
            if (buscar)
            {
                buscar = false;
                Form h = new Registros();
                h.ShowDialog();
            }
            else { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form f = new facturar();
            f.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente.mantenimiento = true;
            Form F = new ConsultaCliente();
            F.ShowDialog();

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProducto.mantenimiento = true;
            Form F = new ConsultaProducto();
            F.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("Desea Salir del Sistema", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (boton == DialogResult.No)
                return;
            else
                this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ConsultaCliente();
            f.ShowDialog();
        }

        private void coonteoPorMonedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Contarmoneda();
            f.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ConsultaProducto();
            f.ShowDialog();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaSuplidores.mantenimiento = true;
            Form f = new ConsultaSuplidores();
            f.ShowDialog();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new ConsultaSuplidores();
            f.ShowDialog();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form f = new Registrar();
            f.ShowDialog();
            if (buscar)
            {
                buscar = false;
                Form h = new Registros();
                h.ShowDialog();
            }
            else { }
        }

        private void devoluciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
        }

        private void pendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Registros();
            f.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarFacturas();
            f.ShowDialog();
        }

        private void trabajosTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
        }

        private void cuadreDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función aun no establecida", "Aviso");
            return;
            Form f = new EditarFactura();
            f.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new facturar();
            f.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Función aun no establecida", "Aviso");
            //return;

            //Form f = new EditarFactura();
            //f.ShowDialog();

        }

        private void btcsave_Click(object sender, EventArgs e)
        {
            Form f = new Registros();
            f.ShowDialog();
        }

        private void reiniciarTablasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form f = new ConsultaProducto();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = new ConsultarFacturas();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form f = new Contarmoneda();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form f = new ConsultaCliente();
            f.ShowDialog();
        }
    }
}