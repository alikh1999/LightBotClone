using LogiBotClone.Runtime.Core.Player;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public class Move : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            var neighborTile =
                FacingAngleToNeighborTile.AngleToNeighborTileDictionary[new Angle(player.localEulerAngles.z)];

            var targetTile = tile.GetNeighborTile(neighborTile);
            var tileOwner = player.GetComponent<TileOwner>();

            if (targetTile == null || tileOwner.Tile.Height != targetTile.Height)
            {
                return;
            }
            
            tileOwner.OwnTile(targetTile);
        }
    }
}
