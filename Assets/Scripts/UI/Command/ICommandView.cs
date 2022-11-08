using UnityEngine;
using UnityEngine.UIElements;

namespace LogiBotClone.Runtime.UI.Command
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