using UnityEngine;
using UnityEngine.Tilemaps;

namespace LogiBotClone.Runtime
{
    public class RotateToLeft : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            player.Rotate(Vector3.forward, 90);
        }
    }
}