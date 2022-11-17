using LogiBotClone.Runtime.Core.Player;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public struct RotateToRight : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            player.transform.Rotate(Vector3.forward, -90);
        }
    }
}