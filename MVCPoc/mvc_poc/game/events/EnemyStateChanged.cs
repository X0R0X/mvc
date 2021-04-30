using mvc_poc.mvc;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.events
{
    public class EnemyStateChanged : AModelEvent
    {
        public int Health { get; }

        public EnemyStateChanged(int health)
        {
            Health = health;
        }
    }
}