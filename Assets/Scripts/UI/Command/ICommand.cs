using System.Collections.Generic;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommand : ICommandView
    {
        global::LogiBotClone.Runtime.Core.Commands.ICommand Command
        {
            get;
        }
    }
}