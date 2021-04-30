using mvc_poc.mvc;

namespace mvc_poc.game.events
{
    public class GameEndEvent : AModelEvent
    {
        public static int WINNER_PLAYER = 0;
        public static int WINNER_ENEMY = 1;

        public int Winner { get; }

        public GameEndEvent(int winner)
        {
            this.Winner = winner;
        }
    }
}