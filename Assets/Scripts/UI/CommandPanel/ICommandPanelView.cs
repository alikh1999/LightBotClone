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

        Button Button
        {
            get;
        }
        
        IReadOnlyList<ICommandView> _CommandViews
        {
            get;
        }

        void AddCommand(ICommandView commandView);
    }
}