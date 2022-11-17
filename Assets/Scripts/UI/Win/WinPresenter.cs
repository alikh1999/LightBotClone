using System;
using LogiBotClone.Runtime.Core.Data;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.Win
{
    public class WinPresenter : MonoBehaviour
    {
        private IWinView _view;
        private Level _Level;

        [SerializeField] 
        private Statics _statics;
        [SerializeField] 
        private Game _game;

        private void Awake()
        {
            _view = GetComponentInChildren<IWinView>();
        }

        private void Start()
        {
            _Level = new Level(_statics.LevelsCount);
        }

        private void OnEnable()
        {
            _view.NextLevelButtonPressed += OnNextLevelClicked;
            _game.GameEnded += OnGameEnded;
        }

        private void OnDisable()
        {
            _view.NextLevelButtonPressed -= OnNextLevelClicked;
            _game.GameEnded -= OnGameEnded;
        }

        private void OnNextLevelClicked()
        {
            _Level.ChangeLevel();
        }

        private void OnGameEnded()
        {
            _view.SetActive(true);
        }
    }
}