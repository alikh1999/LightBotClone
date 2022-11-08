using System.Collections.Generic;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelView : MonoBehaviour, ICommandPanelView
    {
        public int CommandPanelIndex { get; }
        public IReadOnlyList<ICommandView> _CommandViews { get; }
        public void AddCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}