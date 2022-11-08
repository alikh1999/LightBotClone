using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommandView
    {
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