using LogiBotClone.Runtime.Player;
using LogiBotClone.Runtime.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Commands
{
    public class Move : ICommand
    {
        public void Execute(Tile tile, Transform player)
        {
            var neighborTile =
                FacingAngleToNeighborTile.AngleToNeighborTileDictionary[new Angle(player.localEulerAngles.z)];

            var targetTile = tile.GetNeighborTile(neighborTile);
            var executor = player.GetComponent<Executor>();

            if (targetTile == null || executor.TileOwner.Tile.Height != targetTile.Height)
            {
                return;
            }
            
            executor.TileOwner.OwnTile(targetTile);
        }
    }
}
