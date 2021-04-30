using mvc_poc.game.model;
using mvc_poc.mvc;

namespace mvc_poc.game.controller
{
    public class GameStartCmd : ACommand
    {
        public override void Execute()
        {
            ((PlayerModel)_modelRegister.GetModel<PlayerModel>()).StartGame();
            ((EnemyModel)_modelRegister.GetModel<EnemyModel>()).StartGame();
        }
    }
}