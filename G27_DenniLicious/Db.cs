using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using System.Configuration;

namespace G27_DenniLicious
{
    public class Db
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        //private NpgsqlDataAdapter da;

        public Db()
        {
            conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["interaktiva_g27"].ConnectionString);
            conn.Open();
        }

        private NpgsqlDataReader sqlFråga(string sql)
        {
            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (NpgsqlException ex)
            {
                string felmeddelande = ex.Message;
                
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }

        //metod för att testa att kopplingen till databasen funkar - lägger till medlem, YES
        //public void testar()
        //{
        //string sql = "insert into anvandare(namn, typ) Values ('Dennis', 'Admin')";
        //cmd = new NpgsqlCommand(sql,conn);

        //cmd.ExecuteNonQuery();
        //}
    }
}