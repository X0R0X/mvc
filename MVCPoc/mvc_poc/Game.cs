using System;
using mvc_poc.game;
using mvc_poc.game.controller;
using mvc_poc.game.events;
using mvc_poc.game.model;
using mvc_poc.game.view;
using mvc_poc.mvc;
using mvc_poc.mvc.utils;

namespace mvc_poc
{
    public class Game
    {
        private readonly ViewManager _viewManager;
        private bool _exit = false;

        public Game()
        {
            IMessageBus messageBus = new MessageBus();

            IModelRegister register = new ModelRegister();
            register.RegisterModel(new PlayerModel(messageBus));
            register.RegisterModel(new EnemyModel(messageBus));

            IController controller = new Controller(register);

            _viewManager = new ViewManager(controller, messageBus);
            _viewManager.RegisterView(new PlayerViewMediator());
            _viewManager.RegisterView(new EnemyViewMediator());

            messageBus.AddEventListener<GameEndEvent>(OnGameEnd);
            
            controller.RunCommand(new GameStartCmd());
            
            Run();
        }

        private void Run()
        {
            while (!_exit)
            {
                _viewManager.Update();
            }
        }

        private void OnGameEnd(AEvent e)
        {
            _exit = true;
        }
    }
}