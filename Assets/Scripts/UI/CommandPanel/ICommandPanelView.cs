using System.Collections.Generic;

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