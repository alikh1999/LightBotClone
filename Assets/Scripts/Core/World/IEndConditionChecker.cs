using System;

namespace LogiBotClone.Runtime.Core.World
{
    public interface IEndConditionChecker
    {
        event Action GameEnded;
    }
}