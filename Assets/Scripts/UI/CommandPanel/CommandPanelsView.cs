using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelsView : MonoBehaviour, ICommandPanelsView
    {
        public IReadOnlyList<ICommandPanelView> PanelViews => panelViews;

        private List<ICommandPanelView> panelViews;
        
        private void Awake()
        {
            panelViews = GetComponentsInChildren<ICommandPanelView>(true).ToList();
        }

        public void AddCommand(ICommandView commandView, int panelIndex)
        {
            panelViews[panelIndex].AddCommand(commandView);
        }
    }
}