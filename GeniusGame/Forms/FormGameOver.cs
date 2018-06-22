using System;
using System.Windows.Forms;

namespace GeniusGame.Forms
{
    public partial class FormGameOver : Form
    {
        private string playerName = string.Empty;

        private string playerScore = string.Empty;

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public string PlayerScore
        {
            get { return this.playerScore; }
            set { this.playerScore = value; }
        }

        public FormGameOver()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.playerName = this.textBoxName.Text;
        }

        private void FormGameOver_Shown(object sender, EventArgs e)
        {
            this.labelScoreValue.Text = this.playerScore;
        }
    }
}
