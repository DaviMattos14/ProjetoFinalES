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
    public partial class ConsultaComp : Form
    {
        public int idcad;
        public ConsultaComp(int id)
        {
            idcad = id;
            InitializeComponent();
            Composicao c = new Composicao();
            foreach(string nome in c.NomeComp())
            {
                cbEstiloComp.Items.Add(nome);
            }
            List<Composicao> comps = TodasComp();
            dataTableComp.DataSource = comps;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Menu(idcad).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Composicao> comps = ListaComp(cbEstiloComp.Text);
            dataTableComp.DataSource = comps;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public List<Composicao> ListaComp(string nome)
        {
            List<Composicao> comps = new List<Composicao>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Composicao Where Estilo = @estilo"
            };
            cmd.Parameters.AddWithValue("@estilo", nome);
            cmd.Connection.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if(result.HasRows)
            {
                while(result.Read())
                {
                    Composicao c = new Composicao();
                    c.Id = result.GetInt32(0);
                    c.EstiloComp = result.GetString(1);
                    c.Topo = result.GetString(2);
                    c.Selva = result.GetString(3);
                    c.Meio = result.GetString(4);
                    c.Atirador = result.GetString(5);
                    c.Suporte = result.GetString(6);
                    c.Counter1 = result.GetString(7);
                    c.Counter2 = result.GetString(8);
                    c.Counter3 = result.GetString(9);
                    comps.Add(c);
                }
            }
            cmd.Connection.Close();
            return comps;
        }
        public List<Composicao> TodasComp()
        {
            List<Composicao> comps = new List<Composicao>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "SELECT * FROM Composicao"
            };
            cmd.Connection.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Composicao c = new Composicao();
                    c.Id = result.GetInt32(0);
                    c.EstiloComp = result.GetString(1);
                    c.Topo = result.GetString(2);
                    c.Selva = result.GetString(3);
                    c.Meio = result.GetString(4);
                    c.Atirador = result.GetString(5);
                    c.Suporte = result.GetString(6);
                    c.Counter1 = result.GetString(7);
                    c.Counter2 = result.GetString(8);
                    c.Counter3 = result.GetString(9);
                    comps.Add(c);
                }
            }
            cmd.Connection.Close();
            return comps;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=scpj;Uid=root;Pwd="),
                CommandText = "DELETE FROM Composicao WHERE Id = @id"
            };
            cmd.Parameters.AddWithValue("@id", txtExcluir.Text);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            MessageBox.Show("Composição Excluida com Sucesso!");
        }

        private void dataTableComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
