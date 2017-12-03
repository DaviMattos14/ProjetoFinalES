using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPJ
{
   public class Composicao
    {
        public int Id { get; set; }
        public string EstiloComp { get; set; }
        public string Topo { get; set; }
        public string Selva { get; set; }
        public string Meio { get; set; }
        public string Atirador { get; set; }
        public string Suporte { get; set; }
        public string Counter1 { get; set; }
        public string Counter2 { get; set; }
        public string Counter3 { get; set; }

        public List<string> NomeComp()
        {
            List<string> EstiloComp = new List<string>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT DISTINCT Estilo FROM Composicao"
            };

            cmd.Connection.Open();
            MySqlDataReader comp = cmd.ExecuteReader();
            if (comp.HasRows)
            {
                while (comp.Read())
                {
                    string nome = comp.GetString(0);
                    EstiloComp.Add(nome);
                }
            }
            cmd.Connection.Close();
            return EstiloComp;
        }
    }
    
}
