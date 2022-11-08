using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace LogiBotClone.Runtime.World
{
    public class Game : MonoBehaviour
    {
        public event Action GameEnded;
        
        private int _unHighLightedGoalTilesCount;

        private List<TileGoal> goalTiles = new List<TileGoal>();

        private void Awake()
        {
            goalTiles = FindObjectsOfType<TileGoal>().ToList();
        }

        public void AddGoalTile(TileGoal tileGoal)
        {
            goalTiles.Add(tileGoal);
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