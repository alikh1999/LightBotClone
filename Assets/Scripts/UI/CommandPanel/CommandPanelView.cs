using System.Collections.Generic;
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