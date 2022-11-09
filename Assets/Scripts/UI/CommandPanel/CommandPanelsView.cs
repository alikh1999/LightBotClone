using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelsView : MonoBehaviour, ICommandPanelsView
    {
        public IReadOnlyList<ICommandPanelView> PanelViews => panelViews ??= GetComponentsInChildren<ICommandPanelView>(true).ToList();

        private List<ICommandPanelView> panelViews;
        

        public void AddCommand(ICommandView commandView, int panelIndex)
        {
            panelViews[panelIndex].AddCommand(commandView);
        }
    }
}