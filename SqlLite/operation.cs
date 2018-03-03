using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace SqlLite
{
    public class operation
    {

        //private void CrearBD()
        //{
        //    SQLiteConnection.CreateFile("uapa.db");
        //    SQLiteConnection cnx = new SQLiteConnection("Data Source=uapa.db;Version=3;");
        //    cnx.Open();

        //    //TABLA CLIENTE
        //    string sql = "create table cliente (id numeric,nombre varchar(30),apellidos varchar(30), fecnac varchar(10));";
        //    SQLiteCommand command = new SQLiteCommand(sql, cnx);
        //    command.ExecuteNonQuery();

        //    cnx.Close();
        //}
        public string ExecuteNonQuery(string sql)
        {
            //if (!File.Exists("uapa.db"))
            //{
            //    CrearBD();
            //}

            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Sistemas\\db2.db;Version=3;");
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
            //if (!File.Exists("uapa.db"))
            //{
            //    CrearBD();
            //}


            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=uapa.db;Version=3;");
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Sistemas\\db2.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {

            }
            cnx.Close();
            return dt;
        }
    }
}
