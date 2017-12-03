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
    public partial class CadastroComposicao : Form
    {
        public int idcad;

        public CadastroComposicao(int id)
        {
            idcad = id;
            InitializeComponent();
            Campeoes c = new Campeoes();
            foreach(string champ in c.Nomes())
            {
                cbTopo.Items.Add(champ);
                cbSelva.Items.Add(champ);
                cbMeio.Items.Add(champ);
                cbAtirador.Items.Add(champ);
                cbSuporte.Items.Add(champ);
                cbCounter1.Items.Add(champ);
                cbCounter2.Items.Add(champ);
                cbCounter3.Items.Add(champ);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu(idcad).Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "INSERT INTO Composicao (Estilo, Topo, Selva, Meio, Atirador, Suporte, Counter1, Counter2, Counter3) VALUES (@estilo, @topo, @selva, @meio, @atirador, @suporte, @counter1, @counter2, @counter3)"
            };
            cmd.Parameters.AddWithValue("@estilo", txtEstiloComp.Text);
            cmd.Parameters.AddWithValue("@topo", cbTopo.Text);
            cmd.Parameters.AddWithValue("@selva", cbSelva.Text);
            cmd.Parameters.AddWithValue("@meio", cbMeio.Text);
            cmd.Parameters.AddWithValue("@atirador", cbAtirador.Text);
            cmd.Parameters.AddWithValue("@suporte", cbSuporte.Text);
            cmd.Parameters.AddWithValue("@counter1", cbCounter1.Text);
            cmd.Parameters.AddWithValue("@counter2", cbCounter2.Text);
            cmd.Parameters.AddWithValue("@counter3", cbCounter3.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Composição Cadastrada com Sucesso!");
        }

    }
}
