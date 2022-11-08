using LogiBotClone.Runtime.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Commands
{
    public interface ICommand
    {
        void Execute(Tile tile, Transform player);
    }
}