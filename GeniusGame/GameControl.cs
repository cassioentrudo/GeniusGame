using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

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
            this.blue.SongFilePath = Properties.Settings.Default.BlueButtonSong;
            this.blue.IdleColor = Color.Blue;
            this.blue.ActiveColor = Color.DeepSkyBlue;
            this.blue.InstanceName = "blue";

            this.red = new Botao();
            this.red.SongFilePath = Properties.Settings.Default.RedButtonSong;
            this.red.IdleColor = Color.Red;
            this.red.ActiveColor = Color.DarkOrange;
            this.red.InstanceName = "red";

            this.yellow = new Botao();
            this.yellow.SongFilePath = Properties.Settings.Default.YellowButtonSong;
            this.yellow.IdleColor = Color.Yellow;
            this.yellow.ActiveColor = Color.LightGoldenrodYellow;
            this.yellow.InstanceName = "yellow";

            this.green = new Botao();
            this.green.SongFilePath = Properties.Settings.Default.GreenButtonSong;
            this.green.IdleColor = Color.Green;
            this.green.ActiveColor = Color.GreenYellow;
            this.green.InstanceName = "green";

            this.botoes.Add(this.blue);
            this.botoes.Add(this.red);
            this.botoes.Add(this.yellow);
            this.botoes.Add(this.green);

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
            Random rand = new Random();
            int tamanhoLista = this.botoes.Count;

            return this.botoes.ElementAt(rand.Next(0, tamanhoLista - 1));
        }

        public void CheckSequence(Botao button)
        {
            if (this.sequence[this.iteratorSequence] != button)
                this.GameOver();

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
            this.score = 0;
            this.formGame.ShowGameOver();
        }
    }
}
