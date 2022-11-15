using System;
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
        public event Action ExecuteAllCommandsButtonClicked;
        public event Action RestartButtonClicked;

        [SerializeField]
        private Button _executeButton;
        [SerializeField] 
        private Button _restartButton;
        
        private List<ICommandView> views = new List<ICommandView>();

        private void Awake()
        {
            views = GetComponentsInChildren<ICommandView>(true).ToList();
        }

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(RestartButtonClickedFunc);
            _executeButton.onClick.AddListener(ExecuteButtonClicked);
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveAllListeners();
            _executeButton.onClick.RemoveAllListeners();
        }

        private void ExecuteButtonClicked()
        {
            ExecuteAllCommandsButtonClicked?.Invoke();
        }

        private void RestartButtonClickedFunc()
        {
            RestartButtonClicked?.Invoke();
        }
    }
}