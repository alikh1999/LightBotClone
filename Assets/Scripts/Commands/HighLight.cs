using LogiBotClone.Runtime.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Commands
{
    public class HighLight : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            if (tile is TileGoal)
            {
                ((TileGoal)tile).HighLight();
            }
        }
    }
}