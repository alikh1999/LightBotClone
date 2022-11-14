using System;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.World
{
    public class TileGoal : Tile
    {
        public event Action TileHighLighted;
        public bool WasHighLighted => _wasHighLighted;

        private bool _wasHighLighted;

        [SerializeField]
        private SpriteRenderer _spriteRenderer;
        [SerializeField] 
        private Color _hightLightColor;

        public void HighLight()
        {
            _wasHighLighted = true;
            TileHighLighted?.Invoke();
            if (_spriteRenderer != null)
            {
                _spriteRenderer.color = _hightLightColor;
            }
        }
    }
}