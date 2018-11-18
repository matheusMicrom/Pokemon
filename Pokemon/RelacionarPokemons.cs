using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class RelacionarPokemons
    {
        Pokemon pok = new Pokemon();
        Treinador trainer = new Treinador();
        List<string> relacao = new List<string>();    
        public RelacionarPokemons()
        {

            relacao.Add(pok.Id.ToString() + ";" +  trainer.Id.ToString());

        }   

        
        
    }
}
