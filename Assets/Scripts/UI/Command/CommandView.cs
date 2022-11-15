using System;
using LogiBotClone.Runtime.Core.Commands;
using UnityEngine;
using UnityEngine.UI;

namespace LogiBotClone.Runtime.UI.Command
{
    public abstract class CommandView : MonoBehaviour, ICommand
    {
        public event Action ButtonClicked;
        public GameObject GameObject => gameObject;
        public global::LogiBotClone.Runtime.Core.Commands.ICommand Command => command;

        [SerializeField]
        private Button _Button;
        
        protected virtual global::LogiBotClone.Runtime.Core.Commands.ICommand command => new Move();

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