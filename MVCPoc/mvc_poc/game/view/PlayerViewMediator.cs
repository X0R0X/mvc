using System;
using mvc_poc.game.controller;
using mvc_poc.game.events;
using mvc_poc.mvc;
using mvc_poc.mvc.utils;

namespace mvc_poc.game.view
{
    public class PlayerViewMediator : AViewMediator
    {
        private readonly PlayerView _playerView;

        public PlayerViewMediator()
        {
            this._playerView = new PlayerView();
        }

        public override void Register(IController controller, IMessageBus messageBus)
        {
            base.Register(controller, messageBus);

            _messageBus.AddEventListener<PlayerStateChanged>(OnStateChanged);
            
            _playerView.AddEventListener<UserActionEvent>(OnUIShoot);
        }

        public override void Unregister()
        {
            _messageBus.RemoveEventListener<PlayerStateChanged>(OnStateChanged);
            
            
            base.Unregister();
        }

        private void OnStateChanged(AEvent e)
        {
            _playerView.SetHealth(((PlayerStateChanged) e).Health);
        }

        private void OnUIShoot(AEvent e)
        {
            _controller.RunCommand(new ShootCmd(ShootCmd.SHOOTER_PLAYER));
        }

        public override void Update()
        {
            this._playerView.Update();
        }
    }
}