using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KockasFuzet.Models;

namespace KockasFuzet.Controller
{
    internal class SzolgaltatoController
    {
        public List<Szolgaltato> GetSzolgaltatoList()
        {
            MySqlConnection conn = new MySqlConnection();
            string connStr = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            conn.ConnectionString = connStr;
            conn.Open();
            string sql = "SELECT * FROM szolgaltato";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            List<Szolgaltato> eredmeny = new List<Szolgaltato>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Szolgaltato sz = new Szolgaltato()
                {
                    Rovidnev = reader.GetString("Rovidnev"),
                    Nev = reader.GetString("Nev"),
                    Ugyfelszolgalat = reader.GetString("Ugyfelszolgalat")
                };
                eredmeny.Add(sz);
            }
            conn.Close();
            return eredmeny;
        }
    }
}
