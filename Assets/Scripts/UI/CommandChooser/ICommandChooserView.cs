using System;
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

        event Action ExecuteAllCommandsButtonClicked;
        event Action RestartButtonClicked;
    }
}