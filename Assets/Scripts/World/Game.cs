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

        private List<TileGoal> TilesGoal = new List<TileGoal>();

        private void Awake()
        {
            TilesGoal = FindObjectsOfType<TileGoal>().ToList();
        }

        public void AddTileGoal(TileGoal tileGoal)
        {
            TilesGoal.Add(tileGoal);
            tileGoal.TileHighLighted += OnGoalTileHighLighted;
            _unHighLightedGoalTilesCount++;
        }

        private void Start()
        {
            _unHighLightedGoalTilesCount = TilesGoal.Count;
            foreach (var goalTile in TilesGoal)
            {
                goalTile.TileHighLighted += OnGoalTileHighLighted;
            }
        }

        private void OnDestroy()
        {
            foreach (var goalTile in TilesGoal)
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