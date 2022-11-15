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
                view.ButtonClicked += ()=> OnCommandButtonPressed(view);
            }

            _view.ExecuteAllCommandsButtonClicked += () => ExecuteAllCommandsButtonClicked?.Invoke();
            _view.RestartButtonClicked += OnLevelRestartButtonPressed;
        }

        private void OnDisable()
        {
            foreach (var view in _view.Views)
            {
                view.ButtonClicked -= ()=> OnCommandButtonPressed(view);
            }
            
            _view.ExecuteAllCommandsButtonClicked -= () => ExecuteAllCommandsButtonClicked?.Invoke();
            _view.RestartButtonClicked -= OnLevelRestartButtonPressed;
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