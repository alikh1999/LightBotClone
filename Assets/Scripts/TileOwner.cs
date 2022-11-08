using UnityEngine;

namespace LogiBotClone.Runtime
{
    public class TileOwner : MonoBehaviour
    {
        public Tile Tile => _tile;
        
        private Tile _tile;
        
        public void OwnTile(Tile tile)
        {
            _tile = tile;
            transform.position = tile.transform.position;
        }
    }
}