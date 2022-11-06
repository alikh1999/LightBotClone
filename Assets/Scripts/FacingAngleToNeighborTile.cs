using System.Collections.Generic;

namespace LogiBotClone.Runtime
{
    public static class FacingAngleToNeighborTile
    {
        public static IReadOnlyDictionary<Angle, NeighborTile>
            AngleToNeighborTileDiciDictionary => angleToNeighborTileDiciDictionary;


        private static readonly Dictionary<Angle, NeighborTile> angleToNeighborTileDiciDictionary =
            new Dictionary<Angle, NeighborTile>
            {
                {new Angle(0), NeighborTile.Right},
                {new Angle(90), NeighborTile.Up},
                {new Angle(180), NeighborTile.Left},
                {new Angle(270), NeighborTile.Down}
            };
    }
}