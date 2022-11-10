using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.CommandPanel;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public class CommandsListView : MonoBehaviour, ICommandList
    {
        public Button Button => _Button;
        public GameObject GameObject => gameObject;
        public int CommandPanelIndex => _commandPanelIndex;
        
        [SerializeField]
        private Button _Button;

        [SerializeField] 
        private int _commandPanelIndex;
    }
}