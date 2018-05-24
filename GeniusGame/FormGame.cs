using System;
using System.Threading;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormGame : Form
    {
        private ClassButton blueButton = null;

        private ClassButton redButton = null;

        private ClassButton yellowButton = null;

        private ClassButton greenButton = null;

        public FormGame()
        {
            InitializeComponent();

            this.blueButton = new ClassButton(this.buttonBlue, Properties.Resources.blueButton, Properties.Resources.bluePressButton);

            this.redButton = new ClassButton(this.buttonRed, Properties.Resources.redButton, Properties.Resources.redPressButton);

            this.yellowButton = new ClassButton(this.buttonYellow, Properties.Resources.yellowButton, Properties.Resources.yellowPressButton);

            this.greenButton = new ClassButton(this.buttonGreen, Properties.Resources.greenButton, Properties.Resources.greenPressButton);
    }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.greenButton);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.yellowButton);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.blueButton);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.ExecuteButton(this.redButton);
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
