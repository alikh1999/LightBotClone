using System;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.World
{
    public class TileGoal : Tile
    {
        public event Action TileHighLighted;
        public bool WasHighLighted => _wasHighLighted;

        private bool _wasHighLighted;

        public void HighLight()
        {
            _wasHighLighted = true;
            TileHighLighted?.Invoke();
        }
    }
}