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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            operation oper = new operation();
            string id, nombre, apellidos, fecnac;
            id = txtId.Text;
            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;
            fecnac = dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString();
                
            oper.ExecuteNonQuery(" INSERT INTO cliente(nombre,apellidos,fecha)VALUES('" + nombre + "','" + apellidos + "','" + fecnac + "');");
            this.Close();
        }
    }
}
