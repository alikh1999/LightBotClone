using System.Collections.Generic;
using System.Linq;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.CommandChooser
{
    public class CommandChooserView : MonoBehaviour, ICommandChooserView
    {
        public IReadOnlyList<ICommandView> Views => views;
        public Button ExecuteAllCommandsButton => _executeButton;
        public Button RestartLevelButton => _restartButton;

        [SerializeField]
        private Button _executeButton;
        [SerializeField] 
        private Button _restartButton;
        
        private List<ICommandView> views = new List<ICommandView>();

        private void Awake()
        {
            views = GetComponentsInChildren<ICommandView>(true).ToList();
        }
    }
}