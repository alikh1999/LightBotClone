using System;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public class CommandsListView : MonoBehaviour, ICommandList
    {
        public event Action ButtonClicked;
        public GameObject GameObject => gameObject;
        public int CommandPanelIndex => _commandPanelIndex;
        
        [SerializeField]
        private Button _Button;

        [SerializeField] 
        private int _commandPanelIndex;
        
        private void OnEnable()
        {
            _Button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _Button.onClick.RemoveListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            ButtonClicked?.Invoke();
        }
    }
}