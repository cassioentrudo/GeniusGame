using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private GameControl gameControl = null;

        private Song song = null;

        private const int interval = 1000;

        public FormGame()
        {
            InitializeComponent();

            this.gameControl = new GameControl(this);
            this.song = new Song();

            this.StartFormObjects();
            this.DisableFormButtons();
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
            this.ExecuteButton(this.buttonGreen, this.gameControl.Green, 0);
            this.gameControl.CheckSequence(this.gameControl.Green);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.buttonYellow, this.gameControl.Yellow, 0);
            this.gameControl.CheckSequence(this.gameControl.Yellow);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.buttonBlue, this.gameControl.Blue, 0);
            this.gameControl.CheckSequence(this.gameControl.Blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.buttonRed, this.gameControl.Red, 0);
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
                switch (button.InstanceName)
                {
                    case "blue":
                        ExecuteButton(this.buttonBlue, button, interval);
                        break;

                    case "green":
                        ExecuteButton(this.buttonGreen, button, interval);
                        break;

                    case "yellow":
                        ExecuteButton(this.buttonYellow, button, interval);
                        break;

                    case "red":
                        ExecuteButton(this.buttonRed, button, interval);
                        break;
                }
            }

            //Terminou de exibir a sequência. Habilita botões pro usuário repetir..
            this.EnableFormButtons();
        }

        private void ExecuteButton(Button FormButton, Botao button, int time)
        {
            this.song.Play(button.SongFilePath);
            FormButton.BackColor = button.ActiveColor;
            this.Refresh();
            Thread.Sleep(time);
            this.song.Stop();
            FormButton.BackColor = button.IdleColor;
            this.Refresh();
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
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.gameControl.Start();
        }

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            FormConfiguration formConfig = new FormConfiguration();
            formConfig.ShowDialog();
        }
    }
}
