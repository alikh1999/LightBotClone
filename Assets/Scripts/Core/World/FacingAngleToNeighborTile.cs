using System.Collections.Generic;

namespace LogiBotClone.Runtime.Core.World
{
    public static class FacingAngleToNeighborTile
    {
        public static IReadOnlyDictionary<Angle, NeighborTile>
            AngleToNeighborTileDictionary => angleToNeighborTileDictionary;


        private static readonly Dictionary<Angle, NeighborTile> angleToNeighborTileDictionary =
            new Dictionary<Angle, NeighborTile>
            {
                {new Angle(0), NeighborTile.Right},
                {new Angle(90), NeighborTile.Up},
                {new Angle(180), NeighborTile.Left},
                {new Angle(270), NeighborTile.Down}
            };
    }
}