using System.Collections.Generic;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommandList : ICommandView
    {
        int CommandPanelIndex
        {
            get;
        }
    }
}