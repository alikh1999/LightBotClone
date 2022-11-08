using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;

namespace LogiBotClone.Runtime.UI.CommandSelector
{
    public interface ICommandChooserView
    {
        IReadOnlyList<ICommandView> Views
        {
            get;
        }
    }
}