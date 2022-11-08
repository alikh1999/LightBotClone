using System.Collections.Generic;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommandList : ICommandView
    {
        IReadOnlyList<LogiBotClone.Runtime.ICommand> Commands
        {
            get;
        }
    }
}