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
    public partial class Menu : Form 
    {
        public int idJogadorLogado;
        public string jogador;
        public Menu(int id)
        {
            InitializeComponent();
           lblID.Text = Convert.ToString(id);
            idJogadorLogado = Convert.ToInt32(lblID.Text);
        }
        public Menu(string valor)
        {
            InitializeComponent();
            jogador = valor;
           lblID.Text = Convert.ToString(PegaId(valor));
        }
        public Menu(int id, string nick)
        {
            InitializeComponent();
            lblID.Text = Convert.ToString(id);
            idJogadorLogado = Convert.ToInt32(lblID.Text);
            jogador = nick;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroCampeao(idJogadorLogado).Show();
            this.Hide();
        }

        private void btnConsultarCamp_Click(object sender, EventArgs e)
        {
            new ConsultarCampeao(idJogadorLogado).Show();
            this.Hide();
        }

        private void btnCadastrarComp_Click(object sender, EventArgs e)
        {
            new CadastroComposicao(idJogadorLogado).Show();
            this.Hide();
        }

        private void btnConsultarComp_Click(object sender, EventArgs e)
        {
            new ConsultaComp(idJogadorLogado).Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AlterarDados(idJogadorLogado, jogador).Show();
            this.Hide();
        }

        public int PegaId(string nome)
        {
            int Id = 0;
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT Id FROM Jogador WHERE Nome = @nome"
            };
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Connection.Open();
            MySqlDataReader jogador = cmd.ExecuteReader();
            if (jogador.HasRows)
            {
                while (jogador.Read())
                {
                    Id = jogador.GetInt32(0);
                    idJogadorLogado = Id;
                }
            }
            cmd.Connection.Close();
            return Id;
        }
    }
}
