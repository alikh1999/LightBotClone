using LogiBotClone.Runtime.Core.Player;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class HighLight : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            if (tileOwner.Tile is TileGoal tileGoal)
            {
                tileGoal.HighLight();
            }
        }
    }
}