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
    public partial class CadastroJogador : Form
    {
        public CadastroJogador()
        {
            InitializeComponent();
            cbRota1.Items.Add("TOPO");
            cbRota1.Items.Add("SELVA");
            cbRota1.Items.Add("MEIO");
            cbRota1.Items.Add("ATIRADOR");
            cbRota1.Items.Add("SUPORTE");

            cbRota2.Items.Add("TOPO");
            cbRota2.Items.Add("SELVA");
            cbRota2.Items.Add("MEIO");
            cbRota2.Items.Add("ATIRADOR");
            cbRota2.Items.Add("SUPORTE");

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                    CommandText = "SELECT * FROM Jogador WHERE Nome = @nome"
                };
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Connection.Open();
                MySqlDataReader jogadores = cmd.ExecuteReader();
                if (jogadores.HasRows)
                {
                    cmd.Connection.Close();
                    MessageBox.Show("Invocador já Cadastrado");
                }
                else
                {
                    if (txtSenha == txtConfirSenha || cbRota1.Text != cbRota2.Text)
                    {
                        cmd.Connection.Close();
                        cmd.CommandText = "INSERT INTO Jogador (Nome, Senha, Rota1, Rota2) VALUE (@nome, @senha, @rota1, @rota2)";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                        cmd.Parameters.AddWithValue("@rota1", cbRota1.Text);
                        cmd.Parameters.AddWithValue("@rota2", cbRota2.Text);

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        MessageBox.Show("Cadastro Concluido com Sucesso!");
                        new Login().Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Senhas e/ou Rotas Incorretas");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Senhas e/ou Rotas Incorretas");
            }


            
            

            
        }
    }
}
