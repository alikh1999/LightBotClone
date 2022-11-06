using UnityEngine;

namespace LogiBotClone.Runtime
{
    public interface ICommand
    {
        void Execute(Tile tile, Transform player);
    }
}