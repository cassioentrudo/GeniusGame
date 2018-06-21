using System.Drawing;

namespace GeniusGame
{
    public class Botao
    {
        public Botao()
        {
            this.song = new Song();
        }

        #region Variáveis internas da classe

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
        /// <summary>
        /// Path contendo o arquivo .mp3
        /// </summary>
        private string songFilePath;

        /// <summary>
        /// Nome da instância desse objeto
        /// </summary>
        private string instanceName;

        #endregion

        #region Propriedades

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

        public string SongFilePath
        {
            get { return this.songFilePath; }
            set { this.songFilePath = value; }
        }

        public string InstanceName
        {
            get { return this.instanceName; }
            set { this.instanceName = value; }
        }

        #endregion
    }
}
