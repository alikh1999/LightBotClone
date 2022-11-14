using LogiBotClone.Runtime.Core.Data;
using LogiBotClone.Runtime.Core.Utili;
using LogiBotClone.Runtime.Core.World;
using UnityEngine;

namespace LogiBotClone.Runtime.UI.Win
{
    public class WinPresenter : MonoBehaviour
    {
        private IWinView _view;
        private int _levelNumber;

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
            _levelNumber = PlayerPrefs.HasKey(PlayerPrefKeys.LevelNumber) ? PlayerPrefs.GetInt(PlayerPrefKeys.LevelNumber) : 1;
        }

        private void OnEnable()
        {
            _view.NextLevelButton.onClick.AddListener(OnNextLevelClicked);
            _game.GameEnded += OnGameEnded;
        }

        private void OnDisable()
        {
            _view.NextLevelButton.onClick.RemoveAllListeners();
            _game.GameEnded -= OnGameEnded;
        }

        private void OnNextLevelClicked()
        {
            _levelNumber++;
            var nextSceneName = _levelNumber.ToString();

            if (_levelNumber >= _statics.LevelsCount)
            {
                return;
            }
            
            PlayerPrefs.SetInt(PlayerPrefKeys.LevelNumber, _levelNumber);
            PlayerPrefs.Save();
            
            SceneLoader.Load(nextSceneName);
        }

        private void OnGameEnded()
        {
            _view.SetActive(true);
        }
    }
}