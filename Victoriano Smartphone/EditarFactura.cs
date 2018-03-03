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
    public partial class EditarFactura : Form
    {
        public EditarFactura()
        {
            InitializeComponent();
        }

        operacion oper = new operacion();
        DataTable dt = new DataTable();

        //Variables necesarias
        bool detalleguardado = false;
        bool facturaguardada = false;
        public static string numfactura = "0";
        public static string idcliente = "0";
        public static string nombrecliente = "Cliente";
        public static bool credito = false;
        public static string currentproductocantidad = "0";
        public static string detcantidad = "";
        public static int detallecantidad = 0;
        public static string nuevacantidad = "";

        //Id Actual a en Edición
        string idfacturaactual = "0";

        //Bool para saber si se modificó la factura
        //En caso verdadero, no se podrá imprimir hasta ser guardada
        static bool modificado = false;

        //Detalle en Edición Variable Para Diferenciar lo que se Guarda de lo que se Actualiza
        static int UPDATING = 0;

        //Para controlar el loop y la actualización de totales.
        public static bool agregandoproducto = false;

        //Saber si la factura ya se guardó
        public static bool guardada = false;

        //Para el total
        public static int totalfactura = 0;

        //Para contar las columnas
        public int numproducto = 0;

        //Se realizó busqueda o se cerró el formulario?
        public static bool probuscar = false;
        //Para devolver los valores del producto seleccionado
        public static string idproducto = "0";

        public DateTime fecha = DateTime.Now;
        public static bool imprimir = false;
        public static string buscar = "0"; // Para Buscar un registro guardado
        public static bool bbuscar = false; // Para saber si se va a buscar algún registro o si solo se cerró el formulario de buscar

        public static bool modificar = false;

        private void EditarFactura_Load(object sender, EventArgs e)
        {

            DesactivarEdición();
            idfacturaactual = ConsultarFacturas.idfacturaeditar;
            //Si hay un código al cargar Then Realizar la Búsqueda...
            if (idfacturaactual != "" && idfacturaactual != "0")
            {
                BuscarFactura();
            }




        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            DialogResult boton = MessageBox.Show("¿Desea guardar los cambios realizados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (boton == DialogResult.No)
                return;
            else

            if (credito && idcliente != 0.ToString() || !credito)
            {
                //Variables necesarias para el detalle
                string idf, idp, nombre, cantidad, precio, total;
                idf = numfactura;

                int maxrow = dataGridView1detalle.RowCount;

                for (int i = 0; i < maxrow; i++)
                {
                    detalleguardado = true;
                    try
                    {
                        idp = dataGridView1detalle.Rows[i].Cells[0].Value.ToString();
                        nombre = dataGridView1detalle.Rows[i].Cells[1].Value.ToString();
                        cantidad = dataGridView1detalle.Rows[i].Cells[2].Value.ToString();
                        precio = dataGridView1detalle.Rows[i].Cells[3].Value.ToString();
                        total = dataGridView1detalle.Rows[i].Cells[4].Value.ToString();

                        dt = oper.ExtraeData("SELECT existencia FROM producto WHERE id = '" + idp + "';");
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();

                        currentproductocantidad = dataGridView1.Rows[0].Cells[0].Value.ToString();

                        nuevacantidad = (Convert.ToInt32(currentproductocantidad) - Convert.ToInt32(cantidad)).ToString();

                        oper.Sqlsinconsulta("INSERT INTO detalle(idf, idp, nombre, cantidad, precio, total) VALUES('" + idf + "', '" + idp + "', '" + nombre + "', '" + cantidad + "', '" + precio + "', '" + total + "');");
                        oper.Sqlsinconsulta("UPDATE producto SET existencia = '" + nuevacantidad + "' WHERE id = '" + idp + "';");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al Guardar la Factura", "Guardar");
                        detalleguardado = false; //Para detener el guardado si hubo algún error en el guardado
                    }

                }

                if (detalleguardado)
                {

                    //Variables necesarias para la factura
                    string idc, nombrec, fechaf;

                    nombrec = tbcliente.Text;
                    if (credito)
                    {
                        try { idc = Convert.ToInt32(tbidcliente.Text).ToString(); }
                        catch (Exception)
                        {
                            MessageBox.Show("Elija el cliente nuevamente", "Error");
                            return;
                        }
                    }
                    else { idc = ""; }


                    //Para coloar la fecha en formato correcto
                    int mmes = 0, ddia = 0;
                    string mes, dia, año;
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
                    fechaf = (año + "-" + mes + "-" + dia);
                    total = totalfactura.ToString();

                    oper.Sqlsinconsulta("INSERT INTO factura(idc, nombrec, fecha, total) VALUES('" + idc + "', '" + nombrec + "', '" + fechaf + "', '" + total + "');");
                    facturaguardada = true;

                    dataGridView1detalle.ReadOnly = true;

                    if (detalleguardado && facturaguardada)
                    {
                        DialogResult Guardar = MessageBox.Show("Factura Guardada, Desea imprimirla", "Guardar", MessageBoxButtons.YesNo);
                        if (boton == DialogResult.Yes)
                        {
                            ImprimirFactura(); // Método de impresión de Factura

                            //Bloquear Factura
                            btbuscar.Enabled = false;
                            tbproducto.Enabled = false;
                            btnsearch.Enabled = false;
                            chkbcontado.Enabled = false;
                            chkbcredito.Enabled = false;
                            tbcliente.Enabled = false;
                            btnguardar.Enabled = false;
                            btnimprimir.Enabled = true;
                            btneliminiar.Enabled = false;
                            ptbcliente.Enabled = false;
                            btnimprimir.Select();
                            return;
                        }
                        else

                            //Bloquear Factura
                            btbuscar.Enabled = false;
                        tbproducto.Enabled = false;
                        btnsearch.Enabled = false;
                        chkbcontado.Enabled = false;
                        chkbcredito.Enabled = false;
                        tbcliente.Enabled = false;
                        btnguardar.Enabled = false;
                        btnimprimir.Enabled = true;
                        btneliminiar.Enabled = false;
                        ptbcliente.Enabled = false;
                        btnimprimir.Select();
                    }

                }
            }
            else
            {
                MessageBox.Show("La facura es a Crédito por favor seleccione un cliente válido", "Aviso");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new BuscarCliente();
            f.ShowDialog();
            tbcliente.Text = nombrecliente;
            tbidcliente.Text = idcliente;
        }

        private void chkbcredito_CheckedChanged(object sender, EventArgs e)
        {

            //Factura a Crédito
            if (chkbcredito.Checked)
            {

                //Para Cambiar de Contado a Crédito y activar el cliente obligatorio
                chkbcontado.Checked = false;
                tbcliente.Enabled = false;
                tbcliente.Text = "";
                lbidcliente.Visible = true;
                tbidcliente.Visible = true;
                btnsearch.Visible = true;
                credito = true;

                // Para darle estilo de movimiento a las dos imágenes
                ptbcanasto.Location = new Point(514, 169);
                ptbcarro.Location = new Point(656, 190);
                ptbcliente.Location = new Point(651, 130);

                //Para Encender el boton de guardado y apagar el de imprimir
                modificado = true;
                btnimprimir.Enabled = false;
                btnguardar.Enabled = true;

            }
            else { chkbcontado.Checked = true; }

        }

        private void chkbcontado_CheckedChanged(object sender, EventArgs e)
        {

            //Factura al Contado
            if (chkbcontado.Checked)
            {
                //Para Cambiar de Crédito a Contado y desactivar el cliente obligatorio
                chkbcredito.Checked = false;
                tbcliente.Enabled = true;
                tbcliente.Text = "";
                lbidcliente.Visible = false;
                tbidcliente.Visible = false;
                tbidcliente.Text = "";
                btnsearch.Visible = false;
                credito = false;

                // Para devolver las imágenes a su lugar
                ptbcanasto.Location = new Point(514, 137);
                ptbcarro.Location = new Point(656, 158);
                ptbcliente.Location = new Point(730, 88);

                //Para Encender el boton de guardado y apagar el de imprimir
                modificado = true;
                btnimprimir.Enabled = false;
                btnguardar.Enabled = true;

            }
            else { chkbcredito.Checked = true; }

        }

        public void btbuscar_Click(object sender, EventArgs e)
        {

            RealizarBusqueda();

        }

        private void tbproducto_KeyDown(object sender, KeyEventArgs e)

        {

            if (Convert.ToInt32(e.KeyCode) == 13)
            {

                RealizarBusqueda();

            }

        }

        public void RealizarBusqueda()
        {

            Buscar_Producto.busqueda = tbproducto.Text;
            Form f = new Buscar_Producto();
            f.ShowDialog();

            if (probuscar)
            {
                try
                {

                    dt = oper.ExtraeData("SELECT id, nombre, precio FROM producto WHERE id = '" + idproducto + "';");
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();

                    //Agregar el Producto al Grid Visual
                    dataGridView1detalle.Rows.Add();

                    dataGridView1detalle.Rows[numproducto].Cells[0].Value = dataGridView2.Rows[0].Cells[0].Value;//id producto buscado
                    dataGridView1detalle.Rows[numproducto].Cells[1].Value = dataGridView2.Rows[0].Cells[1].Value;//nombre producto buscado
                    dataGridView1detalle.Rows[numproducto].Cells[2].Value = 1; //cantidad producto buscado default 1
                    dataGridView1detalle.Rows[numproducto].Cells[3].Value = Convert.ToInt32(dataGridView2.Rows[0].Cells[2].Value);//precio
                    dataGridView1detalle.Rows[numproducto].Cells[4].Value = dataGridView2.Rows[0].Cells[2].Value;//total

                    tbproducto.Text = ""; //Para limpiar el cuadro de texto de buscar.

                    numproducto++; // Para hacer que el número de produto incremente y se agregue en la siguiente fila.
                    rastreonum.Text = numproducto.ToString();

                    probuscar = false; // Para cerrar la búsqueda

                    modificado = true;
                    btnimprimir.Enabled = false;
                    btnguardar.Enabled = true;

                }
                catch (Exception)
                {

                    MessageBox.Show("Error al agregar producto, inténtelo de nuevo", "Agregar");
                    return;

                }

                ActualizarTotales();

            }
            else
            {
                ActualizarTotales();
            }
            ActualizarTotales();
        }

        private void dataGridView1detalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //Chequeo para el Guardado...
            if (dataGridView1detalle.RowCount > 0)
            {

                dataGridView1detalle.CurrentCell.Value = Convert.ToInt32(dataGridView1detalle.CurrentCell.Value);
                string datag1 = dataGridView1detalle.CurrentCell.Value.ToString();
                if (datag1 == "0")
                {
                    EliminarProducto();
                }
            }

            ActualizarTotales();

            //Para Encender el boton de guardado y apagar el de imprimir
            modificado = true;
            btnimprimir.Enabled = false;
            btnguardar.Enabled = true;

        }

        public void ActualizarTotales()
        {

            //Codigo para actualizar Totales
            int maxrow = 0;
            int cantidad = 0;
            int precio = 0;
            int total = 0;

            maxrow = dataGridView1detalle.RowCount;

            totalfactura = 0;

            for (int i = 0; i < maxrow; i++)
            {
                try
                {
                    cantidad = Convert.ToInt32(dataGridView1detalle.Rows[i].Cells[2].Value);
                    precio = Convert.ToInt32(dataGridView1detalle.Rows[i].Cells[3].Value);
                    total = (cantidad * precio);
                    totalfactura += total;

                    dataGridView1detalle.Rows[i].Cells[4].Value = total;
                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese un número válido", "Aviso");

                }

            }

            //Para formatear el Valor en Pesos Dominacos del total
            string preciobox = totalfactura.ToString();

            if (totalfactura > 0)
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

            tbtotal.Text = "RD$ " + preciobox + ".00";

        }

        public void EliminarProducto()
        {
            int Cantidades = dataGridView1detalle.SelectedRows.Count;
            for (int i = 0; i < Cantidades; i++)
            {

                try
                {
                    int RowSelected = dataGridView1detalle.SelectedRows[0].Index;
                    dataGridView1detalle.Rows.RemoveAt(RowSelected);

                    if (UPDATING > 0 && (RowSelected + 1) <= UPDATING)
                    {
                        dataGridView1.Rows.RemoveAt(RowSelected);
                        UPDATING--;
                        tbrastreo.Text = UPDATING.ToString();
                    }
                    else { }

                    numproducto--;
                    rastreonum.Text = numproducto.ToString();

                    modificado = true;
                    btnimprimir.Enabled = false;
                    btnguardar.Enabled = true;


                }
                catch (Exception)
                {

                    MessageBox.Show("Por favor seleccione el producto que desea eliminar de la facutura", "Elminar");

                }

            }

            ActualizarTotales();

        }

        private void dataGridView1detalle_KeyDown(object sender, KeyEventArgs e)
        {

            if (Convert.ToInt32(e.KeyCode) == 46 && !detalleguardado)
            {

                EliminarProducto();

            }



        }

        private void dataGridView1detalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("Ingrese un número válido", "Aviso");
            SendKeys.Send("{ESC}");

        }

        private void dataGridView1detalle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void tbtotal_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;
        }

        public void ImprimirFactura()
        {

            printDialog1.ShowDialog();
            printfactura.Print();


        }

        private void printfactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                //Para dar formato a la hora (12hr am - pm)
                int hour = 0;
                string minutes = "00";
                string seconds = "00";
                string noon = "am";

                //Position of the total(x) rand rester
                int totalposition = 140;
                int rester = 0;

                //Posición del logo
                int logoposx = 17;
                int logoposy = -5;

                //Tamaño del logo
                int logosizex = 256;
                int logosizey = 100;

                //Tamaño de la informacion
                int logoinfosizex = 264;
                int logoinfosizey = 85;

                //Posición del texto
                int positionx = 15;
                int positiony = 65;

                //Posición de la cantidad, precio y total del artículo
                int cantidadpos = 143;
                int preciopos = 183;
                int totalpos = 228;

                //Incremento o interlineado
                int GetingDown = 12;

                Font cabecera = new Font("Andalus", 10, FontStyle.Bold);
                Font detalle = new Font("Agency FB", 11, FontStyle.Bold);
                Font articulo = new Font("Agency FB", 9);
                Font punto = new Font("Agency FB", 2);

                //cabecera
                e.Graphics.DrawImage(logo.Image, logoposx, logoposy, logosizex, logosizey);
                e.Graphics.DrawString("Factura: " + numfactura, cabecera, Brushes.Black, positionx, positiony);
                positiony += GetingDown;

                //Setting the right 12 format hour
                if (DateTime.Now.Hour > 12) { hour = (DateTime.Now.Hour - 12); noon = "pm"; } else { hour = DateTime.Now.Hour; noon = "am"; }
                if (DateTime.Now.Minute < 10) { minutes = "0" + Convert.ToString(DateTime.Now.Minute); } else { minutes = Convert.ToString(DateTime.Now.Minute); }
                if (DateTime.Now.Second < 10) { seconds = "0" + Convert.ToString(DateTime.Now.Second); } else { seconds = Convert.ToString(DateTime.Now.Second); }

                e.Graphics.DrawString("Fecha: " + DateTime.Now.Day.ToString() + "/"
                   + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString(), cabecera, Brushes.Black, positionx, positiony);
                positiony += GetingDown;
                e.Graphics.DrawString("Cliente: " + tbcliente.Text, cabecera, Brushes.Black, positionx, positiony);
                positiony += GetingDown;
                e.Graphics.DrawString("Hora: " + hour.ToString() + ":"
                    + minutes + ":" + seconds + " " + noon, cabecera, Brushes.Black, positionx, positiony);
                positiony += GetingDown;

                //Detalle
                positiony += 3;
                e.Graphics.DrawString("Artículo          -          Cantidad - Precio - Total", detalle, Brushes.Black, positionx, positiony);
                positiony += GetingDown + 4;

                //Para formatear el Valor en Pesos Dominacos del total
                string preciobox = totalfactura.ToString();

                if (totalfactura > 0)
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


                string nombre = "", cantidad = "", precio = "", total = "";

                int maxrow = dataGridView1detalle.RowCount;

                for (int i = 0; i < maxrow; i++)
                {
                    try
                    {

                        nombre = dataGridView1detalle.Rows[i].Cells[1].Value.ToString();
                        cantidad = dataGridView1detalle.Rows[i].Cells[2].Value.ToString();
                        precio = dataGridView1detalle.Rows[i].Cells[3].Value.ToString();
                        total = dataGridView1detalle.Rows[i].Cells[4].Value.ToString();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un problema durante la Impresión", "DetalleErrorInsert");
                    }
                    {

                    }

                    e.Graphics.DrawString(nombre, articulo, Brushes.Black, positionx, positiony);
                    e.Graphics.DrawString(cantidad, articulo, Brushes.Black, cantidadpos, positiony);
                    e.Graphics.DrawString(precio, articulo, Brushes.Black, preciopos, positiony);
                    e.Graphics.DrawString(total, articulo, Brushes.Black, totalpos, positiony);
                    positiony += GetingDown + 1;

                }


                positiony += 2;
                e.Graphics.DrawString("Total: RD$ " + preciobox + ".00", detalle, Brushes.Black, (totalposition - rester), positiony);
                positiony += GetingDown - 2;
                e.Graphics.DrawString("------------------------------------------------------", detalle, Brushes.Black, (positionx - 5), positiony);
                positiony += GetingDown;
                e.Graphics.DrawString("                  Gracias por su compra", detalle, Brushes.Black, positionx, (positiony - 2));

                //Impresion del logo de información
                e.Graphics.DrawImage(logoinf.Image, (positionx - 3), (positiony + 3), logoinfosizex, logoinfosizey);
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                positiony += GetingDown;
                e.Graphics.DrawString(".", punto, Brushes.Gray, (positionx - 5), positiony);
                positiony += GetingDown;

                //Testeando Posiciones
                int newx = 105;
                int newy = (positiony - 85);
                int newbdistance = 12;

                //Fuente para la información de la Empresa
                Font info = new Font("Batang", 6, FontStyle.Bold);
                Font info2 = new Font("Batang", 6);

                e.Graphics.DrawString("829-636-9991 / 829 – 292 - 0985", info, Brushes.Black, (-11 + newx), newy);
                newy += newbdistance;
                e.Graphics.DrawString("    edward.victoriano@gmail.com", info, Brushes.Black, (-2 + newx), newy);
                newy += newbdistance;
                e.Graphics.DrawString("  Calle 16 de Agosto, Jarabacoa", info2, Brushes.Black, (11 + newx), newy);
                newy += newbdistance;
                e.Graphics.DrawString("       La Vega, Rep. Dominicana", info2, Brushes.Black, (12 + newx), newy);
                newy += newbdistance;
                e.Graphics.DrawString("frente a la bomba Total Jimenoa", info2, Brushes.Black, (8 + newx), newy);

                //Fuetente para el sobre logo
                Font sobrelogo2 = new Font("Calibri (Cuerpo)", 6, FontStyle.Bold);
                e.Graphics.DrawString("Edward", sobrelogo2, Brushes.Black, 20, (-60 + positiony));
                e.Graphics.DrawString("Victoriano", sobrelogo2, Brushes.Black, (20 + 32), (-60 + positiony));

                //Fuente para el Sobre Logo "Tecnológicamente Confiable"
                Font delantero = new Font("Impact", 5);
                e.Graphics.DrawString("Tecnológicamente Confiable", delantero, Brushes.Black, 160, 65);

            }
            catch (Exception)
            {


            }


        }

        private void ptbcliente_Click(object sender, EventArgs e)
        {

            Form f = new BuscarCliente();
            f.ShowDialog();
            tbcliente.Text = nombrecliente;
            tbidcliente.Text = idcliente;

            modificado = true;
            btnimprimir.Enabled = false;
            btnguardar.Enabled = true;

        }

        void BuscarFactura()
        {

            try
            {
                //Pequeño método para quitar ceros delanteros...
                if (tbfacturanumero.Text != "")
                {
                    tbfacturanumero.Text = Convert.ToInt32(tbfacturanumero.Text).ToString();
                    tbfacturanumero.Select(tbfacturanumero.Text.Length, 0);
                }
                else { }

                //Para Rellenar el Detalle
                dataGridView1detalle.Rows.Clear();
                numproducto = 0;

                dt = oper.ExtraeData("SELECT id, idp, nombre, cantidad, precio, total FROM detalle WHERE idf = '" + idfacturaactual + "';");
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();



                for (int i = 0; i < (dataGridView1.RowCount - 1); i++)
                {

                    dataGridView1detalle.Rows.Add();

                    dataGridView1detalle.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[1].Value;//id producto buscado
                    dataGridView1detalle.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[2].Value;//nombre producto buscado
                    dataGridView1detalle.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[3].Value;  //cantidad producto
                    dataGridView1detalle.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);//precio
                    dataGridView1detalle.Rows[i].Cells[4].Value = dataGridView1.Rows[i].Cells[5].Value;//total

                    numproducto++;
                    rastreonum.Text = numproducto.ToString();

                }

                UPDATING = (dataGridView1.RowCount - 1);
                tbrastreo.Text = UPDATING.ToString();

                ActualizarTotales();

                //Para Colocar el Cliente y el Tipo de Factura
                dt = oper.ExtraeData("SELECT * FROM factura WHERE id = '" + idfacturaactual + "';");
                dataGridView2.DataSource = dt;
                dataGridView2.Refresh();

                if (dataGridView2.Rows[0].Cells[5].Value.ToString() == "CONTADO")
                {
                    credito = false;
                    chkbcontado.Checked = true;
                }
                else
                {
                    credito = true;
                    chkbcredito.Checked = true;
                    tbidcliente.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                };

                tbcliente.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();

                //Número de factura y Fecha
                lbnumfactura.Text = "No. Factura: " + idfacturaactual;
                numfactura = idfacturaactual;
                lbfecha.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();

                //Para Apagar el boton de guardado y Encender el de imprimir
                modificado = false;
                btnimprimir.Enabled = true;
                btnguardar.Enabled = false;

                ActivarEdición();

            }
            catch (Exception)
            {
                DesactivarEdición();
                MessageBox.Show("La factura " + idfacturaactual + " no existe o fue eliminada", "Edición");
                tbfacturanumero.Clear();
                tbfacturanumero.Focus();

            }


        }

        private void btneliminiar_Click(object sender, EventArgs e)
        {

            EliminarProducto();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            //Para apagar el boton de guardado y encender el de imprimir
            modificado = false;
            btnimprimir.Enabled = true;
            btnguardar.Enabled = false;

            tbposy.Document = printfactura;



        }

        private void btnbuscarfactura_Click(object sender, EventArgs e)
        {
            
            //Si hay un código en el TextBox Then Realizar la Búsqueda...
            if (tbfacturanumero.Text != "")
            {
                idfacturaactual = tbfacturanumero.Text;
                BuscarFactura();
            }

        }

        private void tbfacturanumero_KeyDown(object sender, KeyEventArgs e)
        {

            //Si hay un código en el TextBox Then Realizar la Búsqueda...
            if (tbfacturanumero.Text != "")
            {
                //Si se presiona enter en el cuadro de texto de "Buscar por Código"
                if (e.KeyCode == Keys.Enter) { idfacturaactual = tbfacturanumero.Text; BuscarFactura(); } else { }
            }

            //Si se presiona ESCAPE en el cuadro de texto de "Buscar por Código" = Salir del formulario
            if (e.KeyCode == Keys.Escape) { this.Close(); } else { }


        }

        private void btnimprimir_Click_1(object sender, EventArgs e)
        {
            ImprimirFactura();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                tbposy.Zoom = Convert.ToDouble(tbzoom.Text);

            }
            catch (Exception)
            {
                //Do Nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tbposy.Document = printfactura;

        }

        void DesactivarEdición()
        {

            //Desactivar Botonoes de edición
            btbuscar.Enabled = false;
            tbproducto.Enabled = false;
            chkbcontado.Enabled = false;
            chkbcredito.Enabled = false;
            tbcliente.Enabled = false;
            ptbcliente.Enabled = false;
            btneliminiar.Enabled = false;
            btnimprimir.Enabled = false;
            btnguardar.Enabled = false;
            numfactura = "";
            idcliente = "0";
            nombrecliente = "Cliente";

        }

        void ActivarEdición()
        {

            //Activar Botonoes de edición
            btbuscar.Enabled = true;
            tbproducto.Enabled = true;
            chkbcontado.Enabled = true;
            chkbcredito.Enabled = true;
            tbcliente.Enabled = true;
            ptbcliente.Enabled = true;
            btneliminiar.Enabled = true;
            btnimprimir.Enabled = true;
            btnguardar.Enabled = false;

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form f = new BuscarCliente();
            f.ShowDialog();
            tbcliente.Text = nombrecliente;
            tbidcliente.Text = idcliente;

            modificado = true;
            btnimprimir.Enabled = false;
            btnguardar.Enabled = true;
        }
    }
}
