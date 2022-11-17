using LogiBotClone.Runtime.Core.Player;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public struct Jump : ICommand
    {
        public void Execute(TileOwner tileOwner, Transform player)
        {
            var neighborTile =
                FacingAngleToNeighborTile.AngleToNeighborTileDictionary[new Angle(player.localEulerAngles.z)];

            var targetTile = tileOwner.Tile.GetNeighborTile(neighborTile);

            if (targetTile == null || tileOwner.Tile.Height == targetTile.Height)
            {
                return;
            }
            
            tileOwner.OwnTile(targetTile);
        }
    }
}