using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormVisualizar : Form
    {
        int id;
        Pokemon pk = new Pokemon();
        List<Pokemon> pokedex = new List<Pokemon>();
        int linha;
        public FormVisualizar(int identificador)
        {
            InitializeComponent();
            id = identificador;
        }
        private string pesquisaEvolução()
        {
            string imgEvolucao = "";

            for (int i = 0; i < pokedex.Count; i++)
            {
                // Pega o id da posição e compará com o recebido por parametro
                if (pokedex[i].Nome.Equals(pokedex[linha].Nome_Evolucao))
                {
                    if (pokedex[i].Id.Equals(pokedex[linha].Id))
                    {
                        continue;
                    }
                    else
                    {
                        imgEvolucao = pokedex[i].Imagem;
                        break;
                    }
                }
            }
            return imgEvolucao;
        }
        private void pesquisaInfor()
        {

            pokedex = pk.criaPokedex();
            // Pesquisa a posição do ID dentro da lista de pokemons
            linha = pk.PesquisaPeloID(id);
            pictrBImgPoke.ImageLocation = pokedex[linha].Imagem;
            pictrBImgPoke.SizeMode = PictureBoxSizeMode.StretchImage;
            lblPokemon.Text = pokedex[linha].Nome;
            lblAltura.Text = pokedex[linha].Altura.ToString();
            lblEfeito.Text = pokedex[linha].Efeito.ToString();
            lblForca.Text = pokedex[linha].Forca.ToString();
            lblPeso.Text = pokedex[linha].Peso.ToString();
            lblID.Text = pokedex[linha].Id.ToString();
            lblEvoNome.Text = pokedex[linha].Nome_Evolucao;

            string imagemEvolucao = pesquisaEvolução();
            // se a string que retorna do metodo for nula ou vazia significa que
            // não foi achado uma evolução cadastrada
            // ao contrário disto quer dizer q foi achado um resultado e atribui a picturebox
            if (string.IsNullOrEmpty(imagemEvolucao))
            {
                lblEvoluNCadastrada.Visible = true;
            }else
            {
                pctrBImgEvolucao.ImageLocation = imagemEvolucao;
                pctrBImgEvolucao.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (pokedex[linha].Nome.Equals(pokedex[linha].Nome_Evolucao))
            {
                lblEvoluNCadastrada.Visible = true;
                lblEvoluNCadastrada.Text = "Pokemon não possui mais evolução";

            }

        }

        private void FormVisualizar_Load(object sender, EventArgs e)
        {
            try
            {
                pesquisaInfor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
