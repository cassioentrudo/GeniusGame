namespace GeniusGame
{
    public class Player
    {
        string name = string.Empty;
        int score = 0;

        public string Nome
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}
