using System;
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

            this.blue = new Botao(this.buttonBlue, Properties.Resources.blueButton, Properties.Resources.bluePressButton);

            this.red = new Botao(this.buttonRed, Properties.Resources.redButton, Properties.Resources.redPressButton);

            this.yellow = new Botao(this.buttonYellow, Properties.Resources.yellowButton, Properties.Resources.yellowPressButton);

            this.green = new Botao(this.buttonGreen, Properties.Resources.greenButton, Properties.Resources.greenPressButton);
    }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.Play(this.green);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.Play(this.yellow);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.Play(this.blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.Play(this.red);
        }

        public void Play(Botao acionado)//Mudar de classe?
        {
            acionado.ButtonForm.BackgroundImage = acionado.ImagePress;
            this.Refresh();
            Thread.Sleep(300);
            acionado.ButtonForm.BackgroundImage = acionado.ImageNormal;
            this.Refresh();
        }
    }
}
