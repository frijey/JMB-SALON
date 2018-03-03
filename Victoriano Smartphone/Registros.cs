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
    public partial class Registros : Form
    {
        operacion oper = new operacion();
        public static string id = "";
        public static string nombrecliente = "";
        public static string equipo = "";
        public static string modelo = "";
        public static string proceso = "";
        public static string detalle = "";
        public static string memoria = "";
        public static string chip = "";
        public static string fecha = "";

        //Estado del Servicio
        string servicioestado = "PROCESO";

        public Registros()
        {
            InitializeComponent();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            BuscarporNombre();
        }

        private void tbnombre_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BuscarporCodigo();
        }

        private void tbcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            BuscarporCodigo();
        }

        void BuscarporNombre()
        {

            try
            {
                dataGridView1.Rows.Clear();
                operacion oper = new operacion();
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT id,nombrecliente,equipo,fecha, preciotrabajo FROM registro WHERE nombrecliente LIKE '%" + tbnombre.Text + "%' AND estado LIKE '%" + servicioestado + "%';");
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
                for (int i = 0; i < (dataGridView3.RowCount - 1); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dataGridView3.Rows[i].Cells[0].Value;
                    dataGridView1.Rows[i].Cells[1].Value = dataGridView3.Rows[i].Cells[1].Value;
                    dataGridView1.Rows[i].Cells[2].Value = dataGridView3.Rows[i].Cells[2].Value;
                    dataGridView1.Rows[i].Cells[3].Value = dataGridView3.Rows[i].Cells[3].Value;
                    dataGridView1.Rows[i].Cells[4].Value = dataGridView3.Rows[i].Cells[4].Value;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Cargar los Registros, Contacte al J.M.B.", "Aviso");

            }

        }

        void BuscarporCodigo()
        {
            
            try
            {
                dataGridView1.Rows.Clear();
                operacion oper = new operacion();
                DataTable dt = new DataTable();
                dt = oper.ExtraeData("SELECT id,nombrecliente,equipo,fecha, preciotrabajo FROM registro WHERE id LIKE '%" + tbcodigo.Text + "%' AND estado LIKE '%" + servicioestado + "%';");
                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();
                for (int i = 0; i < (dataGridView3.RowCount - 1); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dataGridView3.Rows[i].Cells[0].Value;
                    dataGridView1.Rows[i].Cells[1].Value = dataGridView3.Rows[i].Cells[1].Value;
                    dataGridView1.Rows[i].Cells[2].Value = dataGridView3.Rows[i].Cells[2].Value;
                    dataGridView1.Rows[i].Cells[3].Value = dataGridView3.Rows[i].Cells[3].Value;
                    dataGridView1.Rows[i].Cells[4].Value = dataGridView3.Rows[i].Cells[4].Value;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Cargar los Registros, Contacte al J.M.B.", "Aviso");

            }

        }

        private void btnmostrartodo_Click(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        void MostrarTodo()
        {
            try
            {
                dataGridView1.Rows.Clear();

                operacion oper = new operacion();
                DataTable dt = new DataTable();

                //Cargar los registros según el radio check box
                dt = oper.ExtraeData("SELECT id,nombrecliente,equipo,fecha, preciotrabajo FROM registro WHERE estado LIKE '%" + servicioestado + "%';");

                dataGridView3.DataSource = dt;
                dataGridView3.Refresh();

                for (int i = 0; i < (dataGridView3.RowCount - 1); i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = dataGridView3.Rows[i].Cells[0].Value;
                    dataGridView1.Rows[i].Cells[1].Value = dataGridView3.Rows[i].Cells[1].Value;
                    dataGridView1.Rows[i].Cells[2].Value = dataGridView3.Rows[i].Cells[2].Value;
                    dataGridView1.Rows[i].Cells[3].Value = dataGridView3.Rows[i].Cells[3].Value;
                    dataGridView1.Rows[i].Cells[4].Value = dataGridView3.Rows[i].Cells[4].Value;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Cargar los Registros, Contacte al J.M.B.", "Aviso");

            }



        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            ModificarRegistro();
        }

        void ModificarRegistro()
        {
            try
            {
                //Validar si se modificará un registro o si se creará uno nuevo
                if (dataGridView1.RowCount > 0)
                {
                    int actualid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    //Rellenar Tabla Grid2 con los datos completos
                    operacion oper = new operacion();
                    DataTable dt = new DataTable();
                    dt = oper.ExtraeData("SELECT * FROM registro WHERE id = '" + actualid + "';");
                    dataGridView2.DataSource = dt;
                    dataGridView2.Refresh();
                    dataGridView2.Columns[0].ReadOnly = true;

                    id = dataGridView2.Rows[0].Cells[0].Value.ToString();
                    nombrecliente = dataGridView2.Rows[0].Cells[1].Value.ToString();
                    equipo = dataGridView2.Rows[0].Cells[2].Value.ToString();
                    modelo = dataGridView2.Rows[0].Cells[3].Value.ToString();
                    proceso = dataGridView2.Rows[0].Cells[4].Value.ToString();
                    detalle = dataGridView2.Rows[0].Cells[5].Value.ToString();
                    memoria = dataGridView2.Rows[0].Cells[6].Value.ToString();
                    chip = dataGridView2.Rows[0].Cells[7].Value.ToString();
                    fecha = dataGridView2.Rows[0].Cells[8].Value.ToString();

                    //Abrir el formulario de Edición y activar la variable de edición
                    Registrar.modificando = true;
                    Form f = new Registrar();
                    f.ShowDialog();
                    Registrar.modificando = false;
                    MostrarTodo();
                }
                else
                {
                    //Abrir el formulario de Edición y activar la variable de edición
                    Registrar.modificando = false;
                    Form f = new Registrar();
                    f.ShowDialog();
                    MostrarTodo();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un solo registro a la vez", "Modificar");

            }


        }

        private void Registros_Load(object sender, EventArgs e)
        {

            MostrarTodo();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarRegistro();
        }

        private void tbcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarporCodigo();
        }

        private void tbnombre_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarporNombre();
        }

        private void rdterminados_CheckedChanged(object sender, EventArgs e)
        {
            btnfacturar.Text = "Cancelar";
            servicioestado = "ENTREGADO";
            ptbflecha.Location = new Point(504, 147);
            btnfacturar.Visible = false;
            MostrarTodo();
        }

        private void rdenproceso_CheckedChanged(object sender, EventArgs e)
        {
            btnfacturar.Text = "Terminar";
            servicioestado = "PROCESO";
            ptbflecha.Location = new Point(501, 190);
            btnfacturar.Visible = true;
            MostrarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avanzar();
        }

        void Avanzar()
        {
            //Cambiar el registro al lugar correspondiente
            try
            {

                if (servicioestado == "PROCESO")
                {
                    TerminarTrabajo.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    TerminarTrabajo.Proceso = "TERMINADO";
                    TerminarTrabajo.fechadbname = "fechaterminado";
                    TerminarTrabajo.montodbname = "preciotrabajo";
                    TerminarTrabajo.procesoconcepto = "Terminar Trabajo";

                    //Facturar el registro seleccionado
                    Form f = new TerminarTrabajo();
                    f.ShowDialog();
                    MostrarTodo();
                }
                else
                {
                    if (servicioestado == "TERMINADO")
                    {
                        TerminarTrabajo.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        TerminarTrabajo.Proceso = "ENTREGADO";
                        TerminarTrabajo.fechadbname = "fechaterminado";
                        TerminarTrabajo.montodbname = "cobrado";
                        TerminarTrabajo.procesoconcepto = "Entregar Trabajo";

                        //Facturar el registro seleccionado
                        Form f = new TerminarTrabajo();
                        f.ShowDialog();
                        MostrarTodo();
                    }
                    else
                    {

                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un solo registro para Facturar...", "Aviso");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnfacturar.Text = "Entregar";
            servicioestado = "TERMINADO";
            ptbflecha.Location = new Point(501, 190);
            btnfacturar.Visible = true;
            MostrarTodo();
        }

        private void ptbflecha_Click(object sender, EventArgs e)
        {

            //Para coloar la fecha en formato correcto
            int mmes = DateTime.Now.Month;
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
            string fechaen = (año + "-" + mes + "-" + dia);

            //Devolver el registro a un lugar anterior
            try
            {

                if (servicioestado == "PROCESO")
                {
                    int idcancel = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    DialogResult Cancelar = MessageBox.Show("¿Desea Eliminar el registro No.: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                        "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Cancelar == DialogResult.No)
                        return;
                    else
                        //Eliminar Registro
                        oper.Sqlsinconsulta("UPDATE registro SET estado = 'ELIMINADO', fechaentregado = '" + fechaen + "' WHERE id = '" + idcancel + "';");
                    MostrarTodo();
                }
                else
                {
                    if (servicioestado == "TERMINADO")
                    {
                        int idcancel = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        DialogResult Cancelar = MessageBox.Show("¿Desea devolver el registro No.: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                            " a trabajos en proceso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Cancelar == DialogResult.No)
                            return;
                        else
                            //Devolver Registro
                            oper.Sqlsinconsulta("UPDATE registro SET estado = 'PROCESO', preciotrabajo = '', fechaterminado = '' WHERE id = '" + idcancel + "';");
                        MostrarTodo();
                    }
                    else
                    {
                        int idcancel = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        DialogResult Cancelar = MessageBox.Show("¿Desea coloar el registro No.: " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                            " en trabajos sin entregar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Cancelar == DialogResult.No)
                            return;
                        else
                            //Devolver Registro
                            oper.Sqlsinconsulta("UPDATE registro SET estado = 'TERMINADO', cobrado = '', fechaentregado = '' WHERE id = '" + idcancel + "';");
                        MostrarTodo();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un solo registro para Facturar...", "Aviso");
            }


        }
    }
}
