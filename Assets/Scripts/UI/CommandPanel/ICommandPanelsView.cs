using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public interface ICommandPanelsView
    {
        IReadOnlyList<ICommandPanelView> PanelViews
        {
            get;
        }
        
        void AddCommand(ICommandView commandView, int panelIndex);
    }
}