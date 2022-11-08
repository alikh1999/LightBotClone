using System;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandSelector
{
    public class CommandChooserPresenter : MonoBehaviour
    {
        public event Action<ICommandView> CommandSelected; 

        private ICommandChooserView _view;

        private void Awake()
        {
            _view = GetComponentInChildren<ICommandChooserView>(true);
        }

        private void OnEnable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.clicked += () => { OnCommandButtonPressed(view); };
            }
        }

        private void OnDisable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.clicked -= () => { OnCommandButtonPressed(view); };
            }
        }

        private void OnCommandButtonPressed(ICommandView commandView)
        {
            CommandSelected?.Invoke(commandView);
        }
    }
}