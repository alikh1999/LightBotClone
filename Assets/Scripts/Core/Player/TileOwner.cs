using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Player
{
    public class TileOwner : MonoBehaviour
    {
        public Tile Tile => _tile;
        
        [SerializeField]
        private Tile _tile;
        
        public void OwnTile(Tile tile)
        {
            _tile = tile;
            transform.position = tile.transform.position;
        }
    }
}