using UnityEngine;

namespace LogiBotClone.Runtime
{
    public class RotateToRight : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            player.transform.Rotate(Vector3.forward, -90);
        }
    }
}