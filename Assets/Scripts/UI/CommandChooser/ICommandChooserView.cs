using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;

namespace LogiBotClone.Runtime.UI.CommandChooser
{
    public interface ICommandChooserView
    {
        IReadOnlyList<ICommandView> Views
        {
            get;
        }
    }
}