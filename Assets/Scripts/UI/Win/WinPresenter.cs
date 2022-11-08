using LogiBotClone.Runtime.Data;
using LogiBotClone.Runtime.Utili;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LogiBotClone.Runtime.UI.Win
{
    public class WinPresenter : MonoBehaviour
    {
        private IWinView _view;

        private int _levelNumber;

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
        }

        private void OnDisable()
        {
            _view.NextLevelButton.onClick.RemoveAllListeners();
        }

        private void OnNextLevelClicked()
        {
            var nextSceneName = _levelNumber.ToString();
            _levelNumber++;
            PlayerPrefs.SetInt(PlayerPrefKeys.LevelNumber, _levelNumber);
            PlayerPrefs.Save();
            
            SceneLoader.Load(nextSceneName);
        }
    }
}