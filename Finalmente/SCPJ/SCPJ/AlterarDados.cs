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
    public partial class AlterarDados : Form
    {
        public int idcad;
        public string nomeJogador;
        public AlterarDados(int id, string nome)
        {
            idcad = id;
            nomeJogador = nome;
            InitializeComponent();
            cbNewRota1.Items.Add("Topo");
            cbNewRota1.Items.Add("Selva");
            cbNewRota1.Items.Add("Meio");
            cbNewRota1.Items.Add("Atirador");
            cbNewRota1.Items.Add("Suporte");

            cbNewRota2.Items.Add("Topo");
            cbNewRota2.Items.Add("Selva");
            cbNewRota2.Items.Add("Meio");
            cbNewRota2.Items.Add("Atirador");
            cbNewRota2.Items.Add("Suporte");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu(idcad, nomeJogador).Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
               Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
               CommandText = "SELECT * FROM Jogador WHERE Nome = @nome"
            };
            //cmd.Parameters.AddWithValue("@nome", txtNick.Text);
            //cmd.Connection.Open();
            //MySqlDataReader verificar = cmd.ExecuteReader();
            //if (verificar.HasRows && txtNick.Text != nomeJogador)
            //{
            //    cmd.Connection.Close();
            //    MessageBox.Show("Invocador já Cadastrado");
            //}
            //else
            //{
               // try
                //{
                  //  cmd.Connection.Close();
                    if (txtNewSenha.Text == txtConfirNewSenha.Text && cbNewRota1.Text != cbNewRota2.Text)
                    {
                        cmd.CommandText = "UPDATE Jogador SET Senha = @senha, Rota1 = @rota1,  Rota2 = @rota2 WHERE Id = @id";
                        cmd.Parameters.AddWithValue("@id", idcad);
                        cmd.Parameters.AddWithValue("@senha", txtNewSenha.Text);
                        cmd.Parameters.AddWithValue("@rota1", cbNewRota1.Text);
                        cmd.Parameters.AddWithValue("@rota2", cbNewRota2.Text);

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();

                        MessageBox.Show("Alterações Salvas com Sucesso!");
                        new Login().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senhas e/ou Rotas Incorretas");
                    }
                    //if (txtNick.Text != nomeJogador && txtNewSenha.Text == txtConfirNewSenha.Text && cbNewRota1.Text != cbNewRota2.Text)
                    //{
                    //    cmd.CommandText = "UPDATE Jogador SET Nome = @nome, Senha = @senha, Rota1 = @rota1,  Rota2 = @rota2 WHERE Id = @id";
                    //    cmd.Parameters.AddWithValue("@id", idcad);
                    //    cmd.Parameters.AddWithValue("@nome", txtNick.Text);
                    //    cmd.Parameters.AddWithValue("@senha", txtNewSenha.Text);
                    //    cmd.Parameters.AddWithValue("@rota1", cbNewRota1.Text);
                    //    cmd.Parameters.AddWithValue("@rota2", cbNewRota2.Text);

                    //    cmd.Connection.Open();
                    //    cmd.ExecuteNonQuery();
                    //    cmd.Connection.Close();

                    //    MessageBox.Show("Alterações Salvas com Sucesso!");

                    //}
                //}
                //catch
                //{
                //    MessageBox.Show("Senhas e/ou Rotas Incorretas");
                //}

            //}
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "DELETE FROM Jogador WHERE Id = @id"
            };
            cmd.Parameters.AddWithValue("@id", idcad);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Conta Excluida Com Sucesso!");
            new Login().Show();
            this.Hide();
        }
    }
}
