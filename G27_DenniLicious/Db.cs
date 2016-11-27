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
            string sql = "SELECT * FROM anvandare order by id asc";
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
                bool aku = (bool)dr["aku"];
                string akut = aku.ToString();

            vald = new string[]
                {
                    idd,
                    Namn,
                    Typ,
                    akut
                };
            }
                return vald;
            
        }

        public List<Anvandare> Provdeltagarna()
        {
            string sql = "select * from anvandare where typ='Anställd' or typ='Nyanställd'";
            dr = sqlFråga(sql);

            Anvandare pd;
            List<Anvandare> pdLista = new List<Anvandare>();

            while (dr.Read())
            {
                pd = new Anvandare()
                {
                    Namn = dr["namn"].ToString(),
                    Id = (int)dr["id"]
                };

                pdLista.Add(pd);
            }
            return pdLista;

        }







        //Metod som returnerar en lista med de personer som ska skriva licensieringstestet (val 1)
        public List<Anvandare>Del1()
        {
            string sql = "select * from anvandare where typ='Nyanställd'";
            dr = sqlFråga(sql);

            Anvandare prl;
            List<Anvandare> prLista = new List<Anvandare>();

            while(dr.Read())
            {
                prl = new Anvandare()
                {
                    Namn = dr["namn"].ToString()
                };

                prLista.Add(prl);
            }
            return prLista;
        }

        //Metod som returnerar en lista med de personer som ska göra åku-test (val 2)
        public List<Anvandare>Del2()
        {
            string sql = "select * from anvandare where aku='false' and typ='Anställd'";
            dr = sqlFråga(sql);

            Anvandare praku;
            List<Anvandare> prAkuLista = new List<Anvandare>();

            while(dr.Read())
            {
                praku = new Anvandare()
                {
                    Namn = dr["namn"].ToString()
                };

                prAkuLista.Add(praku);
            }
            return prAkuLista;
        }

        public List<Provresultat> hämtaResultat(int valdPerson)
    {
        string sql = "select * from test t"
            + " where t.anvandare_id = '" + valdPerson + "'"
            + " order by test_id desc"
            + " limit 1";
        dr = sqlFråga(sql);

        Provresultat resultatet;
        List<Provresultat> resultatlista = new List<Provresultat>();

        while (dr.Read())
        {
            resultatet = new Provresultat()
            {
                test_typ = dr["test_typ"].ToString(),
                godkand = (bool)dr["godkand"],
                resultat_totalt = dr["resultat_totalt"].ToString(),
                datum = (DateTime)dr["datum"],
                resultat_produkter = dr["resultat_produkter"].ToString(),
                resultat_ekonomi = dr["resultat_ekonomi"].ToString(),
                resultat_etik = dr["resultat_etik"].ToString()
                
            };

            resultatlista.Add(resultatet);
        }
        return resultatlista;
    }

        public void RegistreraProv(string test_typ, bool godkand, string resultat_totalt, DateTime datum, int anvandare_id, string resultat_produkter, string resultat_ekonomi, string resultat_etik )
        {
            string sql = "insert into test (test_typ, godkand, resultat_totalt, datum, anvandare_id, resultat_produkter, resultat_ekonomi, resultat_etik)"
                + " values (@test_typ, @godkand, @resultat_totalt, @datum, @anvandare_id, @resultat_produkter, @resultat_ekonomi, @resultat_etik)";

            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@test_typ", test_typ);
            cmd.Parameters.AddWithValue("@godkand", godkand);
            cmd.Parameters.AddWithValue("@resultat_totalt", resultat_totalt);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@anvandare_id", anvandare_id);
            cmd.Parameters.AddWithValue("@resultat_produkter", resultat_produkter);
            cmd.Parameters.AddWithValue("@resultat_ekonomi", resultat_ekonomi);
            cmd.Parameters.AddWithValue("@resultat_etik", resultat_etik);
            cmd.ExecuteNonQuery();
        }

        public void andraBehorighet(int aID)
        {
            string sql = "update anvandare set"
            + " typ = 'Anställd' where id = @aID";
            

            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@aID", aID);
            

            cmd.ExecuteNonQuery();
        }

        public void akuGodkand(int aID)
        {
            string sql = "update anvandare set"
            + " aku = 'true' where id = @aID";


            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@aID", aID);


            cmd.ExecuteNonQuery();
        }

        public void aterstallAku()
        {
            string sql = "update anvandare set aku='false'";


            cmd = new NpgsqlCommand(sql, conn);
            


            cmd.ExecuteNonQuery();
        }
    }
}