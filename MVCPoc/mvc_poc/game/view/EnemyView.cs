using System;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.view
{
    class EnemyActionEvent : AEvent
    {
    }

    public class EnemyView : Observer
    {
        private int _health = 0;

        public void Update()
        {
            if (_health == 0)
            {
                Console.WriteLine("ENEMY LOST!");
            }
            else
            {
                Console.WriteLine("ENEMY: health = " + _health);
                Console.WriteLine("ENEMY: SHOOT!");
                Console.ReadKey();
                DispatchEvent<EnemyActionEvent>(new EnemyActionEvent());
            }
        }

        public void SetHealth(int health)
        {
            _health = health;
        }
    }
}