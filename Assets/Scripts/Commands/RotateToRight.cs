using LogiBotClone.Runtime.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Commands
{
    public class RotateToRight : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            player.transform.Rotate(Vector3.forward, -90);
        }
    }
}