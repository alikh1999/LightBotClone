using LogiBotClone.Runtime.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Commands
{
    public class RotateToLeft : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            player.Rotate(Vector3.forward, 90);
        }
    }
}