using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPJ
{
    public class Campeoes
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string RotaPrimaria { get; set; }
        public string RotaSecundaria { get; set; }
        public int Counter { get; set; }
        public int Comba { get; set; }

        public List<string> Nomes()
        {
            List<string> nomes = new List<string>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT Nome FROM Campeoes"
            };

            cmd.Connection.Open();
            MySqlDataReader champ = cmd.ExecuteReader();
            if (champ.HasRows)
            {
                while (champ.Read())
                {
                    string nome = champ.GetString(0);
                    nomes.Add(nome);
                }
            }
            cmd.Connection.Close();
            return nomes;
        }
    }
}
