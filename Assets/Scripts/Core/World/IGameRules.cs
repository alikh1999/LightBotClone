using System;

namespace LogiBotClone.Runtime.Core.World
{
    public interface IGameRules
    {
        public event Action SatisfiedRules;
    }
}