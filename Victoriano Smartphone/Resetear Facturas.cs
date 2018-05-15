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
    public partial class Resetear_Facturas : Form
    {
        public Resetear_Facturas()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if(tbpass.Text == "zxccxz1")
            {
                operacion oper = new operacion();
                oper.Sqlsinconsulta("DELETE FROM factura; DELETE FROM detalle; DELETE FROM sqlite_sequence WHERE name = 'factura'; DELETE FROM sqlite_sequence WHERE name = 'detalle';");
                MessageBox.Show("Campos reiniciados", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbpass.Clear();
            }
            else
            {
                MessageBox.Show("Clave Incorrecta","Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbpass.Clear();
            }
        }
    }
}
