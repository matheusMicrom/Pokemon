using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormPokemons : Form
    {
        Pokemon pk = new Pokemon();
        public FormPokemons()
        {
            InitializeComponent();
        }
        private string PriMaiusc(string texto)
        {
            string FirstUpper = texto[0].ToString().ToUpper();
            return FirstUpper + texto.Substring(1);
        }

        private void MostraNoDataGrid(List<Pokemon> pokes)
        {
            // Limpa o que existe no data grid view
            dataGridView1.DataSource = null;
            // Mostra o que tem no list no dataGridView
            dataGridView1.DataSource = pokes;

            // For para mostrar as colunas de editar e excluir
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Visualizar";                  
                dataGridView1.Rows[i].Cells[1].Value = "Editar";
                dataGridView1.Rows[i].Cells[2].Value = "Excluir";

            }
            dataGridView1.ClearSelection();

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Abre o form Cadastrar pokemons
            FormPokemonsCadastro cadPokes = new FormPokemonsCadastro();
            cadPokes.StartPosition = FormStartPosition.CenterScreen;
            cadPokes.ShowDialog();
        }
        private void recarrega()
        {

            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex = pk.criaPokedex();
            // Entra se o arquivo tiver mais de 0 linhas
            if (pokedex.Count > 0)
            {
                MostraNoDataGrid(pokedex);
            }
        }
        private void FormPokemons_Load(object sender, EventArgs e)
        { // id, nome, imagem, evolucao, altura, peso, efeito, forca ordem
            recarrega();
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;          
        }
        
        // acha id

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            // Pega o ID da linha para excluir ou editar
            object id = dataGridView1.Rows[Convert.ToInt32(dataGridView1.CurrentCell.RowIndex)].Cells[3].Value;
            int linha = pk.PesquisaPeloID(Convert.ToInt32(id));
            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex = pk.criaPokedex();
            // identifica quando clicar na coluna 0 aonde se encontra todos os botôes de Editar e na coluna 1 aoinde se encontra todos os botôes de Excluir
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
            {
                FormVisualizar fv = new FormVisualizar(Convert.ToInt32(id));
                fv.ShowDialog();

            }
            
            else if (dataGridView1.CurrentCell.ColumnIndex.Equals(2))
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Excluir linha", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {

                        pk.excluirLinha(linha);
                        File.Delete(@"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg");
                        
                        recarrega();                    
                }
            }
            else if (dataGridView1.CurrentCell.ColumnIndex.Equals(1))
            {
                FormEditarPokes fep = new FormEditarPokes(Convert.ToInt32(id));
                fep.ShowDialog();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id nome forca efeito peso altura

            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex = pk.criaPokedex();

            switch (comboBoxOrdenar.SelectedIndex)
            {
                case 0:
                    pokedex.Sort((f1, f2) => f1.Id.CompareTo(f2.Id));
                    break;
                case 1:
                    pokedex.Sort((f1, f2) => f1.Nome.CompareTo(f2.Nome));
                    break;
                case 2:
                    pokedex.Sort((f1, f2) => f1.Forca.CompareTo(f2.Forca));
                    break;

                case 3:
                    pokedex.Sort((f1, f2) => f1.Efeito.CompareTo(f2.Efeito));
                    break;

                case 4:
                    pokedex.Sort((f1, f2) => f1.Peso.CompareTo(f2.Peso));
                    break;

                case 5:
                    pokedex.Sort((f1, f2) => f1.Altura.CompareTo(f2.Altura));
                    break;
                case 6:
                    pokedex.Sort((f1, f2) => f1.Nome_Evolucao.CompareTo(f2.Nome_Evolucao));
                    break;

                default:
                    break;
            }
            MostraNoDataGrid(pokedex);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            List<Pokemon> Pokedex = new List<Pokemon>();
            Pokedex = pk.criaPokedex();
            string TxtPesquisa = txtbPesquisa.Text.ToUpper();
            List<Pokemon> resultado = new List<Pokemon>();


            if (string.IsNullOrEmpty(TxtPesquisa))
            {
                MessageBox.Show("Campos em branco!", "Falha ao pesquisar");
            }
            else
            {
                for (int i = 0; i < Pokedex.Count(); i++)
                {
                    if (Pokedex[i].Id.ToString() == TxtPesquisa || Pokedex[i].Nome.ToUpper() == TxtPesquisa || Pokedex[i].Imagem.ToUpper() == TxtPesquisa ||
                        Pokedex[i].Altura.ToString() == TxtPesquisa || Pokedex[i].Peso.ToString() == TxtPesquisa ||
                        Pokedex[i].Efeito.ToString() == TxtPesquisa || Pokedex[i].Forca.ToString() == TxtPesquisa)
                    {
                        resultado.Add(new Pokemon(Pokedex[i].Id, Pokedex[i].Nome, Pokedex[i].Imagem, Pokedex[i].Nome_Evolucao, Pokedex[i].Altura, Pokedex[i].Peso, Convert.ToInt32(Pokedex[i].Efeito),
                            Pokedex[i].Forca));
                    }
                }
                if (resultado.Count <= 0)
                {
                    MessageBox.Show("Nenhum resultado encontrado!");
                }
                MostraNoDataGrid(resultado);
            }
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex = pk.criaPokedex();
            MostraNoDataGrid(pokedex);
            txtbPesquisa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPokemonsCadastro fpc = new FormPokemonsCadastro();
            fpc.ShowDialog();
        }
    }
}