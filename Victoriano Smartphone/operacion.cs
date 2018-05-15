using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Victoriano_Smartphone
{
    public class operacion
    {
        //public static string RutaBD = "C:\\Sistemas\\VS.db";
        public static string RutaBD = "jmbsalon.db";

        public string Sqlsinconsulta(string sql)
        {

            SQLiteConnection cnx = new SQLiteConnection("Data Source="+RutaBD+";Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }

        }

        public DataTable ExtraeData(string sql)
        {

            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=" + RutaBD + ";Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }

            catch (SQLiteException)
            {
                MessageBox.Show("Error al Extraer Datos de la Base de Datos Actual");
            }
            cnx.Close();
            return dt;
        }
    }
}
