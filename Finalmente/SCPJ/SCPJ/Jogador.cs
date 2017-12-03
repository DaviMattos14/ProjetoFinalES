using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPJ
{
    class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Rota1 { get; set; }
        public string Rota2 { get; set; }
        
        public string Logar(string nome, string senha)
        {
            string entrar = "";
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT Id, Senha FROM Jogador WHERE Nome = @nome"
            };
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Connection.Open();
            MySqlDataReader jogador = cmd.ExecuteReader();
            if (jogador.HasRows)
            {
                while (jogador.Read())
                {
                    int Id = jogador.GetInt32(0);
                    Senha = jogador.GetString(1);
                }
            }
            cmd.Connection.Close();
            entrar = Senha;
            return entrar;
        }

       

        
    }
}
