using System.Drawing;

namespace GeniusGame
{
    public class Botao
    {
        public Botao()
        {
            this.song = new Song();
        }

        /// <summary>
        /// Cor do botão quando ele está pressionado
        /// </summary>
        private Color activeColor;

        /// <summary>
        /// Cor do botão quando ele está em seu estado normal
        /// </summary>
        private Color idleColor;

        /// <summary>
        /// Música que toca quando o botão é pressionado
        /// </summary>
        private Song song; 

        public Color ActiveColor
        {
            get { return this.activeColor; }
            set { this.activeColor = value; }
        }

        public Color IdleColor
        {
            get { return this.idleColor; }
            set { this.idleColor = value; }
        }

        public Song Song
        {
            get { return this.song; }
            set { this.song = value; }
        }
    }
}
