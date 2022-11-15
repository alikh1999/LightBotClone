using System;
using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public interface ICommandPanelView
    {
        int CommandPanelIndex
        {
            get;
        }

        event Action ButtonClicked;
        
        IReadOnlyList<ICommandView> CommandViews
        {
            get;
        }

        void AddCommand(ICommandView commandView);
    }
}