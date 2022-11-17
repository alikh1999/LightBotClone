using System.Collections.Generic;

namespace LogiBotClone.Runtime.Core.World
{
    public static class TransformerAngleToNeighborTile
    {
        public static NeighborTile TurnAngleToNeighborTile(float angle)
            => angleToNeighborTileDictionary[angle];

        private static readonly Dictionary<float, NeighborTile> angleToNeighborTileDictionary =
            new Dictionary<float, NeighborTile>
            {
                {0, NeighborTile.Right},
                {90, NeighborTile.Up},
                {180, NeighborTile.Left},
                {270, NeighborTile.Down}
            };
    }
}