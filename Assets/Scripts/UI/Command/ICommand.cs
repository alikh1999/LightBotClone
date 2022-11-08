using System.Collections.Generic;

namespace LogiBotClone.Runtime.UI.Command
{
    public interface ICommand : ICommandView
    {
        Commands.ICommand Command
        {
            get;
        }
    }
}