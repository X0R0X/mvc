using mvc_poc.game.events;
using mvc_poc.mvc;

namespace mvc_poc.game.model
{
    public abstract class AEntityModel : AModel
    {
        protected int _health;

        protected AEntityModel(IMessageBus messageBus) : base(messageBus)
        {
            this._health = 100;
        }

        public virtual void StartGame()
        {
            this._health = 100;
        }

        public virtual void DealDamage(int damage)
        {
            this._health -= damage;
            if (this._health < 0)
            {
                this._health = 0;
            }
        }

        public bool IsDead()
        {
            return this._health <= 0;
        }
    }
}