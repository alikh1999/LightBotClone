using System;
using UnityEngine;

namespace LogiBotClone.Runtime.World
{
    public class Tile : MonoBehaviour
    {
        public int Height => _height;

        [SerializeField] 
        private int _height;
        [SerializeField]
        private Tile _upTile;
        [SerializeField]
        private Tile _downTile;
        [SerializeField]
        private Tile _rightTile;
        [SerializeField]
        private Tile _leftTile;

        private void OnValidate()
        {
            _height = Mathf.Clamp(_height, 0, _height);
        }

        public void SetUp(Tile upTile, Tile downTile, Tile rightTile, Tile leftTile)
        {
            _upTile = upTile;
            _downTile = downTile;
            _rightTile = rightTile;
            _leftTile = leftTile;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public Tile GetNeighborTile(NeighborTile neighborTile)
        {
            switch (neighborTile)
            {
                case NeighborTile.Up:
                    return _upTile;
                case NeighborTile.Down:
                    return _downTile;
                case NeighborTile.Right:
                    return _rightTile;
                case NeighborTile.Left:
                    return _leftTile;
                default:
                    throw new ArgumentOutOfRangeException(nameof(neighborTile), neighborTile, null);
            }
        }
    }
}