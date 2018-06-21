using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private FormConfiguration formConfig = null;

        private GameControl gameControl = null;

        private Song song = null;

        private const int interval = 1000;

        public FormGame()
        {
            InitializeComponent();

            this.gameControl = new GameControl(this);
            this.formConfig = new FormConfiguration();
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

                Thread.Sleep(500);
            }

            //Terminou de exibir a sequência. Habilita botões pro usuário repetir..
            this.EnableFormButtons();
        }

        private void ExecuteButton(Button FormButton, Botao button, int time)
        {
            FormButton.BackColor = button.ActiveColor;
            this.song.Play(button.SongFilePath);            
            this.Refresh();
            Thread.Sleep(interval);
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
            string blueSongPath = this.formConfig.BlueButtonSongPath;
            string redSongPath = this.formConfig.RedButtonSongPath;
            string greenSongPath = this.formConfig.GreenButtonSongPath;
            string yellowSongPath = this.formConfig.YellowButtonSongPath;

            this.gameControl.Prepare(blueSongPath, redSongPath, greenSongPath, yellowSongPath);
            this.gameControl.Start();
        }

        private void buttonConfiguration_Click(object sender, EventArgs e)
        {
            DialogResult result =  this.formConfig.ShowDialog();

            if (result == DialogResult.OK)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.song.Mute(false);
        }
    }
}
