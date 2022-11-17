using System;

namespace LogiBotClone.Runtime.Core.World
{
    public class AllGoalTileHighLighted : IGameRule
    {
        public event Action SatisfiedRule;

        private IGame _game;
        private int _unHighLightedGoalTilesCount;
        
        public void Init(IGame game)
        {
            _game = game;
            _unHighLightedGoalTilesCount = _game.TileGoals.Count;
            foreach (var tileGoal in game.TileGoals)
            {
                tileGoal.TileHighLighted += OnGoalTileHighLighted;
            }
        }

        private void OnGoalTileHighLighted()
        {
            _unHighLightedGoalTilesCount--;
            if (_unHighLightedGoalTilesCount <= 0)
            {
                SatisfiedRule?.Invoke();
            }
        }
    }
}