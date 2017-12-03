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
    public partial class CadastroCampeao : Form
    {
        public int idCad = 0;
        public CadastroCampeao(int id)
        {
            idCad = id;
            InitializeComponent();
            idCad = id;
            Campeoes c = new Campeoes();
            foreach (string nome in c.Nomes())
            {
                cbNome1.Items.Add(nome);
                cbNome2.Items.Add(nome);
                cbNome3.Items.Add(nome);
            }
            cbRota1.Items.Add("");
            cbRota1.Items.Add("Topo");
            cbRota1.Items.Add("Selva");
            cbRota1.Items.Add("Meio");
            cbRota1.Items.Add("Atirador");
            cbRota1.Items.Add("Suporte");

            cbRota2.Items.Add("");
            cbRota2.Items.Add("Topo");
            cbRota2.Items.Add("Selva");
            cbRota2.Items.Add("Meio");
            cbRota2.Items.Add("Atirador");
            cbRota2.Items.Add("Suporte");

            cbRota3.Items.Add("");
            cbRota3.Items.Add("Topo");
            cbRota3.Items.Add("Selva");
            cbRota3.Items.Add("Meio");
            cbRota3.Items.Add("Atirador");
            cbRota3.Items.Add("Suporte");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu(idCad).Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "INSERT INTO ChampsFav (IdJOgador, NomeChamp1, RotaChamp1, NomeChamp2, RotaChamp2, NomeChamp3, RotaChamp3) VALUES (@idjogador, @nomechamp1, @rotachamp1, @nomechamp2, @rotachamp2, @nomechamp3, @rotachamp3)"
            };
            cmd.Parameters.AddWithValue("@idjogador", idCad);
            cmd.Parameters.AddWithValue("@nomechamp1",cbNome1.Text);
            cmd.Parameters.AddWithValue("@rotachamp1", cbRota1.Text);
            cmd.Parameters.AddWithValue("@nomechamp2",cbNome2.Text);
            cmd.Parameters.AddWithValue("@rotachamp2",cbRota2.Text);
            cmd.Parameters.AddWithValue("@NomeChamp3",cbNome3.Text);
            cmd.Parameters.AddWithValue("@rotachamp3",cbRota3.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            MessageBox.Show("Campeões Favoritos Cadastrados com Sucesso!");
        }
    }
}
