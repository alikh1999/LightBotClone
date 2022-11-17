using System;
using System.Collections.Generic;

namespace LogiBotClone.Runtime.Core.World
{
    public class GameRules : IGameRules
    {
        public event Action SatisfiedRules;

        private IGame _game;
        private int _rulesSatisfiedCount;

        private List<IGameRule> gameRules;

        public GameRules(IGame game, List<IGameRule> gameRules)
        {
            _game = game;
            this.gameRules = gameRules;

            foreach (var gameRule in gameRules)
            {
                gameRule.Init(_game);
                gameRule.SatisfiedRule += OnRuleSatisfied;
            }
        }

        private void OnRuleSatisfied()
        {
            _rulesSatisfiedCount++;
            if (_rulesSatisfiedCount >= gameRules.Count)
            {
                SatisfiedRules?.Invoke();
            }
        }
    }
}