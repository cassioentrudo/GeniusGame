using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusGame
{
    public class Sequencia
    {
        private static Botao GetRandBotao(List<Botao> botoes)
        {

            Random rand = new Random();
            int tamanhoLista = botoes.Count;
            Botao botaoSorteado = null;
                
                
            botaoSorteado = botoes.ElementAt(rand.Next(1, tamanhoLista));


            return botaoSorteado;
        }

        public static void IncSequencia(List<Botao> sequenciaBotoes, List<Botao> botoes)
        {
            sequenciaBotoes.Add(GetRandBotao(botoes));
        }
    }
}
