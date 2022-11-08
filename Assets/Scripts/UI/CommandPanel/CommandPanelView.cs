using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.CommandPanel
{
    public class CommandPanelView : MonoBehaviour, ICommandPanelView
    {
        public int CommandPanelIndex => _commandPanelIndex;
        public Button Button => _button;
        
        public IReadOnlyList<ICommandView> _CommandViews { get; }

        [SerializeField]
        private int _commandPanelIndex;
        [SerializeField] 
        private Transform _gridParent;
        [SerializeField] 
        private Button _button;

        private List<ICommandView> commandViews;

        private void Awake()
        {
            commandViews = GetComponentsInChildren<ICommandView>(true).ToList();
        }

        public void AddCommand(ICommandView commandView)
        {
            commandView.GameObject.transform.SetParent(_gridParent);
        }
    }
}