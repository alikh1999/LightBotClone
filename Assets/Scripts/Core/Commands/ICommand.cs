using LogiBotClone.Runtime.Core.Player;
using UnityEngine;

namespace LogiBotClone.Runtime.Core.Commands
{
    public interface ICommand
    {
        void Execute(TileOwner tileOwner, Transform player);
    }
}