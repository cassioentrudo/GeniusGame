using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GeniusGame.Forms;

namespace GeniusGame
{
    public class GameControl
    {
        private FormGame formGame = null;

        private Botao blue = null;
        private Botao red = null;
        private Botao yellow = null;
        private Botao green = null;

        private List<Botao> botoes = new List<Botao>();

        private List<Botao> sequence = new List<Botao>();

        private int iteratorSequence = 0;

        private int score = 0;

        public Botao Blue
        {
            get { return this.blue; }
            set { this.blue = value; }
        }

        public Botao Red
        {
            get { return this.red; }
            set { this.red = value; }
        }

        public Botao Yellow
        {
            get { return this.yellow; }
            set { this.yellow = value; }
        }

        public Botao Green
        {
            get { return this.green; }
            set { this.green = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public GameControl(FormGame formGame)
        {
            this.formGame = formGame;

            this.blue = new Botao();
            this.blue.IdleColor = Color.Blue;
            this.blue.ActiveColor = Color.LightBlue;
            this.blue.InstanceName = "blue";

            this.red = new Botao();
            this.red.IdleColor = Color.Red;
            this.red.ActiveColor = Color.LightSalmon;
            this.red.InstanceName = "red";

            this.yellow = new Botao();
            this.yellow.IdleColor = Color.Yellow;
            this.yellow.ActiveColor = Color.LightYellow;
            this.yellow.InstanceName = "yellow";

            this.green = new Botao();
            this.green.IdleColor = Color.Green;
            this.green.ActiveColor = Color.LightGreen;
            this.green.InstanceName = "green";

            this.botoes.Add(this.blue);
            this.botoes.Add(this.red);
            this.botoes.Add(this.yellow);
            this.botoes.Add(this.green);
        }

        public void Prepare(string blueSongPath, string redSongPath, string greenSongPath, string yellowSongPath)
        {
            this.blue.SongFilePath = blueSongPath;
            this.red.SongFilePath = redSongPath;
            this.green.SongFilePath = greenSongPath;
            this.yellow.SongFilePath = yellowSongPath;
        }

        public void Start()
        {
            this.PlaySequence();
        }

        private void PlaySequence()
        {
            this.sequence.Add(this.GetRandBotao());
            this.formGame.PlaySequence(this.sequence);

            this.iteratorSequence = 0;
        }

        private Botao GetRandBotao()
        {
            Random rand = new Random(((int)DateTime.Now.Ticks & 0x0000FFFF));

            return this.botoes.ElementAt(rand.Next(0, botoes.Count));
        }

        public void CheckSequence(Botao button)
        {
            if (this.sequence[this.iteratorSequence] != button)
            {
                this.GameOver();
                return;
            }

            this.iteratorSequence++;

            if (this.iteratorSequence == this.sequence.Count)
            {
                this.score++;
                this.formGame.UpdateScore();
                this.PlaySequence();
            }
        }

        private void GameOver()
        {
            Player player = new Player();
            player.Score = this.score;

            this.formGame.ShowGameOver();

            if (ScoreBoard.TestaScoreSuficiente(score))
            {
                //chamar o form do game over
                FormGameOver formGameOver = new FormGameOver();
                formGameOver.PlayerScore = this.score.ToString();

                DialogResult res = formGame.ShowDialog();

                if (res == DialogResult.OK)
                {                    
                    player.Nome = formGameOver.PlayerName;
                }               
                
                //cria um player com o nome inserido e o score obitido
                ScoreBoard.InsereNoBoard(player);
                //ou faz isso no form mesmo
            }

            this.score = 0;
        }
    }
}
