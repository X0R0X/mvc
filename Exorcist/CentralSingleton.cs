using _Game.Scripts.View;
using Exorcist.MVCS;
using UnityEngine;

namespace Exorcist
{
    /*public class CentralSingleton
    {
        private static CentralSingleton instance;

        public static CentralSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CentralSingleton();
                }

                return instance;
            }
            set { instance = value; }
        }

        private ViewManager _viewManager;

        public ViewManager ViewManager => _viewManager;

        private CentralSingleton()
        {
        }

        public void RegisterViewManager(ViewManager viewManager)
        {
            _viewManager = viewManager;
        }

        public BaseView[] GetAllViews()
        {
            return GameObject.FindObjectsOfType<BaseView>();
        }

    }*/
}