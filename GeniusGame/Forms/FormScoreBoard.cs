using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GeniusGame.Forms
{
    public partial class FormScoreBoard : Form
    {
        public FormScoreBoard()
        {
            InitializeComponent();
            EscreveBoard();

        }

        private void EscreveBoard()
        {
            List<Player> scoreboard = ScoreBoard.GetScoreBoard();

            EscreveCabecalho();

            for (int row = 1; row < tableLayoutPanel1.RowCount; row++)
                EscreveLinhaBoard(scoreboard, row);
        }

        private void EscreveCabecalho()
        {
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            DefinePropriedadesLabel(label1);
            DefinePropriedadesLabel(label2);
            DefinePropriedadesLabel(label3);

            label1.Text = "#";
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            label2.Text = "NOME";
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            label3.Text = "SCORE";
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
        }

        private void EscreveLinhaBoard(List<Player> scoreboard, int row)
        {
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            DefinePropriedadesLabel(label1);
            DefinePropriedadesLabel(label2);
            DefinePropriedadesLabel(label3);
            label1.Text = row.ToString();
            tableLayoutPanel1.Controls.Add(label1, 0, row);
            label2.Text = scoreboard.ElementAt(row - 1).Nome;
            tableLayoutPanel1.Controls.Add(label2, 1, row);
            label3.Text = scoreboard.ElementAt(row - 1).Score.ToString();
            tableLayoutPanel1.Controls.Add(label3, 2, row);
        }

        private static void DefinePropriedadesLabel(Label label)
        {
            label.BackColor = Color.Black;
            label.ForeColor = Color.White;
            label.TextAlign = ContentAlignment.MiddleCenter;
          
        }
    }
}

