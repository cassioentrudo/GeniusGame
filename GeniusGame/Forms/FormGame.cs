using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private GameControl gameControl = null;

        private const int interval = 1000;

        public FormGame()
        {
            InitializeComponent();

            this.gameControl = new GameControl(this);

            this.StartFormObjects();
        }

        /// <summary>
        /// Apenas inicializa os botões na tela com as cores de idle de cada objeto botao
        /// </summary>
        private void StartFormObjects()
        {
            this.buttonBlue.BackColor = this.gameControl.Blue.IdleColor;
            this.buttonRed.BackColor = this.gameControl.Red.IdleColor;
            this.buttonYellow.BackColor = this.gameControl.Yellow.IdleColor;
            this.buttonGreen.BackColor = this.gameControl.Green.IdleColor;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.gameControl.Green.Play();
            this.gameControl.CheckSequence(this.gameControl.Green);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.gameControl.Yellow.Play();
            this.gameControl.CheckSequence(this.gameControl.Yellow);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.gameControl.Blue.Play();
            this.gameControl.CheckSequence(this.gameControl.Blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.gameControl.Red.Play();
            this.gameControl.CheckSequence(this.gameControl.Red);
        }

        public void UpdateScore()
        {
            this.labelScore.Text = this.gameControl.Score.ToString();
        }

        public void PlaySequence(List<Botao> buttons)
        {   
            //Desabilita os botões. Está mostrando a sequência pro jogador
            this.DisableFormButtons();

            foreach (var button in buttons)
            {
                button.Play();

                switch (button.InstanceName)
                {
                    case "blue":
                        this.buttonBlue.BackColor = button.ActiveColor;
                        this.Refresh();
                        Thread.Sleep(interval);
                        this.buttonBlue.BackColor = button.IdleColor;
                        this.Refresh();
                        break;

                    case "green":
                        this.buttonGreen.BackColor = button.ActiveColor;
                        this.Refresh();
                        Thread.Sleep(interval);
                        this.buttonGreen.BackColor = button.IdleColor;
                        this.Refresh();
                        break;

                    case "yellow":
                        this.buttonYellow.BackColor = button.ActiveColor;
                        this.Refresh();
                        Thread.Sleep(interval);
                        this.buttonYellow.BackColor = button.IdleColor;
                        this.Refresh();
                        break;

                    case "red":
                        this.buttonRed.BackColor = button.ActiveColor;
                        this.Refresh();
                        Thread.Sleep(interval);
                        this.buttonRed.BackColor = button.IdleColor;
                        this.Refresh();
                        break;

                    default:
                        break;
                }

                button.Stop();

                Thread.Sleep(500);
            }

            //Terminou de exibir a sequência. Habilita botões pro usuário repetir..
            this.EnableFormButtons();
        }

        private void DisableFormButtons()
        {
            this.buttonBlue.Enabled = false;
            this.buttonRed.Enabled = false;
            this.buttonGreen.Enabled = false;
            this.buttonYellow.Enabled = false;
        }

        private void EnableFormButtons()
        {
            this.buttonBlue.Enabled = true;
            this.buttonRed.Enabled = true;
            this.buttonGreen.Enabled = true;
            this.buttonYellow.Enabled = true;
        }

        public void ShowGameOver()
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.gameControl.Start();
        }
    }
}
