using System;
using System.Collections.Generic;

namespace LogiBotClone.Runtime.Core.World
{
    public interface IGame
    {
        public IReadOnlyList<TileGoal> TileGoals
        {
            get;
        }
    }
}