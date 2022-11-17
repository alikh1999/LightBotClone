using System;

namespace LogiBotClone.Runtime.Core.World
{
    public interface IGameRule
    {
        event Action SatisfiedRule;
        public void Init(IGame game);
    }
}