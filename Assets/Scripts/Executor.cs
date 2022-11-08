using System;
using UnityEngine;

namespace LogiBotClone.Runtime
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