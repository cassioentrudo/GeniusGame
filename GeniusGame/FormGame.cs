using System;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private ClassButton blue = null;

        private ClassButton red = null;

        private ClassButton yellow = null;

        private ClassButton green = null;

        public FormGame()
        {
            InitializeComponent();

            this.blue = new ClassButton(this.buttonBlue, Properties.Resources.blueButton, Properties.Resources.bluePressButton);

            this.red = new ClassButton(this.buttonRed, Properties.Resources.redButton, Properties.Resources.redPressButton);

            this.yellow = new ClassButton(this.buttonYellow, Properties.Resources.yellowButton, Properties.Resources.yellowPressButton);

            this.green = new ClassButton(this.buttonGreen, Properties.Resources.greenButton, Properties.Resources.greenPressButton);
    }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.green);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.yellow);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.red);
        }

        public void ExecuteButton(ClassButton button)
        {
            button.ButtonForm.BackgroundImage = button.ImagePress;
            this.Refresh();
            Thread.Sleep(300);
            button.ButtonForm.BackgroundImage = button.ImageNormal;
            this.Refresh();
        }
    }
}
