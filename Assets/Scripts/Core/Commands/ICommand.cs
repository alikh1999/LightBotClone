using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public interface ICommand
    {
        void Execute(Tile tile, Transform player);
    }
}