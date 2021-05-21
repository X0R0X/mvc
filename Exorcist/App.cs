using Exorcist.MVCS;
using Exorcist.Updater;
using SampleGame.controller;
using SampleGame.events;
using SampleGame.model;
using UnityEditorInternal;
using UnityEngine;

namespace Exorcist
{
    public class App
    {
        [SerializeField]
        private static App _instance;
        public static App Instance => _instance;

        private readonly ViewManager _viewManager;

        public ViewManager ViewManager => _viewManager;

        private readonly IUpdater _updater;

        public IUpdater Updater => _updater;

        private bool _exit = false;

        private IMessageBus messageBus;
    
    
    
        public App()
        {
            messageBus = new MessageBus();

            IModelRegister register = new ModelRegister();
            register.RegisterModel(new PlayerModel(messageBus));
            register.RegisterModel(new EnemyModel(messageBus));

            IController controller = new Controller(register);

            _viewManager = new ViewManager(controller, messageBus);
            //_viewManager.RegisterView(new PlayerViewMediator());
            //_viewManager.RegisterView(new EnemyViewMediator());

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