using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class FormEditarPokes : Form
    {
        int id;
        int linha = 0;
        Pokemon pk = new Pokemon();
        List<Pokemon> pokedex = new List<Pokemon>();
        public FormEditarPokes(int identficador)
        {
            InitializeComponent();
            id = identficador;
            pesquisaInfor();
            
        }
        private string PriMaiusc(string texto)
        {
            string FirstUpper = texto[0].ToString().ToUpper();
            return FirstUpper + texto.Substring(1);
        }
        private void copiarImgs()
        {
            if (txtbImg.Text != @"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg")
            {
                // Move a imagem da onde ela esteja para a pasta de imagens pokemons
                // Nome padrão das imagem é dado pelo ID, assim como o formato padrão é .jpg  
                File.Copy(txtbImg.Text, @"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg", true);
            }
            

        }
        private void validaCampos()
        {
            // Verifica se o campo esta vazio ou nulo
            if (string.IsNullOrEmpty(txtbNome.Text.Trim()))
            {
                throw new ArgumentException("Campo nome em branco");
            }
            // Verifica se o campo esta vazio
            if (string.IsNullOrEmpty(txtbImg.Text.Trim()))
            {
                throw new ArgumentException("Escolha uma imagem para o pokemon");
            }
            // Verifica se o campo esta vazio
            if (string.IsNullOrEmpty(txtbEvolu.Text.Trim()))
            {
                // Um pokemons pode não ter uma evolução, sendo assim é possivel que não se cadastre uma evolução.
                // Se o pokemon tiver uma evolução será obrigatório o preenchimento,
                // Caso contrário a imagem da evolução do pokemon será a mesma imagem do campo pokemon
                DialogResult dr = MessageBox.Show("Pokemon não possui evolução?", "Evolução pokemon", MessageBoxButtons.YesNo);
                if (dr.Equals(DialogResult.Yes))
                {
                    throw new ArgumentException("Digite o nome da evolução");
                }
                else
                {
                    txtbEvolu.Text = txtbNome.Text;
                    throw new ArgumentException("Nome da evolução do pokemon será igual ao nome do pokemon");
                }
            }
            // Verifica se o campo altura esta vazio ou o valor seja menor que 0
            if ((double)nudAltura.Value <= 0.00)
            {
                throw new ArgumentException("Digite uma valor válida para altura");
            }
            // Verifica se o campo altura esta vazio ou o valor seja menor que 0
            if ((double)nudPeso.Value <= 0.00)
            {
                throw new ArgumentException("Digite uma valor válida para peso");
            }
        }
        private void pesquisaInfor()
        {
            
            pokedex = pk.criaPokedex();            
            // Pesquisa a posição do ID dentro da lista de pokemons
            linha = pk.PesquisaPeloID(id);

            // Atribui informações a achada combase no id na tela 
            nudID.Value = pokedex[linha].Id;
            txtbNome.Text = pokedex[linha].Nome;
            txtbImg.Text = pokedex[linha].Imagem;
            txtbEvolu.Text = pokedex[linha].Nome_Evolucao;
            nudAltura.Value = Convert.ToDecimal(pokedex[linha].Altura);
            nudPeso.Value = Convert.ToDecimal(pokedex[linha].Peso);
            nudEfeito.Value = Convert.ToDecimal(pokedex[linha].Efeito);
            NudForca.Value = Convert.ToDecimal(pokedex[linha].Forca);


        }
        private void Salvar()
        {
            pokedex = pk.criaPokedex();

            if (nudID.Value == pokedex[linha].Id &&
                txtbNome.Text == pokedex[linha].Nome &&
                txtbImg.Text == pokedex[linha].Imagem &&
                txtbEvolu.Text == pokedex[linha].Nome_Evolucao &&
                nudAltura.Value == Convert.ToDecimal(pokedex[linha].Altura) &&
                nudPeso.Value == Convert.ToDecimal(pokedex[linha].Peso) &&
                nudEfeito.Value == Convert.ToDecimal(pokedex[linha].Efeito) &&
                NudForca.Value == Convert.ToDecimal(pokedex[linha].Forca))
            {
                Close();
            }
            else
            {
                pk.salvaEditado((int)nudID.Value, PriMaiusc(txtbNome.Text).TrimStart().TrimEnd(), @"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg", PriMaiusc(txtbEvolu.Text).TrimStart().TrimEnd(), (double)nudAltura.Value, (double)nudPeso.Value, linha);
                Close();
            }
        } 
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                validaCampos();                
                Salvar();
                copiarImgs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbImg.Clear();
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            // Caixa de diálogo para abrir a imagem
            OpenFileDialog ofdImg = new OpenFileDialog();
            // se ele clicar em ok dentro da caia de diálogo 
            // atribui o caminho da imagem ao campo de texto
            if (ofdImg.ShowDialog() == DialogResult.OK)
            {
                txtbImg.Text = ofdImg.FileName;
            }
        }
    }

}
    