using LogiBotClone.Runtime.Core.Player;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class Jump : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            var neighborTile =
                TransformerAngleToNeighborTile.TurnAngleToNeighborTile(player.localEulerAngles.z);

            var targetTile = tileOwner.Tile.GetNeighborTile(neighborTile);

            if (targetTile == null || tileOwner.Tile.Height == targetTile.Height)
            {
                return;
            }
            
            tileOwner.OwnTile(targetTile);
        }
    }
}