using System;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandChooser
{
    public class CommandChooserPresenter : MonoBehaviour
    {
        public event Action<ICommandView> CommandChose; 

        private ICommandChooserView _view;

        private void Awake()
        {
            _view = GetComponentInChildren<ICommandChooserView>(true);
        }

        private void OnEnable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.onClick.AddListener( ()=> OnCommandButtonPressed(view));
            }
        }

        private void OnDisable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.onClick.RemoveAllListeners();
            }
        }

        private void OnCommandButtonPressed(ICommandView commandView)
        {
            CommandChose?.Invoke(commandView);
        }
    }
}