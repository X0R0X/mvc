using mvc_poc.mvc;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.events
{
    public class PlayerStateChanged : AModelEvent
    {
        public int Health { get; }

        public PlayerStateChanged(int health)
        {
            Health = health;
        }
    }
}