using System;
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
        public event Action ButtonClicked;

        public IReadOnlyList<ICommandView> CommandViews => commandViews;

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

        private void OnEnable()
        {
            _button.onClick.AddListener(ButtonClickedFunc);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(ButtonClickedFunc);
        }

        public void AddCommand(ICommandView commandView)
        {
            commandView.GameObject.transform.SetParent(_gridParent);
            commandViews.Add(commandView);
        }

        private void ButtonClickedFunc()
        {
            ButtonClicked?.Invoke();
        }
    }
}