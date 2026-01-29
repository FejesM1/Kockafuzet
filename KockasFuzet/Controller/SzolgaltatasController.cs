using KockasFuzet.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockasFuzet.Controller
{
    internal class SzolgaltatasController
    {
        public List<Szolgaltatas> GetSzolgaltatasList()
        {
            MySqlConnection conn = new MySqlConnection();
            string connStr = "SERVER=localhost;DATABASE=kockasfuzet;UID=root;PASSWORD=;";
            conn.ConnectionString = connStr;
            conn.Open();
            string sql = "SELECT * FROM szolgaltatas";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            List<Szolgaltatas> eredmenyek = new List<Szolgaltatas>();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Szolgaltatas sz = new Szolgaltatas()
                {
                    Id = reader.GetInt32("Id"),
                    Nev = reader.GetString("Nev"),
                };
                eredmenyek.Add(sz);
            }
            conn.Close();
            return eredmenyek;
        }
    }
}
