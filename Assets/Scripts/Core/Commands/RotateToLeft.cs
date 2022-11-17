using LogiBotClone.Runtime.Core.Player;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class RotateToLeft : ICommand
    {
        protected virtual float Angle => 90;
        
        public void Execute(TileOwner tileOwner, Transform player)
        {
            Rotate(player, Angle);
        }

        private void Rotate(Transform player, float angle)
        {
            player.Rotate(Vector3.forward, angle);
        }
    }
}