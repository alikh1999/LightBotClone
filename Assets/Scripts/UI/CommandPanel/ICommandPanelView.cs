using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public interface ICommandPanelView
    {
        int CommandPanelIndex
        {
            get;
        }
        
        IReadOnlyList<ICommandView> _CommandViews
        {
            get;
        }

        void AddCommand();
    }
}