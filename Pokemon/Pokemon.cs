using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Pokemon
    {

        private int id;
        private string nome;
        private string imagem;
        private string nome_Evolucao;
        private double altura;
        private double peso;
        private double efeito;
        private double forca;
        private List<Pokemon> listaPokemons = new List<Pokemon>();


        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public string Nome_Evolucao { get => nome_Evolucao; set => nome_Evolucao = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Efeito { get => efeito; set => efeito = value; }
        public double Forca { get => forca; set => forca = value; }
        public List<Pokemon> ListaPokemons { get => listaPokemons; set => listaPokemons = value; }
        
        // Construtor vazio
        public Pokemon()
        {

        }
        // Construtor recebendo os atributos como parâmetro e guardando nas váriaveis da classe pokemon
        public Pokemon(int iden,string name, string image, string nEvolution, double height, double weigth, int effect, double force)
        {
            id = iden;
            nome = name;
            imagem = image;
            nome_Evolucao = nEvolution;
            altura = height;
            peso = weigth;
            efeito = effect;
            Forca = force;
        }
        // Método para calcular o atributo efeito
        public int calcEfeito()
        {
            // O atributo efeito se da apartir de um número aleatório entre 1 e 5
            Random r = new Random();
            return r.Next(1, 5);

        }
        // Método para calcular o atributo força
        public double calcforca(double altura, double peso, double efeito)
        {
            // Calculo da força se da multiplicando altura pelo peso, somando ao efeito e a raiz disso será a força
            return Math.Sqrt((altura * peso) + efeito);
        }
        // Método para achar o valor do ID
        public int valorId()
        {
            // Se o já tiver outros ID no arquivo será necessário ler a última linha do arquivo, aonde se terá
            // o ultimo Id cadastrado, depois de achar este ultimo Id cadastrado, ele é  pré-incrementado e retornado 
            // ao programa

            // Lê o arquivo pokemons todo
            List<string> arquivoTodo = new List<string>();
            arquivoTodo = lerArquivoPokes();
            int max = arquivoTodo.Count;            
            List<string> achaId = new List<string>();
            string lastline = "";
            int id = 0;

            // Entra se o arquivo não estiver vazio
            if (arquivoTodo.Count != 0)
            {
                // Lê a ultima linha do TXT
                lastline = arquivoTodo.Last();
                // Splita o TXT e guarda em um list
                achaId = lastline.Split(';').ToList();
                // Pega a posição do ID em relação aonde esta na lista e converte em int
                id = Convert.ToInt32(achaId[0]);
            }                                    
            // Pré incremento, pois com pós incremento era primeiro retornado o valor e em seguida incrementado a variável ID
            return ++id;
            
        }
        // Método responsável por ler arquivo de pokemons, retorna um list de string com todos os pokemon
        public List<string> lerArquivoPokes()
        {
            List<string> listStrPokes = new List<string>();
            // Lê todo o arquivo TXT
            listStrPokes = File.ReadAllLines(@"..\..\..\pokemons.txt").ToList();      
            
            return listStrPokes;            

        }
        // Método responsável por gravar os pokemons no TXT
        public void gravaPokemons(string pokemonStr)
        {
            List<string> arquivopokemons = new List<string>();
            // Carrega todo o arquivo de pokemons
            arquivopokemons = lerArquivoPokes();
            // 1 - Salvar 
            // Adiciona novo pokemon a lista
            arquivopokemons.Add(pokemonStr);
            // Salva todos os pokemons no TXT
            File.WriteAllLines(@"..\..\..\pokemons.txt", arquivopokemons, Encoding.UTF8);


        }

        // Método responsável por achar o id mandado por parametro na lista<pokemon>
        // Retorna a linha do ID
        public int PesquisaPeloID(int id)
        {
            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex = criaPokedex();
            int linhaID = -1;
            // For para passar por todas as linhas
            for (int i = 0; i < pokedex.Count; i++)
            {
                // Pega o id da posição e compará com o recebido por parametro
                if (pokedex[i].Id == id)
                {                    
                    linhaID = i;
                    break;
                }
            }
            return linhaID;
        }
        // Método responsável por criar a pokedex (Referência a um dispositivo existente em pokemon que tem a função de conter todos
        //                                          os pokemon)
        public List<Pokemon> criaPokedex()
        {
            List<Pokemon> poked = new List<Pokemon>(); // instancia lista da classe pokemon            
            List<string> poke = new List<string>();
            foreach (var item in lerArquivoPokes())
            {
                // Quebra os ; existentes na string e transforma essa string quebrada em um list
                poke = item.Split(';').ToList();
                // Pega esse list com a string quebrada e joga em um list da classe pokemon, aonde atribui cada posição do list<string> poke a uma variavel que será guarda seguindo 
                //arquivoTodo ordem de gravação no txt
                poked.Add(new Pokemon(

                    Convert.ToInt32(poke[0]),
                    poke[1],
                    poke[2],
                    poke[3],
                    Convert.ToDouble(poke[4]),
                    Convert.ToDouble(poke[5]),
                    Convert.ToInt32(poke[6]),
                    Convert.ToDouble(poke[7])
                ));
            }
            return poked;
        }
        public void excluirLinha(int line)
        {
            List<string> arquivopokemons = new List<string>();
            // Carrega todo o arquivo de pokemons
            arquivopokemons = lerArquivoPokes();
            arquivopokemons.RemoveAt(line);
            File.WriteAllLines(@"..\..\..\pokemons.txt", arquivopokemons, Encoding.UTF8);
        }
        public void salvaEditado(int iden, string name, string image, string nEvolution, double height, double weigth, int linha)
        {
            List<string> arquivoPokesString = new List<string>();
            arquivoPokesString = lerArquivoPokes();
            int effect = calcEfeito();

            string linhaSalvar = (iden + ";" 
                + name + ";"
                + image + ";"
                + nEvolution + ";"
                + height + ";"
                + weigth + ";"
                + effect + ";"
                + (int)calcforca(height, weigth, effect)
                ).ToString();
            arquivoPokesString[linha] = linhaSalvar;
            File.WriteAllLines(@"..\..\..\pokemons.txt", arquivoPokesString, Encoding.UTF8);
           
        }
    }
}
