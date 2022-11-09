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
        public IReadOnlyList<ICommand> Commands => _panelView.CommandViews.Select(x => x as ICommand).ToList();
        
        [SerializeField]
        private Button _Button;
        [SerializeField]
        private ICommandPanelView _panelView;
    }
}