using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.World
{
    public class Game : MonoBehaviour, IGame, IEndConditionChecker
    {
        public IReadOnlyList<TileGoal> TileGoals => tilesGoal;
        public event Action GameEnded;

        private IGameRules _gameRules;
        
        private List<TileGoal> tilesGoal;

        public void Init(List<TileGoal> tilesGoal, List<IGameRule> gameRules)
        {
            this.tilesGoal = tilesGoal;
            
            _gameRules = new GameRules(this, gameRules);
            _gameRules.SatisfiedRules += OnAllSatisfiedRules;
        }

        private void Awake()
        {
            tilesGoal = FindObjectsOfType<TileGoal>().ToList();
        }

        private void Start()
        {
            _gameRules = new GameRules(this, new List<IGameRule>{new AllGoalTileHighLighted()});
            _gameRules.SatisfiedRules += OnAllSatisfiedRules;
        }

        private void OnAllSatisfiedRules()
        {
            GameEnded?.Invoke();
        }
    }
}