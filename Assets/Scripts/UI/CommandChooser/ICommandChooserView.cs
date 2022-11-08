using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.CommandChooser
{
    public interface ICommandChooserView
    {
        IReadOnlyList<ICommandView> Views
        {
            get;
        }

        Button ExecuteAllCommandsButton
        {
            get;
        }

        Button RestartLevelButton
        {
            get;
        }
    }
}