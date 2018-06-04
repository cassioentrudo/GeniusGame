using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GeniusGame
{
    public class GameControl
    {


    
        public void PlaySequencia(List<Botao> sequencia)
        {


            var instance = new FormGame();

            foreach (Botao botao in sequencia)
            {
                instance.Play(botao);
            }
           

        }

        


    }
}
