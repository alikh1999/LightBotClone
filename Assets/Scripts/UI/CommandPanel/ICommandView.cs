using UnityEngine;
using UnityEngine.UIElements;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public interface ICommandView
    {
        ICommand Command
        {
            get;
        }

        Button Button
        {
            get;
        }

        GameObject GameObject
        {
            get;
        }
    }
}