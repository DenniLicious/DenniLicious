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

        public List<Anvandare> Anvandarna()
        {
            string sql = "SELECT * FROM anvandare";
            dr = sqlFråga(sql);

            Anvandare a;
            List<Anvandare> AL = new List<Anvandare>();

            while (dr.Read())
            {
                a = new Anvandare()
                {
                    Id = (int)dr["id"],
                    Namn = dr["namn"].ToString(),
                    Typ = dr["typ"].ToString()
                };

                AL.Add(a);
            }
            return AL;

        }
        public string[] ValdAnvandare(int userid)
        {
            string sql = "select * from anvandare a where a.id = '" + userid + "'";
            dr = sqlFråga(sql);
            string[] vald = new string[]{"", "", ""};

            while (dr.Read())
            {
                int Id = (int)dr["id"];
                string idd = Id.ToString();
                string Namn = dr["namn"].ToString();
                string Typ = dr["typ"].ToString();

            vald = new string[]
                {
                    idd,
                    Namn,
                    Typ
                };
            }
                

                return vald;
            
        }


        //public void ValdAnvandare(int userid)
        //{
        //    string sql = "select * from anvandare a where a.id = '" + userid + "'";
        //    dr = sqlFråga(sql);

        //    Anvandare vald;

        //    while (dr.Read())
        //    {
        //        vald = new Anvandare()
        //        {
        //            Id = (int)dr["id"],
        //            Namn = dr["namn"].ToString(),
        //            Typ = dr["typ"].ToString()
        //        };


        //    }
        //}
        //metod för att testa att kopplingen till databasen funkar - lägger till medlem, YES
        //public void testar()
        //{
        //string sql = "insert into anvandare(namn, typ) Values ('Dennis', 'Admin')";
        //cmd = new NpgsqlCommand(sql,conn);

        //cmd.ExecuteNonQuery();
        //}
    }
}