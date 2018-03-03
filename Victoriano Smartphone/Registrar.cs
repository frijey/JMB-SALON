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
    public partial class Registrar : Form
    {
        //Para Iniciar la Modificación
        public static bool modificando = false;

        public static string numregistro = "0";
        public DateTime fecha = DateTime.Now;
        public static bool imprimir = false;
        public static string buscar = "0"; // Para Buscar un registro guardado
        public static bool bbuscar = false; // Para saber si se va a buscar algún registro o si solo se cerró el formulario de buscar

        bool nuevo = true;
        public static bool modificar = false;

        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            if (modificando)
            {
                //Cargar el Registro que se editará...
                try
                {
                    tbnombre.Text = Registros.nombrecliente;
                    tbequipo.Text = Registros.equipo;
                    tbmodelo.Text = Registros.modelo;
                    tbproceso.Text = Registros.proceso;
                    tbdetalle.Text = Registros.detalle;
                    tbmemoria.Text = Registros.memoria;
                    tbchip.Text = Registros.chip;
                    lbfecha.Text = Registros.fecha;
                    numregistro = Registros.id;
                    lbnumregistro.Text = ("No. Registro: " + numregistro);

                    nuevo = false; // Para asegurarnos que el registro buscado se modifique y que no se agregue uno nuevo

                    //Para Habilitar la Impresión del registro buscado
                    imprimir = true;
                    btimprimir.Enabled = true;
                }
                catch (Exception)
                {

                }

                modificando = false;

            }
            else
            {

                NuevoRegistro();

                //Bloque de Código Descontinuado, sustituido por el método NuevoRegistro();

                ////Para asegurarnos que se está creando un nuevo registro
                //nuevo = true;

                ////Para establecer el Número de registro actual
                //int lid;

                //operacion oper = new operacion();
                //DataTable dt = new DataTable();
                //dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'registro';");
                //dataGridView1.DataSource = dt;
                //dataGridView1.Refresh();
                //dataGridView1.SelectAll();

                //foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
                //{
                //    try
                //    {
                //        numregistro = fila.Cells[0].Value.ToString();
                //        lid = Convert.ToInt32(numregistro);
                //        lid++;
                //        numregistro = Convert.ToString(lid);
                //    }
                //    catch (Exception)
                //    {
                //    }

                //}

                ////Para mostrar el número de resgistro en el formulario actual
                //lbnumregistro.Text = ("No. Registro: " + numregistro);

                ////Esto es para establecer la fecha en el formulario actual
                //lbfecha.Text = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());

            }

        }

        private void btcsave_Click(object sender, EventArgs e)
        {

            {
                if (!string.IsNullOrEmpty(tbnombre.Text) || !string.IsNullOrWhiteSpace(tbnombre.Text))
                {
                    operacion oper = new operacion();
                    DataTable dt = new DataTable();
                    int mmes = 0, ddia = 0;
                    string id = numregistro;
                    string nombrecliente, equipo, modelo, proceso, detalle, memoria, chip, año, mes, dia, fecha;

                    nombrecliente = tbnombre.Text;
                    equipo = tbequipo.Text;
                    modelo = tbmodelo.Text;
                    proceso = tbproceso.Text;
                    detalle = tbdetalle.Text;
                    memoria = tbmemoria.Text;
                    chip = tbchip.Text;

                    //Para coloar la fecha en formato correcto
                    mmes = DateTime.Now.Month;
                    ddia = DateTime.Now.Day;

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
                    año = DateTime.Now.Year.ToString();
                    fecha = (año + "-" + mes + "-" + dia);

                    if (nuevo)
                    {
                        oper.Sqlsinconsulta("INSERT INTO registro (nombrecliente, equipo, modelo, proceso, detalle, memoria, chip, fecha, estado) VALUES('" + nombrecliente + "', '" + equipo + "', '" + modelo + "', '" + proceso + "', '" + detalle + "', '" + memoria + "', '" + chip + "', '" + fecha + "', 'PROCESO');");
                        MessageBox.Show("Se agregó el registro Correctamente", "Registrar");

                        //Para hacer que si el cliente hacer algún cambio este se modifique
                        nuevo = false;

                        //Para que se habilite la opción imprimir
                        imprimir = true;
                        btimprimir.Enabled = true;
                        btimprimir.Focus();
                    }
                    else
                    {
                        oper.Sqlsinconsulta("UPDATE registro SET nombrecliente = '" + nombrecliente + "', equipo = '" + equipo + "', modelo = '" + modelo + "', proceso = '" + proceso + "', detalle = '" + detalle + "', memoria = '" + memoria + "', chip = '" + chip + "' WHERE id = '" + numregistro + "';");
                        MessageBox.Show("Se Modificó el Cliente", "Guardar");

                        //Para que se habilite la opción imprimir
                        imprimir = true;
                        btimprimir.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Todos los Campos", "Guardar");
                }

            }

        }

        private void btcnew_Click(object sender, EventArgs e)
        {

            NuevoRegistro();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmmain.buscar = true;
            this.Close();
        }

        private void btimprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todavía no se estarán imprimiendo los Registros", "Aviso");
        }

        private void tbnombre_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbequipo_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbmodelo_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbproceso_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbdetalle_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbmemoria_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        private void tbchip_KeyDown(object sender, KeyEventArgs e)
        {
            VerificarTecla(Convert.ToInt16(e.KeyCode));
        }

        void VerificarTecla(int e)
        {
            if (e == 13)
            {
                SendKeys.Send("{TAB}");
            }
            else { }
        }

        void NuevoRegistro()
        {

            //Para establecer el Número de registro actual
            int lid;

            operacion oper = new operacion();
            DataTable dt = new DataTable();
            dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'registro';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

                try
                {
                    numregistro = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    lid = Convert.ToInt32(numregistro);
                    lid++;
                    numregistro = Convert.ToString(lid);
                }
                catch (Exception)
                {
                    numregistro = "1";
                }

            //Para mostrar el número de resgistro en el formulario actual
            lbnumregistro.Text = ("No. Registro: " + numregistro);

            //Esto es para establecer la fecha en el formulario actual
            lbfecha.Text = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());

            tbnombre.Text = "";
            tbequipo.Text = "";
            tbmodelo.Text = "";
            tbproceso.Text = "Reparación";
            tbdetalle.Text = "";
            tbmemoria.Text = "No";
            tbchip.Text = "No";

            nuevo = true;
            imprimir = false;
            btimprimir.Enabled = false;
            tbnombre.Focus();

        }
    }
}
