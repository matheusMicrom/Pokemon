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
    public partial class FormPokemonsCadastro : Form
    {
        Pokemon pk = new Pokemon();
        int id = 0;
        public FormPokemonsCadastro()
        {
            InitializeComponent();
        }
        private void copiarImgs()
        {
            // Move a imagem da onde ela esteja para a pasta de imagens pokemons
            // Nome padrão das imagem é dado pelo ID, assim como o formato padrão é .jpg  
            File.Copy(txtbImg.Text, @"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg");            
            
        }
        private string PriMaiusc(string texto)
        {
            string FirstUpper = texto[0].ToString().ToUpper();
            return FirstUpper + texto.Substring(1);
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
                DialogResult dr = MessageBox.Show("Pokemon não possui evolução?","Evolução pokemon", MessageBoxButtons.YesNo);
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
        // Método para cadastrar pokemon no txt
        private void cadastro()
        {// Ordem em que as informações devem ser guardadas no arquivo TXT:
         // id, nome, imagem, evolucao, altura, peso, efeito, forca
            id = pk.valorId();
            int efeito = pk.calcEfeito();
            double Forca = pk.calcforca((double)nudAltura.Value, (double)nudPeso.Value, efeito);
            // String que será salva no arquivo txt, enviar ao método gravaPokemons uma string já formatada
            pk.gravaPokemons(
                (
                id + ";"
                + PriMaiusc(txtbNome.Text).TrimStart().TrimEnd() + ";"
                + @"..\..\..\imagens\pokemons\" + id.ToString() + ".jpg" + ";"
                + PriMaiusc(txtbEvolu.Text).TrimStart().TrimEnd() + ";"
                + (double)nudAltura.Value + ";"
                + (double)nudPeso.Value + ";" 
                + efeito + ";"
                + Convert.ToInt32(Forca)
                ).ToString()
                );           
            
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                validaCampos();
                cadastro();
                copiarImgs();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
           
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

        private void btnEvolu_Click(object sender, EventArgs e)
        {
            // Caixa de diálogo para abrir a imagem
            OpenFileDialog ofdEvolu = new OpenFileDialog();
            // se ele clicar em ok dentro da caixa de diálogo 
            // atribui o caminho da imagem ao campo de texto
            if (ofdEvolu.ShowDialog() == DialogResult.OK)
            {
                txtbEvolu.Text = ofdEvolu.FileName;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbImg.Clear();
        }
    }
}
