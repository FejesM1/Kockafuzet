using KockasFuzet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Controller
{
    internal class SzamlaController
    {
        public List<Szamla> GetSzamlaList()
        {
            MySqlConnection conn = new MySqlConnection();
            string connStr = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            conn.ConnectionString = connStr;
            conn.Open();
            string sql = "SELECT * FROM szamla";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            List<Szamla> eredmenyek = new List<Szamla>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Szamla sz = new Szamla()
                {
                    Id = reader.GetInt32("Id"),
                    Szolgaltatasazon = reader.GetInt32("SzolgaltatasAzon"),
                    Szolgaltatorovid = reader.GetString("SzolgaltatoRovid"),
                    Tol = reader.GetDateTime("Tol"),
                    Ig = reader.GetDateTime("Ig"),
                    Osszeg = reader.GetInt32("Osszeg"),
                    Hatarido = reader.GetDateTime("Hatarido"),
                    Befizetve = reader.GetDateTime("Befizetve"),
                    Megjegyzes = reader.GetString("Megjegyzes")
                };

                eredmenyek.Add(sz);
            }
            conn.Close();
            return eredmenyek;
        }
    }
}
