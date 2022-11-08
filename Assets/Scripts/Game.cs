using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LogiBotClone.Runtime
{
    public class Game : MonoBehaviour
    {
        public event Action GameEnded;
        
        private int _unHighLightedGoalTilesCount;

        private List<GoalTile> goalTiles = new List<GoalTile>();

        private void Awake()
        {
            goalTiles = FindObjectsOfType<GoalTile>().ToList();
        }

        public void AddGoalTile(GoalTile goalTile)
        {
            goalTiles.Add(goalTile);
        }

        private void Start()
        {
            _unHighLightedGoalTilesCount = goalTiles.Count;
            foreach (var goalTile in goalTiles)
            {
                goalTile.TileHighLighted += OnGoalTileHighLighted;
            }
        }

        private void OnDestroy()
        {
            foreach (var goalTile in goalTiles)
            {
                goalTile.TileHighLighted -= OnGoalTileHighLighted;
            }
        }

        private void OnGoalTileHighLighted()
        {
            _unHighLightedGoalTilesCount--;
            if (_unHighLightedGoalTilesCount <= 0)
            {
                GameEnded?.Invoke();
            }
        }
    }
}