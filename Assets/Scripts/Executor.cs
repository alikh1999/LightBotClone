using UnityEngine;

namespace LogiBotClone.Runtime
{
    public class Executor : MonoBehaviour
    {
        public Tile Tile => _tile;
        
        private Tile _tile;
        
        public void Execute(ICommand command)
        {
            command.Execute(_tile, transform);
        }

        public void OwnTile(Tile tile)
        {
            _tile = tile;
            transform.position = tile.transform.position;
        }
    }
}