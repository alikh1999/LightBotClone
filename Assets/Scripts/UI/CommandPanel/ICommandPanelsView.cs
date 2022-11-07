using System.Collections.Generic;
using UnityEngine.UIElements;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public interface ICommandPanelsView
    {
        IReadOnlyList<Button> AddCommandButtons
        {
            get;
        }

        void AddCommand();
    }
}