using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private Botao blue = null;
        private Botao red = null;
        private Botao yellow = null;
        private Botao green = null;

        public FormGame()
        {
            InitializeComponent();

            this.blue = new Botao();
            this.blue.Song.FilePath = "C:\\Cassio\\TCP\\Trabalho\\Drake - Hotline Bling.mp3";
            //this.red = new Botao(Color.Red, Color.OrangeRed);
            //this.yellow = new Botao(Color.Blue, Color.BlueViolet);
            //this.green = new Botao(Color.Green, Color.GreenYellow);
    }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.Play(this.buttonGreen, this.green);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.Play(this.buttonYellow, this.yellow);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.blue.Song.Play();
            //.Play(this.buttonBlue, this.blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.Play(this.buttonRed, this.red);
        }

        public  void Play(Button button, Botao acionado)
        {
            //button.ForeColor = acionado.ActiveColor;
            //this.Refresh();
            //Thread.Sleep(500);
            //button.ForeColor = acionado.IdleColor;
            //this.Refresh();
        }
    }
}
