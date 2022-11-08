using System.Collections.Generic;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommand : ICommandView
    {
        LogiBotClone.Runtime.ICommand Command
        {
            get;
        }
    }
}