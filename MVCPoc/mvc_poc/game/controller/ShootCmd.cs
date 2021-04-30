using System;
using mvc_poc.game.model;
using mvc_poc.mvc;

namespace mvc_poc.game.controller
{
    public class ShootCmd : ACommand
    {
        public static int SHOOTER_PLAYER = 0;
        public static int SHOOTER_ENEMY = 1;

        private readonly int _shooter;

        public ShootCmd(int shooter)
        {
            _shooter = shooter;
        }

        public override void Execute()
        {
            int dmg = new Random().Next(1, 30);
            if (_shooter == SHOOTER_PLAYER)
            {
                ((EnemyModel) _modelRegister.GetModel<EnemyModel>()).DealDamage(dmg);
            }
            else if (_shooter == SHOOTER_ENEMY)
            {
                ((PlayerModel) _modelRegister.GetModel<PlayerModel>()).DealDamage(1);
            }
        }
    }
}