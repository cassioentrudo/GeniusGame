using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusGame
{
    class ScoreBoard
    {
        private static string BoardPath = "..\\..\\..\\ScoreBoard\\data\\ScoreBoard.txt";

        private static void InsereNoBoard(Player player)
        {
            List<Player> newBoard = UpdateBoardList(player);

            using (Stream saida = File.Open(BoardPath, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                for (int i = 0; i < 10; i++)
                    escritor.WriteLine(newBoard.ElementAt(i).Nome + " " + newBoard.ElementAt(i).Score);
            }

        }

        private static List<Player> UpdateBoardList(Player player)
        {
            List<Player> board = GetScoreBoard();
            board.Add(player);

            List<Player> newBoard = board.OrderByDescending(p => p.Score).ToList();
            newBoard.RemoveAt(10);
            return newBoard;
        }

        private static bool TestaScoreSuficiente(int scoreFeito)
        {

            return (GetScorePosicaoN(10) < scoreFeito);
        }

        private static int GetScorePosicaoN(int n)
        {
            List<Player> board = GetScoreBoard();
            return board.ElementAt(n - 1).Score;

        }

        private static List<Player> GetScoreBoard()
        {

            if (!File.Exists(BoardPath))
                CriaNovoBoard();

            return LeBoard();
        }

        private static List<Player> LeBoard()
        {

            List<Player> board = new List<Player>();
            using (Stream arquivo = File.Open(BoardPath, FileMode.Open))
            using (StreamReader leitor = new StreamReader(arquivo))
            {
                for (int i = 0; i < 10; i++)
                {

                    string linha = leitor.ReadLine();
                    Player player = new Player
                    {
                        Nome = linha.Split(' ')[0],
                        Score = Convert.ToInt32(linha.Split(' ')[1])
                    };
                    board.Add(player);

                }
            }

            return board;
        }

        private static void CriaNovoBoard()
        {
            using (Stream NovoScoreBoard = File.Open(BoardPath, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(NovoScoreBoard))
            {

                for (int i = 0; i < 10; i++)
                    escritor.WriteLine("--- 0");
            }
        }
    }
}

