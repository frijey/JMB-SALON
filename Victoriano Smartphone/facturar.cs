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
    public partial class facturar : Form
    {
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

        //Para Guardar la Ganancia
        static int gananciaparcial = 0;
        static int gananciatotal = 0;
        static int currentcosto = 0;

        public DateTime fecha = DateTime.Now;
        public static bool imprimir = false;
        public static string buscar = "0"; // Para Buscar un registro guardado
        public static bool bbuscar = false; // Para saber si se va a buscar algún registro o si solo se cerró el formulario de buscar

        public static bool modificar = false;

        public facturar()
        {
            InitializeComponent();
        }

        private void facturar_Load(object sender, EventArgs e)
        {

            NuevaFactura();

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            DialogResult boton = MessageBox.Show("Desea Guardar la Factura Actual", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (boton == DialogResult.No)
                return;
            else

                try
                {
                    Convert.ToInt32(idcliente);
                }
                catch (Exception)
                {

                    MessageBox.Show("La facura es a Crédito por favor seleccione un cliente válido", "Aviso");
                    return;

                }

            if (!detalleguardado && !facturaguardada)
            {
                if (credito && idcliente != 0.ToString() && idcliente != "" || !credito)
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

                            //Calcular costo
                            dt = oper.ExtraeData("SELECT costo FROM producto WHERE id = '" + idp + "';");
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();

                            currentcosto = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
                            currentcosto = Convert.ToInt32(cantidad) * currentcosto;

                            //Restar Total del detalle menos el total de costo
                            gananciaparcial = Convert.ToInt32(total) - currentcosto;
                            gananciatotal += gananciaparcial;

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

                        string tipo = "";
                        int restante = Convert.ToInt32(total);
                        if (credito) { tipo = "CREDITO"; } else { tipo = "CONTADO"; restante = 0; }

                        oper.Sqlsinconsulta("INSERT INTO factura(idc, nombrec, fecha, total, tipo, ganancia, restante) VALUES('" + idc + "', '" + nombrec + "', '" + fechaf + "', '" + total + "', '" + tipo + "', '" + gananciatotal + "', '" + restante + "');");

                        facturaguardada = true;

                        dataGridView1detalle.ReadOnly = true;

                        if (detalleguardado && facturaguardada)
                        {
                            DialogResult Guardar = MessageBox.Show("Factura Guardada, Desea imprimirla", "Guardar", MessageBoxButtons.YesNo);
                            if (Guardar == DialogResult.Yes)
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
                            {
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
                }
                else { MessageBox.Show("La facura es a Crédito por favor seleccione un cliente válido", "Aviso"); }

            }
            else { MessageBox.Show("Está factura ya fue guardada por favor Presione el boton de Nueva Factura", "Guardar"); }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f = new BuscarCliente();
            f.ShowDialog();
            tbcliente.Text = nombrecliente;
            tbidcliente.Text = idcliente;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
                ptbcliente.Location = new Point(651, 116);


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
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                    agregandoproducto = true;
                    dataGridView1detalle.Rows.Add();

                    dataGridView1detalle.Rows[numproducto].Cells[0].Value = dataGridView1.Rows[0].Cells[0].Value;//id producto buscado
                    dataGridView1detalle.Rows[numproducto].Cells[1].Value = dataGridView1.Rows[0].Cells[1].Value;//nombre producto buscado
                    dataGridView1detalle.Rows[numproducto].Cells[2].Value = 1; //cantidad producto buscado default 1
                    dataGridView1detalle.Rows[numproducto].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value);//precio
                    dataGridView1detalle.Rows[numproducto].Cells[4].Value = dataGridView1.Rows[0].Cells[2].Value;//total
                    numproducto++; // Para hacer que el número de produto incremente y se agregue en la siguiente fila.
                    tbproducto.Text = "";
                    //totalfactura += Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value); //Para ir sumando el total

                    probuscar = false; // Para cerrar la búsqueda

                    agregandoproducto = false;
                    ActualizarTotales();

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
            if (!agregandoproducto)
            {
                ActualizarTotales();
            }
            else { }

            if (agregandoproducto == false)
            {

                ActualizarTotales();

            }
            else
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            EliminarProducto();

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

            tbtotal.Text = "RD$ " + Convert.ToString(preciobox) + ".00";

        }

        public void EliminarProducto()
        {

            try
            {

                dataGridView1detalle.Rows.RemoveAt(dataGridView1detalle.SelectedRows[0].Index);
                numproducto--; //Para reducir el lugar de la cantidad de productos...
                ActualizarTotales();

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor seleccione el producto que desea eliminar de la facutura", "Elminar");

            }

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

        private void button1_Click(object sender, EventArgs e)
        {

            if (!facturaguardada)
            {
                DialogResult boton = MessageBox.Show("La factura actual no se ha guardado, seguro que desea una nueva factura", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (boton == DialogResult.No)
                    return;
                else;
            }
            else { }


            NuevaFactura();

        }

        public void NuevaFactura()
        {

            //Renovar Factura
            btbuscar.Enabled = true;
            tbproducto.Enabled = true;
            dataGridView1detalle.Rows.Clear();
            chkbcontado.Checked = true;
            chkbcontado.Enabled = true;
            chkbcredito.Enabled = true;
            btnsearch.Enabled = true;
            tbtotal.Text = "RD$ 0.00";
            btnguardar.Enabled = true;
            btneliminiar.Enabled = true;
            tbcliente.Enabled = true;
            credito = false;
            ptbcliente.Enabled = true;

            //Variables necesarias
            detalleguardado = false;
            facturaguardada = false;
            numfactura = "0";
            idcliente = "0";
            nombrecliente = "Cliente";
            credito = false;

            gananciaparcial = 0;
            gananciatotal = 0;
            currentcosto = 0;

            //Para controlar el loop y la actualización de totales.
            agregandoproducto = false;

            //Saber si la factura ya se guardó
            guardada = false;

            //Para el total
            totalfactura = 0;

            //Para contar las columnas
            numproducto = 0;

            //Se realizó busqueda o se cerró el formulario?
            probuscar = false;
            //Para devolver los valores del producto seleccionado
            idproducto = "0";

            fecha = DateTime.Now;
            imprimir = false;
            buscar = "0"; // Para Buscar un registro guardado
            bbuscar = false; // Para saber si se va a buscar algún registro o si solo se cerró el formulario de buscar

            //Lo mismo que se necesita al cargar
            //Inhabilitar las Columnas necesarias
            dataGridView1detalle.ReadOnly = false;
            dataGridView1detalle.Columns[0].ReadOnly = true;
            dataGridView1detalle.Columns[1].ReadOnly = true;
            dataGridView1detalle.Columns[4].ReadOnly = true;

            //Para establecer el Número de registro actual
            int lid;

            dt = oper.ExtraeData("SELECT seq FROM sqlite_sequence WHERE name = 'factura';");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.SelectAll();

            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                try
                {
                    numfactura = fila.Cells[0].Value.ToString();
                    lid = Convert.ToInt32(numfactura);
                    lid++;
                    numfactura = Convert.ToString(lid);
                }
                catch (Exception)
                {
                }

            }

            //Para mostrar el número de resgistro en el formulario actual
            lbnumfactura.Text = ("No. factura: " + numfactura);

            //Esto es para establecer la fecha en el formulario actual
            lbfecha.Text = (DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());


        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

            ImprimirFactura();
            ImprimirFactura();

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

            printfactura.Print();

        }

        private void printfactura_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }

        private void prtmain_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            try
            {

                //Para dar formato a la hora (12hr am - pm)
                int hour = 0;
                string minutes = "00";
                string seconds = "00";
                string noon = "am";

                //Position of the total(x) rand rester
                int totalposition = 127;
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
                Font detalle = new Font("Andalus", 11, FontStyle.Bold);
                Font detalle2 = new Font("Andalus", 10, FontStyle.Bold);
                Font articulo = new Font("Andalus", 9);
                Font punto = new Font("Andalus", 2);

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
                e.Graphics.DrawString("Artículo        -         Cant. - Precio - Total", detalle2, Brushes.Black, positionx, positiony);
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
                e.Graphics.DrawString("------------------------------------", detalle, Brushes.Black, (positionx - 5), positiony);
                positiony += GetingDown;
                e.Graphics.DrawString("                  Gracias por su compra", detalle, Brushes.Black, (positionx-2), (positiony - 2));

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
                int newx = 104;
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

        }
    }
}
