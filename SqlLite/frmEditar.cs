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
    public partial class frmEditar : Form
    {
        public frmEditar(string id, string nombre, string apellidos, string fecnac)
        {
            InitializeComponent();

            txtId.Text = id;
            txtNombre.Text = nombre;
            txtApellidos.Text = apellidos;

        }

        private void frmEditar_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            operation oper = new operation();
            string id, nombre, apellidos, fecnac;
            id = txtId.Text;
            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;
            fecnac = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();

            oper.ExecuteNonQuery(" UPDATE cliente SET nombre='" + nombre + "' ,apellidos='" + apellidos + "',fecnac='" + fecnac + "' WHERE id='" + id + "'");
            this.Close();
        }
    }
}
