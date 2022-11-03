using System.Collections.Generic;

namespace DefaultNamespace
{
    public static class FacingAngleToNeighborTile
    {
        public static IReadOnlyDictionary<Angle, NeighborTile>
            AngleToNeighborTileDiciDictionary => angleToNeighborTileDiciDictionary;


        private static readonly Dictionary<Angle, NeighborTile> angleToNeighborTileDiciDictionary =
            new Dictionary<Angle, NeighborTile>
            {
                {new Angle(0), NeighborTile.Up},
                {new Angle(180), NeighborTile.Down},
                {new Angle(90), NeighborTile.Up},
                {new Angle(90), NeighborTile.Up}
            };
    }
}