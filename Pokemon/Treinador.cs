using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pokemon
{
    class Treinador
    {

        private int id;
        private string nome;
        private char sex;
        private string image;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Sex { get => sex; set => sex = value; }
        public string Image { get => image; set => image = value; }

        public Treinador()
        {
        }
        public Treinador(int identificador, string name, char sexo, string imagem)
        {

            id = identificador;
            nome = name;
            sex = sexo;
            image = imagem;
        }      

        //METODO PARA LER TODOS OS TREINADORES CADASTRADOS
        public List<string> lerArquivoTreinador()
        {
            //Instancio um list, onde sera armazenado de 
            //forma dinamica meu arquivo com o cadastro dos treinadores
            List<string> listStrCoach = new List<string>();


            //le todo o arquivo TXT e converto em um list
            listStrCoach = File.ReadAllLines(@"..\..\..\treinadores.txt").ToList();
            return listStrCoach;
        }

        //METODO PARA PEGAR O ID DO TREINADOR

        public int idTreinador()
        {
            //Instancio um list para armazenar a list do arquivo
            //retornado do metodo "lerArquivoTreinador"
            List<string> todoArquivo = new List<string>();
            todoArquivo = lerArquivoTreinador();


            //Instancio um list para armazenar o list da 
            //ultimalinha do arquivo lido
            List<string> achaIdTreinador = new List<string>();
            string ultimaLinha = "";
            id = 0;


            //Verifica se os espacos preenchidos no arquivo sao
            //diferentes de zero, para confirmar que ha algo gravado
            if (todoArquivo.Count != 0)
            {
                //Pega a ulitma linha do arquivo e armazena na variavel
                ultimaLinha = todoArquivo.Last();

                //Splito a variavel, converto em um list e 
                //armazeno no list "achaIdTreinador" que instanciei
                achaIdTreinador = ultimaLinha.Split(';').ToList();

                //Converto o list "achaIdTreinador" em inteiro,
                //pegando a posicao 0 que e o seu indice na lista
                // e armazeno o valor na variavel "id"
                id = Convert.ToInt32(achaIdTreinador[0]);

            }
            //Pre-incremento o ID para depois mostrar ele
            // com seu valor anterior acrescido de 1
            return ++id;
        }

        //METODO PARA CADASTRAR TREINADOR
        public void cadastroTreinador(string novoTreinador)
        {
            //Instancio um list com o tipo de dado string, 
            //onde sera armazenado o meu arquivo
            List<string> arquivoTreinador = new List<string>();

            //Armazeno o arquivo lido no metodo "lerArquivoTreinador"
            arquivoTreinador = lerArquivoTreinador();

            //Adiciono um novo criador na minha lista
            arquivoTreinador.Add(novoTreinador);

            //Salvo todos os treinadores no caminho do arquivo "treinadores.txt",  
            //passando o que sera gravado e sua formatacao
            File.WriteAllLines(@"..\..\..\treinadores.txt", arquivoTreinador, Encoding.UTF8);
        }
        // Criar a lista de treinadores
        public List<Treinador> criaListaTreinadores()
        {
            List<Treinador> treina = new List<Treinador>(); // instancia lista da classe treinadores            
            List<string> trei = new List<string>();
            foreach (var item in lerArquivoTreinador())
            {
                // Quebra os ; existentes na string e transforma essa string quebrada em um list
                trei = item.Split(';').ToList();
                // Pega esse list com a string quebrada e joga em um list da classe treinadores, aonde atribui cada posição do list<string> trei a uma variavel que será guarda seguindo 
                //arquivoTodo ordem de gravação no txt
                treina.Add(new Treinador(
                    Convert.ToInt32(treina[0]), // ID
                    treina[1].ToString(), // Nome
                    Convert.ToChar(treina[2]), // Sexo
                    treina[3].ToString() // Imagem                    
                ));
            }
            return treina;
        }

    }
}
