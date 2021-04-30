using mvc_poc.game.events;
using mvc_poc.mvc;

namespace mvc_poc.game.model
{
    public class EnemyModel : AEntityModel
    {
        public EnemyModel(IMessageBus messageBus) : base(messageBus)
        {
        }

        public override void StartGame()
        {
            base.StartGame();
            
            this._messageBus.DispatchFromModel<EnemyStateChanged>(
                new EnemyStateChanged(this._health)
            );
        }

        public override void DealDamage(int damage)
        {
            base.DealDamage(damage);

            this._messageBus.DispatchFromModel<EnemyStateChanged>(
                new EnemyStateChanged(this._health)
            );

            if (this._health <= 0)
            {
                this._messageBus.DispatchFromModel<GameEndEvent>(new GameEndEvent(GameEndEvent.WINNER_PLAYER));
            }
        }
    }
}