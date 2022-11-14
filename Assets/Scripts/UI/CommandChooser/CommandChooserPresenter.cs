using System;
using LogiBotClone.Runtime.Core.Data;
using LogiBotClone.Runtime.Core.Utili;
using LogiBotClone.Runtime.UI.Command;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.CommandChooser
{
    public class CommandChooserPresenter : MonoBehaviour
    {
        public event Action<ICommandView> CommandChose;
        public event Action ExecuteAllCommandsButtonClicked;

        private ICommandChooserView _view;
        private string _currentLevelName;

        private void Awake()
        {
            _view = GetComponentInChildren<ICommandChooserView>(true);
        }

        private void Start()
        {
            _currentLevelName = PlayerPrefs.HasKey(PlayerPrefKeys.LevelNumber) ? PlayerPrefs.GetInt(PlayerPrefKeys.LevelNumber).ToString() : 1.ToString();
        }

        private void OnEnable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.onClick.AddListener( ()=> OnCommandButtonPressed(view));
            }

            _view.ExecuteAllCommandsButton.onClick.AddListener(() => ExecuteAllCommandsButtonClicked?.Invoke());
            _view.RestartLevelButton.onClick.AddListener(OnLevelRestartButtonPressed);
        }

        private void OnDisable()
        {
            foreach (var view in _view.Views)
            {
                view.Button.onClick.RemoveAllListeners();
            }
            
            _view.ExecuteAllCommandsButton.onClick.RemoveAllListeners();
            _view.RestartLevelButton.onClick.RemoveAllListeners();
        }

        private void OnCommandButtonPressed(ICommandView commandView)
        {
            CommandChose?.Invoke(commandView);
        }

        private void OnLevelRestartButtonPressed()
        {
            SceneLoader.Load(_currentLevelName);
        }
    }
}