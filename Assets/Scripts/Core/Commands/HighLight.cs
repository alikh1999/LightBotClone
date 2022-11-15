using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class HighLight : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            if (tile is TileGoal tileGoal)
            {
                tileGoal.HighLight();
            }
        }
    }
}