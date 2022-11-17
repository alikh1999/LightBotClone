using LogiBotClone.Runtime.Core.Player;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public struct RotateToLeft : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            player.Rotate(Vector3.forward, 90);
        }
    }
}