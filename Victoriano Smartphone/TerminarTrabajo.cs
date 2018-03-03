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
    public partial class TerminarTrabajo : Form
    {
        operacion oper = new operacion();
        //Variables necesarias para realizar el prcoeso adecuado
        public static int id = 0;
        public static string Proceso = "null";
        public static string fechadbname = "null";
        public static string montodbname = "null";
        public static string procesoconcepto = "null";

        public int monto = 0;

        public TerminarTrabajo()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //Para coloar la fecha en formato correcto
            int  mmes = DateTime.Now.Month;
            int ddia = DateTime.Now.Day;

            string mes;
            string dia;

            if (mmes < 10)
            {
                mes = ("0" + mmes.ToString());
            }
            else { mes = mmes.ToString(); }

            if (ddia < 10)
            {
                dia = ("0" + mmes.ToString());
            }
            else { dia = ddia.ToString(); }

            //Luego de hacer las revisiones necesarias en día y mes, formatear con guiones la fecha.
            string año = DateTime.Now.Year.ToString();
            string fecha = (año + "-" + mes + "-" + dia);


            oper.Sqlsinconsulta("UPDATE registro SET estado = '"+Proceso+"', "+montodbname+" = '" + monto  + "', " + fechadbname + " = '" + fecha + "' WHERE id = '" + id + "';");
            this.Close();

            //if (!String.IsNullOrEmpty(tbmonto.Text))
            //{
            //    try
            //    {
            //        Registrar.bbuscar = true;
            //        Registrar.buscar = tbmonto.Text;
            //        this.Close();
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor ingrese un número de registro válido","Buscar");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbmonto_Enter(object sender, EventArgs e)
        {
            tbmonto.Text = monto.ToString();
        }

        private void tbmonto_Leave(object sender, EventArgs e)
        {
            try
            {
                //Pasar el valor del monto
                monto = Convert.ToInt32(tbmonto.Text);

                string preciobox = tbmonto.Text;

                if (preciobox.Length > 3)
                {
                    int m = (preciobox.Length - 1) / 3;

                    int place = preciobox.Length - (3 * m);
                    preciobox = preciobox.Insert(place, ",");

                    for (int j = 1; j < m; j++)
                    {
                        place += 4;
                        preciobox = preciobox.Insert(place, ",");

                    }
                }
                else
                {

                }

                tbmonto.Text = "RD$ " + preciobox + ".00";
            }
            catch (Exception)
            {
                tbmonto.Text = "";
                tbmonto.Focus();
            }
        }


        private void FacturarRegistro_Load(object sender, EventArgs e)
        {
            TerminarTrabajo.ActiveForm.Text = procesoconcepto;
            lbregistro.Text = "No.: " + id.ToString();
        }

        private void tbmonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                SendKeys.Send("{Tab}");
            }
        }

        void Terminar()
        {

        }

        void Entregar()
        {

        }
    }
}
