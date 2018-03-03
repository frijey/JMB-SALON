using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlLite
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation oper = new operation();
            DataTable dt = oper.ExtraeData(" SELECT * FROM cliente; ");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            //foreach (DataRow fila in dt.Rows)
            //{
            //    txtNombre.Text = fila["nombre"].ToString();
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar f = new frmAgregar();
                f.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id="", nombre = "", apellidos="";
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                 id = fila.Cells[0].Value.ToString();
                nombre = fila.Cells[1].Value.ToString();
                apellidos = fila.Cells[2].Value.ToString();
            }
     

            frmEditar f = new frmEditar(id, nombre, apellidos,"");
            f.Show();
        }
    }
}
