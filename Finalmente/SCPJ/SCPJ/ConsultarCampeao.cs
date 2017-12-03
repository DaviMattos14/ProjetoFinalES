using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCPJ
{
    public partial class ConsultarCampeao : Form
    {
        public int idcad;
        public ConsultarCampeao(int id)
        {
            idcad = id;
            InitializeComponent();
            cbNomes.Items.Add("");
            Campeoes c = new Campeoes();
            foreach (string nome in c.Nomes())
            {
                cbNomes.Items.Add(nome);
            }
            cbRota.Items.Add("");
            cbRota.Items.Add("Topo");
            cbRota.Items.Add("Selva");
            cbRota.Items.Add("Meio");
            cbRota.Items.Add("Atirador");
            cbRota.Items.Add("Suporte");

            cbClasse.Items.Add("");
            cbClasse.Items.Add("Lutador");
            cbClasse.Items.Add("Tanque");
            cbClasse.Items.Add("Assasino");
            cbClasse.Items.Add("Mago");
            cbClasse.Items.Add("Atirador");

            List<Campeoes> TodosChamps = TodosChamp();
            dgCampeoes.DataSource = TodosChamp();
        }

        private void ConsultarCampeao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu(idcad).Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(cbNomes.Text != "")
            {
                List<Campeoes> campeoes = ConsultaN(cbNomes.Text);
                dgCampeoes.DataSource = campeoes;
            }
            if(cbRota.Text != "")
            {
                List<Campeoes> campeoes = ConsultaR(cbRota.Text);
                dgCampeoes.DataSource = campeoes;
            }
            if (cbClasse.Text != "")
            {
                List<Campeoes> campeoes = ConsultaC(cbClasse.Text);
                dgCampeoes.DataSource = campeoes;
            }
            

        }
        
        public List<Campeoes> ConsultaN(string nome)
        {
            List<Campeoes> campeoes = new List<Campeoes>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Campeoes WHERE Nome = @nome"
            };
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Connection.Open();
            MySqlDataReader champs = cmd.ExecuteReader();
            if (champs.HasRows)
            {
                while (champs.Read())
                {
                    Campeoes c = new Campeoes();
                    c.Id = champs.GetInt32(0);
                    c.Nome = champs.GetString(1);
                    c.Classe = champs.GetString(2);
                    c.RotaPrimaria = champs.GetString(3);
                    c.RotaSecundaria = champs.GetString(4);
                    c.Counter = champs.GetInt32(5);
                    c.Comba = champs.GetInt32(6);
                    campeoes.Add(c);
                }
            }
            cmd.Connection.Close();
            return campeoes;
        }
        public List<Campeoes> ConsultaR(string rota)
        {
            List<Campeoes> campeoes = new List<Campeoes>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Campeoes WHERE RotaChamp = @rotachamp OR RotaSec = @rotasec"
            };
            cmd.Parameters.AddWithValue("@rotachamp", rota);
            cmd.Parameters.AddWithValue("@rotasec", rota);
            cmd.Connection.Open();
            MySqlDataReader champs = cmd.ExecuteReader();
            if (champs.HasRows)
            {
                while (champs.Read())
                {
                    Campeoes c = new Campeoes();
                    c.Id = champs.GetInt32(0);
                    c.Nome = champs.GetString(1);
                    c.Classe = champs.GetString(2);
                    c.RotaPrimaria = champs.GetString(3);
                    c.RotaSecundaria = champs.GetString(4);
                    c.Counter = champs.GetInt32(5);
                    c.Comba = champs.GetInt32(6);
                    campeoes.Add(c);
                }
            }
            cmd.Connection.Close();
            return campeoes;
        }

        public List<Campeoes> ConsultaC(string classe)
        {
            List<Campeoes> campeoes = new List<Campeoes>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Campeoes WHERE Classe = @classe"
            };
            cmd.Parameters.AddWithValue("@classe", classe);
            cmd.Connection.Open();
            MySqlDataReader champs = cmd.ExecuteReader();
            if (champs.HasRows)
            {
                while (champs.Read())
                {
                    Campeoes c = new Campeoes();
                    c.Id = champs.GetInt32(0);
                    c.Nome = champs.GetString(1);
                    c.Classe = champs.GetString(2);
                    c.RotaPrimaria = champs.GetString(3);
                    c.RotaSecundaria = champs.GetString(4);
                    c.Counter = champs.GetInt32(5);
                    c.Comba = champs.GetInt32(6);
                    campeoes.Add(c);
                }
            }
            cmd.Connection.Close();
            return campeoes;
        }

        public List<Campeoes> TodosChamp()
        {
            List<Campeoes> campeoes = new List<Campeoes>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Campeoes"
            };
            cmd.Connection.Open();
            MySqlDataReader champs = cmd.ExecuteReader();
            if (champs.HasRows)
            {
                while (champs.Read())
                {
                    Campeoes c = new Campeoes();
                    c.Id = champs.GetInt32(0);
                    c.Nome = champs.GetString(1);
                    c.Classe = champs.GetString(2);
                    c.RotaPrimaria = champs.GetString(3);
                    c.RotaSecundaria = champs.GetString(4);
                    c.Counter = champs.GetInt32(5);
                    c.Comba = champs.GetInt32(6);
                    campeoes.Add(c);
                }
            }
            cmd.Connection.Close();
            return campeoes;
        }

        private void dgCampeoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public List<string> Nomes()
        //{
        //    List<string> nomes = new List<string>();
        //    MySqlCommand cmd = new MySqlCommand()
        //    {
        //        Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
        //        CommandText = "SELECT Nome FROM Campeoes"
        //    };

        //    cmd.Connection.Open();
        //    MySqlDataReader champ = cmd.ExecuteReader();
        //    if (champ.HasRows)
        //    {
        //        while (champ.Read())
        //        {
        //            string nome = champ.GetString(0);
        //            nomes.Add(nome);
        //        }
        //    }
        //    cmd.Connection.Close();
        //    return nomes;
        //}
    }
}
