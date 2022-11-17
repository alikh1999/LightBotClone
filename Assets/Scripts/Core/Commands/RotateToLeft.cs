using LogiBotClone.Runtime.Core.Player;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class RotateToLeft : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            player.Rotate(Vector3.forward, 90);
        }
    }
}