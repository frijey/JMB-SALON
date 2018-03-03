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
    public partial class Contarmoneda : Form
    {
        public Contarmoneda()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int md1 = 0, md5 = 0, md10 = 0, md20 = 0, md25 = 0, md50 = 0, md100 = 0, md200 = 0, md500 = 0, md1000 = 0, md2000 = 0;

            //estas condiciones son para evitar conversiones implicitas, sin un textbox esta vacio.
            if (!string.IsNullOrEmpty(tb1.Text))
            {
                md1 = Convert.ToInt32(tb1.Text);

            }
            else { }

            try
            {
                if (!string.IsNullOrEmpty(tb5.Text))
                {
                    md5 = 5 * Convert.ToInt32(tb5.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb10.Text))
                {
                    md10 = 10 * Convert.ToInt32(tb10.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb20.Text))
                {
                    md20 = 20 * Convert.ToInt32(tb20.Text);
                }
                else { }
                if (!string.IsNullOrEmpty(tb25.Text))
                {
                    md25 = 25 * Convert.ToInt32(tb25.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb50.Text))
                {
                    md50 = 50 * Convert.ToInt32(tb50.Text);
                }
                else { }
                if (!string.IsNullOrEmpty(tb100.Text))
                {
                    md100 = 100 * Convert.ToInt32(tb100.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb200.Text))
                {
                    md200 = 200 * Convert.ToInt32(tb200.Text);
                }
                else { }
                if (!string.IsNullOrEmpty(tb500.Text))
                {
                    md500 = 500 * Convert.ToInt32(tb500.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb1000.Text))
                {
                    md1000 = 1000 * Convert.ToInt32(tb1000.Text);
                }
                else { }

                if (!string.IsNullOrEmpty(tb2000.Text))
                {
                    md2000 = 2000 * Convert.ToInt32(tb2000.Text);
                }
                else { }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo números","Aviso");
            }


            try
            {
                tb1r.Text = Convert.ToString(md1);
                tb5r.Text = Convert.ToString(md5);
                tb10r.Text = Convert.ToString(md10);
                tb20r.Text = Convert.ToString(md20);
                tb25r.Text = Convert.ToString(md25);
                tb50r.Text = Convert.ToString(md50);
                tb100r.Text = Convert.ToString(md100);
                tb200r.Text = Convert.ToString(md200);
                tb500r.Text = Convert.ToString(md500);
                tb1000r.Text = Convert.ToString(md1000);
                tb2000r.Text = Convert.ToString(md2000);

                tbresultado.Text = "RD$ " + Convert.ToString(md1 + md5 + md10 + md20 + md25 + md50 + md100 + md200 + md500 + md1000 + md2000);

            }
            catch (Exception)
            {

            }


        }
    }
}
