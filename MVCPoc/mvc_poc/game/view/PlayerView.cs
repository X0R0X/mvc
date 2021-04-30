using System;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.view
{
    class UserActionEvent : AEvent
    {
    }

    public class PlayerView : Observer
    {
        private int _health = 0;

        public void Update()
        {
            if (_health == 0)
            {
                Console.WriteLine("PLAYER LOST!");
            }
            else
            {
                Console.WriteLine("PLAYER: health = " + _health);
                Console.WriteLine("PLAYER: SHOOT!");
                Console.ReadKey();
                DispatchEvent<UserActionEvent>(new UserActionEvent());
            }
        }

        public void SetHealth(int health)
        {
            _health = health;
        }
    }
}