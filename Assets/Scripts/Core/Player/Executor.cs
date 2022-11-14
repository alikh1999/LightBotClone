using LogiBotClone.Runtime.Core.Commands;
using LogiBotClone.Runtime.Core.Player;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Player
{
    public class Executor : MonoBehaviour
    {
        public TileOwner TileOwner => _Owner;
        
        [SerializeField] 
        private TileOwner _Owner;

        public void Init(TileOwner tileOwner)
        {
            _Owner = tileOwner;
        }
        
        public void Execute(ICommand command)
        {
            command.Execute(_Owner.Tile, transform);
        }
    }
}