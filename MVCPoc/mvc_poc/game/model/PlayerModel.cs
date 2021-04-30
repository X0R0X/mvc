using System;
using System.Net.Mail;
using mvc_poc.game.events;
using mvc_poc.mvc;

namespace mvc_poc.game.model
{
    public class PlayerModel : AEntityModel
    {
        public PlayerModel(IMessageBus messageBus) : base(messageBus)
        {
        }

        public override void StartGame()
        {
            base.StartGame();
            
            this._messageBus.DispatchFromModel<PlayerStateChanged>(
                new PlayerStateChanged(this._health)
            );
        }

        public override void DealDamage(int damage)
        {
            base.DealDamage(damage);

            this._messageBus.DispatchFromModel<PlayerStateChanged>(
                new PlayerStateChanged(this._health)
            );

            if (this._health <= 0)
            {
                this._messageBus.DispatchFromModel<GameEndEvent>(new GameEndEvent(GameEndEvent.WINNER_ENEMY));
            }
        }
    }
}