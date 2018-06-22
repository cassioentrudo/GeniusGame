using GeniusGame.Forms;
using System;
using System.Windows.Forms;

namespace GeniusGame
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.ShowDialog();
        }

        private void buttonRanking_Click(object sender, EventArgs e)
        {
            FormScoreBoard ranking = new FormScoreBoard();
            ranking.ShowDialog();
        }
    }
}
