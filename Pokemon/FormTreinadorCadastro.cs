using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pokemon
{
    public partial class FormTreinadorCadastro : Form
    {
        //Instancio para pegar as propriedades/atributos
        //da minha classe Treinador
        Treinador propTreinador = new Treinador();

        int id = 0;

        public FormTreinadorCadastro()
        {
            InitializeComponent();
        }

        //VALIDAR CAMPOS DO CADASTRO DE NOVO TREINADOR
        private void validaCamposTreinador()
        {
            //verifica se o nome do treinador esta nulo ou vazio
            if (string.IsNullOrWhiteSpace(textBoxNomeTreinador.Text.Trim()))
            {
                //caso a verificacao retorne true, retorna a mensagem de erro
                throw new ArgumentException("Nome do treinador deve ser preenchido");
            }

            //verifica se os radiobuttons nao estao selecionados
            if (radioButtonFemme.Checked == false && radioButtonMasculo.Checked == false)
            {
                throw new ArgumentException("Selecione uma opcao de genero");
            }

            //verifica se o pictureBox esta sem imagem
            if (pictureBoxImgTreinador.Image == null)
            {
                throw new ArgumentException("Escolha uma imagem");
            }
           
        }

        //INCLUSAO DE UM NOVO TREINADOR NO ARQUIVO TREINADORES
        private void novoTreinador()
        {
            id = propTreinador.idTreinador();

            propTreinador.cadastroTreinador(
                (textBoxNomeTreinador.Text 
                + ";" 
                + @"..\..\..\imagens\treinadores\" + id.ToString() + ".jpg" 
                + ";" 
                + groupBoxSexo.ToString() 
                + ";")
                );
            
        }

        //BOTAO CADASTRAR EXECUTARA OS METODOS DENTRO  
        //DELE E CRIARA O NOVO CADASTRO DE TREINADOR
        private void buttonCadstroTreinadr_Click(object sender, EventArgs e)
        {
            //Tenta executar
            try
            {
                validaCamposTreinador();
                novoTreinador();

            }

            //Retorna mensagem de erro da classe Exception
            // caso nao consiga executar
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }   
        }


        //CARREGAR IMAGEM DO TREINADOR PARA NOVO CADASTRO
        private void pictureBoxImgTreinador_Click(object sender, EventArgs e)
        {
            //CONDICAO PARA ABRIR A CAIXA DE SELECAO PARA IMAGEM
            OpenFileDialog arquivoImg = new OpenFileDialog();

            //FILTRA OS ARQUIVOS PELA EXTENSAO JPG
            arquivoImg.Filter = "jpg|*.jpg";

            //CONDICAO QUANDO SELECIONADO UM ARQUIVO
            if (arquivoImg.ShowDialog() == DialogResult.OK)
            {
                //ARQUIVO DA IMG SERA CARREGADA NA PICTUREBOX
                pictureBoxImgTreinador.ImageLocation = arquivoImg.FileName;
            }

        }
    }
}
