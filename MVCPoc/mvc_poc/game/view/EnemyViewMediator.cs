using System;
using mvc_poc.game.controller;
using mvc_poc.game.events;
using mvc_poc.mvc;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.view
{
    public class EnemyViewMediator : AViewMediator
    {
        private EnemyView _enemyView;

        public EnemyViewMediator()
        {
            this._enemyView = new EnemyView();
            
        }

        public override void Register(IController controller, IMessageBus messageBus)
        {
            base.Register(controller, messageBus);

            _messageBus.AddEventListener<EnemyStateChanged>(this.OnStateChanged);
            
            this._enemyView.AddEventListener<EnemyActionEvent>(OnUIShoot);
        }

        public override void Unregister()
        {
            _messageBus.RemoveEventListener<EnemyStateChanged>(this.OnStateChanged);
            
            base.Unregister();
        }

        private void OnStateChanged(AEvent e)
        {
            _enemyView.SetHealth(((EnemyStateChanged) e).Health);
        }

        private void OnUIShoot(AEvent e)
        {   
            _controller.RunCommand(new ShootCmd(ShootCmd.SHOOTER_ENEMY));
        }

        public override void Update()
        {
            _enemyView.Update();
        }
    }
}