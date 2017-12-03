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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            new CadastroJogador().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Jogador j = new Jogador();
                if (j.Logar(txtNome.Text, txtSenha.Text) == txtSenha.Text)
                {
                    Menu menu = new Menu(txtNome.Text);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome e/ou Senha Incorretos");
                    txtNome.Clear();
                    txtSenha.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nome e/ou Senha Incorretos");
            }
            
            

            //    try
            //    {
            //        MySqlCommand cmd = new MySqlCommand()
            //        {
            //            Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
            //            CommandText = "SELECT Senha FROM Jogador WHERE Nome = @nome"
            //        };

            //        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            //        cmd.Connection.Open();
            //        MySqlDataReader entrar = cmd.ExecuteReader();

            //        if (entrar.HasRows)
            //        {
            //            while (entrar.Read())
            //            {
            //                string logar = entrar.GetString(0);
            //                if (logar == txtSenha.Text)
            //                {
            //                    new Menu().Show();
            //                    this.Hide();
            //                }
            //                else { MessageBox.Show("Nome e/ou Senha Incorretos"); }
            //            }
            //        }
            //        else { MessageBox.Show("Nome e/ou Senha Incorretos"); }
            //        cmd.Connection.Close();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Nome e/ou Senha Incorretos");
            //    }
            //}


        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
