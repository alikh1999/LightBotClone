using System.Collections.Generic;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.CommandSelector
{
    public interface ICommandSelectorView
    {
        IReadOnlyList<Button> Buttons
        {
            get;
        }
    }
}